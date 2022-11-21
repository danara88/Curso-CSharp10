namespace _05_Modulo_funciones.Codigo
{
    public class LDelegados
    {
        public void CodigoDelCurso()
        {
            // Ejemplo de delegados

            // Estas son utiles cuando tengamos funciones sencillas

            Action action; 

            Func<int> func;

            Predicate<int> predicado;

            // Que es un delegado ?
            // Un delegado es un puntero que apunta a una funcion.
            // Es una manera de guardar una referencia de una funcion en una variable.

            bool TryParse2(string valor, out int resultado)
            {
                return int.TryParse(valor, out resultado);
            }

            // No podemos poner "out"
            // Func<string, int, bool> tryParseFunc = TryParse2;

            TryParseDelegado miTryParse = TryParse2;

            int cantidad;

            if(miTryParse("2", out cantidad))
            {
                Console.WriteLine(cantidad);
            }

            void Procesar(TryParseDelegado miTryParse)
            {
                // Codigo ..
            }

        }

        delegate bool TryParseDelegado(string valor, out int resultado);
    }
}
