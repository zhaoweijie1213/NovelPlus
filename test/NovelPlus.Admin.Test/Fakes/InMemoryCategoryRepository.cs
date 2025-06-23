using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Test.Fakes;

public class InMemoryCategoryRepository : ICategoryRepository
{
    private readonly List<CategoryEntity> _store = new();

    public Task<int> BatchRemoveAsync(int[] ids)
    {
        _store.RemoveAll(c => ids.Contains(c.Id));
        return Task.FromResult(1);
    }

    public Task<int> CountAsync(Dictionary<string, object> query) => Task.FromResult(_store.Count);

    public Task<CategoryEntity?> GetAsync(int id) => Task.FromResult(_store.FirstOrDefault(c => c.Id == id));

    public Task<List<CategoryEntity>> ListAsync(Dictionary<string, object> query) => Task.FromResult(_store.ToList());

    public Task<int> RemoveAsync(int id)
    {
        _store.RemoveAll(c => c.Id == id);
        return Task.FromResult(1);
    }

    public Task<int> SaveAsync(CategoryEntity category)
    {
        category.Id = _store.Count + 1;
        _store.Add(category);
        return Task.FromResult(1);
    }

    public Task<int> UpdateAsync(CategoryEntity category)
    {
        var index = _store.FindIndex(c => c.Id == category.Id);
        if (index >= 0)
        {
            _store[index] = category;
        }
        return Task.FromResult(1);
    }
}
