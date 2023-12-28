using E_Shop_Catalog.Database;
using E_Shop_Catalog.Interface;
using E_Shop_Catalog.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Shop_Catalog.Controller
{
    [ApiController]
    [Route("Laptops")]
    public class LaptopsController : ControllerBase, ICRUD
    {
        private readonly DataBaseContext _context;

        public LaptopsController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LaptopModel _model)
        {
            try
            {
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
        public async Task<IActionResult> GetByName(string Name) {
            try {
                var result = _context.Laptops.FindAsync(Name);
                return Ok(result);
            } catch {
                Console.WriteLine($"Cant found : {Name}");
                return BadRequest($"Laptop with: {Name} wasn't found ");
            }
           
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Laptops);
        }

        [HttpGet]
        [Route("Laptops/{Id}")]
        public async Task<IActionResult> GetByID(int Id)
        {
            LaptopModel result = await _context.Laptops.FindAsync(Id);
            if (result == null)
            {
                return BadRequest($"Laptop with: {Id} wasn't found ");
            }
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteById(int Id)
        {
            var result = _context.Laptops.SingleOrDefaultAsync(a => a.Laptops_Id == Id);
            if (result != null)
            {
                _context.Laptops.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteByName(string Name) {
            var result = _context.Laptops.SingleOrDefaultAsync(a => a.Laptop_Name == Name);
            if (result != null)
            {
                _context.Laptops.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
    }
}
