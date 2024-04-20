using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 181941. 문자 리스트를 문자열로 반환하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181941

public class Solution
{
    public string solution(string[] arr)
    {
        string answer = string.Empty;

        foreach (var c in arr)
        {
            answer += c;
        }

        return answer;
    }
}
