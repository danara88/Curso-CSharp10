namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class AClasesCampos
    {

        // Internal: Significa que la clase solo puede ser accesada en el proyecto y no a fuera.
        internal class Book
        {
            internal int id;

            internal string name;

            internal bool active;
        }

        public void CodigoDelCurso()
        {
            // Ejemplo 1: Creando la instancia de la clase Book

            var harryPotterBook = new Book();

            harryPotterBook.id = 1;

            harryPotterBook.name = "Harry Potter Saga";

            harryPotterBook.active = true;

            // Ejemplo 2: Pasando una clase como referencia

            // Una instancea de clase al ser de tipo de referencia, son mutables

            void ModififyBook(Book book)
            {
                book.name = "Modified book";

                book.active = false;
            }

            Console.WriteLine("Antes de la modificacion: ");

            Console.WriteLine(harryPotterBook.name);

            ModififyBook(harryPotterBook);

            Console.WriteLine("Despues de la modificacion: ");

            Console.WriteLine(harryPotterBook.name);
        }
    }
}
