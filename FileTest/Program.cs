namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directoryName = @"C:\Users\khin.thuzar.thin\Downloads";
            DirectoryInfo di = new DirectoryInfo(directoryName);
            // text files
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }

            var newFileName = $"{directoryName}\\test.txt";
            FileInfo file = new FileInfo(newFileName);
            if (file.Exists)
            {
                Console.WriteLine("File already exists!");
            }
            else
            {
                //create new file
                var fileWriter =  file.CreateText();
                using (fileWriter)
                {
                    fileWriter.WriteLine("Hi I am testing you. testing yahoeoeoeoeoe");
                    fileWriter.Close();
                }
            }

            File.Copy(newFileName, $"{directoryName}\\test-{DateTime.Now:yyyymmddhhmmss}.txt", true);
        }
    }
}