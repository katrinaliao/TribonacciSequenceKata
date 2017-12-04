using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TribonacciSequenceKata
{
    [TestClass]
    public class UnitTest
    {
        //[TestMethod]
        //public void Input001_Amount0_return0()
        //{
        //    var expected = 0;
        //    var actual = TribonacciSequence.Sum(0, 0, 0, 0);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void Input001_Amount3_return0()
        {
            var expected = new List<int>{0,0,1};
            var actual = TribonacciSequence.Sum(0, 0, 1, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input001_Amount4_return0()
        {
            var expected = new List<int>()
            {
                0,0,1,1
            };
            var actual = TribonacciSequence.Sum(0, 0, 1, 4);
            Assert.AreEqual(expected, actual);
        }
    }

    public static class TribonacciSequence
    {
        //前三個數字之和
        public static List<int> Sum(int num1, int num2, int num3, int amount)
        {
            List<int> numbers = CreateList(num1, num2, num3);

            if (amount < 3)
            {
                for (int i = 0; i < amount; i++)
                {
                    return numbers;
                }
            }
                

            for (int i = 3; i < amount ; i++)
            {
                numbers.Add(numbers[i - 3] + numbers[i - 2] + numbers[i - 1]);
            }

            return numbers;
        }

        public static List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }
    }
}
