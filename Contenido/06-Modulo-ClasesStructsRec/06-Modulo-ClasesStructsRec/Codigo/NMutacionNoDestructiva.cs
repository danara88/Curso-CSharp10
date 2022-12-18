namespace _06_Modulo_ClasesStructsRec.Codigo
{
    /*
     * Que es la mutación no destructiva?
     * 
     * Clonar records y mutar algunas de las propiedades del nuevo record
     * 
     */
    public class NMutacionNoDestructiva
    {
        internal record Empresa(string Nombre, int fundacion);

        public void CodigoDelCurso()
        {
            var empresa1 = new Empresa("Udemy", 2010);
            
            // Con esto clonamos de una manera nos destructiva la empres 1
            var empresa2 = empresa1 with { fundacion = 2016 };
        }
    }
}
