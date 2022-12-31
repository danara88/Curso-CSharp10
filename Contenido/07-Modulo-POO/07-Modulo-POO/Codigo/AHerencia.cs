namespace _07_Modulo_POO.Codigo
{
    /**
     * 
     * En la herencia hay dos clases:
     * - Clase base.
     * - Clase derivada.
     * La clase derivada hereda funcionalidades de la clase base
     * 
     */
    public class AHerencia
    {
        public void CodigoDelCurso()
        {
            var carro = new Carro();

            carro.YearCreacion = 2010;

            carro.Marca = "Toyota";

            var camion = new Camion();

            camion.Marca = "Mercedez";

            camion.YearCreacion = 2019;

            // Uso del polimorfismo
            LeerMarca(camion);
        }

        // Uso del polimorfismo
        public void LeerMarca(Vehiculo vehiculo)
        {
            Console.WriteLine(vehiculo.Marca);
        }
    }
    
    /// <summary>
    /// Clase base
    /// </summary>
    public class Vehiculo
    {
        public string? Marca { get; set; }
        public int YearCreacion { get; set; }
    }

    /// <summary>
    /// Clase derivada
    /// </summary>
    public class Carro : Vehiculo
    {
        public void EncenderRadio()
        {
            Console.WriteLine("Encender la radio");
        }
    }

    /// <summary>
    /// Clase derivada
    /// </summary>
    public class Camion : Vehiculo
    {
    
    }
}
