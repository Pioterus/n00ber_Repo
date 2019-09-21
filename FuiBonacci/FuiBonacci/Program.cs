using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuiBonacci
{
    



   
        class Program
        {
            static void Main(string[] args)
            {
                long a = 0;
                long b = 1;
                long n = 0;
                Console.WriteLine("1 wyraz ciągu Fibonacciego = {0}", a);
                Console.WriteLine("2 wyraz ciągu Fibonacciego = {0}", b);
                for (int i = 2; i < 50; i++)
                {
                    n = a + b;
                    a = b;
                    b = n;
                    Console.WriteLine("{0} wyraz ciągu Fibonacciego = {1}", i + 1, n);
                //sfsfsf
                }
            }
        }
    }

