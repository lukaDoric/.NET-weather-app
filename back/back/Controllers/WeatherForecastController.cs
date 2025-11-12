using Microsoft.AspNetCore.Mvc;
using System;
using back.Data;
using back.Models;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WeatherForecastController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Weather> Get()
        {
            return _context.Weathers.ToList();
        }
    }
}
