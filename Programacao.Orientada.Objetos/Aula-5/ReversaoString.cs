namespace Aula_5
{
    public class ReversaoString
    {
        public string Reverter(string fraseParaReverter)
        {
            string fraseRevertida = string.Empty;

            for (int i = fraseParaReverter.Length; i > 0; i--)
            {
                fraseRevertida += fraseParaReverter[i - 1];
            }

            return fraseRevertida;
        }
    }
}
