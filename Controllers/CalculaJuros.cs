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
        public ActionResult<Amount> Get(int t, decimal vi)
        {
            Amount amount = new Amount();
            amount._InitialValue = vi;
            amount._Time = t;
            GetIR(amount);
            return Ok(amount.GetFinalValue());
        }


        private void GetIR(Amount amount)
        {
            RunAsync(amount).Wait();
        }

        public static async Task RunAsync(Amount amount)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44341");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET the Tax Interest Rate
                var response = client.GetAsync("/TaxaJuros");
                response.Wait();
                HttpResponseMessage result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var result1 = result;
                }
            }
        }
    }
}
