namespace WarehouseService.Services;

public interface IRepository<T, T_id>
{
    T GetById(T_id id);
    IList<T> GetAll();
    T_id Create(T obj);
    void Delete(T_id id);
    void Update(T obj);
}
