using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services
{
    public class ItemRepo : IItemRepository
    {
        #region Services

        private readonly WarehouseServiceDbContext _context;

        #endregion

        public ItemRepo(WarehouseServiceDbContext context)
        {
            _context = context;
        }
        public int Create(Item obj)
        {
            _context.itemsT.Add(obj);
            _context.SaveChanges();
            return obj.Id;
        }

        public bool Delete(int id)
        {
            Item item = GetById(id);
            if (item != null)
            {
                _context.itemsT.Remove(item);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Item> GetAll()
        {
            return _context.itemsT.ToList();
        }

        public Item GetById(int id)
        {
            return _context.itemsT.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Item obj)
        {
            Item item = GetById(obj.Id);
            if (item != null)
            {
                item.Description = obj.Description;
                item.ItemGroupId = obj.ItemGroupId;
                item.ItemCode = obj.ItemCode;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
