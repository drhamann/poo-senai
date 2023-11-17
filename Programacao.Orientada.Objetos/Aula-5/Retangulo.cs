namespace Aula_5;

//Classe pai e filha
public class Retangulo : FiguraGeometrica
{
    public double Altura { get; set; }
    public double Lado { get; set; }

    public Retangulo(double lado, double altura)
    {
        Lado = lado;
        Altura = altura;
        Nome = "Retangulo";
    }

    public Retangulo()
    {
        Nome = "Retangulo";
    }

    public override double CalcularArea()
    {
        return Lado * Altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (Altura + Lado);
    }
}
