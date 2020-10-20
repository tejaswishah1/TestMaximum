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
    }
}
