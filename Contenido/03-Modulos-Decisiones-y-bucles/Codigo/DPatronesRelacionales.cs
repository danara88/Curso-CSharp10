namespace _03_Modulos_Decisiones_y_bucles.Codigo
{
    public class DPatronesRelacionales
    {
        public void CodigoDelCurso()
        {
            var bodyAge = 32;

            string message = bodyAge switch
            {
                < 12 => "Eres un ninio",
                >= 12 and <= 17 =>  "Estas en la pubertad",
                >= 18 => "Eres un adulto",
            };

            Console.WriteLine(message);

            var date = DateTime.Now;
            var month = date.Month;

            var estacion = month switch
            {
                1 or 2 or 3 => "Primavera",
                4 or 5 or 6 => "Verano",
                7 or 8 or 9 => "Otonio",
                10 or 11 or 12 => "Invierno",
                _ => throw new ApplicationException("Mes no especificado")
            };

            Console.WriteLine(estacion);
        }
    }
}
