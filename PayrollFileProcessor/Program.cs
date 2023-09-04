//7-29 , Exercise 1

namespace PayrollFileProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the payroll file name : ");
            string fileNameInput = Console.ReadLine();
            
            string directory = @"C:\Users\khin.thuzar.thin\Downloads\Payrolls\";
            string rawFileInput = $@"{directory}{fileNameInput}.txt";

            double grossPaySum = 0;
            StreamWriter reportLogWriter = null;
            try
            {

                using (StreamReader reader = new StreamReader(rawFileInput))
                {
                    while (reader.EndOfStream != true)
                    {
                        var data = reader.ReadLine().Split(',');

                        string id = data[0];
                        string name = data[1];
                        double payrate = double.Parse(data[2]);
                        double hour = double.Parse(data[3]);
                        double grossPay = hour > 40 ? hour * payrate * 1.5 :  hour * payrate;
                        grossPaySum += grossPay;
                        var toWrite = $"Total Gross Pay for {name} is {grossPay}";
                        Console.WriteLine(toWrite);
                    }
                }

                reportLogWriter = new StreamWriter($@"{directory}PayrollFileProcessor.log", true);
                var now = DateTime.Now;
                reportLogWriter.WriteLine($"Processing file: {fileNameInput}.txt on {now:dd-MM-yyyy} at {now:hh:mm:ss} {now:tt}");
                reportLogWriter.WriteLine($"Gross pay totals were {grossPaySum:C}");
                reportLogWriter.WriteLine("----------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening file: {ex.Message}");
            }
            finally
            {
                if(reportLogWriter != null)
                {
                    reportLogWriter.Close();
                }
            }
        }
    }
}