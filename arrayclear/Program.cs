using System;

class Program
{
    static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine($"Before: {pallets[0].ToLower()}");
        
        Array.Clear(pallets, 0, 2);

        if (pallets[0] != null)
        {
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        }
        else
        {
            Console.WriteLine("After: null");
        }

        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}

