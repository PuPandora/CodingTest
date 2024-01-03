using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    public static int Solution(int price)
    {
        int result = 0;

        // 50만원 이상, 20% 할인
        if (price >= 500_000)
        {
            result = (int)(price * 0.8f);
        }
        // 30만원 이상, 10% 할인
        else if (price >= 300_000)
        {
            result = (int)(price * 0.9f);
        }
        // 10만원 이상, 5% 할인
        else if (price >= 100_000)
        {
            result = (int)(price * 0.95f);
        }
        // 그 외, 0% 할인
        else
        {
            result = price;
        }

       return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Solution(374_740));
    }
}
