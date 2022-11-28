using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseService.Models;
using WarehouseService.Services;
using WarehouseService.Data;
using WarehouseService.Models.Requests;

namespace WarehouseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        #region Services 
        private readonly IStockRepository _stockRepository;
        #endregion

        public StockController(IStockRepository StockRepository)
        {
            _stockRepository = StockRepository;
        }

        #region Public Methods
        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateStockRequest request)
        {
            return Ok(_stockRepository.Create(new Stock
            {
                ItemId = request.ItemId,
                LocationId = request.LocationId,
                Qty = request.Qty
            })) ;
            
        }

        [HttpGet("get/all")]
        public IActionResult GetAllItems()
        {
            return Ok(_stockRepository.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_stockRepository.GetById(id));
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_stockRepository.Delete(id));
        }
        #endregion
    }
}
