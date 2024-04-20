using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 181939. 더 크게 합치기
// https://school.programmers.co.kr/learn/courses/30/lessons/181939

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
