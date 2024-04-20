using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로그래머스 181942. 문자열 섞기
// https://school.programmers.co.kr/learn/courses/30/lessons/181942?language=csharp

public class Soluition
{
    public string solution(string str1, string str2)
    {
        string answer = string.Empty;

        char[] char1 = str1.ToCharArray();
        char[] char2 = str2.ToCharArray();

        for (int i = 0; i < str1.Length; i++)
        {
            answer += char1[i];
            answer += char2[i];
        }

        return answer;
    }
}
