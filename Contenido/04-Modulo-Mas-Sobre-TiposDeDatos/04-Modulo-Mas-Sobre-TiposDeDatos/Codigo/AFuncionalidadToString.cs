namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class AFuncionalidadToString
    {
        public void CodigoDelCurso()
        {
            int intQuantity = 250;
            string stringQuantity = intQuantity.ToString();

            Console.WriteLine($"Quantity string: {stringQuantity}");

            string myDate = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine($"DateTime in string: {myDate}");
        }
    }
}
