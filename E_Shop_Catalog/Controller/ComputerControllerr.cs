using E_Shop_Catalog.Database;
using E_Shop_Catalog.Interface;
using E_Shop_Catalog.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;

namespace E_Shop_Catalog.Controller
{
    public class ComputerControllerr : ControllerBase, ICRUD
    {
        private readonly DataBaseContext _context;
        public ComputerControllerr(DataBaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ComputerModel _model)
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
        public async Task<IActionResult> GetByName(string Name)
        {
            try 
            {
                var result = _context.Computers.FindAsync(Name);
                return Ok(result);
            }
            catch
            {
                Console.WriteLine($"Cant found : {Name}");
                return BadRequest($"Laptop with: {Name} wasn't found ");
            }

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Product);
        }
        [HttpGet]
        [Route("Products/{Id}")]
        public async Task<IActionResult> GetByID(int Id)
        {
            ComputerModel result = await _context.Computers.FindAsync(Id);
            if (result == null)
            {
                return BadRequest($"Product with: {Id} wasn't found ");
            }
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int Id)
        {
            var result = _context.Computers.SingleOrDefaultAsync(a => a.Computers_Id == Id);
            if (result != null)
            {
                _context.Computers.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteByName(string Name)
        {
            var result = _context.Computers.SingleOrDefaultAsync(a => a.Copmputer_Name == Name);
            if (result != null)
            {
                _context.Computers.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
    }
}
