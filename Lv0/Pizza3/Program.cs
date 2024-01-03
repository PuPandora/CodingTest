using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    /// <param name="slice">피자 조각 수</param>
    /// <param name="n">인원 수</param>
    public static int Solution(int slice, int n)
    {
        // 피자 조각 수가 충분한 경우
        if (slice > n)
        {
            return 1;
        }
        else
        {
            // 나머지가 없는 경우
            if (n % slice == 0)
            {
                return n / slice;
            }
            else
            {
                double result = Math.Ceiling((double)n / slice);
                return (int)result;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Solution(7, 10));
    }
}
