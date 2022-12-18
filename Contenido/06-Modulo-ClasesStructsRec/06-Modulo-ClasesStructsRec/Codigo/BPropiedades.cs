namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class BPropiedades
    {
        private string _name;

        private int _year;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Usar la forma corta para no hacer modificaciaones
        public string month { get; set; }

        public int velocidad { get; } = 100;

        public int velocidad2 => 100; // Otra forma de obtener por get 

        public int aceleracion { get; private set; } = 40;

    }
}
