namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
    private static readonly Random Random = new();

    private double _distanciaPercorrida { get; set; }
    public Posicoes Posicao { get; set; }

    public Corredor(int posicaoCorredor) : base()
    {
        Nome = $"Corredor-{posicaoCorredor}";
        _distanciaPercorrida = 0.0;
        Posicao = Posicoes.NaoGanho;
    }

    public void Mover()
    {
        int distanciaPercorrida = Random.Next(1, 6);

        _distanciaPercorrida += (distanciaPercorrida * 0.1);
    }

    public double DistanciaPercorrida()
    {
        return _distanciaPercorrida;
    }
}
