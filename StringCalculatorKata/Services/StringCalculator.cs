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
            {
                return 0;
            }

            var split = numbers.Split(',');

            if (split.Length == 1)
                return int.Parse(split[0]);

            return int.Parse(split[0])+ int.Parse(split[1]);
        }
    }
}
