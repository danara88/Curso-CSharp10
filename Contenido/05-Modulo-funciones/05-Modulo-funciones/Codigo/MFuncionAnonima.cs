namespace _05_Modulo_funciones.Codigo
{
    public class MFuncionAnonima
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Una simple funcion anonima

            // Utiles cuando no queremos ponerle un nombre a la funcion

            Action imprimirMensaje = () =>
            {
                Console.WriteLine(DateTime.Now.ToString());
            };

            imprimirMensaje();

            // Ejemplo 2

            void Procesar(Action accion)
            {
                Console.WriteLine("Antes de ejecutar la accion");

                accion();

                Console.WriteLine("Despues de ejecutar la accion");
            }

            Procesar(() =>
            {
                Console.WriteLine(DateTime.Now.ToString());
            });

            // Ejemplo 3
            // Recibe un parametro y va a retornar un valor

            Func<int, int> duplicar = (int valor) => valor * 2;

            Func<int, int> duplicar2 = valor => valor * 2;

            var duplicar3 = (int valor) => valor * 2;

            // Ejemplo 4
            // Recibe dos parametros y retorna un valor

            Func<bool, string, int> ejemplo = (bool1, string1) =>
            {
                return 42;
            };

            ejemplo(true, "hello");

            // Si uso var, tengo que ser explicito en el tipo de dato

            var ejemploV2 = (bool bool1, string string1) =>
            {
                return 23;
            };
        }
    }
}
