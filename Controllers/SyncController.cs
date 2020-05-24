using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sync.WebApi.Entities;
using Sync.WebApi.Models;
using Sync.WebApi.Services;

namespace Sync.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SyncController : Controller
    {
        private readonly ProductService _productService;

        public SyncController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            try
            {
                ProductEntity productEntity = _productService.Create(product);

                return Ok(productEntity);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPut]
        public IActionResult Update()
        {
            return NoContent();
        }
        
        [HttpDelete]
        public IActionResult Remove()
        {
            return NoContent();
        }
        
    }
}