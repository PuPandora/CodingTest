using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = string.Empty;

        // my_string 문자열 반복
        foreach (char c in my_string)
        {
            // 현재 반복 돌아가는 문자를 n회 만큼 더함
            for (int i = 0; i < n; i++)
            {
                answer += c;
            }
        }

        return answer;
    }
}
