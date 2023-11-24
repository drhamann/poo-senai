using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_VIOLANDO
{
    class Empregado
    {
        public void SalvarNoBanco() { }
        public void GerarRelatorio() { }
    }

}

namespace SOLID_SRP_CORRETO
{
    class Empregado
    {
        public void SalvarNoBanco() { }
    }
    class GeradorDeRelatorio
    {
        public void GerarRelatorio() { }
    }
}
