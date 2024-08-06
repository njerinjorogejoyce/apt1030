using System;

class Program
{
    static void Main()
    {
        int value = 1;

        value++;
        Console.WriteLine("First: " + value);

        Console.WriteLine("Second: " + value++);
        // At this point, value is incremented after being printed

        Console.WriteLine("Third: " + value);

        Console.WriteLine("First (pre-increment): " + (++value));
        // At this point, value is incremented before being printed

        // Reset value to 1
        value = 1;
        ++value;
        value++;

        Console.WriteLine("First (after resetting and incrementing): " + value);
    }
}

