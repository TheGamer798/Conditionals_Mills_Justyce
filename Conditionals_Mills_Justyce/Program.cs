using System;

namespace Conditionals_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a whole number");
            int wholeNum = Convert.ToInt32(Console.ReadLine());
            if (wholeNum >= 0)
            {
                Console.WriteLine($"{wholeNum} is an positive number");
            }
            else
            {
                Console.WriteLine($"{wholeNum} is an negative number");
            }

            if (wholeNum % 2 == 0)
            {
                Console.WriteLine($"{wholeNum} is an even number");
            }
            else
            {
                Console.WriteLine($"{wholeNum} is an odd number");
            }

            int num1 = 798;
            int num2 = 231;
            int firstMax = Math.Max(wholeNum, num1);
            int max = Math.Max(firstMax, num2);
            Console.WriteLine($"The max out of {wholeNum}, {num1}, and {num2} is {max}");

            Console.WriteLine("enter a grade (A, B, C, D, F)");
            char grade = Console.ReadKey().KeyChar;

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nsuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nvery good");
                    break;
                case 'C':
                    Console.WriteLine("\naverage");
                    break;
                case 'D':
                    Console.WriteLine("\nbelow average");
                    break;
                case 'F':
                    Console.WriteLine("\nfail");
                    break;
                default:
                    Console.WriteLine("\nnot a valid grade");
                    break;
            }


        }
    }
}
