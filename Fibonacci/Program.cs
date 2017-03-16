/**
 
 查找斐波纳契数列中第 N 个数。

所谓的斐波纳契数列是指：

前2个数是 0 和 1 。
第 i 个数是第 i-1 个数和第i-2 个数的和。
斐波纳契数列的前10个数字是：

0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...
0  1  2  3  4  5  6  7   8   9
 */


namespace Fibonacci
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = GeneralFibonacci(10);
        }

        /// <summary>
        ///     递归算法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n > 0 && n <= 2)
            {
                return 1;
            }
            return this.Fibonacci(n - 1) + this.Fibonacci(n - 2);
        }

        /// <summary>
        ///     普通算法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int GeneralFibonacci(int n)
        {
            int sum = 0;
            //穷举第一个和第二个数列元素
            int item1 = 1;
            int item2 = 1;
            if (n <= 0)
            {
                return sum;
            }
            if (n > 0 && n <= 2)
            {
                sum = 1;
                return sum;
            }
            //循环变量应该从0开始长度为n-2 (总长n - 两个穷举数列2)
            for (int i = 0; i < n - 2; i++)
            {
                sum = item1 + item2;
                item1 = item2;
                item2 = sum;
            }
            return sum;
        }
    }
}