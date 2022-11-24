using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services
{
    public class LocationRepo : ILocationRepository
    {
        #region Services

        private readonly WarehouseServiceDbContext _context;

        #endregion

        public LocationRepo(WarehouseServiceDbContext context)
        {
            _context = context;
        }
        public int Create(Location obj)
        {
            _context.locationsT.Add(obj);
            _context.SaveChanges();
            return obj.Id;
        }

        public bool Delete(int id)
        {
            Location Location = GetById(id);
            if (Location != null)
            {
                _context.locationsT.Remove(Location);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<Location> GetAll()
        {
            return _context.locationsT.ToList();
        }

        public Location GetById(int id)
        {
            return _context.locationsT.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Location obj)
        {
            Location Location = GetById(obj.Id);
            if (Location != null)
            {
                Location.LocationCode = obj.LocationCode;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
