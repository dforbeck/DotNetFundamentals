using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Value_Types
    {
        public void ValueTypes()
        {
            char character = '2';

            bool isLightOn = true;
            bool hasLegs = false;

            //Numbers

            byte byteMin = 0;
            byte byteMax = 255;

            short shortMin = -32768;
            short shortMax = 32767;

            int intMin = -24789798;
            int intMax = 24789798;

            long longerNumber = 48789787980;

            float floatNumber = 2.345f;

            double doubleExample = 3.4345345343454d;

            decimal decimalExample = 3.4565475676577676767m;

            int? nullValue = null;

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);
        }

        //starting new method within same class

        //declare 10 varaibles 10 different types
        public void Declaration()
        {
            int daysInMonth;       
            float avgGPA;
            double bankBal;
            byte daysinMonth;
            decimal domesticGNP;
            string names;
            bool computerOn;
            bool computerOff;
            char inital;
            long thisIsLong;
        }

        //public is an access modifier
        public void Declaration_And_Initialization()
        {

            int daysInMonth;
            float avgGPA;
            double bankBal;
            byte daysinMonth;
            decimal domesticGNP;
            string names;
            bool computerOn;
            bool computerOff;
            char inital;
            long thisIsLong;

        }
    }
}
