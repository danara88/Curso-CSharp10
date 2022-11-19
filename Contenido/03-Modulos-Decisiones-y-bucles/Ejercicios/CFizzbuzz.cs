namespace _03_Modulos_Decisiones_y_bucles.Ejercicios
{
    /// <summary>
    ///  Escribir un programa que muestre en pantalla los números del 1 hasta n, 
    ///  sustituyendo los múltiplos de 3 por la palabra “fizz”, los múltiplos de 5 por “buzz” 
    ///  y los múltiplos de ambos, es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.
    /// </summary>
    public class CFizzbuzz
    {
        public static void Realizar(int n)
        {
            const string FIZZ = "fizz";
            const string BUZZ = "buzz";
            const string FIZZ_BUZZ = "fizzbuzz";

            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(FIZZ);
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(BUZZ);
                    continue;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(FIZZ_BUZZ);
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
