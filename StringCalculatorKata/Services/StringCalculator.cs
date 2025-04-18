using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.Services
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };

            if (numbers.StartsWith("//"))
            {
                var customDelimiter = numbers[2];
                delimiters = [customDelimiter];
                numbers = numbers[4..];
            }

            var numberList = numbers.Split(delimiters, StringSplitOptions.None)
                                     .Select(int.Parse)
                                     .Sum();
            return numberList;
        }
    }
}
