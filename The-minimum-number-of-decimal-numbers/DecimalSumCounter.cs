using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_minimum_number_of_decimal_numbers
{
    internal class DecimalSumCounter
    {
        public static int CalculationOfCountDecimalCombinations(string n)
        {
            int maxDigit = 0;

            foreach (char c in n)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString()); 

                    if (digit > maxDigit)
                    {
                        maxDigit = digit;
                    }
                }
            }

            return maxDigit;
        }
    }
}
