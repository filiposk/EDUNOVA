using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                int op1, op2;
                Console.Write("Enter first operand: ");
                op1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second operand: ");
                op2 = int.Parse(Console.ReadLine());

                Console.WriteLine(String.Format("Result is: {0}", op1 + op2));
                Console.WriteLine("---------------------------");
            }
        }
    }
}
