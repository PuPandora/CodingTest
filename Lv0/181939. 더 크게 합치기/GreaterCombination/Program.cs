using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;

        string wayA = a.ToString() + b.ToString();
        string wayB = b.ToString() + a.ToString();
        bool isWayABigger = int.Parse(wayA) > int.Parse(wayB);

        if (isWayABigger)
        {
            answer = int.Parse(wayA);
        }
        else
        {
            answer = int.Parse(wayB);
        }

        return answer;
    }
}
