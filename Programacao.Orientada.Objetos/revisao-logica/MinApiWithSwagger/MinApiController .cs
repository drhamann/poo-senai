using Microsoft.AspNetCore.Mvc;

namespace MinApiWithSwagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MinApiController : ControllerBase
    {
        // Topic 1: Introduction to Programming Logic
        [HttpGet("introduction")]
        public IActionResult Introduction()
        {
            return Ok(GetResultWithChallenge("Introduction to Programming Logic", "Hello, World!"));
        }

        [HttpGet("introduction-challenge")]
        public IActionResult IntroductionChallenge()
        {
            return Ok("Challenge: Print a welcome message with your name.");
        }

        // Topic 2: Algorithm Representation
        [HttpGet("algorithm-representation")]
        public IActionResult AlgorithmRepresentation()
        {
            return Ok(GetResultWithChallenge("Algorithm Representation", "Descriptive representation - Describes the algorithm in natural language."));
        }

        [HttpGet("algorithm-representation-challenge")]
        public IActionResult AlgorithmRepresentationChallenge()
        {
            return Ok("Challenge: Create a more complex algorithm and represent it in pseudocode.");
        }

        // Topic 3: Installation and Configuration
        [HttpGet("installation-and-configuration")]
        public IActionResult InstallationAndConfiguration()
        {
            return Ok(GetResultWithChallenge("Installation and Configuration", "Install Visual Studio or another IDE. Configure projects, virtual environments, and additional tools."));
        }

        [HttpGet("installation-and-configuration-challenge")]
        public IActionResult InstallationAndConfigurationChallenge()
        {
            return Ok("Challenge: Install a new programming language or tool and configure a basic project.");
        }

        // Topic 4: Arithmetic Operators
        [HttpGet("arithmetic-operators")]
        public IActionResult ArithmeticOperators()
        {
            return Ok(GetResultWithChallenge("Arithmetic Operators", GetArithmeticOperatorsResult()));
        }

        [HttpGet("arithmetic-operators-challenge")]
        public IActionResult ArithmeticOperatorsChallenge()
        {
            return Ok("Challenge: Implement additional arithmetic operations (subtraction, multiplication, division, modulus).");
        }

        // Topic 5: Variables and Constants
        [HttpGet("variables-and-constants")]
        public IActionResult VariablesAndConstants()
        {
            return Ok(GetResultWithChallenge("Variables and Constants", GetVariablesAndConstantsResult()));
        }

        [HttpGet("variables-and-constants-challenge")]
        public IActionResult VariablesAndConstantsChallenge()
        {
            return Ok("Challenge: Manipulate the variable and constant values further.");
        }

        // Topic 6: Logical Operators
        [HttpGet("logical-operators")]
        public IActionResult LogicalOperators()
        {
            return Ok(GetResultWithChallenge("Logical Operators", GetLogicalOperatorsResult()));
        }

        [HttpGet("logical-operators-challenge")]
        public IActionResult LogicalOperatorsChallenge()
        {
            return Ok("Challenge: Create more complex logical conditions.");
        }

        // Topic 7: Data Types
        [HttpGet("data-types")]
        public IActionResult DataTypes()
        {
            return Ok(GetResultWithChallenge("Data Types", GetDataTypesResult()));
        }

        [HttpGet("data-types-challenge")]
        public IActionResult DataTypesChallenge()
        {
            return Ok("Challenge: Add more data types and display their values.");
        }

        // Topic 8: Selection Structures
        [HttpGet("selection-structures")]
        public IActionResult SelectionStructures()
        {
            return Ok(GetResultWithChallenge("Selection Structures", GetSelectionStructuresResult()));
        }

        [HttpGet("selection-structures-challenge")]
        public IActionResult SelectionStructuresChallenge()
        {
            return Ok("Challenge: Implement a different selection structure.");
        }

        // Topic 9: Repetition Structures
        [HttpGet("repetition-structures")]
        public IActionResult RepetitionStructures()
        {
            return Ok(GetResultWithChallenge("Repetition Structures", GetRepetitionStructuresResult()));
        }

        [HttpGet("repetition-structures-challenge")]
        public IActionResult RepetitionStructuresChallenge()
        {
            return Ok("Challenge: Use a different type of loop.");
        }

        // Topic 10: Vector Manipulation
        [HttpGet("vector-manipulation")]
        public IActionResult VectorManipulation()
        {
            return Ok(GetResultWithChallenge("Vector Manipulation", GetVectorManipulationResult()));
        }

        [HttpGet("vector-manipulation-challenge")]
        public IActionResult VectorManipulationChallenge()
        {
            return Ok("Challenge: Implement additional operations on the array.");
        }

        // Topic 11: Matrix Manipulation
        [HttpGet("matrix-manipulation")]
        public IActionResult MatrixManipulation()
        {
            return Ok(GetResultWithChallenge("Matrix Manipulation", GetMatrixManipulationResult()));
        }

        [HttpGet("matrix-manipulation-challenge")]
        public IActionResult MatrixManipulationChallenge()
        {
            return Ok("Challenge: Manipulate the 2D array in a different way.");
        }

        // Topic 12: Time and Space Complexity
        [HttpGet("time-and-space-complexity")]
        public IActionResult TimeAndSpaceComplexity()
        {
            return Ok(GetResultWithChallenge("Time and Space Complexity", GetTimeAndSpaceComplexityResult()));
        }

        [HttpGet("time-and-space-complexity-challenge")]
        public IActionResult TimeAndSpaceComplexityChallenge()
        {
            return Ok("Challenge: Learn about and provide a brief explanation of time and space complexity.");
        }

        // Topic 13: Use of ChatGPT
        [HttpGet("use-of-chatgpt")]
        public IActionResult UseOfChatGPT()
        {
            return Ok(GetResultWithChallenge("Use of ChatGPT", "Integrate ChatGPT API for assistance in problem-solving or code generation."));
        }

        [HttpGet("use-of-chatgpt-challenge")]
        public IActionResult UseOfChatGPTChallenge()
        {
            return Ok("Challenge: Research and implement a simple integration with ChatGPT.");
        }

        private object GetResultWithChallenge(string topic, object result)
        {
            return new { Topic = topic, Result = result };
        }

        private object GetArithmeticOperatorsResult()
        {
            int a = 5;
            int b = 3;
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            double division = (double)a / b; // Ensure division result is a decimal
            int modulus = a % b;

            return new { Addition = addition, Subtraction = subtraction, Multiplication = multiplication, Division = division, Modulus = modulus };
        }

        private object GetVariablesAndConstantsResult()
        {
            int variable = 10;
            const int constant = 5;
            variable = variable * 2; // Variable manipulation

            return new { Variable = variable, Constant = constant };
        }

        private object GetLogicalOperatorsResult()
        {
            bool trueValue = true;
            bool falseValue = false;
            bool andResult = trueValue && falseValue;
            bool orResult = trueValue || falseValue;
            bool notResult = trueValue is false;

            return new { AndResult = andResult, OrResult = orResult, NotResult = notResult };
        }

        private object GetDataTypesResult()
        {
            int integer = 10;
            double floatingPoint = 3.14;
            char character = 'A';
            bool boolean = true;
            string text = "Hello, World!";

            return new { Integer = integer, FloatingPoint = floatingPoint, Character = character, Boolean = boolean, Text = text };
        }

        private object GetSelectionStructuresResult()
        {
            int age = 18;
            string result = "";

            if (age < 13)
            {
                result = "Child";
            }
            else if (age < 20)
            {
                result = "Teenager";
            }
            else
            {
                result = "Adult";
            }

            return result;
        }

        enum temperatura
        {
            celcisus = 0,
            kelvin = 1,
            fareightn = 2
        }

        private object GetRepetitionStructuresResult()
        {
            // For Loop Example
            string forLoopResult = "";
            for (var i = 0; i < 5; i++)
            {
                forLoopResult += $"Count: {i}\n";
            }

            // While Loop Example
            int[] numbers = { 1, 2, 3, 4, 5 };

            string whileLoopResult = "";
            int index = 0;
            while (index < numbers.Length)
            {
                whileLoopResult += $"Number: {numbers[index]}\n";
                index++;
            }

            return new { ForLoopResult = forLoopResult, WhileLoopResult = whileLoopResult };
        }

        private object GetVectorManipulationResult()
        {
            // Manipulation of Arrays
            int[] array = { 1, 2, 3, 4, 5 };
            int sum = array.Sum();
            int max = array.Max();
            int min = array.Min();
            double average = array.Average();

            return new { Array = array, Sum = sum, Max = max, Min = min, Average = average };
        }

        private object GetMatrixManipulationResult()
        {
            // Manipulation of 2D Arrays
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            return new { Matrix = matrix, Rows = rows, Cols = cols };
        }

        private object GetTimeAndSpaceComplexityResult()
        {
            // Time and Space Complexity are more theoretical and may not have direct code examples here.
            // They are often analyzed using Big O notation and involve algorithm design and analysis.
            string timeComplexity = "Time complexity is a measure of the amount of time an algorithm takes to complete.";
            string spaceComplexity = "Space complexity is a measure of the amount of memory an algorithm uses.";

            return new { TimeComplexity = timeComplexity, SpaceComplexity = spaceComplexity };
        }
    }
}
