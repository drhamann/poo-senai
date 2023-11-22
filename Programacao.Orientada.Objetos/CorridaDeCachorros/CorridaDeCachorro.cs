using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros;

public class CorridaDeCachorro
{
    private const int NUMERO_MINIMO_DE_APOSTADORES = 5;
    private const int NUMERO_MINIMO_DE_CORREDORES = 4;
    public List<Apostador> Apostadores { get; }
    public List<Corredor> Corredores { get; }

    public CorridaDeCachorro
        (int numeroDeApostadores,
         int numeroDeCorredores = 4
        )
    {
        if(numeroDeApostadores < NUMERO_MINIMO_DE_APOSTADORES)
        {
            throw new ArgumentException("No minimo é permitido 5 apostadores");
        }

        if (numeroDeCorredores < NUMERO_MINIMO_DE_CORREDORES)
        {
            throw new ArgumentException("No minimo é permitido 4 corredores");
        }

        Apostadores = new List<Apostador>();

        for(int i = 0; i < numeroDeApostadores; i++)
        {
            Apostadores.Add(new Apostador(i));
        }

        Corredores = new List<Corredor>();
        for (int i = 0;i < numeroDeCorredores; i++)
        {
            Corredores.Add(new Corredor(i));
        }
    }

    public void EscolherCorredor(Apostador apostador, Corredor corredor)
    {
        //TODO: 
        apostador.CachorroApostado = corredor.Id;
    }

    public void EscolherCorredor(string NomeApostador, string NomeCorredor)
    {
        var apostador = Apostadores.Find(apostador => apostador.Nome.Equals(NomeApostador));
        var cachorroCorredor = Corredores.Find(corredor => corredor.Nome.Equals(NomeCorredor));

        EscolherCorredor(apostador, cachorroCorredor);
    }

    public void Correr()
    {
        while (ExisteCorredorCom100Metros() is false)
        {
            foreach (var corredor in Corredores)
            {
                corredor.Mover();
            }
        }
    }

    private bool ExisteCorredorCom100Metros()
    {
        foreach (var corredor in Corredores)
        {
            if(corredor.DistanciaPercorrida() >= 100.00)
            {
                return true;
            }
        }
        return false;
    }
}
