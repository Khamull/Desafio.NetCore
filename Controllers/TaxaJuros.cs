using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJuros : ControllerBase
    {
        private readonly ILogger<TaxaJuros> _logger;

        public TaxaJuros(ILogger<TaxaJuros> logger)
        {
            _logger = logger;
        }
        // GET: TaxaJuros
        [HttpGet]
        public ActionResult<InterestRate> Get()
        {
            return Ok(InterestRate.GetIRate());
        }
    }
}
