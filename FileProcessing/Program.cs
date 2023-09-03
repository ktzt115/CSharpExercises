//Workbook 2, 2-24 , Exercise 1

namespace FileProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileName = "PayrollData3.txt";
                var fileFullPath = @$"C:\Users\khin.thuzar.thin\Downloads\KPayRolls\{fileName}";
                if (File.Exists(fileFullPath))
                {
                    using (StreamReader reader = new StreamReader(fileFullPath))
                    {
                        while (!reader.EndOfStream)
                        {
                            var data = reader.ReadLine();
                            TimeCard tc = TimeCard.CreateTimeCard(data);
                            Console.WriteLine($"GrossPay for {tc.Name} : {tc.GetGrossPay():N2}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("File Does not exists");
                }
            }
            catch(InvalidCastException castException)
            {
                Console.WriteLine(castException.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File does not exists! Please provide correct file");
            }
            catch (Exception e)
            {
                Console.WriteLine("Some Exception happened.");
            }
            finally
            {
                Console.WriteLine("File Processing Complete");
            }
            
        }
    }
}