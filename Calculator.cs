using System;

namespace Calculator
{
    internal class Calculator
    {
        /** Összeadás **/
        public double Add(double first, double second)
        {
            return first + second;
        }

        /** Kivonás **/
        public double Subtract(double first, double second)
        {
            return first - second;
        }

        /** Szorzás **/
        public double Multiply(double first, double second)
        {
            return first * second;
        }

        /** Osztás **/
        public double Divide(double first, double second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return first / second;
        }

        /** Hatványoás **/
        public double Exponentiate(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        /** Gyökvonás **/
        public double SquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(number);
        }
    }
}
