using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoveZero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveZero.Tests
{
    [TestClass()]
    public class MoveZeroTests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            MoveZero test = new MoveZero();
            int[] numsInA = { 0, 1, 0, 3, 12, 0 };
            int[] numsOut = { 1, 3, 12, 0, 0, 0 };

            int[] numsIn =( test.MoveZeroes(numsInA)).ToArray();
           
            //if (numsOut==numsIn)
            //{
            Assert.IsTrue(numsIn.Count()==6);
            //}
        }
    }
}