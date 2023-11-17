

namespace Aula_5;

// Classe filha
public class Circulo : FiguraGeometrica
{
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double Raio { get; set; }

    public override double CalcularArea()
    {
        // PI * R 2
        var area = Math.PI * Raio * Raio;

        return area;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
