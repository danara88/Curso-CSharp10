namespace _03_Modulos_Decisiones_y_bucles.Codigo
{
    public class CSwitchCorto
    {
        public void CodigoDelCurso()
        {
            var myNumber = 2;

            string swicthResult = myNumber switch
            {
                0 => "Es un cero",
                1 => "Es un uno",
                2 => "Es un dos",
                _=> "Otro numero"
            };

            Console.WriteLine(swicthResult);
        }
    }
}
