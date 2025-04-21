using StringCalculatorKata.Messages;
using StringCalculatorKata.Services;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1\n2,3", 6)]
        [InlineData("//;\n1;2;3", 6)]
        [InlineData("2,1001,6", 8)]
        public void Add_ShouldReturnCorrectSum_ForValidInputs(string input, int expected)
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            var result = calculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ShouldThrowException_ForNegativeNumbers()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            var ex = Assert.Throws<Exception>(() => calculator.Add("1,-2,3,-4"));

            // Assert
            var expectedMessage = string.Format(ErrorMessages.NegativeNumbersNotAllowed, "-2, -4");
            Assert.Equal(expectedMessage, ex.Message);
        }
    }
}