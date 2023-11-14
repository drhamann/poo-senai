namespace MinApiWithSwagger.Controllers
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }


        public string[] Calculate(int númeroAcalcular)
        {
            var listaFizzBuzz = new List<string>();
            for (int i = 1; i <= númeroAcalcular; i++)
            {
                string fizzResult = IsFizz(i);
                fizzResult = IsBuzz(i, fizzResult);
                fizzResult = IsFizzBuzz(i, fizzResult);

                listaFizzBuzz.Add(fizzResult);
            }
            return listaFizzBuzz.ToArray();

        }

        private string IsFizz(int position)
        {
            if (position % 3 == 0)
            {
                return "Fizz";
            }
            return position.ToString();
        }

        private string IsBuzz(int position, string lastResult)
        {
            return position % 5 == 0 ? "Buzz" : lastResult;
        }
        private string IsFizzBuzz(int position, string lastResult)
        {
            return position % 3 == 0 && position % 5 == 0 ?
                "FizzBuzz" : lastResult;
        }

    }
}