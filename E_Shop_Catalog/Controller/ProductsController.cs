using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Model;
using E_Shop_Catalog.Database;

namespace E_Shop_Catalog.Controller
{
    [ApiController]
    [Route("Products")]
    public class ProductsController:ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly ProductModel _product;
        public ProductsController(DataBaseContext context) {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ProductModel _model) {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid Data");
                }
                _context.Add(_model);
                _context.SaveChanges();
                return Ok("Work");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex);
            }

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Product);
        }
        [HttpGet]
        [Route("Products/Id")]
        public async Task<IActionResult> GetByID(int Id) {
            ProductModel result =  await _context.Product.FindAsync(Id);
            if (result == null)
            {
                return BadRequest($"Product with: {Id} wasn't found ");
            }
            return Ok(result);
        }
    }
}
