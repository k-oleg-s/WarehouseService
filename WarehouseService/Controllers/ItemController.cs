using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;

namespace WarehouseService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IItemRepository _itemRepository;

    [HttpPost("create")]
    public IActionResult Create([FromBody] CreateItemRequest request)
    {
        return Ok(_itemRepository.Create(new Item
        {
            ItemCode = request.ItemCode,
            Description = request.Description,
            ItemGroupId = request.ItemGroupId
        }));
    }

    [HttpGet("get/all")]
    public IActionResult GetAllItems()
    {
        return Ok(_itemRepository.GetAll());
    }

    [HttpGet("get/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        return Ok(_itemRepository.GetById(id));
    }
}
