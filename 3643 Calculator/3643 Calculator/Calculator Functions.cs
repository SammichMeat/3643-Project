using System;

namespace _3643_Calculator.Properties
{
    public class CalculatorEngine
    {
        private double doubleA;
        private double doubleB;

        public double GetDoubleA()
        {
            return doubleA;
        }

        public double GetDoubleB()
        {
            return doubleB;
        }

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
                throw new DivideByZeroException();
            }

            return doubleA / doubleB;
        }

        public double Equals(double x, double y)
        {
            //WATCH MODULE 2 DEMO (see requirements page)
            return 0d;
        }

        public double RaiseToPower()
        {
            //preq-ENGINE-9
            return Math.Pow(doubleA, doubleB);
        }

        public double Logarithm()
        {
            return Math.Log(doubleA, doubleB);
        }
    }
}