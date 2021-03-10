using System;

namespace IterationStatementsLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter();
            Console.WriteLine();
            Console.ReadLine();
            CountThree();
            Console.WriteLine();
            Console.ReadLine();
            bool areEqual = EqualOrNot(userNumber1, userNumber2);
            int num1 = userNumber1();
            int num2 = UserNumber2();

            Console.WriteLine($"{userNumber1} is = to {userNumber2} : {areEqual}");

            //Write a method that will print to the console all numbers 1000 through -1000.

            //Write a method to accept two integers as parameters and check whether they are equal or not.
            //Write a method to check whether a given number is even or odd.
            //Write a method to check whether a given number is positive or negative.
            //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()...
            //or the safer TryParse() for an extra challenge!!

            private static void Counter()

            {
                for (int i = 1000; i >= -1000; i++)
                {
                    Console.WriteLine(i);


                }
            }

            static void int userNumber1()
            {
                Console.WriteLine();


                int num1 = int.Parse(Console.ReadLine());
                return num1;


            }

            private static int UserNumber2()
            {
                Console.WriteLine();
                int num2 = int.Parse(Console.ReadLine());

                return num2;
            }

            private static bool EqualOrNot(int x, int y)
            {
                return num1 = num2;

            }

            //Write a method that will print to the console numbers 3 through 999 by 3 each time.

            private static void CountThree()
            {
                for (int i = 3; i >= 999; i += 3)
                {
                    Console.WriteLine(i);
                }



















            }

        }
    }
