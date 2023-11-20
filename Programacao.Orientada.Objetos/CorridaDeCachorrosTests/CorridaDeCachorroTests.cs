using Xunit;
using FluentAssertions;

namespace CorridaDeCachorros.Tests
{
    
    public class CorridaDeCachorroTests
    {
        [Fact]
        public void Deve_Iniciar_A_Corrida_Com_No_Minimo_5_Apostadores()
        {
            //Arrange
            var expectedApostadores = 5;

            //Act
            CorridaDeCachorro corridaDeCachorro = new CorridaDeCachorro(expectedApostadores);

            //Assert
            corridaDeCachorro.Apostadores.Count.Should().Be(expectedApostadores);
        }
    }
}