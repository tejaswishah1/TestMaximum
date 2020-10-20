using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace MaximumUnitTesting
{
    [TestClass]
    public class MaximumValueTesting
    {
        [TestMethod] ////Maximum Value at Position 1
        ////TC.1

        public void GIVEN_THREE_NUMBERS_1ST_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            int[] intArray = { 30, 20, 10 };
            Maximum<int> maxnum = new Maximum<int>(intArray);

            int max = maxnum.MaxValue(30, 20, 10);

            Assert.AreEqual(30, max);



        }
        [TestMethod] ////Maximum Value at Position 2
        ////TC.2

        public void GIVEN_THREE_NUMBERS_2ND_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            int[] intArray = { 20, 30, 10 };
            Maximum<int> maxnum = new Maximum<int>(intArray);

            int max = maxnum.MaxValue(20, 30, 10);

            Assert.AreEqual(30, max);

        }
        [TestMethod] ////Maximum Value at Position 3
        ////TC.3

        public void GIVEN_THREE_NUMBERS_3RD_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            int[] intArray = { 20, 10, 100 };
            Maximum<int> maxnum = new Maximum<int>(intArray);

            int max = maxnum.MaxValue(20, 10, 100);

            Assert.AreEqual(100, max);

        }
        [TestMethod] ////Maximum Value at Position 1
        ////TC.2.1

        public void GIVEN_THREE_DECIMALS_1ST_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            double[] doubleArray = { 5.9, 2.1,3.1 };
            Maximum<double> maxnum = new Maximum<double>(doubleArray);

            double max = maxnum.MaxValue(5.9, 2.1, 3.1);

            Assert.AreEqual(5.9, max);



        }
        [TestMethod] ////Maximum Value at Position 2
        ////TC.2.2

        public void GIVEN_THREE_DECIMALS_2ND_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            double[] doubleArray = { 2.1,5.9,3.1 };
            Maximum<double> maxnum = new Maximum<double>(doubleArray);

            double max = maxnum.MaxValue(2.1, 5.9, 3.1);

            Assert.AreEqual(5.9, max);



        }
        [TestMethod] ////Maximum Value at Position 3
        ////TC.2.3

        public void GIVEN_THREE_DECIMALS_3RD_NUMBER_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            double[] doubleArray = { 2.1,3.1, 5.9};
            Maximum<double> maxnum = new Maximum<double>(doubleArray);

            double max = maxnum.MaxValue(2.1, 3.1, 5.9);

            Assert.AreEqual(5.9, max);



        }
        [TestMethod] ////Maximum Value at Position 1
                     ////TC.3.1

        public void GIVEN_THREE_STRINGS_1ST_STRING_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            string[] stringArray = { "33", "10", "9" };
            Maximum<string> maxnum = new Maximum<string>(stringArray);

            string max = maxnum.MaxValue("33", "10", "9");

            Assert.AreEqual("33", max);



        }
        [TestMethod] ////Maximum Value at Position 2
                     ////TC.3.2

        public void GIVEN_THREE_STRINGS_2nd_STRING_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            string[] stringArray = { "33", "100", "9" };
            Maximum<string> maxnum = new Maximum<string>(stringArray);

            string max = maxnum.MaxValue("33", "100", "9");

            Assert.AreEqual("100", max);



        }
        [TestMethod] ////Maximum Value at Position 3
                     ////TC.3.3

        public void GIVEN_THREE_STRINGS_3rd_STRING_SHOULD_RETURN_MAXIMUM_VALUE()
        {
            string[] stringArray = { "33", "100", "900" };
            Maximum<string> maxnum = new Maximum<string>(stringArray);

            string max = maxnum.MaxValue("33", "100", "900");

            Assert.AreEqual("900", max);



        }


    }
}
    

