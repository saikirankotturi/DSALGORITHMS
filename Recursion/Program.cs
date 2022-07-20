using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SumOfNaturalNumbersIteration(100));
            //Console.WriteLine(SumOfNaturalNumbersRecursion(100));
           SquareOfNumbersRecursion(3);
            Console.ReadLine();
        }

        public static int SumOfNaturalNumbersIteration(int n)
        {

            int i = 1;
            int sum = 0;
            while(i<=n)
            {
                sum = sum + i;
                i = i + 1;
            }
            return sum;

        }

        public static int SumOfNaturalNumbersRecursion(int n)
        {
            if(n==0)
            {
                return 0;
            }

            return SumOfNaturalNumbersRecursion(n - 1) + n;
        }

        public static void SquareOfNumbersRecursion(int n)
        {
            if(n>0)
            {
                SquareOfNumbersRecursion(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                SquareOfNumbersRecursion(n - 1);
            }
        }
    }
}
