namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class FDeconstructor
    {
        private class ResultadoDT
        {
            public int Value { get; set; }

            public int Duplo { get; set; }

            public int Triplo { get; set; }

            public void Deconstruct(out int value, out int duplo, out int triplo)
            {
                value = Value;
                duplo = Duplo;
                triplo = Triplo;
            }
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

            // Ejemplo 0: Sin usar desconstructor
            //var value = resultado.Value;
            //var duplo = resultado.Duplo;
            //var triplo = resultado.Triplo;

            // Ejemplo 1: Usando desconstructor (Explicito)
            //int value, duplo, triplo;
            //resultado.Deconstruct(out value, out duplo, out triplo);

            // Ejemplo 2: USando desconstructor resumido
            //resultado.Deconstruct(out var value, out var duplo, out var triplo);

            // Ejemplo 3: Sin usar Deconstruct directamente
            //(var value, var duplo, var triplo) = resultado;

            // Ejemplo 4: Los mas resumido posible
            var (value, duplo, triplo) = resultado;

            Console.WriteLine("El valor es " + value);
            Console.WriteLine("El duplo es " + duplo);
            Console.WriteLine("El triplo es " + triplo);
        }
    }
}
