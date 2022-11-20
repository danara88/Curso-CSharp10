namespace _04_Modulo_Mas_sobre_TiposDatos.Ejercicios
{
    public class ANumeroMayor
    {
        public int? DeterminarElNumeroMayor(int[] numeros)
        {
            int? resultado = 0;

            if (numeros.Length == 0)
            {
                resultado = null;
            } 
            else
            {
                int mayor = numeros[0];
                
                for(int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                    }
                }

                resultado = mayor;
            }

            return resultado;
        }
    }
}
