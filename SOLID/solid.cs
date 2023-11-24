namespace SOLID
{
    public class SOLID
    {
        public void SampleExtensionOCP()
        {
            DateTime objetoParaTratarHora = DateTime.Now;

            objetoParaTratarHora.AdicionarUmMinuto();
        }
    }

    public static class DateTimeExtension
    {
        public static void AdicionarUmMinuto(this DateTime dateTime)
        {
            dateTime.AddMinutes(1);
        }
    }

}
