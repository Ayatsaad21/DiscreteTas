using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_prime_numper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j;
            Console.WriteLine(" please enter the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            n2 = int.Parse(Console.ReadLine());

            for(i=n1;i<=n2;i++)
            {
                for(j=2;j<=i;j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (i == j)
                    Console.WriteLine("the prime number is:" + j);
            }
            Console.ReadKey();




        }
    }
}
