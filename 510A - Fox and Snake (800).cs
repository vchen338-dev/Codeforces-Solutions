using System;

class Program
{
    static void Main()
    {
        var parts = Console.ReadLine().Split();
        int n = int.Parse(parts[0]);
        int m = int.Parse(parts[1]);

        for (int r = 1; r <= n; r++)
        {
            if (r % 2 == 1)
            {
                // Odd rows: all '#'
                Console.WriteLine(new string('#', m));
            }
            else
            {
                // Even rows: alternate tail on right then left
                if (r % 4 == 0)
                {
                    // Row 4, 8, ... -> '#' then dots
                    Console.WriteLine("#" + new string('.', m - 1));
                }
                else
                {
                    // Row 2, 6, ... -> dots then '#'
                    Console.WriteLine(new string('.', m - 1) + "#");
                }
            }
        }
    }
}

