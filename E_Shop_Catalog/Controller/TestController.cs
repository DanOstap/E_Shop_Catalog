using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Model;
using E_Shop_Catalog.Database;

namespace E_Shop_Catalog.Controller
{
    [ApiController]
    public class TestController:ControllerBase
    {
        private readonly DataBaseContext _context;
        public TestController(DataBaseContext context) {
            _context = context;
        }

        [Route("TestBullshit")]
        [HttpPost]
        public IActionResult Dan([FromBody] ProductModel product) {
            try {
                if (ModelState.IsValid)
                {
                    _context.Product.Add(product);
                    _context.SaveChanges();
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
