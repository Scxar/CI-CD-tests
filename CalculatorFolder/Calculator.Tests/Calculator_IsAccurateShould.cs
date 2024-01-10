using Xunit;
using CalculatorTest;

namespace CalculatorTester
{
    public class Calculator_IsAccurateShould
    {
        [Fact]
        public void CheckAddWorks()
        {
            Calculator calc = new();

            int expected = 7;
            int a = 5;
            int b = 2;

            int result = calc.Add(a, b);

            Assert.Equal(expected, result);
        }
    }
}