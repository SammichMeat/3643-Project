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
            calc.SetDoubleA(10);
            calc.SetDoubleB(0);
            Console.WriteLine(calc.Divide());
        }
    }
}