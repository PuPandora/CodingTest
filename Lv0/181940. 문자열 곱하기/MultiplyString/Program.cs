using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 181940. 문자열 곱하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181940

public class Solution
{
    public string solution(string my_string, int k)
    {
        string answer = string.Empty;

        for (int i = 0; i < k; i++)
        {
            answer += my_string;
        }

        return answer;
    }
}
