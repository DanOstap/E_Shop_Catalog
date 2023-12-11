using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Model;
using E_Shop_Catalog.Database;
using Microsoft.AspNetCore.Http.HttpResults;

namespace E_Shop_Catalog.Controller
{
    [ApiController]
    [Route("Computers")]
    public class ComputersController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public ComputersController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ComputerModel _model) {
            try
            {
                if (!ModelState.IsValid)
                {
                    BadRequest("Invalid data");
                }
                _context.Add(_model);
                _context.SaveChanges();
                return Ok();
            }

            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex);
            }
        }
        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_context.Computers);
        }
        [HttpGet]
        [Route("Computer/Id")]
        public async Task<IActionResult> GetByID(int Id)
        {
            ComputerModel result = await _context.Computers.FindAsync(Id);
            if (result == null)
            {
                return BadRequest($"Computer with: {Id} wasn't found ");
            }
            return Ok(result);
        }
    }
}
