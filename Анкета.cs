using System;

namespace Анкета
{
    class Program
    {
               
        static void Main()
        {
            Console.WriteLine("Введите имя.");
            String name = Console.ReadLine();
                        
            Console.WriteLine("Введите фамилию.");
            String surname = Console.ReadLine();
            
            Console.WriteLine("Введите возраст.");
            String age = Console.ReadLine();
            
            Console.WriteLine("Введите рост.");
            String height = Console.ReadLine();
            
            Console.WriteLine("Введите вес.");
            String weight = Console.ReadLine();
            
            Console.WriteLine(name + " " + surname + ", " + "возраст: " + age + ", " + "рост: " + height + ", " + "вес: " + weight +".");
            Console.WriteLine("{0} {1}, возраст: {2}, рост: {3}, вес: {4}.", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname}, возраст: {age}, рост: {height}, вес: {weight}.");
            Console.ReadLine();
        }
    }
}
