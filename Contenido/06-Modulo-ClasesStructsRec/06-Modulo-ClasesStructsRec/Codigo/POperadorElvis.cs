namespace _06_Modulo_ClasesStructsRec.Codigo
{
    /**
     * El operador Elvis nos ayuda a accesar de forma segura a una propiedad o variable en caso
     * de que este sea nula.
     */
    public class POperadorElvis
    {
        public void CodigoDelCurso()
        {
            // Puede que la variable numeros sea nula
            int[]? numeros = { 1, 2, };

            // Usando operador Elvis para evitar un error de referencia nula usando "?"
            Console.WriteLine($"La longitud es: {numeros?.Length}");
        }
    }
}
