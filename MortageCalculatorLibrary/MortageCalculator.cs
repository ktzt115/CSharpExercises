namespace MortageCalculatorLibrary
{
    public class MortageCalculator
    {
        public MortageCalculator() { 
        
        }
        public double CalculateMonthlyMortagePayment(double loanAmount, double interestRate, double loanTermsInMonth)
        {
            double monthlyInterestRate = interestRate / 100 / 12;
            return Math.Round(loanAmount * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -1 * loanTermsInMonth)), 2, MidpointRounding.ToEven);
        }
    }
}