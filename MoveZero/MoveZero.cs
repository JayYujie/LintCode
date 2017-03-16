using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveZero
{
    public class MoveZero
    {
        public LinkedList<int>  MoveZeroes(int[] nums)
        {
            // Write your code here
            var numList = new LinkedList<int>(nums);
            int length = 0;
            while (numList.Contains(0))
            {
                numList.Remove(0);
                length++;
            }
            for (int i = 0; i < length; i++)
            {
                numList.AddLast(0);
            }
            return numList;
        }
    }
}
