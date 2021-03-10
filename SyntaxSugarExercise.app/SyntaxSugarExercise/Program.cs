using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            
            var response = answer < 9 ? "Is less than nine" : "greater than nine";


            Console.WriteLine(response);
        }
    }
}
