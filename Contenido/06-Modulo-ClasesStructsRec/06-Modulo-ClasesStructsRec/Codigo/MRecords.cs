namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public static class MRecords
    {
        /**
         * Este es un Record nominal
         * Los records nominales no te crean automaticamente una funcion Deconstruct,
         * por lo que no podemos extraer sus propiedades con una tupla.
         */
        internal record Persona
        {
            public string Nombre { get; set; }

            public string Apellido { get; set; }

        }

        /**
         * Este es un Recod struct.
         * Compila a un Struct
         * 
         */
        internal record struct PersonaStruct
        {
            public string Nombre { get; set; }

            public string Apellido { get; set; }
        }

        /*
         * Este es un record posicional.
         * Sirven para lograr inmutabilidad.
         * Por defecto es un record posicional de clase.
         */
        internal record Empresa(string Nombre, int fundacion);

        /**
         * Un record struct por defecto no es inmutable.
         * Para hacer un record struct posicional debemos poner el readonly
         */
        internal readonly record struct EmpresaStruct(string Nombre, int fundacion);

        public static void CodigoDelCurso()
        {
            // Ejmplo 1
            // Prueba de la igualdad

            var person1 = new Persona() { Nombre = "Daniel", Apellido = "Torres" };

            var person2 = new Persona() { Nombre = "Daniel", Apellido = "Torres" };

            // Se comparan los datos que contiene (Comparacion estructural)
            var sonIguales = person1 == person2; // true

            Console.WriteLine(sonIguales);

            person1 = null;

            var personRecordStruct = new PersonaStruct();

            // Ejemplo 2

            // Esto es equvaliente a una clase con dos propiedades
            // Coomo es inmutable, no podemos modificar sus propiedades.
            var empresa1 = new Empresa("Udemy", 2019);

            var (nombre, year) = empresa1;

        }
    }
}
