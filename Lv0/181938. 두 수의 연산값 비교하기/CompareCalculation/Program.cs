using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 181938. 두 수의 연산값 비교하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181938

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;
        int wayAResult = 0;
        int wayBResult = 0;
        bool isWayAOver = false;

        wayAResult = WayA(a, b);
        wayBResult = WayB(a, b);

        isWayAOver = wayAResult >= wayBResult;

        if (isWayAOver)
        {
            answer = wayAResult;
        }
        else
        {
            answer = wayBResult;
        }

        return answer;
    }

    private int WayA(int a, int b)
    {
        string strA = a.ToString();
        string strB = b.ToString();

        return int.Parse(strA + strB);
    }

    private int WayB(int a, int b)
    {
        return (2 * a * b);
    }
}
