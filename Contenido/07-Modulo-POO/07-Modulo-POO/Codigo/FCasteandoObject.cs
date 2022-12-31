namespace _07_Modulo_POO.Codigo
{
    public static class FCasteandoObject
    {
        public static void CodigoDelCurso()
        {
            AceptoCualquierParametro(new CelPhone());
            AceptoCualquierParametro(new int());
        }

        public static void AceptoCualquierParametro(object objeto)
        {
            Console.WriteLine("Inicio del metodo");

            // Este casteo explicito puede marcar error si pasamos otra cosa que no sea de tipo CelPhone
            //var celPhone = (CelPhone)objeto;

            // Es similar a lo anterior, pero si el casteo falla entonces manda nulo.
            // var celPhone = objeto as CelPhone;

            if(objeto is CelPhone celPhone)
            {
                Console.WriteLine("El objeto es un calular");
            } 
            else if (objeto is int entero)
            {
                Console.WriteLine("El objeto es un entero");
            }
            else
            {
                Console.WriteLine("El objeto no es un celular");
            }

            Console.WriteLine("Fin del metodo");
        }
    }

    public class CelPhone
    {

    }
}
