namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class KClasesParciales
    {
        /**
         * 
         * Clases parciales: Sirven para unir dos clases en el mismo namespace
         * con el mismo nombre;
         * 
         */
        internal partial class Calculadora
        {
            public double Sumar()
            {
                return 2 + 2;
            }
        }

        internal partial class Calculadora
        {
            public double CalcularPI()
            {
                return Math.PI;
            }
        }

        public void CodigoDelCurso()
        {
            var calculadora = new Calculadora();

            calculadora.Sumar();

            calculadora.CalcularPI();
        }
    }
}
