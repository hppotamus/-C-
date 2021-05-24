using System;

namespace Distance_1._0
{
    class Program
    {
        static double Distance(string x1, string y1, string x2, string y2)
        {
            return Math.Sqrt(Math.Pow(Convert.ToDouble(x2) - Convert.ToDouble(x1), 2) + Math.Pow(Convert.ToDouble(y2) - Convert.ToDouble(y1), 2));
        }
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();

            string x2 = Console.ReadLine();
            string y2 = Console.ReadLine();


            Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
            Console.ReadLine();
        }
    }
}