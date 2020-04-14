using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using businesstechapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace businesstechapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AportesController : ControllerBase
    {

        private readonly BTContexto _context;

        private readonly ILogger<AportesController> _logger;

        public AportesController(ILogger<AportesController> logger, BTContexto context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Aportes> Get()
        {
           return  _context.Aportes.ToList();
        }
    }
}
