using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSSQLDOCKER.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly TestDbContext _context;


        public WeatherForecastController(TestDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<TestEntry>> Get()
        {
            var entries = await _context.TestEntries.ToListAsync();
            return entries;
        }

        [HttpPost]
        public async Task Post([FromBody] TestEntry entry)
        {
            await _context.TestEntries.AddAsync(entry);
            await _context.SaveChangesAsync();
        }
    }
}
