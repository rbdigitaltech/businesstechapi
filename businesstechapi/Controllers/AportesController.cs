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


        [HttpPost]
        public void Insere(Aportes a)
        {

            _context.Aportes.Add(new Aportes()
            {
                idcliente = 130,
                valor = 100,
                percentual = 10,
                dataInicio = DateTime.Now,
                tempoMeses = 12
            });

            _context.SaveChanges();
        }


    }
}
