using System;
namespace UnitTestTraining.Math
{
    public class Calculator
    {
       

        // Factorial Method ex: Fact(4) = 1*2*3*4
        public double Factorial(int n)
        {
            if (n < 0) throw new InvalidOperationException("n should be a positive number");

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
