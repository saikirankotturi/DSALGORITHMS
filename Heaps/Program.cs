using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
   public class Heap
    {
        public int maxSize;
        public int[] data;
        public int cSize;

        public Heap()
        {
            maxSize = 10;
            cSize = 0;
            data = new int[maxSize];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public bool IsEmpty()
        {
            return cSize == 0;
        }

        public int Length()
        {
            return cSize;
        }

        public void Insert(int e)
        {
            if (maxSize==cSize)
            {
                Console.WriteLine("Heap has no Space");
            }
            cSize = cSize + 1;
            int hi = cSize;

            while (hi>1 && e > data[hi/2])
            {
                data[hi] = data[hi / 2];
                hi = hi / 2;
            }
            data[hi] = e;   

        }

        public int Delete()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Heap is empty");
                return -1;
            }
            int e = data[1];
            data[1] = data[cSize];
            data[cSize] = -1;
            cSize = cSize - 1;
            int i = 1;
            int j = i * 2;
            while (j<=cSize)
            {
                if (data[j] < data[j+1])
                {
                    j = j + 1;
                }
                if (data[i] < data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i = j;
                    j=i * 2;
                }
                else
                {
                    break;
                }
            }

            return e;

        }

        public int Max()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1];
        }

        public void Display()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.ReadLine();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();
            heap.Insert(20);
            heap.Insert(10);
            heap.Insert(30);
            heap.Insert(5);
            heap.Insert(50); 


            heap.Display();
 
            Console.WriteLine(heap.Delete());
            Console.WriteLine("After deletion");
            heap.Display();
            Console.WriteLine(heap.Delete());
            heap.Display();
            Console.ReadLine();
        }
    }
}
