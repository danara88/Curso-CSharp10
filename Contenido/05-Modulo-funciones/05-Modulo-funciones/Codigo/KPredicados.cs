namespace _05_Modulo_funciones.Codigo
{
    public class KPredicados
    {
        public void CodigoDelCurso()
        {
            // Predicado: En C# un predicado es un Fuc que siempre retornar un boolean.

            // Ejemplo 1

            bool EsPar(int num)
            {
                return num % 2 == 0;
            }

            Predicate<int> predicado = EsPar;

            var numero = 4;

            Console.WriteLine($"Es {numero} par ? {predicado(numero)}");
        }
    }
}
