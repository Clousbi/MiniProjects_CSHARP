using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            int len;
            Console.WriteLine("Sequência:");
            len = int.Parse(Console.ReadLine());

            Fibonacci_Iterative(len);

            Console.ReadKey();
        }
    }
}
