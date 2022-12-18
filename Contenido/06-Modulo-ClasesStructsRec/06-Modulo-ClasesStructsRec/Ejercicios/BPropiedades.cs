namespace _06_Modulo_ClasesStructsRec.Ejercicios
{
    public class Person
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string CompleteName => $"{ Name } { Surname }";
    }

    public class ExerciseProperties
    {
        public Person GetPerson(string Name, string Surname, DateTime BirthDate)
        {
            return new Person()
            {
                Name = Name,

                Surname = Surname,

                BirthDate = BirthDate
            };
        }
    }
}
