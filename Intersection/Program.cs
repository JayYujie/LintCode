namespace Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            
            int[] nums1 = {1, 2, 2, 1};
            int[] nums2 = {2, 2};
            Dictionary<int,int> a = Intersection(nums1, nums2);
        }

        public static Dictionary<int,int> Intersection(int[] nums1, int[] nums2)
        {
            var dicIntersect = new Dictionary<int, int>();
            var intersectData = new Dictionary<int, int>();
            // Traverse the first array.
            foreach (int data in nums1)
            {
                if (!dicIntersect.Keys.Contains(data))
                {
                    dicIntersect.Add(data, 0);
                }

                dicIntersect[data]++;
            }
       
            // Traverse the second array.  
            foreach (int data in nums2)
            {
                /* Repeat the matched elements */
                /*if (dicIntersect.Keys.Contains(data))
                {
                    try
                    {
                        intersectData.Add(data, data);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Collection Repeat！");
                    }
                }*/
                /* dictionary collision */
                try
                {
                    dicIntersect.Add(data, data);
                }
                    //An item with the same key has already been added.
                    //发生字典碰撞捕获异常：说明重复Key出现，加入到Intersect即为重复数据
                catch (Exception ex)
                {
                    try
                    {
                        intersectData.Add(data, data);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Collection Repeat！");
                    }
                }
                dicIntersect[data]++;
            }

            return intersectData;
        }
    }
}