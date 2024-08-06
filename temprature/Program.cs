using System;

class Program
{
    static void Main()
    {
        // First conversion and output
        int fahrenheit1 = 94;
        decimal temperature1 = ((fahrenheit1 - 32) * 5m / 9);
        Console.WriteLine("The temperature is " + temperature1 + " degree Celsius");

        // Second conversion and output with rounding
        int fahrenheit2 = 94;
        decimal temperature2 = ((fahrenheit2 - 32m) * 5m / 9m);
        Console.WriteLine("The temperature is " + Math.Round(temperature2) + " degree Celsius");
    }
}
