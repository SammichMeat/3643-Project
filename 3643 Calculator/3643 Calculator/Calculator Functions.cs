using System;
using System.Diagnostics;

namespace _3643_Calculator.Properties
{
    public class CalculatorEngine
    {
        private double doubleA;
        private double doubleB;
        
        public void SetDoubleA(double a)
        {
            doubleA = a;
        }
        public void SetDoubleB(double b)
        {
            doubleB = b;
        }
        public double Add()
        {
            //preq-ENGINE-3
            return doubleA + doubleB;
        }

        public double Subtract()
        {
            //preq-ENGINE-4
            return doubleA - doubleB;
        }

        public double Multiply()
        {
            //preq-ENGINE-5
            return doubleA * doubleB;
        }

        public double Divide()
        {
            //preq-ENGINE-7
            if (doubleB == 0)
            {
                throw new DivideByZeroException("Cannot Divide by Zero");
            }

            return doubleA / doubleB;
        }

        public double Equals()
        {
            //preq-ENGINE-8
            if (Math.Abs(doubleA - doubleB) <= 0.000000001)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        public double RaiseToPower()
        {
            //preq-ENGINE-9
            return Math.Pow(doubleA, doubleB);
        }

        public double Logarithm()
        {
            //preq-ENGINE-10
            if (doubleA <= 0)
            {
                throw new ArithmeticException("Value A cannot be less than or equal to Zero");
            }

            if (doubleB == 0)
            {
                throw new ArithmeticException("Value B cannot be Zero");
            }
            
            return Math.Log(doubleA, doubleB);
        }

        public double Root()
        {
            //preq-ENGINE-11
            if (doubleB == 0)
            {
                throw new ArithmeticException("Value B cannot be Zero");
            }

            return Convert.ToDouble(Math.Pow(doubleA, (1 / doubleB)));
        }

        public double Factorial()
        {
            //preq-ENGINE-12
            var f = (int)Math.Round(doubleA);
            int total = 1;
            if (f != 0)
            {
                total = f;
                for (int i = 1; i < Math.Abs(f); i++)
                {
                    total *= i;
                }
            }
            return total;
        }

        public double Sine()
        {
            //preq-ENGINE-13
            var radians = doubleA * Math.PI/180;
            return Math.Round(Math.Sin(radians),7);
        }
        
        public double Cosine()
        {
            //preq-ENGINE-14
            var radians = doubleA * Math.PI/180;
            return Math.Round(Math.Cos(radians),7);
        }
        public double Tangent()
        {
            //preq-ENGINE-15
            var radians = doubleA * Math.PI/180;
            return Math.Round(Math.Tan(radians),7);
        }

        public double Reciprocal()
        {
            if (doubleA == 0)
            {
                throw new DivideByZeroException("Cannot Divide by Zero");
            }

            return 1 / doubleA;
        }
    }
}