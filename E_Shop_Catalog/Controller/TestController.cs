using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Service;
using E_Shop_Catalog.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Migrations;
using E_Shop_Catalog.Migrations;
namespace E_Shop_Catalog.Controller
{
    [ApiController]
    public class TestController:ControllerBase
    {
        private readonly DataBaseContex _contex;
        public TestController(DataBaseContex contex) {
            _contex = contex;
        }
        [Route("TestBullshit")]
        [HttpPost]
        public IActionResult Dan([FromBody] ProductModel product) {
            try {
                if (ModelState.IsValid)
                {
                    _contex.Product.Add(product);
                    _contex.SaveChanges();
                    return Ok("Work");
                }
                return BadRequest("Invalid Data");
            }
            catch (Exception ex)
            {
                return StatusCode(500,"Request: " + ex);
            }
            }
    }
}
