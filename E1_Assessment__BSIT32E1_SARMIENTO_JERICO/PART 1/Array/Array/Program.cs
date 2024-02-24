using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter a formula to generate values for the array (e.g., n^2):");
            string formula = Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                int n = i + 1;
                numbers[i] = EvaluateFormula(formula, n);
            }

            Console.WriteLine("Values in the array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("The highest value in the array is: " + max);
        }

        static int EvaluateFormula(string formula, int n)
        {
            int result = 0;
            switch (formula)
            {
                case "n^2":
                    result = n * n;
                    break;
                default:
                    Console.WriteLine("Unsupported formula. Using default (n^2).");
                    result = n * n;
                    break;
            }
            return result;
        }
    }
}

