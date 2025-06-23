using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Test.Fakes;

public class InMemoryBookRepository : IBookRepository
{
    private readonly List<BookEntity> _store = new();

    public Task<int> BatchRemoveAsync(long[] ids)
    {
        _store.RemoveAll(b => ids.Contains(b.Id));
        return Task.FromResult(1);
    }

    public Task<int> CountAsync(Dictionary<string, object> query) => Task.FromResult(_store.Count);

    public Task<BookEntity?> GetAsync(long id) => Task.FromResult(_store.FirstOrDefault(b => b.Id == id));

    public Task<List<BookEntity>> ListAsync(Dictionary<string, object> query) => Task.FromResult(_store.ToList());

    public Task<int> RemoveAsync(long id)
    {
        _store.RemoveAll(b => b.Id == id);
        return Task.FromResult(1);
    }

    public Task<int> SaveAsync(BookEntity book)
    {
        book.Id = _store.Count + 1;
        _store.Add(book);
        return Task.FromResult(1);
    }

    public Task<int> UpdateAsync(BookEntity book)
    {
        var index = _store.FindIndex(b => b.Id == book.Id);
        if (index >= 0)
        {
            _store[index] = book;
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
