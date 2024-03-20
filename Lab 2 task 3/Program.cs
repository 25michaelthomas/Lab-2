//  Michael Thomas
//  CPS*3330*02
//  Lab 2

using Unit1;

namespace TestRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, root;
            do
            {
                Console.Write("Enter a number: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a < 0)
                    Console.WriteLine("Please enter a positive number!");
            } while (a < 0);

            root = Unit1.Root.MyRoot(a);
        }
    }
}