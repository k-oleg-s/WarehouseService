using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;
using WarehouseService.Data;

namespace WarehouseService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController : ControllerBase
{
    private readonly ILocationRepository _locationRepository;

    [HttpPost("create")]
    public IActionResult Create([FromBody] CreateLocationRequest request)
    {
        return Ok(_locationRepository.Create(new Location
        {
            LocationCode = request.LocationCode
        }));
    }

    [HttpGet("get/all")]
    public IActionResult GetAllItems()
    {
        return Ok(_locationRepository.GetAll());
    }

    [HttpGet("get/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        return Ok(_locationRepository.GetById(id));
    }

    [HttpGet("delete/{id}")]
    public IActionResult DeleteById([FromRoute] int id)
    {
        return Ok(_locationRepository.Delete(id));
    }
}
