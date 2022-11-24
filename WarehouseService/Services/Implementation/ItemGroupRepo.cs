using WarehouseService.Models;
using WarehouseService.Data;

namespace WarehouseService.Services;

public class ItemGroupRepo : IItemGroupRepository
{
    #region Services

    private readonly WarehouseServiceDbContext _context;

    #endregion

    public ItemGroupRepo(WarehouseServiceDbContext context)
    {
        _context = context;
    }
    public Guid Create(ItemGroup obj)
    {
        _context.itemGroupsT.Add(obj);
        _context.SaveChanges();
        return obj.Id;
    }

    public bool Delete(Guid id)
    {
        ItemGroup item_group = GetById(id);
        if (item_group != null)
        {
            _context.itemGroupsT.Remove(item_group);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IList<ItemGroup> GetAll()
    {
        return _context.itemGroupsT.ToList();
    }

    public ItemGroup GetById(Guid id)
    {
        return _context.itemGroupsT.FirstOrDefault(x => x.Id == id);
    }

    public bool Update(ItemGroup obj)
    {
        ItemGroup item_group = GetById(obj.Id);
        if (item_group != null)
        {
            item_group.GroupName = obj.GroupName;
            _context.SaveChanges();
            return true;
        }
        return false;
    }
}
