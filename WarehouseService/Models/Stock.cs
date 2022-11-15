namespace WarehouseService.Models;

public class Stock
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int LocationId { get; set; }
    public int Qty { get; set; }
}
