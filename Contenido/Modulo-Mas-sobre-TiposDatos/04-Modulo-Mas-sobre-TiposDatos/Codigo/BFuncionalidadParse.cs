namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class BFuncionalidadParse
    {
        public void CodigoDelCurso()
        {
            // Parsear a numero
            string myQuantity = "3567";
            int quantity = int.Parse(myQuantity);
            Console.WriteLine($"Quantity: {quantity}");

            // Parsear a tipo fecha
            string dateString = "2022-11-09";
            DateTime date = DateTime.Parse(dateString);
            Console.WriteLine($"La fecha parceada es: {date}");

            // Uso del tryParse
            string numberToParse = "5";
            int storedNumber;

            var canParse = int.TryParse(numberToParse, out storedNumber);

            if(canParse)
            {
                storedNumber++;
                Console.WriteLine($"Stored Number: {storedNumber}");
            }
            else
            {
                Console.WriteLine("No se pudo parsear");
            }
        }
    }
}
