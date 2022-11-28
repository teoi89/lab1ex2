using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura */

            Console.WriteLine("This program will calculate arithmetic mean of three numbers");
            Console.WriteLine("Introduce your first number:");

            double firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce your second number:");

            double secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce your third number:");

            double thirdNumber = int.Parse(Console.ReadLine());

            double arithmeticMean = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine("Arithmetic mean of the three numbers is: " + arithmeticMean);
        }
    }
}
