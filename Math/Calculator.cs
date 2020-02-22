using System;
namespace Math
{
    public class Calculator
    {

        // Factorial Method ex: Fact(4) = 1*2*3*4
        public double Factorial(int n)
        {
            double result = 1;
            for (int i=1; i<n; i++) {
                result *= i;
            }

            return result;
        }
    }
}
