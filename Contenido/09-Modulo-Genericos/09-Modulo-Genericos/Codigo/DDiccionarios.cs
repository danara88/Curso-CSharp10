namespace _09_Modulo_Genericos.Codigo
{
    /*
	 * Un diccionario es un tipo de colección
	 */
    public class DDiccionarios
	{
		public static void CodigoDelCurso()
		{
			Dictionary<string, int> myDictionary = new Dictionary<string, int>();

			myDictionary.Add("cero", 0);

            myDictionary.Add("uno", 1);

            myDictionary.Add("dos", 2); // Este solo me permite agregar valores al diccionario

			myDictionary["tres"] = 3; // Este me permite añadir y modificar valores al diccionario

			Console.Write(myDictionary["dos"]);

			if(myDictionary.ContainsKey("tres"))
			{
				Console.WriteLine(myDictionary["tres"]);
			}

			// Iterar el diccionario
			foreach (var item in myDictionary.Keys)
			{
				Console.WriteLine("Keys: " + item);
			}

            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine("Values: " + item);
            }

			// Otra forma de inicializar los valores de un diccionario
			Dictionary<string, int> myDictionary2 = new Dictionary<string, int>()
			{
				{"uno", 1 },
				{"dos", 2 },
				{"tres", 3 }
			};

			var parImparDic = new Dictionary<string, List<int>>();

			parImparDic.Add("par", new List<int>());

            parImparDic.Add("impar", new List<int>());

			for (int i = 1; i <= 10; i++)
			{
				var key = i % 2 == 0 ? "par" : "impar";

				parImparDic[key].Add(i);
			}

			foreach (var keyValue in parImparDic)
			{
				Console.WriteLine(keyValue.Key);

				foreach (var item in keyValue.Value)
				{
					Console.WriteLine($"- {item}");
				}
			}

        }
    }
}

