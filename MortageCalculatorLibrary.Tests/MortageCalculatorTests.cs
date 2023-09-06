namespace MortageCalculatorLibrary.Tests
{
    [TestClass]
    public class MortageCalculatorTests
    {
        private MortageCalculator _calculator;

        public MortageCalculatorTests()
        {
            _calculator = new MortageCalculator();
        }

        [TestMethod]
        public void CalculateMonthlyMortgagePayment_WithValidInputs_ReturnsCorrectPayment()
        {
            // Arrange
            double loanAmount = 53000.00;
            double interestRate = 7.625;
            double loanTermsInMonth = (15 * 12);

            // Act
            double monthlyPayment = _calculator.CalculateMonthlyMortagePayment(loanAmount, interestRate, loanTermsInMonth);

            // Assert
            Assert.AreEqual(495.09, monthlyPayment);
        }

        [DataTestMethod]
        [DataRow(50000, 3, 60, 898.43)]
        [DataRow(200000, 5, 120, 2121.31)]
        public void CalculateMonthlyMortgagePayment_MoreTests(double loanAmount, double interestRate, double loanTermsInMonth, double expectedMonthlyPayment)
        {
            // Act
            double monthlyPayment = _calculator.CalculateMonthlyMortagePayment(loanAmount, interestRate, loanTermsInMonth);

            // Assert
            Assert.AreEqual(expectedMonthlyPayment, monthlyPayment);
        }
    }
}