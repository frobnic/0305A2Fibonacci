using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305A2Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2; // Schleifenvariable, fib(0) und fib(1) werden vorher ausgegeben.
            int a = 0; // zweiter vorgaenger
            int b = 1; // erster vorgaenger
            int f = 0; // Fibonacci-zahl

            Console.WriteLine("fib({0,2}) = {1,8}  ", 1, 0);
            Console.WriteLine("fib({0,2}) = {1,8}  ", 2, 1);
            while (n < 30)
            {

                n++;

                f = a + b;
                a = b;
                b = f;
                Console.WriteLine("fib({0,2}) = {1,8}  ", n, f);



            }
        }
    }
}
