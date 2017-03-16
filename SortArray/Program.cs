/*
     
    给一组整数，按照升序排序，使用选择排序，冒泡排序，插入排序或者任何 O(n2) 的排序算法。
     
*/

namespace SortArray
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] A = {3, 2, 1, 4, 5};
           
            //InsertSort(A);


            var array = new int[3][] 
            {new int[3] {5, 6, 2}, 
                new int[5] {6, 9, 7, 8, 3}, 
                new int[2] {3, 2}};
          var a=  array[2][2];
        }

        /// <summary>
        ///     冒泡排序
        /// </summary>
        /// <param name="A"></param>
        public static void SortIntegers(int[] A)
        {
            //foreach (int item in A)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadKey();

            //}
            // Write your code here
            int temp = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] > A[j+1])
                    {
                        temp = A[j+1];
                        A[j+1] = A[j];
                        A[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort Array:");
            foreach (int item in A)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="A"></param>
        public static void SelectedSort(int[] A)
        {
            //foreach (int item in A)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadKey();
            //}
            int temp;
            int index = 0;

            for (int i = 0; i < A.Length-1; i++)
            {
                index = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        index = j;
                    }
                 
                }
                temp = A[i];
                A[i] = A[index];
                A[index] = temp;
            }
            foreach (int item in A)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="A"></param>
        public static void InsertSort(int[] A)
        {
            int temp;
            for (int i = 1; i < A.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (A[j] < A[j - 1])
                    {
                        temp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = temp;
                    }
                }
            }

        }
        
     
    }
}