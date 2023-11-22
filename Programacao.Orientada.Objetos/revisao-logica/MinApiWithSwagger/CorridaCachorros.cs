using CorridaDeCachorros;
using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger
{

    [ApiController]
    [Route("[controller]")]
    public class CorridaCachorrosApiController : ControllerBase
    {
        //TODO:Fazer a corrida funcionar
        public CorridaCachorrosApiController(CorridaDeCachorro corridaCachorros)
        {
            CorridaCachorros = corridaCachorros;
        }

        public CorridaDeCachorro CorridaCachorros { get; }

        [HttpGet]
        public IActionResult Start()
        {
            return Ok(CorridaCachorros.Correr());
        }

        [HttpPost]
        public IActionResult Apostas(string nomeDoApostador, string nomeDoCorredor, double totalAposta)
        {
            try
            {
                CorridaCachorros.Apostar(nomeDoApostador, nomeDoCorredor, totalAposta);

            }
            catch
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
