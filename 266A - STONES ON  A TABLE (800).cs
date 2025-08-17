using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int count = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
