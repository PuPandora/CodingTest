using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static double Solution(int[] numbers)
    {
        double result = 0;
        foreach (int n in numbers)
        {
            result += n;
        }
        result /= numbers.Length;

        return result;
    }

    static void Main(string[] args)
    {
    }
}
