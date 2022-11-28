using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;
using WarehouseService.Data;

namespace WarehouseService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IItemRepository _itemRepository;

    [HttpPost("create")]
    public ActionResult<int> Create([FromBody] CreateItemRequest request)
    {
        return Ok(_itemRepository.Create(new Item
        {
            ItemCode = request.ItemCode,
            Description = request.Description,
            ItemGroupId = request.ItemGroupId
        }) );
    }

    [HttpGet("ItemGroup/get_all")]
    public ActionResult<IList<Item>> GetAllItems()
    {
        return Ok(_itemRepository.GetAll());
    }

    [HttpGet("ItemGroup/get/{id}")]
    public ActionResult<Item> GetById([FromRoute] int id)
    {
        return Ok(_itemRepository.GetById(id));
    }
    [HttpDelete("ItemGroup/delete/{id}")]
    public ActionResult<bool> DeleteById([FromRoute] int id)
    {
        return Ok(_itemRepository.Delete(id));
    }
}
