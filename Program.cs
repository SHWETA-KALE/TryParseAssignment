using System;

namespace TryParseAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l, b;

            Console.WriteLine("Enter the length of a rectangle: ");
            while (!double.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for length: ");
            }

            Console.WriteLine("Enter the breadth of a rectangle: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for breadth: ");
            }

            Console.WriteLine("Area of a rectangle is: " + RecArea(l, b));
        }

        static double RecArea(double length, double breadth)
        {
            return length * breadth;
        }
    }
}
