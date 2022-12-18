namespace _06_Modulo_ClasesStructsRec.Codigo
{
    /**
     * Un miembro estatico son aquellas que se pueden utilizar sin necesidad de instancear
     * la clase.
     * Un miembro de la clase son aquellos miembros que si necesitan una instancea de la clase.
     * 
     * Si todos los miembros de una clase van a ser estátcos, entonces puedo hacer la clase estática.
     */
    public class Person2
    {
        public static int ConteoInstancias { get; set; }
        public Person2()
        {
            ConteoInstancias++;
        }
    }
}
