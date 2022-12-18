namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class IPatronesDePropiedad
    {
        internal class Sport
        {
            public string? Name { get; set; }
            public string? Category { get; set; }
        }

        public void CodigoDelCurso()
        {
            // Ejemplo 1: Patron de propiedad
            var surname = "Gavilan";
            if(surname is { Length: 7})
            {
                Console.WriteLine("La longitud del string es de 7");
            }
            else if(surname is { Length: > 7})
            {
                Console.WriteLine("La longitud del string es mayor a 7");
            }

            // Ejemplo 2
            var sport = new Sport();
            if(sport is { Name: "Tenis" or "Soccer", Category: "Soft"})
            {
                Console.WriteLine("Usando patron de propiedad !");
            }

            // Ejemplo 3: Propiedades de propiedades
            if(sport is { Name.Length: > 6})
            {
                Console.WriteLine("La longitud del nombre del deporte es mayor a 6");
            }
            
        }
    }
}
