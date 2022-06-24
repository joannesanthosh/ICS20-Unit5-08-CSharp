// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        var total = 0;
        var firstInteger = int.Parse(Console.ReadLine());
        var secondInteger = int.Parse(Console.ReadLine());
        var remainder = firstInteger;
        if (firstInteger < 0 || secondInteger < 0) {
        Console.WriteLine("Please enter a positive number!");
        Console.WriteLine("Enter the value of the first integer.");
        firstInteger = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the value of the second integer.");
        secondInteger = (Convert.ToInt32(Console.ReadLine()));
    }

        // process
        if (firstInteger > 0 && secondInteger > 0) {
          while (remainder >= secondInteger) {
          remainder = remainder - secondInteger;
          total++;
      } 
    }   else if ((firstInteger < 0) && (secondInteger < 0)) {
          remainder = Math.Abs(remainder);
          secondInteger = Math.Abs(secondInteger)
          ;while (remainder >= secondInteger) {
          remainder = remainder - secondInteger;
          total++;
      }
    }   else {
          remainder = Math.Abs(remainder);
          secondInteger = Math.Abs(secondInteger)
          ;while (remainder >= secondInteger) {
          remainder = remainder - secondInteger;
          total++;
      }
          total = -Math.Abs(total);
    };
          Console.WriteLine("");
          Console.WriteLine(firstInteger + " ÷ " + secondInteger + " = " + total + " The remainder is " + remainder);
          Console.WriteLine("\nDone.");
    } 
}
    