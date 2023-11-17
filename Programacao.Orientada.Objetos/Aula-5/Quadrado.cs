namespace Aula_5;

// Classe filha
public class Quadrado : FiguraGeometrica
{
    public Quadrado(double lado)
    {
        Lado = lado;
        Nome = "Quadrado";
    }
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        var area = Lado * Lado;
        return area;
    }

    public override double CalcularPerimetro()
    {
        return Lado + Lado + Lado + Lado;
    }

}
