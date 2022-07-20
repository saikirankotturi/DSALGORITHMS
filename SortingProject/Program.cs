using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectionSort((new int[] { 6, 4, 2, 3, 9, 7 }), 6);
            //InsertionSort((new int[] { 1, 4, 3, 2, 9, 7 ,8,14,13,12,19}), 11);
            // BubbleSort((new int[] { 1, 4, 3, 2, 9, 7, 8, 14, 13, 12, 19 }), 11);

            Program p = new Program();
            int[] A = { 2, 1, 5, 4, 9, 8 };
            p.QuickSort(A, 0, 5);
            p.Display(A);

        }
     
        
        
        public static void SelectionSort(int[] A,int n)
        {
            int position = 0;
            for (int i = 0; i < n-1; i++)
            {
                position = i;
                for (int j = i+1; j < n; j++)
                {
                    if(A[j]<A[position])
                    {
                        position = j;                     
                     
                    }
                }
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
            DisplayArray(A);
        
        }

        public static void InsertionSort(int[] A, int n)
        {            
            for (int i = 1; i < n; i++)
            {
                int cvalue = A[i];
                int position = i;
                while(position>0 && A[position-1]>cvalue)
                {
                    A[position] = A[position-1];
                    position = position - 1;
                }
                A[position] = cvalue;
              
            }
            DisplayArray(A);
        }

        public static void BubbleSort(int[] A, int n)
        {
            for (int sorted = n-1; sorted >0; sorted--)
            {
                for (int i = 0; i < sorted; i++)
                {
                    if(A[i]>A[i+1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }

            }

            DisplayArray(A);
        }
        
        public void QuickSort(int[] A, int low, int high)
        {
            if(low<high)
            {
                int pivot = QuickSortPartition(A, low, high);
                QuickSort(A, low, pivot - 1);
                QuickSort(A, pivot + 1, high);
            }
        }
     
        public static int QuickSortPartition(int[] A, int low, int high)
        {
            int i = low+1;
            int j = high;
            int pivot = A[low];
            do
            {

                while (i<=j && A[i]<pivot)
                {
                    i = i + 1;
                }
                while (i <= j && A[j] > pivot)
                {
                    j = j- 1;
                }

                if (i<=j)
                {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }

            } while (i<j);

            int temp1 = A[low];
            A[low] = A[j];
            A[j] = temp1;

            return j;           

        }

      
        public void Display(int[] A)
        {
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void DisplayArray(int[] A)
        {
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           
        }
    }
}
