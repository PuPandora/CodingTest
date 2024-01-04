using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static string Solution(string my_string)
    {
        string answer = "";
        for (int i = 0; i < my_string.Length; i++)
        {
            answer += my_string[my_string.Length - i - 1];
        }
        return answer;
    }

    static void Main(string[] args)
    {
    }
}
