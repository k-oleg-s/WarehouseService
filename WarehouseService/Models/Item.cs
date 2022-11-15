namespace WarehouseService.Models;

public class Item
{
    public int Id { get; set; }
    public string ItemCode { get; set; }
    public string Description { get; set; }
    public int ItemGroupId { get; set; }

}
