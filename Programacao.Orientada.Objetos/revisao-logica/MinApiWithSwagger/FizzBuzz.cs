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
                listaFizzBuzz.Add(i.ToString());
            }
            return listaFizzBuzz.ToArray();

        }
    }
}