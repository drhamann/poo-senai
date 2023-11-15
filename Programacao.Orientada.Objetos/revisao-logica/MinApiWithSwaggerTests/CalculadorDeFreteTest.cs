using MinApiWithSwagger;
using Xunit;

namespace MinApiWithSwaggerTests
{
    public class CalculadorDeFreteTest
    {
        readonly CalculadorDeFrete _calculadorDeFrete;

        public CalculadorDeFreteTest()
        {
            _calculadorDeFrete = new CalculadorDeFrete();
        }

        [Theory]
        [InlineData(1, 0.1)]
        [InlineData(100, 10.0)]
        [InlineData(199, 19.9)]
        public void Deve_Calcular_O_Frete_De_Uma_Distancia_Menor_Que_200km
            (int distancia, double expectedValor)
        {

            //Act
            var result = _calculadorDeFrete.CalcularFrete(distancia, 4);

            //Assert

            Assert.Equivalent(Math.Round(expectedValor, 2), Math.Round(result, 2));
        }

        [Theory]
        [InlineData(200, 21)]
        [InlineData(399, 40.9)]
        [InlineData(400, 42)]
        [InlineData(599, 61.9)]
        [InlineData(600, 63)]
        [InlineData(799, 82.9)]
        [InlineData(800, 84)]
        [InlineData(999, 103.9)]
        public void Deve_Calcular_O_Frete_De_Uma_Distancia_Maior_Que_200km_E_Menor_Que_1000km
           (int distancia, double expectedValor)
        {
            //Act
            var result = _calculadorDeFrete.CalcularFrete(distancia, 4);

            //Assert

            Assert.Equivalent(Math.Round(expectedValor, 2), Math.Round(result, 2));
        }

        [Theory]
        [InlineData(1000, 115)]
        [InlineData(1200, 136)]
        [InlineData(1999, 218.9)]
        [InlineData(2000, 230)]
        public void Deve_Calcular_O_Frete_De_Uma_Distancia_Maior_Que_1000km
           (int distancia, double expectedValor)
        {
            //Act
            var result = _calculadorDeFrete.CalcularFrete(distancia, 4);

            //Assert

            Assert.Equivalent(Math.Round(expectedValor, 2), Math.Round(result, 2));
        }

        [Theory]
        [InlineData(1, 5, 0.5)]
        [InlineData(100, 25, 50.0)]
        [InlineData(199, 17, 99.5)]
        public void Deve_Calcular_O_Frete_De_Uma_Distancia_Menor_Que_200km_Peso_Entre_5_E_25
           (int distancia, int peso, double expectedValor)
        {

            //Act
            var result = _calculadorDeFrete.CalcularFrete(distancia, peso);

            //Assert

            Assert.Equivalent(Math.Round(expectedValor, 2), Math.Round(result, 2));
        }
        [Theory]
        [InlineData(1, 26, 0.3)]
        [InlineData(100, 50, 30)]
        [InlineData(199, 75, 59.7)]
        public void Deve_Calcular_O_Frete_De_Uma_Distancia_Menor_Que_200km_Peso_Entre_26_E_75
       (int distancia, int peso, double expectedValor)
        {

            //Act
            var result = _calculadorDeFrete.CalcularFrete(distancia, peso);

            //Assert

            Assert.Equivalent(Math.Round(expectedValor, 2), Math.Round(result, 2));
        }
    }
}