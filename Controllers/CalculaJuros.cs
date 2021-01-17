using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJuros : ControllerBase
    {
        private readonly ILogger<CalculaJuros> _logger;

        public CalculaJuros(ILogger<CalculaJuros> logger)
        {
            _logger = logger;
        }
        // GET: /calculajuros?t=5&vi=100 Resultado esperado: 105,10
        // GET: TaxaJuros
        [HttpGet]
        public ActionResult<Amount> Get(int t, double vi)
        {
            Amount amount = new Amount
            {
                _InitialValue = vi,
                _Time = t,
                _IR = InterestRate.GetIRate()
            };
            return Ok(amount.GetFinalValue());
        }
    }
}
