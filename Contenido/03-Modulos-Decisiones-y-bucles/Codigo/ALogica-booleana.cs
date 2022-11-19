namespace _03_Modulos_Decisiones_y_bucles.Codigo
{
    public class ALogica_booleana
    {
        public void CodigoDelCurso()
        {
            var quantity1 = 200;
            var quantity2 = 300;
            bool result = quantity1 == quantity2;

            var myName = "Daniel";

            // Buena practica en lugar de usar ==
            bool isNameNull = myName is null;
            bool isNameNotNull = myName is not null;
        }
    }
}

