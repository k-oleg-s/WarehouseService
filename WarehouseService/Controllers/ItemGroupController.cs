using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;

namespace WarehouseService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemGroupController : ControllerBase
{
    private readonly IItemGroupRepository _itemGroupRepository;

    [HttpPost("create")]
    public IActionResult Create([FromBody] CreateItemGroupRequest request)
    {
        return Ok(_itemGroupRepository.Create(new ItemGroup
        {
            GroupName = request.GroupName
        }));
    }

    [HttpGet("get/all")]
    public IActionResult GetAllItems()
    {
        return Ok(_itemGroupRepository.GetAll());
    }

    [HttpGet("get/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        return Ok(_itemGroupRepository.GetById(id));
    }
}
