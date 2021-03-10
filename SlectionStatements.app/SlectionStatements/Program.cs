using System;

namespace SlectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // If-Else//


            var r = new Random();
            var favNumber = r.Next(1, 1000); 
            Console.WriteLine("Whats my favorite number between 1-10000?");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput <= favNumber)

            {
                Console.WriteLine("too low");
            }
            else if (userInput >= favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            
            Console.WriteLine($"Your favorite number is {favNumber}");

            // Switch Case //

            Console.WriteLine("What is your favorite school subject:");
            var favoriteSchoolObejct = Console.ReadLine();
            Console.WriteLine(favoriteSchoolObejct);

            switch (favoriteSchoolObejct.ToLower())
            {
                case "math":
                    Console.WriteLine("My favorite school Subject is Math");
                    break;
                case "english":
                    Console.WriteLine("My favorite school Subject is English");
                    break;
                case "physics":
                    Console.WriteLine("My favorite school Subject is Physics");
                    break;

                case "portuguese":
                    Console.WriteLine("My favorite school Subject is Portuguese");
                    break;


            }


        }
    }
}
