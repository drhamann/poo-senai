namespace SOLID_VIOLACAO
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
    }
    public class CalculadoraVolume
    {
        public double CalcularVolume(Retangulo retangulo, double profundidade)
        {
            return retangulo.Altura * retangulo.Largura * profundidade;
        }
    }

    public class Circulo
    {
        public double Raio { get; set; }
    }

    public class CalculadoraArea
    {
        public double CalcularArea(object forma)
        {
            if (forma is Retangulo)
            {
                var retangulo = (Retangulo)forma;
                return retangulo.Altura * retangulo.Largura;
            }
            else if (forma is Circulo)
            {
                var circulo = (Circulo)forma;
                return Math.PI * circulo.Raio * circulo.Raio;
            }
            else
            {
                throw new ArgumentException("Tipo de forma não suportado");
            }
        }
    }

}

namespace SOLID_CORRETO
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }

    public class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public override double CalcularArea()
        {
            return Altura * Largura;
        }
    }
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }

    public class Calculadora
    {
        public double CalcularArea(Forma forma)
        {
            return forma.CalcularArea();
        }
    }

}
