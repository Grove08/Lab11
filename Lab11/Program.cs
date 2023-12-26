using System;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            
            LinearEquation linearEquation = new LinearEquation(k, b);
            Console.WriteLine(linearEquation.Root());
            Console.ReadKey();
        }
    }
}
