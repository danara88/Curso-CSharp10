namespace _06_Modulo_ClasesStructsRec.Codigo
{
    public class Car
    {
        private string _carModel;

        /// <summary>
        /// Constructor: Tiene la finalidad de preparar la instancea de una clase para ser utilizada.
        /// </summary>
        public Car() : this("modelo por defecto") // Podemos llamar un constructor desde otro constructor.
        {
            Console.WriteLine("Inicializando el constructor");
        }

        /// <summary>
        /// Podemos tener varios constructores usando la sobrecarga de metodos, diferenciandola por los parametros.
        /// </summary>
        /// <param name="carModel"></param>
        public Car(string carModel)
        {
            _carModel = carModel;
        }

        public string CarModel { 
            get { return _carModel.ToUpper(); } 
            set { _carModel = value; }
        }

    }
}
