using System;

namespace Methods_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            var Name = Console.ReadLine();
            Console.WriteLine("Whats your favorite color?");
            string Color = Console.ReadLine();
            Console.WriteLine("What your favorite animal?");
            string Animal = Console.ReadLine();

            Console.WriteLine($"Hi my name is {Name}, my favorite color is {Color}, and my favorite animal is {Animal}");
        }
    }
}
