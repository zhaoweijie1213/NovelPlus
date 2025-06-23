using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Test.Fakes;

public class InMemoryAuthorRepository : IAuthorRepository
{
    private readonly List<AuthorEntity> _store = new();

    public Task<int> BatchRemoveAsync(long[] ids)
    {
        _store.RemoveAll(a => ids.Contains(a.Id));
        return Task.FromResult(1);
    }

    public Task<int> CountAsync(Dictionary<string, object> query) => Task.FromResult(_store.Count);

    public Task<AuthorEntity?> GetAsync(long id) => Task.FromResult(_store.FirstOrDefault(a => a.Id == id));

    public Task<List<AuthorEntity>> ListAsync(Dictionary<string, object> query) => Task.FromResult(_store.ToList());

    public Task<int> RemoveAsync(long id)
    {
        _store.RemoveAll(a => a.Id == id);
        return Task.FromResult(1);
    }

    public Task<int> SaveAsync(AuthorEntity author)
    {
        author.Id = _store.Count + 1;
        _store.Add(author);
        return Task.FromResult(1);
    }

    public Task<int> UpdateAsync(AuthorEntity author)
    {
        var index = _store.FindIndex(a => a.Id == author.Id);
        if (index >= 0)
        {
            _store[index] = author;
        }
        return Task.FromResult(1);
    }

    public Task<Dictionary<object, object>> TableStaAsync(DateTime minDate)
    {
        var result = new Dictionary<object, object>
        {
            [minDate.Date] = _store.Count
        };
        return Task.FromResult(result);
    }
}
