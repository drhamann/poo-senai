using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger
{
    public interface IJogador
    {
        int Idate { get; set; }
        string Nome { get; set; }

        bool Atirar(string outroJogador);
        int Correr();
    }
    public abstract class AbstractJogador : IJogador
    {
        public string Nome { get; set; }
        public int Idate { get; set; }

        public AbstractJogador()
        {
            Nome = "Zero";
        }

        public int Correr()
        {
            return 20;
        }

        public virtual bool Atirar(string outroJogador)
        {
            return false;
        }
    }

    public class JogadorCs : AbstractJogador
    {
        public override bool Atirar(string outroJogador)
        {
            if (base.Atirar(outroJogador) is false)
            {
                return true;
            }
            return false;
        }
    }

    public class JogadorDeLol : AbstractJogador
    {
        public JogadorDeLol()
        {

        }

        public override bool Atirar(string outroJogador)
        {
            if (Nome.Equals(outroJogador))
            {
                return true;
            }
            return false;
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class JogadorApiController : ControllerBase
    {
        public IJogador JogadorDelol { get; set; }
        public IJogador JogadorDeCs { get; set; }

        public JogadorApiController()
        {
            JogadorDelol = new JogadorDeLol()
            {
                Nome = "JogadorDelol"
            };
            JogadorDeCs = new JogadorCs()
            {
                Nome = "Cristiano"
            };
        }

        [HttpGet]
        public IActionResult ChameOsJogadores()
        {
            JogadorDeCs.Atirar("Cristiano");
            JogadorDelol.Atirar("JogadorDelol")
;
            return Ok();
        }
    }
}
