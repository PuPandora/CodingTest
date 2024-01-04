using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PrintAge
{
    internal class Program
    {
        static int Solution(int age)
        {
            int year = 2022;
            return year - age + 1;
        }

        static void Main(string[] args)
        {
        }
    }
}
