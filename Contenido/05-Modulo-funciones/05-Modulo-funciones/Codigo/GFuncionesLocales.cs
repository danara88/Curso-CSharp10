namespace _05_Modulo_funciones.Codigo
{
    public class GFuncionesLocales
    {
        public void CodigoDelCurso()
        {
            // Funciones locales:
            // Son funciones que se encuentran dentro de otras funciones.
            // Util para centralizar logica.

            // Ejemplo 1

            void SumarEImprimir()
            {
                var cantidad = 5;

                ImprimirValor(cantidad);

                cantidad++;

                ImprimirValor(cantidad);

                void ImprimirValor(int cantidad)
                {
                    Console.WriteLine("El valor es " + cantidad);
                }
            }

            SumarEImprimir();
        }
    }
}
