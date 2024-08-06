using System;

class Program
{
    static void Main()
    {
        string s = "The quick brown fox jumps over the lazy dog";
        string[] subs = s.Split(' ');

        foreach (var sub in subs)
        {
            char[] value = sub.ToCharArray();
            Array.Reverse(value);
            string result = new string(value);
            Console.WriteLine(result);
        }
    }
}

