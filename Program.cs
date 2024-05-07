int fahrenheit = 90;
decimal celsius = (decimal)(fahrenheit - 32) * 5 / 9;

Console.WriteLine($"The temperature is {celsius.ToString("F1")} in Celsius.");
