namespace CorridaDeCachorros;

public class Apostador : BaseModel
{
    private const double VALOR_INICIAL_CORRIDA = 20.0;

    public double Saldo { get; set; }
    public Guid CachorroApostado { get; set; }

    public Apostador(int posicaoApostador) : base()
    {
        Saldo = VALOR_INICIAL_CORRIDA;
        Nome = $"Apostador-{posicaoApostador}";
    }
}
