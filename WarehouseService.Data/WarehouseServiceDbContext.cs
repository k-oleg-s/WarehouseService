using Microsoft.EntityFrameworkCore;

namespace WarehouseService.Data;

public class WarehouseServiceDbContext : DbContext
{
    public DbSet<ItemGroup> itemGroupsT { get; set; }
    public DbSet<Item> itemsT { get; set; }
    public DbSet<Location> locationsT { get; set; }
    public DbSet<Stock> stockT { get; set; }
    public WarehouseServiceDbContext(DbContextOptions options) : base(options)
    {
    }
}