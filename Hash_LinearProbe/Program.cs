using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_LinearProbe
{

    class Linear_HashProbe
    {
        int maxSize;
        int[] Hash_Linear;
        public Linear_HashProbe()
        {
            maxSize = 10;
            Hash_Linear = new int[maxSize];
        }

        public int HashCode(int element)
        {
            return element % maxSize;
        }

        public int LinearProbe(int element)
        {
            int i = HashCode(element);
            int j = 0;

            while (Hash_Linear[(i+j)%maxSize]!=0)
            {
                j = j + 1;
            }

            return (i + j) % maxSize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            if(Hash_Linear[i]==0)
            {
                Hash_Linear[i] = element;
            }
            else
            {
                i = LinearProbe(element);
                Hash_Linear[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = HashCode(key);
            int j = 0;
            while (Hash_Linear[(i+j)%maxSize]!=key)
            {
                if(Hash_Linear[(i+j)%maxSize]==0)
                {
                    return false;
                }
                j = j + 1;

            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < maxSize; i++)
            {
                Console.WriteLine(Hash_Linear[i]);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Linear_HashProbe hash = new Linear_HashProbe();
            hash.Insert(20);
            hash.Insert(40);
            hash.Insert(23);
            hash.Insert(27);
            hash.Display();
            Console.ReadLine();
        }
    }
}
