using System.Net.Sockets;
using System;
using _3643_Calculator.Properties;

namespace _3643_Calculator
{
    internal class Driver 
    {
        public static void Main(string[] args)
        {
            CalculatorEngine calc = new CalculatorEngine();
            Console.WriteLine(calc.Add(3,4));
            Console.WriteLine(calc.Divide(2, 0));
        }
    }
}