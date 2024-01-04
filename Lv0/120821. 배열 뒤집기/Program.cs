using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static int[] Solution(int[] num_list)
    {
        int[] answer = new int[num_list.Length];
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[num_list.Length - i - 1];
        }
        return answer;
    }

    static void Main(string[] args)
    {
        Solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8});
    }
}
