//2-45 , 2 , MortageCalculator
//3-23 , 1 & 2 , add improvement

while (true)
{

    Console.WriteLine("How much are you borrowing? ");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double amountBorrow))
    {
        Console.WriteLine("What is your interest rate? ");
        input = Console.ReadLine();

        if (double.TryParse(input, out double interestRate))
        {
            interestRate = interestRate / 100;
            
            Console.WriteLine("How long is your loan (in years)? ");
            input = Console.ReadLine();
            if(int.TryParse(input, out int loanYears))
            {
                double monthlyInterestRate = interestRate / 12;
                double numberOfMonthlyPayment = loanYears * 12;
                double paymentAmount = getPaymentAmount(amountBorrow, monthlyInterestRate, numberOfMonthlyPayment);
                double totalPayment = paymentAmount * numberOfMonthlyPayment;
                double totalInterestPaid = totalPayment - amountBorrow;

                Console.WriteLine($"Your estimated payment is {paymentAmount:F2}");
                Console.WriteLine($"You paid {totalPayment:C} over the life of the loan");
                Console.WriteLine($"Your total interest cost for the loan was {totalInterestPaid:C}");
            }
            else
            {
                Console.WriteLine("ERROR: bad input");
            }
        }
        else
        {
            Console.WriteLine("ERROR: bad input");
        }
        
        
    }
    else
    {
        Console.WriteLine("ERROR: bad input");
    }

    Console.WriteLine("Do you want to get information for another loan (Y/N)?");
    input = Console.ReadLine();
    if(!input.ToLower().Equals("y"))
    {
        break;
    }
}





double getPaymentAmount(double amountBorrow, double monthlyInterestRate, double numberOfMonthlyPayment)
{

    return Math.Round(amountBorrow * monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -1 * numberOfMonthlyPayment )), 2, MidpointRounding.ToEven);

}