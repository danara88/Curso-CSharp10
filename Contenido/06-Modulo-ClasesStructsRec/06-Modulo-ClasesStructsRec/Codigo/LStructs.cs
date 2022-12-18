namespace _06_Modulo_ClasesStructsRec.Codigo
{
    /**
     * 
     * Los structs son igual a las clases pero las clases son de tipo de referencia.
     * Por temas de rendimiento podemos usar Structs los cuales son de tipo de valor.
     * 
     */
    public class LStructs
    {
        internal struct Punto
        {
            public Punto(int x, int y)
            {
                X = x; 
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public double Diferencia(int x, int y) => x - y;
        }
        public void CodigoDelCurso()
        {
            // Importante diferencia: Todos los structs tiene un constructor sin parametros.

            var punto = new Punto(); // Por lo que esto es valido

            Console.WriteLine($"La diferencia entre los puntos es {punto.Diferencia(4,2)}");
        }
    }
}
