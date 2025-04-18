using StringCalculatorKata.Services;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            var calc = new StringCalculator();
            var result = calc.Add("");
            Assert.Equal(0, result);

        }

        [Fact]
        public void Add_SingleNumber_ReturnsThatNumber()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_TwoNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_MultipleNumbersSeparatedByComma_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1,2,3,4,5");
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_NumbersWithNewLineDelimiter_ReturnsSum()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1\n2,3");
            Assert.Equal(6, result);
        }
    }
}