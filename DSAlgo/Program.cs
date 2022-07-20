using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(LinearSearch((new int[] {1,4,7,8}),4,10));
            //Console.WriteLine(BinarySearch((new int[] { 1, 4, 7, 8 ,10}), 5, 4));
            //Console.WriteLine(BinarySearchRecursive((new int[] { 1, 4, 7, 8, 10 }), 10,0,4));
            Console.ReadLine();
        }

        public static int LinearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while(index<n)
            {
                if (A[index] == key)
                    return index;
                index = index + 1;

            }

            return -1;


        }

        public static int BinarySearch(int[] A, int n, int key)
        {
            int L =0;
            int R =n-1;

            while(L<=R)
            {
                int mid = (L + R) / 2;
                if(A[mid]==key)
                {
                    return mid;
                }
                else if (key<A[mid])
                {
                    R = mid - 1;
                }
                else 
                {
                    L = mid + 1;
                }
               
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] A, int key, int L, int R)
        {
            int mid = (L + R) / 2;
            
                if(key==A[mid])
                {
                    return mid;
                }
                else if(key<A[mid])
                {
                   return BinarySearchRecursive(A, key, L, mid - 1);
                }
                else
                {
                   return BinarySearchRecursive(A, key, mid+1, R);
                }
         
        }
    }
}
