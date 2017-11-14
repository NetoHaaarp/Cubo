using System;
namespace Programa
{
    class Cubo
    {
        public static void Main(String[] args)
        {
            double Profundidad = 0;
            double Alto = 0;
            double Largo = 0;
            Console.WriteLine("Area de un Cubo");
            Console.WriteLine("Profundidad");
            Profundidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Alto");
            Alto = double.Parse(Console.ReadLine());
            Console.WriteLine("Largo");
            Largo = double.Parse(Console.ReadLine());
            Alto = Profundidad * Alto * Largo;
            Console.WriteLine("Area del cubo = " + Alto);



            Console.ReadKey();
        }
    }
}