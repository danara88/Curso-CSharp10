namespace _05_Modulo_funciones.Codigo
{
    public class BFuncionesConParametros
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1

            int Duplicar(int num)
            {
                return num * 2;
            }

            Duplicar(4);

            // Ejemplo 2

            int Sumar(int num1, int num2)
            {
                return num1 + num2;
            }

            Sumar(2, 2);

            // Ejemplo 3
            // Parametros nombrados

            void RepetirEnConsola(string mensaje, int veces)
            {
                for (int i = 0; i < veces; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }

            RepetirEnConsola(mensaje: "Hola Mundo", veces: 10);

            RepetirEnConsola(veces: 3, mensaje: "Hi");



        }
    }
}
