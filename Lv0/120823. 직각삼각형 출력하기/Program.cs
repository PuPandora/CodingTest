using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = int.Parse(s[0]);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
