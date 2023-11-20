using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros
{
    public class Apostador
    {
        private const double VALOR_INICIAL_CORRIDA = 20.0;

        public double Saldo { get; set; }
        public string Nome { get; set; }

        public Apostador(int posicaoApostador)
        {
            Saldo = VALOR_INICIAL_CORRIDA;
            Nome = $"Apostador-{posicaoApostador}";
        }
    }
}
