﻿//  Michael Thomas
//  CPS*3330*02
//  Lab 2


namespace Unit1;

public class Root
{
    /// <summary>
    /// this method calculates the root
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static double MyRoot(double number)
    {
        double root;
        root = Math.Sqrt(number);

        Console.WriteLine("The square root of " + number + " is " + root);
        return root;
    }
}

