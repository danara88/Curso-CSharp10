namespace _05_Modulo_funciones.Codigo
{
    public class ITipoDeDatoAction
    {
        public void CodigoDelCurso()
        {
            // Action: Tipo de dato que nos permite almacenar en variables funciones VOID.

            // Ejemplo 1:

            Action imprimeMensaje;

            void ImprimirFecha()
            {
                Console.WriteLine(DateTime.Now.ToString());
            }

            void ImprimirNombre()
            {
                Console.WriteLine("Daniel");
            }

            // Guardar la referencia
            imprimeMensaje = ImprimirFecha;

            //Luego invocarla
            imprimeMensaje();

            imprimeMensaje = ImprimirNombre;

            imprimeMensaje();

            // Ejemplo 2:

            void Procesar(Action action)
            {
                Console.WriteLine("Antes de ejecutar el action");

                action();

                Console.WriteLine("Despues de ejecutar el action");
            }

            imprimeMensaje = ImprimirFecha;

            Procesar(imprimeMensaje);

            Console.WriteLine();

            Procesar(ImprimirNombre);

            // Ejemplo 3:
            // Funcion VOID que reciben parametros

            Action<int> alterarNumero;

            void Sumar(int valor)
            {
                valor++;

                Console.WriteLine("El valor + 1 es " + valor);
            }

            alterarNumero = Sumar;

            alterarNumero(5);

            // Ejemplo 4

            Action<string, int> imprimir;

            void ImprimirNVeces(string mensaje, int veces)
            {
                for (int i = 0; i < veces; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }

            imprimir = ImprimirNVeces;

            imprimir("Hello", 6);


        }

    }
}
