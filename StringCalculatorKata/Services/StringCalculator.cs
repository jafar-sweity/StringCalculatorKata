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

            var numberList = numbers.Split(delimiters, StringSplitOptions.None); 
            var parsedNumbers = new List<int>();

            foreach (var number in numberList)
            {
                if (int.TryParse(number, out int parsedNumber))
                {
                    if (parsedNumber <= 1000)
                    {
                        parsedNumbers.Add(parsedNumber);
                    }
                }
            }

            var negativeNumbers = parsedNumbers.Where(n => n < 0).ToList();

            if (negativeNumbers.Count !=0)
            {
                var negativeNumbersString = string.Join(", ", negativeNumbers);
                throw new Exception($"Negative numbers not allowed: {negativeNumbersString}");
            }

            return parsedNumbers.Sum();
        }
    }
}
