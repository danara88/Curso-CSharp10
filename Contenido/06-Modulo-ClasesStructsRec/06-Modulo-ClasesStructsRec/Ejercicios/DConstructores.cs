namespace _06_Modulo_ClasesStructsRec.Ejercicios
{
    /*
       Debajo tenemos una clase Persona, la cual tiene 3 propiedades. En esta clase debes colocar dos constructores:

       1) El primer constructor tendrá los valores de Nombre y Apellido (en ese mismo orden).

       2) El segundo constructor tendrá los valores de Nombre, Apellido y FechaNacimiento (en ese mismo orden).

       Nota: Si vas a utilizar el valor por defecto de un tipo (como DateTime)
    */
    public class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Student(string name, string surname): this(name, surname, default)
        {
        }

        public Student(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
