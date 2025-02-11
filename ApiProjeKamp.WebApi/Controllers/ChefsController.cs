using ApiProjeKamp.WebApi.Context;
using ApiProjeKamp.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllChefs() 
        {
            var value = _context.Chefs.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddChefs(Chef chef) 
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Şef Eklendi...");
        }

        [HttpDelete]
        public IActionResult DeleteChefs(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Şef Silindi...");
        }

        [HttpGet("GetChefById")]
        public IActionResult GetChef(int id)
        {
            var value = _context.Chefs.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Şef Güncellendi");
        }

    }
}
