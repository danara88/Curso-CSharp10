namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class EClasesComoValoresSalida
    {
        private class ResultadoDT
        {
            public int Value { get; set; }

            public int Duplo { get; set; }

            public int Triplo { get; set; }
        }

        private ResultadoDT CalcularDuploTriplo(int value)
        {
            return new ResultadoDT 
            { 
                Value = value, 
                Duplo = value * 2, 
                Triplo = value * 3 
            };
        }

        public void CodigoDelCurso()
        {
            var resultado = CalcularDuploTriplo(5);

            Console.WriteLine("El valor es " + resultado.Value);
            Console.WriteLine("El duplo es " + resultado.Duplo);
            Console.WriteLine("El triplo es " + resultado.Triplo);
        }

    }
}
