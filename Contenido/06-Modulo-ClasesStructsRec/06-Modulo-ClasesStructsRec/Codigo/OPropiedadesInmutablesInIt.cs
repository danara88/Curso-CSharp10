namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class OPropiedadesInmutablesInIt
    {
        /*
         * Clase con propiedades inmutables.
         *  Usando init.
         */
        internal class ClaseConPropiedadesInmutables {
            public int propiedad { get; init; }

            public int propiedad2 { get; init; }

        }
        public void CodigoDelCurso()
        {
            var clase = new ClaseConPropiedadesInmutables()
            {
                propiedad = 1,
                propiedad2 = 2,
            };

            // Esto no es valido ya que usamos init.
            // Las propiedades solo pueden ser definidas al inicializar la instancia de la clase
            //clase.propiedad = 1;

            //clase.propiedad2 = 3;
        }
    }
}
