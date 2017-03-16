using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = AddDigits(38);
            Console.WriteLine("Normal Function:{0}", root);
            root = AddDigitsforRole(38);
            Console.WriteLine("Rules Function:{0}", root);
        }
        public static int AddDigits(int num)
        {
            // Write your code here  
            //num  0   !0  
            //num  <10   >10  

            /* 
             * 外循环 处理数据的依据就是求模运算大于零，且这个数大于十 不大于十直接返回 
             * 内循环 求余累加sum  num从个位开始依次到N位，直至num=0不再进入 
           
             */
            if (num < 10)
            {

                return num;
            }
            else
            {

                while (num % 10 > 0 && num > 10)
                {
                    var sum = 0;
                    while (num > 0)
                    {
                        sum += num % 10;
                        num /= 10;

                    }
                    num = sum;
                }
                return num;
            }
        }
        public static int AddDigitsforRole(int num)
        {
            /* 
            1    1 
            2    2 
            3    3 
            4    4 
            5    5 
            6    6 
            7    7 
            8    8     
            9    9     
            10    1 
            11    2 
            12    3     
            13    4 
            14    5 
            15    6 
            16    7 
            17    8 
            18    9 
            19    1 
            20    2 
             * 9个数一个轮回，我们就直接模9 
             * 那么特殊情况（9 及9的倍数）我们采用减一加一获取 
             * 减一加一也兼顾了其它数的求根 
             */
            return (num - 1) % 9 + 1;

        }
    }
}
