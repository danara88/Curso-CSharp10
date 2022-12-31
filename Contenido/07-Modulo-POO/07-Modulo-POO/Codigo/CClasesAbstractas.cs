namespace _07_Modulo_POO.Codigo
{
    /**
     * 
     * Las clases abstractas no pueden instancearse.
     * 
     */
    public class CClasesAbstractas
    {
        public void CodigoDelCurso()
        {
            // NO se puede instancear una clase abstracta
            // var animal = new Animal();

            // Puedo instancear clases derivadas
            var dog = new Dog();

            dog.Name = "Guffy";

            dog.Category = "Mamifer";
        }
    }

    public abstract class Animal
    {
        public string? Name { get; set; }

        public string? Category { get; set; }

        // Como está marcada como abstracta, todas las clases derivadas deben de implementarlo
        public abstract void Walk();
    }

    public class Dog : Animal
    {
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
