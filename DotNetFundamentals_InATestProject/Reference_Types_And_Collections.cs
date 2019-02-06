using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        public void ReferenceTypes()
        {
            //Classes
            //Interfaces

            string hello = "Hello World";
        }

        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can", "be anything" };
            int[] arrayofNumbers = { 1, 3, 450, 2, 4, 5 };

            List<string> listOfStrings = new List<string>();
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            SortedList<int, string> sortedKeyAndValuePair = new SortedList<int, string>();
            Stack<string> lastinFirstOut = new Stack<string>();
        }

        //Challenge write a method that will take a parameter of a string and then
        //add that string to a sentence.  Output it to the test runner

        public string SayHello(string hello)
        {
            string greeting = "Hello " + hello;
            Console.WriteLine($"Hello {hello}");
            return greeting;
        }

        [TestMethod]
        public void SayHello_Test()
        {
            //Arrange
            string name = "John";

            //Act
            string actual = SayHello(name);

            //Assert
            Assert.AreEqual("Hello John", actual);

        }

    }
}
