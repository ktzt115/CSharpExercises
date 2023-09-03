namespace MenuDrivenTemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                string command = Console.ReadLine();
                double temperatureInFahrenheit;
                double temperatureInCelsius;
                switch (command)
                {
                    case "CtoF":
                        Console.WriteLine("Enter a Celsius temperature");
                        command = Console.ReadLine();
                        if (double.TryParse(command, out temperatureInCelsius))
                        {
                            double multiplier = 9.0f / 5.0f;
                            temperatureInFahrenheit = (temperatureInCelsius * multiplier) + 32;
                            Console.WriteLine($"{temperatureInCelsius} degrees in Celsius is {temperatureInFahrenheit} degrees in Fahrenheit");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case "FtoC":
                        Console.WriteLine("Enter a Fahrenheit temperature:");
                        command = Console.ReadLine();
                        if (double.TryParse(command, out temperatureInFahrenheit))
                        {
                            double multiplier = 5.0f / 9.0f;
                            temperatureInCelsius = (temperatureInFahrenheit - 32) * multiplier;
                            Console.WriteLine($"{temperatureInFahrenheit} degrees in Fahrenheit is {temperatureInCelsius} degrees in Celsius");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case "Quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}