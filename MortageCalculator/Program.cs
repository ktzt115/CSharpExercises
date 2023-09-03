//2-45 , 2 , MortageCalculator

Console.WriteLine("How much are you borrowing? ");
string input = Console.ReadLine(); 
double amountBorrow = double.Parse(input);
Console.WriteLine("What is your interest rate? ");
input = Console.ReadLine();
double interestRate = double.Parse(input)/100;

Console.WriteLine("How long is your loan (in years)? ");
input = Console.ReadLine();
int loanYears = int.Parse(input);

double monthlyInterestRate =  interestRate / 12;
double numberOfMonthlyPayment = loanYears * 12;
double paymentAmount = getPaymentAmount(amountBorrow, monthlyInterestRate, numberOfMonthlyPayment);
double totalPayment = paymentAmount * numberOfMonthlyPayment;
double totalInterestPaid = totalPayment - amountBorrow;

Console.WriteLine($"Your estimated payment is {paymentAmount:F2}");
Console.WriteLine($"You paid {totalPayment:C} over the life of the loan");
Console.WriteLine($"Your total interest cost for the loan was {totalInterestPaid:C}");

double getPaymentAmount(double amountBorrow, double monthlyInterestRate, double numberOfMonthlyPayment)
{

    return Math.Round(amountBorrow * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -1 * numberOfMonthlyPayment )), 2, MidpointRounding.ToEven);

}