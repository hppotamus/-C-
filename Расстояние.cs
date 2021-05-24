using System;

namespace Расстояние
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputx1 = Console.ReadLine();
            double x1 = Convert.ToDouble(inputx1);

            string inputy1 = Console.ReadLine();
            double y1 = Convert.ToDouble(inputy1);

            string inputx2 = Console.ReadLine();
            double x2 = Convert.ToDouble(inputx2);

            string inputy2 = Console.ReadLine();
            double y2 = Convert.ToDouble(inputy2);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:F2}", distance);
            Console.ReadLine();

        }
    }     
}
