namespace Aula_5;

public class Celular : IDispositivoEletronico
{
    private bool Status { get; set; }

    public void Desligar()
    {
        Status = false;
    }

    public void Ligar()
    {
        Status = true;
    }

    public bool StatusDispositivo()
    {
        return Status;
    }
}
