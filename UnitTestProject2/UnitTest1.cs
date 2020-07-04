using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStuff;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

                //arrage
                var expected = new List<int> { -185, 726 };
                var input = new List<int> { 12, 12, 35, 567, 78, 234, 33, 1, -12, -344, -222, -78, 78 };

                //act
                var actual = MiniMaxSum.calculateMiniMax(input);

            //assert
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[0], actual[0]);
                

        }
    }
}
