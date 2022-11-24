using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;
using WarehouseService.Data;

namespace WarehouseService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemGroupController : ControllerBase
{
    #region Services 
    private readonly IItemGroupRepository _itemGroupRepository;
    #endregion

    public ItemGroupController(IItemGroupRepository itemGroupRepository )
    {
            _itemGroupRepository = itemGroupRepository;
    }

    #region Public Methods
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
    #endregion

}
