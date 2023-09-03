//excises 2-45 , 1 
double multiplier = 5.0f / 9.0f;

Console.WriteLine("Enter the temperature in Fahrenheit - ");
string input = Console.ReadLine();
double temperatureInFahrenheit = double.Parse(input);

Console.WriteLine($"Temperature In Fahrenheit is {temperatureInFahrenheit:F1}\u00B0F");
double temperatureInCelsius = (temperatureInFahrenheit - 32) * multiplier;
Console.WriteLine($"Temperature In Celsius is {temperatureInCelsius:F1}\u00B0C");