namespace _07_Modulo_POO.Codigo
{
    public class HInterfaces
	{

		internal interface IPerson
		{
			public void Speak();

			public void Walk();

			public bool IsActive { get; set; }

			public string OnlyLecture { get; }
		}

        internal interface IBird
        {
            public void Fly();
        }

        internal class Person : IPerson, IBird
        {
            public bool IsActive { get; set; }

            public string OnlyLecture => "Hello World";

            public void Fly()
            {
                Console.Write("I am flying !");
            }

            public void Speak()
            {
                Console.Write("Speaking !");
            }

            public void Walk()
            {
                Console.Write("I am walking");
            }
        }


    }
}

