using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            System.Console.Write(num + "  ");
            for (int i = 5, j = 0; j < 9; i = i + 2, j++)
            {
                if (num >= 0)
                {
                    num = num - i;
                }
                else
                {
                    num = num + i;
                }
                System.Console.Write(num + "  ");
            }
        }
    }
}
