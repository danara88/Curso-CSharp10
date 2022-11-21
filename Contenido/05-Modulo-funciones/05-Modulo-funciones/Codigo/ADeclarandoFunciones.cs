namespace _05_Modulo_funciones.Codigo
{
    public class ADeclarandoFunciones
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Funciones simples

            string ObtenerNombre()
            {
                return "Alejandro Martinez";
            }

            var nombre = ObtenerNombre();

            // Ejemplo 2: Funcion que no retorna nada

            void ImprimirFechaYHora()
            {
                var fecha = DateTime.Now;
                var mensaje = $"Hoy es {fecha.ToString("yyyy-MM-dd hh:mm:ss")}";

                Console.WriteLine(mensaje);
            }

            ImprimirFechaYHora();
        }
    }
}
