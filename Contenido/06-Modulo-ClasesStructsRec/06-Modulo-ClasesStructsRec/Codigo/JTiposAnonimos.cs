namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class JTiposAnonimos
    {
        internal class Car
        {
            public string Model { get; set; }

            public int Year { get; set; }

        } 

        public void CodigoDelCurso()
        {
            // Ejemplo 1: Tipo anonimo (Clase sin nombre)
            // No se puede editar las propiedades de un tipo anonimo

            var user = new { Name = "Daniel", Age = 22 };
           
            Console.WriteLine(user.Name);

            // Ejemplo 2: Inferir nombre de propiedades

            var car = new Car() { Model = "Toyota", Year = 2007 };

            var anonimousCar = new { car.Model, car.Year };

            // Ejemplo 3: Mutacion no destructiva

            var mutedUser = user with { Age = 32 };
        }

    }
}
