using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addition;

namespace TestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c=new Class1();
            Console.WriteLine(c.Addition(1, 2));
            Console.ReadLine();

        }
    }
}
