using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Operators_And_Methods
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;

            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = b % 1;

            Assert.AreEqual(3, c);
            Assert.AreEqual(-1, d);
            Assert.AreEqual(2, e);
            Assert.AreEqual(1 / 2, f);
            Assert.AreEqual(0, g);

        }
        //ADDITION
        [TestMethod]
        public void AddTwoNumbersReturnSum_Test()
        {
            int sum = AddTwoNumbersReturnSum(3, 7);
            Console.WriteLine(sum);
            Assert.AreEqual(10, sum);
        }

        public int AddTwoNumbersReturnSum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        //SUBTRACTION
        [TestMethod]
        public void SubtractTwoNumbersReturn_Test()
        {
            int sub = SubtractTwoNumbersReturn(10, 3);
            Console.WriteLine(sub);
            Assert.AreEqual(7, sub);
        }

        public int SubtractTwoNumbersReturn(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        //MULTIPLICATION
        [TestMethod]
        public void MultiplyTwoNumbersReturn_Test()
        {
            int mult = MultiplyTwoNumbersReturn(7, 3);
            Console.WriteLine(mult);
            Assert.AreEqual(21, mult);
        }

        public int MultiplyTwoNumbersReturn(int a, int b)
        {
            int sub = a * b;
            return sub;
        }

        //DIVISION
        [TestMethod]
        public void DivideTwoNumbersReturn_Test()
        {
            int divi = DivideTwoNumbersReturn(10, 2);
            Console.WriteLine(divi);
            Assert.AreEqual(5, divi);
        }

        public int DivideTwoNumbersReturn(int a, int b)
        {
            int divi = a / b;
            return divi;
        }

        //MODULUS
        [TestMethod]
        public void RemainderTwoNumbersReturn_Test()
        {
            int rem = RemainderTwoNumbersReturn(10, 2);
            Console.WriteLine(rem);
            Assert.AreEqual(0, rem);
        }

        public int RemainderTwoNumbersReturn(int a, int b)
        {
            int rem = a % b;
            return rem;
        }


    }
}
