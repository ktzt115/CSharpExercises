//Workbook 2, 2-24 , Exercise 1

namespace FileProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var files = new List<string>() { "PayrollData1.txt", "PayrollData2.txt", "PayrollData3.txt" };

            foreach (var file in files)
            {
                Console.WriteLine($"Processing for {file} started");
                try
                {
                    var fileFullPath = @$"C:\Users\khin.thuzar.thin\Downloads\KPayRolls\{file}";
                    if (File.Exists(fileFullPath))
                    {
                        using (StreamReader reader = new StreamReader(fileFullPath))
                        {
                            while (!reader.EndOfStream)
                            {
                                try
                                {
                                    string data = reader.ReadLine();
                                    TimeCard tc = TimeCard.CreateTimeCard(data);
                                    Console.WriteLine($"GrossPay for {tc.Name}\t{tc.GetGrossPay():N2}");
                                }
                                catch (InvalidCastException castException)
                                {
                                    Console.WriteLine(castException.Message);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Some Exception happened.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exists! Please provide correct file");
                    }
                }
                catch (FileNotFoundException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Some Exception happened.");
                }
                finally
                {
                    Console.WriteLine($"Processing for {file} Complete");
                    Console.WriteLine();
                }
            }


        }
    }
}