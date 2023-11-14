using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger
{
    public class CalculadorDeFrete
    {
        /// <summary>
        /// Calculo de frete para uma compra
        /// Vamos criar um programa que receba a distância entre o distribuidor e o local de entrega e calcule o valor do frete, sendo que para km é cobrado R$ 0,10 
        /// A cada 200 km, deve adicionar uma taxa de R$ 1,00A cada 1000 km, deve adicionar uma taxa de R$ 10,00
        /// Agora precisamos calcular o frete baseado no preço da encomenda
        /// O valor do frete não altera para produtos com até 5kg
        /// Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
        /// Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x

        /// </summary>
        /// <param name="posicaoInical"></param>
        /// <param name="distancia"></param>
        /// <param name="peso"></param>
        /// <returns></returns>
        public double CalcularFrete(int distancia, int peso)
        {
            // TODO: Calcular frete

            return 0.0;
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class CalculadorDeFreteApiController : ControllerBase
    {
        public CalculadorDeFreteApiController(CalculadorDeFrete calculadorDeFrete)
        {
            CalculadorDeFrete = calculadorDeFrete;
        }

        public CalculadorDeFrete CalculadorDeFrete { get; }

        [HttpGet("calculador-frete")]
        public IActionResult CalculoFrete(int distancia, int peso)
        {
            return Ok(CalculadorDeFrete.CalcularFrete(distancia, peso));
        }
    }
}
