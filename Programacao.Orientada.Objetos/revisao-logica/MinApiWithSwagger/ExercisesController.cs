using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercisesController : ControllerBase
    {
        // Exercício 1: FizzBuzz
        /// <summary>
        /// Escreva um programa que imprima os números de 1 a 30. 
        /// Para múltiplos de 3, imprima 'Fizz', para múltiplos de 5, imprima 'Buzz', 
        /// e para múltiplos de ambos, imprima 'FizzBuzz'.
        /// "Resultado esperado: [1, 2, 'Fizz', 4, 'Buzz', 'Fizz', ..., 'FizzBuzz']"
        /// </summary>
        /// <returns>Lista de números ou palavras conforme as regras do FizzBuzz.</returns>
        [HttpGet("fizzbuzz")]
        public IActionResult FizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();

            var fizzBuzzResult = fizzBuzz.Calculate(30);

            return Ok(fizzBuzzResult);
        }

        // Exercício 2: Soma dos Quadrados
        /// <summary>
        /// Dada uma lista de números, escreva um programa para calcular a soma dos quadrados desses números.
        /// Resultado esperado: Se a lista for [1, 2, 3, 4, 5], a soma dos quadrados será 55."
        /// </summary>
        /// <returns>A soma dos quadrados dos números na lista.</returns>
        [HttpGet("sum-of-squares")]
        public IActionResult SumOfSquares(int[] numbers)
        {
            return Ok();
        }

        // Exercício 3: Inversão de String
        /// <summary>
        /// Dada uma string, escreva um programa para inverter a string.
        /// "Resultado esperado: Se a string for 'Hello, World!', o resultado deve ser '!dlroW ,olleH'."
        /// </summary>
        /// <returns>A string invertida.</returns>
        [HttpGet("reverse-string")]
        public IActionResult ReverseString(string fraseNormal)
        {
            return Ok();
        }

        // Exercício 4: Números Primos
        /// <summary>
        /// Escreva um programa para encontrar todos os números primos até um determinado limite.
        /// "Resultado esperado: Se o limite for 30, os números primos são [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]."
        /// </summary>
        /// <returns>Lista de números primos até o limite.</returns>
        [HttpGet("prime-numbers")]
        public IActionResult PrimeNumbers(int limite)
        {
            return Ok();
        }

        // Exercício 5: Sequência de Fibonacci
        /// <summary>
        /// Escreva um programa para gerar a sequência de Fibonacci até um determinado termo.
        /// "Resultado esperado: Se o termo desejado for 10, a sequência de Fibonacci será [0, 1, 1, 2, 3, 5, 8, 13, 21, 34]."
        /// </summary>
        /// <returns>A sequência de Fibonacci até o termo desejado.</returns>
        [HttpGet("fibonacci-sequence")]
        public IActionResult FibonacciSequence(int limite)
        {
            return Ok();
        }

        // Exercício 6: Maior Subsequência Crescente
        /// <summary>
        /// Dada uma lista de números, escreva um programa para encontrar a maior subsequência crescente.
        /// "Resultado esperado: Se a lista for [3, 10, 2, 1, 20], a maior subsequência crescente será [3, 10, 20]."
        /// </summary>
        /// <returns>A maior subsequência crescente na lista.</returns>
        [HttpGet("longest-increasing-subsequence")]
        public IActionResult LongestIncreasingSubsequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return BadRequest("A lista de números não pode ser vazia.");
            }

            // Lógica para encontrar a maior subsequência crescente
            List<int> longestIncreasingSubsequence = null;//FindLongestIncreasingSubsequence(numbers);

            return Ok(longestIncreasingSubsequence);
        }

        // Exercício 7: Ordenação de Lista
        /// <summary>
        /// Dada uma lista de números desordenada, escreva um programa para ordenar a lista em ordem crescente.
        /// "Resultado esperado: Se a lista for [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5], 
        /// o resultado após ordenação será [1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9]."
        /// </summary>
        /// <returns>A lista ordenada em ordem crescente.</returns>
        [HttpGet("sort-list")]
        public IActionResult SortList(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return BadRequest("A lista de números não pode ser vazia.");
            }

            // Lógica para ordenar a lista
            List<int> sortedList = numbers.ToList();

            return Ok(sortedList);
        }
    }
}
