
namespace CorridaDeCachorros;

public class CorridaDeCachorro
{
    private const int NUMERO_MINIMO_DE_APOSTADORES = 5;
    private const int NUMERO_MINIMO_DE_CORREDORES = 4;

    public double ValorTotalDeApostas { get; set; } = 0.0;
    public List<Apostador> Apostadores { get; }
    public List<Corredor> Corredores { get; }

    public Corredor Primeiro { get; set; }
    public Corredor Segundo { get; set; }
    public Corredor Terceiro { get; set; }

    public Premio PrimeiroPremio { get; set; }
    public Premio SegundoPremio { get; set; }
    public Premio TerceiroPremio { get; set; }

    public CorridaDeCachorro
        (int numeroDeApostadores = 5,
         int numeroDeCorredores = 4
        )
    {
        if (numeroDeApostadores < NUMERO_MINIMO_DE_APOSTADORES)
        {
            throw new ArgumentException("No minimo é permitido 5 apostadores");
        }

        if (numeroDeCorredores < NUMERO_MINIMO_DE_CORREDORES)
        {
            throw new ArgumentException("No minimo é permitido 4 corredores");
        }

        Apostadores = new List<Apostador>();

        for (int i = 0; i < numeroDeApostadores; i++)
        {
            Apostadores.Add(new Apostador(i));
        }

        Corredores = new List<Corredor>();
        for (int i = 0; i < numeroDeCorredores; i++)
        {
            Corredores.Add(new Corredor(i));
        }
    }

    public void Apostar(Apostador apostador, Corredor corredor, double totalAposta)
    {
        if (apostador.Saldo < totalAposta)
        {
            throw new Exception("Não tem dinheiro");
        }

        ValorTotalDeApostas += totalAposta;
        apostador.CachorroApostado = corredor.Id;
        apostador.Saldo -= totalAposta;
    }

    public void Apostar(string NomeApostador, string NomeCorredor, double totalAposta)
    {
        var apostador = Apostadores.Find(apostador => apostador.Nome.Equals(NomeApostador));
        var cachorroCorredor = Corredores.Find(corredor => corredor.Nome.Equals(NomeCorredor));

        Apostar(apostador, cachorroCorredor, totalAposta);
    }

    public string Correr()
    {
        while (Corredores.Exists(corredor =>
            corredor.DistanciaPercorrida() <= 100)
            )
        {
            VerificarCorredoresEcorrer();
        }

        DefinirPremioGanhadores();


        return "TODO";
    }

    public void DefinirPremioGanhadores()
    {
        var apostadoresEmPrimeiro
        = Apostadores.FindAll(apostador => apostador.CachorroApostado.Equals(Primeiro.Id));
        PrimeiroPremio =
            new Premio(Posicoes.Primeiro, (ValorTotalDeApostas * 0.7), apostadoresEmPrimeiro);

        var apostadoresEmSegundo
            = Apostadores.FindAll(apostador => apostador.CachorroApostado.Equals(Segundo.Id));
        SegundoPremio =
            new Premio(Posicoes.Segundo, (ValorTotalDeApostas * 0.2), apostadoresEmSegundo);

        var apostadoresEmTerceiro
        = Apostadores.FindAll(apostador => apostador.CachorroApostado.Equals(Terceiro.Id));
        TerceiroPremio =
            new Premio(Posicoes.Terceiro, (ValorTotalDeApostas * 0.1), apostadoresEmTerceiro);


    }

    private void VerificarCorredoresEcorrer()
    {
        foreach (var corredor in Corredores)
        {
            corredor.Mover();
            if (corredor.DistanciaPercorrida() >= 100.00)
            {
                if (Primeiro is null)
                {
                    Primeiro = corredor;
                    corredor.Posicao = Posicoes.Primeiro;
                    continue;
                }
                if (Segundo is null)
                {
                    Segundo = corredor;
                    corredor.Posicao = Posicoes.Segundo;
                    continue;
                }
                if (Terceiro is null)
                {
                    Terceiro = corredor;
                    corredor.Posicao = Posicoes.Terceiro;
                    continue;
                }
                corredor.Posicao = Posicoes.NaoGanho;
            }
        }
    }
}
