namespace _06_Modulo_ClasesStructsRec.Ejercicios
{
    public class User
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public DateTime BirthDate { get; set; }
    }

    public class CEsMayorDeEdad
    {
        private int _adultAge = 18;
        
        public bool isAdult(User user)
        {
            var actualDate = DateTime.Now;

            var yearDiff = actualDate.Year - user.BirthDate.Year;

            var birthDateThisYear = new DateTime(actualDate.Year, user.BirthDate.Month, user.BirthDate.Day);

            bool hasBirthDayYet = birthDateThisYear <= actualDate;

            if(!hasBirthDayYet) 
            {
                yearDiff--;
            }

            return yearDiff >= _adultAge;
        }
    }
}
