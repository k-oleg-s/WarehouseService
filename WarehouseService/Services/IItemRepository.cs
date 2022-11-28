using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services
{
    public interface IItemRepository:IRepository<Item, int>
    {
    }
}
