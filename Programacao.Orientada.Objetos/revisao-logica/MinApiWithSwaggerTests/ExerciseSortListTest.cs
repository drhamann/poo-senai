using Aula_5;
using FluentAssertions;
using Xunit;

namespace MinApiWithSwaggerTests;

public class ExerciseSortListTest
{
    [Fact]
    public void Deve_Ordenar_Uma_Lista_De_Numeros()
    {
        //Arrange
        ExerciseSortList exerciseSortList = new ExerciseSortList();

        int[] listaDesordenada = new int[] { 9, 5, 4, 2, 5, 3, 1, 6, 5, 3, 1 };
        int[] listaOrdenada = new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9 };

        //Act
        var resultadoDaOrdenacao = exerciseSortList.SortNumber(listaDesordenada);

        //Assert
        resultadoDaOrdenacao.Should().BeEquivalentTo(listaOrdenada);
    }

    [Fact]
    public void Deve_Ordenar_Uma_Lista_De_Numeros_Sem_Repeticao()
    {
        //Arrange
        ExerciseSortList exerciseSortList = new ExerciseSortList();

        int[] listaDesordenada = new int[] { 3, 2, 1 };
        int[] listaOrdenada = new int[] { 1, 2, 3 };

        //Act
        var resultadoDaOrdenacao = exerciseSortList.SortNumber(listaDesordenada);

        //Assert
        resultadoDaOrdenacao.Should().BeEquivalentTo(listaOrdenada);
    }
}
