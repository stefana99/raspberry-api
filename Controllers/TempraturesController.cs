using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using raspberry_api.Models;

namespace raspberry_api.Controllers
{
    [Route("api/[controller]")]
    public class TempraturesController : Controller
    {
        private readonly TempraturesContext _context;
        public TempraturesController(TempraturesContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Reading> Get()
        {
            return _context.Readings.ToList();
        }
    }
}