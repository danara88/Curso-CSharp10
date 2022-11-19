namespace _03_Modulos_Decisiones_y_bucles.Codigo
{
    public class BSentenciaSwitch
    {
        public void CodigoDelCurso()
        {
            var actualYear = 2022;

            switch(actualYear) {
                case 2020:
                    Console.WriteLine("Is 2020");
                    break;
                case 2021:
                    Console.WriteLine("Is 2021");
                    break;
                case 2022:
                    Console.WriteLine("Is 2022");
                    break;
                default:
                    Console.WriteLine("Undefined year");
                    break;
            }
        }
    }
}
