using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yu_LeetCode.Problems;

namespace LeetCode.Test.Test
{
    public class TwoSumTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] num = { 3, 2, 4 };
            int[] res = TwoSum.Solution(num, 6);
            int[] ans = { 1, 2 };
            Assert.AreEqual(res, ans);
        }

        [Test]
        public void Test2()
        {
            int[] num = { 1, 6, 3, 10, 16, 2, 7 };
            int[] res = TwoSum.Solution(num, 18);
            int[] ans = { 4, 5 };
            Assert.AreEqual(res, ans);
        }
    }
}
