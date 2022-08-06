using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heaps;

namespace HeapSort
{
    public class Sort
    {
        

        public void HeapSort(int[] A,int n)
        {
            Heaps.Heap heap = new Heaps.Heap();

            for (int i = 0; i < n; i++)
            {
                heap.Insert(A[i]);

            }

            int k = n - 1;
            for (int i = 0; i < n; i++)
            {
                A[k] = heap.Delete();
                k = k - 1;
            }
        }

        public void Display(int [] A,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(A[i] + "");

            }
            Console.WriteLine();
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            int[] A = { 63, 54, 74, 65, 90 };
            Console.WriteLine("Original Array");
            sort.Display(A,A.Length);
            sort.HeapSort(A, A.Length);
            sort.Display(A, A.Length);
            Console.ReadLine();


        }
    }
}
