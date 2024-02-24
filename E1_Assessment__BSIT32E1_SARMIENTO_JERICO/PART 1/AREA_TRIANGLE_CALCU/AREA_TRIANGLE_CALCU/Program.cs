using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int tarea;
            //area = 1/2*b*h
            Console.WriteLine("Area of Triangle Calculator");

            Console.WriteLine("Enter the Base of a triangle:");
            int tbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of a triangle:");
            int theight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The formula to get the area of triangle is A = (B*H)/2");
            Console.WriteLine("The Base of Triangle is = " + tbase);
            Console.WriteLine("The Height of Triangle is = " + theight);
            tarea = (tbase * theight) / 2;
            Console.WriteLine("The Area of Triangle is = " + tarea);

        }
    }
}