namespace _07_Modulo_POO.Codigo
{
    /**
     * Puedes utilizar sealed clases para evitar que otras clases puedan derivar de esta.
     * 
     * La ventaja de usar sealed es un incremento en la velocidad del programa.
     * 
     * Sealed tambien puede ser usada en propiedades para evitar que puedan ser sobr escritas.
     */
    public class DSealedClases
    {
        public void CodigoDelCurso()
        {

        }

        public sealed class NoPuedeSerDerivada
        {

        }

        public abstract class Computadorta
        {
            public abstract void Apagar(); // Puedes sobre escribirlo
        }

        public class MacBook : Computadorta
        {
            // Sealed: Obligo a mis otras clases derivadas a utilizar esta implementacion.
            // No podran sobrescribir el metodo.
            public sealed override void Apagar()
            {
                Console.WriteLine("La computadora se esta apagando.");
            }
        }
        
    }
}