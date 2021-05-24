using System;

namespace Индекс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес");
            String inputWeight = Console.ReadLine();
            double weight = Convert.ToDouble(inputWeight);

            Console.WriteLine("Введите рост");
            String inputHeight = Console.ReadLine();
            double height = Convert.ToDouble(inputHeight) / 100;

            double index = weight / (height * height);

            Console.WriteLine("Индекс массы тела равен " + "{0:F1}", index);
            Console.ReadLine();

        }
    }
}
