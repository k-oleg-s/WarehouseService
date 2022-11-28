namespace WarehouseService.Services;

public interface IRepository<T, T_id>
{
    T GetById(T_id id);
    IList<T> GetAll();
    T_id Create(T obj);
    bool Delete(T_id id);
    bool Update(T obj);
}
