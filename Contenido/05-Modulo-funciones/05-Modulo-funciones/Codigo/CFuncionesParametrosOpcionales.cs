namespace _05_Modulo_funciones.Codigo
{
    public class CFuncionesParametrosOpcionales
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1
            // Los parametros opcionales van al final

            void ImprimirEnConsola(string mensaje, bool enMayusuclas = true)
            {
                if (enMayusuclas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            ImprimirEnConsola("Hello World", false);


        }
    }
}
