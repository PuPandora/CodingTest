using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static int[] Solution(int money)
    {
        const int coffeePrice = 5500;
        return new int[2] { money / coffeePrice, money % coffeePrice };
    }
}
