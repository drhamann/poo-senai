﻿using Xunit;
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
            = new CorridaDeCachorro(5, expectedCorredores);

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

}