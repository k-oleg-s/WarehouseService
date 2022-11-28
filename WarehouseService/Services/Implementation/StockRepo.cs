using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services
{
    public class StockRepo : IStockRepository
    {
        #region Services

        private readonly WarehouseServiceDbContext _context;

        #endregion

        public StockRepo(WarehouseServiceDbContext context)
        {
            _context = context;
        }
        public int Create(Stock obj)
        {
            _context.stockT.Add(obj);
            _context.SaveChanges();
            return obj.Id;
        }

        public bool Delete(int id)
        {
            Stock Stock = GetById(id);
            if (Stock != null)
            {
                _context.stockT.Remove(Stock);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Stock> GetAll()
        {
            return _context.stockT.ToList();
        }

        public Stock GetById(int id)
        {
            return _context.stockT.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Stock obj)
        {
            Stock Stock = GetById(obj.Id);
            if (Stock != null)
            {
                Stock.Qty = obj.Qty;
                Stock.LocationId = obj.LocationId;
                Stock.ItemId = obj.ItemId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
