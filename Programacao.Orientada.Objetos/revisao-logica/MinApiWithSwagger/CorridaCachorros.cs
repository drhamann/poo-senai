using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger
{
    public class CorridaCachorros
    {
        /*
         * Projeto teste, vamos fazer uma casa de apostas para corrida de cachorro
Deve pedir quanto apostadores terá a partida
Todo apostador começa com R$ 20,00
Deve ter no mínimo 5 apostadores
Deve informar quantos corredores terá a casa de apostas
Deve ter no mínimo 4 corredores
Os corredores podem mover aleatoriamente a cada rodada entre 10cm até 60 cm 
Deve fazer com que cada apostador informe em qual corredor ele irá apostar
Ganha a corrida o corredor que chegar em 100 metros primeiro
Até o terceiro colocado recebe prêmio proporcional ao valor das apostas, sendo 70%, 20% e 10%
Todos devem finalizar a corrida
Deve mostrar ao finalizar a corrida 
Colocação dos corredores
Quanto cada apostador tem de saldo
*/
        public string Correr()
        {
            return "Resultado corrida";
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class CorridaCachorrosApiController : ControllerBase
    {
        //TODO:Fazer a corrida funcionar
        public CorridaCachorrosApiController(CorridaCachorros corridaCachorros)
        {
            CorridaCachorros = corridaCachorros;
        }

        public CorridaCachorros CorridaCachorros { get; }

        [HttpGet]
        public IActionResult Start()
        {
            return Ok(CorridaCachorros.Correr());
        }
    }
}
