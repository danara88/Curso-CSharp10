namespace _07_Modulo_POO.Codigo
{
    /**
     * Si la clase base tiene un constructor, las clases derivadas deben utilizarlos.
     */
    public class EContructorClaseBase
    {
        public void CodigoDelCurso()
        {
            var product = new Headphones("Skull Candy");
            product.ToString();
        }

        /// <summary>
        /// Clase base
        /// </summary>
        public abstract class Product
        {
            public string Name { get; set; }

            public Product(string name)
            {
                Name = name;
            }
        }

        /// <summary>
        /// Clase derivada
        /// </summary>
        public class Headphones : Product
        {
            // Obligatorio pasar el name en el constructor
            public Headphones(string name) : base(name)
            {
            }
        }


    }
}
