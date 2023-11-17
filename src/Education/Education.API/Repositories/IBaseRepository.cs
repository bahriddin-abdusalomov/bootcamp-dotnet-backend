namespace Education.API.Repositories;

public interface IBaseRepository<TModel>
{
    public ValueTask<long> CountAsync();
    public ValueTask<int> CreateAsync(TModel model);
    public ValueTask<int> UpdateAsync(TModel model);
    public ValueTask<int> DeleteAsync(TModel model);
    public ValueTask<TModel> GetByIdAsync(long id);
    public ValueTask<IEnumerable<TModel>> GetAllAsync();
}
