using System;

class Program
{
    static void Main()
    {
        Random dice = new Random();
        
        // Generating a random number (non-negative integer)
        int roll1 = dice.Next();
        
        // Generating a random number between 0 (inclusive) and 101 (exclusive)
        int roll2 = dice.Next(101);
        
        // Generating a random number between 50 (inclusive) and 101 (exclusive)
        int roll3 = dice.Next(50, 101);
        
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
    }
}

