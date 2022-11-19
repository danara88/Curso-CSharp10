namespace _03_Modulos_Decisiones_y_bucles.Ejercicios
{
    /// <summary>
    ///  Utiliza "if-else" para determinar cuál entero es más grande, a o b.
    ///  
    ///  Debes asignar el valor más grande a la variable resultado.
    ///  
    /// </summary>
    public class ANumeroMasGrande
    {
        public int DeterminarNumeroMayor(int a, int b)
        {
            int resultado = 0;

            if (a > b)
            {
                resultado = a;
            }
            else
            {
                resultado= b;
            }

            return resultado;
        }
    }
}
