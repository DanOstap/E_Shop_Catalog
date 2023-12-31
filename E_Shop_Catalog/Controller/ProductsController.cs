﻿using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Model;
using E_Shop_Catalog.Database;
using Microsoft.EntityFrameworkCore;
using E_Shop_Catalog.Interface;

namespace E_Shop_Catalog.Controller
{
    [ApiController]
    [Route("Products")]
    public class ProductsController : ControllerBase, ICRUD
    {
        private readonly DataBaseContext _context;
        public ProductsController(DataBaseContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductModel _model)
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
        public IActionResult GetAll()
        {
            return Ok(_context.Product);
        }
        [HttpGet]
        public async Task<IActionResult> GetByName(string Name)
        {
            try
            {
                var result = _context.Product.FindAsync(Name);
                return Ok(result);
            }
            catch
            {
                Console.WriteLine($"Cant found : {Name}");
                return BadRequest($"Laptop with: {Name} wasn't found ");
            }

        }
        [HttpGet]
        [Route("Products/{Id}")]
        public async Task<IActionResult> GetByID(int Id)
        {
            ProductModel result = await _context.Product.FindAsync(Id);
            if (result == null)
            {
                return BadRequest($"Product with: {Id} wasn't found ");
            }
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int Id)
        {
            var result = _context.Product.SingleOrDefaultAsync(a => a.Product_Id == Id);
            if (result != null)
            {
                _context.Product.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteByName(string Name)
        {
            var result = _context.Product.SingleOrDefaultAsync(a => a.Product_Name == Name);
            if (result != null)
            {
                _context.Product.Remove(await result);
                _context.SaveChangesAsync();
                return Ok("Delte Confirm");
            }
            return BadRequest("Incorect data");
        }
    }
}
