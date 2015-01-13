using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourAge;
            Console.WriteLine("Enter your age:");
            Console.WriteLine();
            yourAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after ten years is : " + (yourAge + 10));
        }
    }
}
