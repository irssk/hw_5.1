using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Error: division by zero is not possible.");
            }
            else
            {
                double result = dividend / divisor;
                Console.WriteLine($"Result: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a numeric value.");
        }
    }
}
