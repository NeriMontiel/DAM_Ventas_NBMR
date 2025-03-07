using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ventas.API.Data;
using Ventas.Shared.Entities;

namespace Ventas.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController: ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
           this._context = context;
        }
        [HttpPost]

        public async Task<ActionResult> PostAsync (Country country)
        {
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]

        public async Task<ActionResult> Getasync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }
    }
}
