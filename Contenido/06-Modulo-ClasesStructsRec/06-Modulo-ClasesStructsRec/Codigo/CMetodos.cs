namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class CMetodos
    {
        public double speed { get; private set; } = 50;

        public double maxSpeed { get; set; } = 120;

        public void Acceletate()
        {
            Accelerate(1);
        }

        public void Stop() => speed = 0;

        // Sobrecarga:
        // Consiste en que podemos tener dos metodos con el mismo nombre
        // pero con distintos parametros.
        // Por lo menos tener distintos parametros
        public void Accelerate(double increment)
        {
            if (speed > maxSpeed)
            {
                Console.WriteLine("Max speed passed");
                return;
            }
            else if(speed + increment >maxSpeed)
            {
                increment = maxSpeed - speed;
            }

            speed += increment;
        }
    }
}
