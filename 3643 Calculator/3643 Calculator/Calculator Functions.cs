using System;

namespace _3643_Calculator.Properties
{
    public class CalculatorEngine
    {
        public double Add(double x, double y)
        {
            //preq-ENGINE-3
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            //preq-ENGINE-4
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            //preq-ENGINE-5
            return x * y;
        }

        public double Divide(double x, double y)
        {
            //preq-ENGINE-7
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }

        public double Equals(double x, double y)
        {
            //WATCH MODULE 2 DEMO (see requirements page)
            return 0d;
        }

        public double RaiseToPower(double x, double y)
        {
            //preq-ENGINE-9
            return Math.Pow(x, y);
        }

        public double Logarithm(double x, double y)
        {
            return Math.Log(x, y);
        }
    }
}