using System;

namespace TrianguloPOOparcial.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Triangulo(12, 14, 15);
            var t2 = new Triangulo(10, 6, 6);
            var t3 =new Triangulo(4, 5, 10);
            var t4 = new Triangulo(5, 10, 11);
            MostrarAnalisis(t1);
            MostrarAnalisis(t2);
            MostrarAnalisis(t3);
            MostrarAnalisis(t4);
            
            
        }

        private static void MostrarAnalisis(Triangulo t)
        {
            if (t.EsTriangulo())
            {
                Console.WriteLine("El perimetro es de "+t.GetPerimetro());
                Console.WriteLine("La superficie es de "+t.GetSuperficie());
                Console.WriteLine("Es un triángulo de tipo "+t.GetTipoTriangulo());
            }
            else
            {
                Console.WriteLine("No es un triángulo ");
            }

            Console.WriteLine("-----------------");
        }
    }
}
