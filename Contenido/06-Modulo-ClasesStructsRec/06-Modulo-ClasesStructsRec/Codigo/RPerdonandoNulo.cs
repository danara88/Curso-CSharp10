using _06_Modulo_ClasesStructsRec.Ejercicios;

namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class RPerdonandoNulo
    {
        internal class UserNulo
        {
            // Perdonando nulo usando "null!"
            // No abusar.
            public string Name { get; set; } = null!;
        }

        public void Procesar(User u)
        {
            if(u is null)
            {
                // Usando nameof
                throw new ArgumentNullException(nameof(u));

                // Lo de arriba es lo mismo que esto:
                throw new ArgumentNullException("u");
            }
        }
        public void CodigoDelCurso() {

            // Perdonando el nulo
            Procesar(null!);
        }
    }
}
