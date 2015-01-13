using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            Console.Write(num + "    ");
            for (int i = 5, j = 1; j <= 999; j++, i = i + 2)
            {
                if (num >= 0)
                {
                    num = num - i;
                }
                else
                {
                    num = num + i;
                }
                Console.Write(num + "    ");
            }
        }
    }
}
