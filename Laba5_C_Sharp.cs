using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Варіант 22
            int res;
            int tmp;
            for (int i = 1000000; i <= 1000000000; i++)
            {
                res = 0;
                tmp = i;
                while (tmp != 0)
                {
                    res = (res * 10) + (tmp % 10);
                    tmp /= 10;
                }
                if (res == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
