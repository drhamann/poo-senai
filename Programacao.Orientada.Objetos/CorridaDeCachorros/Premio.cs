namespace CorridaDeCachorros;

public class Premio
{
    public Premio(Posicoes posicao, double valorTotal, List<Apostador> apostadores) 
    {
        if(apostadores.Count == 0)
        {
            throw new Exception("Deve ter no minimo um ganhador no premio");
        }

        Posicao = posicao;
        ValorTotal = valorTotal;
        Apostadores = apostadores;
        ValorParcial = ValorTotal / apostadores.Count;
        foreach (var apostador in Apostadores)
        {
            apostador.Saldo += ValorParcial;
        }
    }

    public Posicoes Posicao { get; }
    public double ValorTotal { get; }
    public double ValorParcial { get; }
    public List<Apostador> Apostadores { get; }

    public override string ToString()
    {
        return "";
    }
}
