using System;
namespace _02_Modulo_Variables.Codigo
{
    public class EManejoDeFechas
    {
        DateTime actualDate = DateTime.Now;

        DateTime myBirthDay = new DateTime(2000, 11, 09, 03, 00, 00);

        DateTime tomorroDate = DateTime.Now.AddDays(1);

        public void CodigoDeLaClase()
        {
            string dateInString = tomorroDate.ToShortDateString();

            string myBirthDayString = myBirthDay.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }
    }
}

