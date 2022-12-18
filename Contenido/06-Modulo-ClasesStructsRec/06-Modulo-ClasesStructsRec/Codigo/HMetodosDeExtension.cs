namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public static class HMetodosDeExtension
    {
        public static void CodigoDelCurso()
        {

            var mensaje = "Hola mundo";

            // Ahora pudo usar la clase string con el metodo que añadí.
            // Es como inyectar el metodo a la clase string.
            // Puedo mandar parametros.
            var cantidadPalabras = mensaje.ContarPalabras(valorPorDefecto: -2);

            // Otra manera de hacerlo.
            // Es por ello que usamos metodos de extenasión
            var cantidadPalabrasV2 = ExtensionString.ContarPalabras(mensaje);

            Console.WriteLine(cantidadPalabras);
        }
    }


    /**
     * Los metodos de extencion son como para añadirles métodos a una clase
     * desde afuera.
     * 
     */
    public static class ExtensionString
    {
        public static int ContarPalabras(this string? s, int valorPorDefecto = -1)
        {
            if (string.IsNullOrEmpty(s)) return valorPorDefecto;

            // Environment.NewLine:
            // Cuando tenemos dos lineas separadas con enter, los
            // va a contar como palarbras distintas.
            var separadores = new string[] { " ", Environment.NewLine };

            var palabras = s.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            return  palabras.Length;
        }
    }

}
