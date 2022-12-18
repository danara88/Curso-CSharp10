namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class QCoalescenciaNula
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1

            // Coalescencia nula: En case de tener nulo en una variable, que se evalue otro valor.
            // Coalescencia nula "??"
            int[]? numeros = new int[] { 1, 2, 3, };

            var conteo = numeros?.Length ?? 0;

            // Ejemplo 2

            numeros ??= new int[] {}; // Si numeros es nulo, asignale un arreglo vacio

            Console.WriteLine($"Es nulo ? {numeros is null}");

            Console.WriteLine($"Es un arreglo vacio ? {numeros.Length == 0}");
        }
    }
}
