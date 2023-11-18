namespace Aula_5
{
    public class ExerciseSortList
    {
        public int[] SortNumber(int[] numbers)
        {
            //TODO: Resolver.
            /// "Resultado esperado: Se a lista for [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5], 
            ///
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int proximoValor = numbers[j];
                    int valorAtual = numbers[i];

                    if (valorAtual > proximoValor)
                    {
                        numbers[i] = proximoValor;
                        numbers[j] = valorAtual;
                    }
                }
            }

            return numbers;
        }
    }
}
