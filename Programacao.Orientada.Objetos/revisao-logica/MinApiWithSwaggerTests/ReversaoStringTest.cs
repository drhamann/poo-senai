using Aula_5;
using FluentAssertions;
using Xunit;

namespace MinApiWithSwaggerTests;

public class ReversaoStringTest
{
    [Fact]
    public void Deve_Reverter_A_Frase()
    {
        //Arrange
        string fraseParaReverter = "Hello World";
        string fraseRevertida = "dlroW olleH";
        string resultado = string.Empty;
        ReversaoString reversaoString = new ReversaoString();

        //Act
        resultado = reversaoString.Reverter(fraseParaReverter);


        //Assert
        resultado.Should().Be(fraseRevertida);
    }
}
