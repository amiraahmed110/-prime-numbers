using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER N1 , N2");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int X = 0;
            for (int i = N1; i <= N2; i++)
            {
                for (int n =1; n <= i; n++)
                {
                    if (i % n == 0)
                        X++;
                }
                if ( X ==2)
                {
                    Console.WriteLine(i);
                    X = 0;
               }
                else
                {
                    X = 0;
                    continue;
                }
                Console.ReadKey();






            }








        }
    }
}
