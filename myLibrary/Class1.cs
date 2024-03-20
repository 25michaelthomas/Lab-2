//  Michael Thomas
//  CPS*3330*02
//  Lab 2

namespace myLibrary;

public class Library
{
    public static void Product()
    {
        Console.WriteLine("Enter the number of integers you will provide");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter value for 'a' and press enter: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter value for 'b' and press enter: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = a * b;

        if (num == 3){
            Console.WriteLine("Enter value for 'c' and press enter: ");
            double c = Convert.ToDouble(Console.ReadLine());

            result = a * b * c;

            Console.WriteLine($"The product of all three provided numbers is: {result}");
        }
        else
        {
            Console.WriteLine("The product of " + a + " and " + b + $" is: {result}");

        }

        
    }
}

