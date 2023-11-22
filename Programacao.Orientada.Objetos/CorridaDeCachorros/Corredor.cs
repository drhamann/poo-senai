namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
    private double _distanciaPercorrida { get; set; }
    private static readonly Random Random = new();
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
