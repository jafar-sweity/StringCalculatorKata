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
    }
}