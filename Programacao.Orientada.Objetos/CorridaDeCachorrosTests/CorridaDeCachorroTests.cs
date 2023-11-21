using Xunit;
using FluentAssertions;

namespace CorridaDeCachorros.Tests;

public class CorridaDeCachorroTests
{
    [Fact]
    public void Deve_Iniciar_A_Corrida_Com_No_Minimo_5_Apostadores()
    {
        //Arrange
        var expectedApostadores = 5;

        //Act
        CorridaDeCachorro corridaDeCachorro 
            = new CorridaDeCachorro(expectedApostadores);

        //Assert
        corridaDeCachorro.Apostadores.Count.Should().Be(expectedApostadores);
    }

    [Fact]
    public void Nao_Deve_Iniciar_A_Corrida_Com_Menos_De_5_Apostadores()
    {
        //Arrange
        var expectedApostadores = 4;

        //Act
        try
        {
            var corridaDeCachorro = new CorridaDeCachorro(expectedApostadores);
        }catch(ArgumentException ex)
        {
            ex.Message.Should().Be("No minimo é permitido 5 apostadores");
        }
    }

    [Fact]
    public void Deve_Iniciar_A_Corrida_Com_No_Minimo_4_Corredores()
    {
        //Arrange
        var expectedCorredores = 4;

        //Act
        CorridaDeCachorro corridaDeCachorro
            = new CorridaDeCachorro(5);

        //Assert
        corridaDeCachorro.Corredores.Count.Should().Be(expectedCorredores);
    }

    [Fact]
    public void Nao_Deve_Iniciar_A_Corrida_Com_No_Minimo_3_Corredores()
    {
        //Arrange
        var expectedCorredores = 3;

        //Act
        try
        {
            var corridaDeCachorro = new CorridaDeCachorro(5, expectedCorredores);
        }catch( ArgumentException ex)
        {
            ex.Message.Should().Be("No minimo é permitido 4 corredores");
        }
    }

    [Fact]
    public void Deve_Os_Corredores_Mover_Entre_Dezcm_E_Sessentacm()
    {
        //Arrange
        var corridaDeCachorro = new CorridaDeCachorro(5);
        double distanciaEsperadaMaiorQue = 0.1;
        double distanciaEsperadaMenorQue = 0.6;

        foreach (var corredor in corridaDeCachorro.Corredores)
        {
            //Act
            corredor.Mover();

            //Assert
            corredor.DistanciaPercorrida().Should().BeGreaterThanOrEqualTo(distanciaEsperadaMaiorQue);
            corredor.DistanciaPercorrida().Should().BeLessThanOrEqualTo(distanciaEsperadaMenorQue);
        }
    }

    [Fact]
    public void Deve_Permetir_O_Apostador_Escolher_Um_Corredor()
    {
        //Arrange
        var corridaDeCachorro = new CorridaDeCachorro(5);
        var corredorEsperado = corridaDeCachorro.Corredores.First();
        var apostadorEsperado = corridaDeCachorro.Apostadores.First();

        //Act
        corridaDeCachorro.EscolherCorredor(apostadorEsperado, corredorEsperado);

        //Assert
        apostadorEsperado.CachorroApostado.Should().Be(corredorEsperado.Id);

     }

    [Fact]
    public void Deve_Permetir_O_Apostador_Escolher_Um_Corredor_Pelos_Nomes()
    {
        //Arrange
        var corridaDeCachorro = new CorridaDeCachorro(5);
        var nomeDoApostador = "Apostador-1";
        var nomeDoCorredor = "Corredor-3";

        var apostadorExperado = corridaDeCachorro.Apostadores.Find(apostador => apostador.Nome.Equals(nomeDoApostador));
        var cachorroEsperado = corridaDeCachorro.Corredores.Find(corredor => corredor.Nome.Equals(nomeDoCorredor));

        //Act
        corridaDeCachorro.EscolherCorredor(nomeDoApostador, nomeDoCorredor);

        //Assert

        apostadorExperado.CachorroApostado.Should().Be(cachorroEsperado.Id);
        cachorroEsperado.Nome.Should().Be(nomeDoCorredor);
        apostadorExperado.Nome.Should().Be(nomeDoApostador);


    }

}