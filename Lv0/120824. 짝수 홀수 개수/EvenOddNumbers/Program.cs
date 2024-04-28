using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 120824. 짝수 홀수 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120824

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[2] { 0, 0 };
        int evenCount = 0;
        int oddCount = 0;

        // 받은 리스트를 탐색하며 짝수 홀수 개수 기록
        foreach (int i in num_list)
        {
            // 짝수일 경우
            if (i % 2 == 0)
            {
                evenCount++;
            }
            // 홀수일 경우
            else
            {
                oddCount++;
            }
        }

        answer[0] = evenCount;
        answer[1] = oddCount;

        return answer;
    }
}