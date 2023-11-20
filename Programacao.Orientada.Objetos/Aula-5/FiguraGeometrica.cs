namespace Aula_5;

// Classe pai
public abstract class FiguraGeometrica
{
    public string Nome { get; set; }

    public virtual double CalcularArea()
    {
        return 0;
    }

    public virtual double CalcularPerimetro()
    {
        return 0;
    }

    public string GerarNome()
    {
        return Nome + Math.Log10(100);
    }

    public override string ToString()
    {
        return $"Nome da forma {Nome} Area = {CalcularArea()} Perimeto {CalcularPerimetro()}";
    }
}
