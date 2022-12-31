namespace _07_Modulo_POO.Codigo
{
    /**
     * 
     * Metodos virtuales: Nos permite modificar metodos de la clase base para sus
     * respectivas clases derivadas.
     * Util cuando las clases derivadas necesitan el metodo de la clase base pero con distinta
     * funcionalidad. (Funcionalidad personalizada)
     * 
     * Virtual: Sobreescribe un metodo.
     * 
     */
    public static class BMetodosVirtual
    {
        public static void CodigoDelCurso()
        {
            var car = new Car();

            var bike = new Bike();

            Console.WriteLine("--");
            Console.WriteLine("Car");
            car.InReverse();
            Console.WriteLine("--");

            Console.WriteLine("Bike");
            bike.InReverse();
            Console.WriteLine("--");
        }
    }

    public class Vehicle
    {
        public int Velocity { get; set; }

        public int Weight { get; set; }

        public string? Name { get; set; }

        /// <summary>
        /// Podemos sobreescribir este metodo en nuestras clases derivadas
        /// </summary>
        public virtual void InReverse()
        {
            Console.WriteLine("In reverse default");
        }
    }

    public class Car : Vehicle
    {
        public override void InReverse()
        {
            base.InReverse();
            Console.WriteLine("Turn on back lights");
        }
    }

    public class Bike : Vehicle
    {

    }

 
}
