using Microsoft.AspNetCore.Mvc;
using E_Shop_Catalog.Model;
using E_Shop_Catalog.Database;
using Microsoft.EntityFrameworkCore;

namespace E_Shop_Catalog.Interface
{
    public interface ICRUD
    {
        IActionResult GetAll();
        Task<IActionResult> GetByName(string Name);
        Task<IActionResult> GetByID(int Id);
        Task<IActionResult> DeleteById(int Id);
        Task<IActionResult> DeleteByName(string Name);
    }

}
