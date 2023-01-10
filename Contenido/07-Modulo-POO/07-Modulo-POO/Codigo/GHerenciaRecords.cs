namespace _07_Modulo_POO.Codigo
{
    /**
	 * 
	 * Un record solo puede heredar de otro record
	 * 
	 */
    public static class GHerenciaRecords
	{
		public static void  CodigoDelCurso()
		{
			var teacher = new Teacher();

			teacher.Name = "Julian";
		}
	}

	/// <summary>
	/// Ejemplo 1: Usando records nominales
	/// </summary>
	public record Person
	{
		public string? Name { get; set; }

		public string? Surname { get; set; }
	}

	public record Teacher : Person
	{
		public string[]? Courses { get; set; }
	}

	/// <summary>
	/// Los recors posicionales al compilarse crean un constructor
	/// </summary>
	/// <param name="Name"></param>
	/// <param name="Surname"></param>
	public record PositionPerson(string Name, string Surname);

	public record TeacherV2 : PositionPerson
	{
		public TeacherV2(string Name, string Surname) : base(Name, Surname)
		{

		}
	}

	public record PositionalTeacher(string Name, string Surname, string[] Courses) : PositionPerson(Name, Surname);

}

