namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
    public Corredor(int posicaoCorredor) : base()
    {
        Nome = $"Corredor-{posicaoCorredor}";
    }
}
