using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TribonacciSequenceKata
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Input001_Amount0_return0()
        {
            var expected = new List<int> { 0 };
            var actual = TribonacciSequence.GenerateList(0, 0, 1, 0);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input001_Amount2_return00()
        {
            var expected = new List<int> { 0, 0 };
            var actual = TribonacciSequence.GenerateList(0, 0, 1, 2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input001_Amount3_return0()
        {
            var expected = new List<int> { 0, 0, 1 };
            var actual = TribonacciSequence.GenerateList(0, 0, 1, 3);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input001_Amount4_return0()
        {
            var expected = new List<int>()
            {
                0,0,1,1
            };
            var actual = TribonacciSequence.GenerateList(0, 0, 1, 4);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Input001_Amount8_return0()
        {
            var expected = new List<int>()
            {
                0,0,1,1,2,4,7,13
            };
            var actual = TribonacciSequence.GenerateList(0, 0, 1, 8);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public static class TribonacciSequence
    {
        //前三個數字之和
        public static List<int> GenerateList(int num1, int num2, int num3, int amount)
        {
            List<int> numbers = CreateList(num1, num2, num3);
            List<int> numbers2 = new List<int>();
            if (amount < 4)
            {
                for (int i = 0; i < amount; i++)
                {
                    numbers2.Add(numbers[i]);
                }
                return numbers2;
            }
                
            for (int i = 3; i < amount; i++)
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
