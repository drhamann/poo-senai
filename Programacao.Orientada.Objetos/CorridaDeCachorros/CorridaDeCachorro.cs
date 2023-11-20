using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros;

public class CorridaDeCachorro
{
    private const int NUMERO_MINIMO_DE_APOSTADORES = 5;
    public List<Apostador> Apostadores { get; }

    public CorridaDeCachorro(int numeroDeApostadores)
    {
        if(numeroDeApostadores < NUMERO_MINIMO_DE_APOSTADORES)
        {
            throw new ArgumentException("No minimo é permetido 5 apostadores");
        }
       
        Apostadores = new List<Apostador>();

        for(int i = 0; i < numeroDeApostadores; i++)
        {
            var apostador = new Apostador(i);
            Apostadores.Add(apostador);
        }


    }
}
