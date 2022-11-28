using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services
{
    public interface IStockRepository:IRepository<Stock, int>
    {
    }
}
