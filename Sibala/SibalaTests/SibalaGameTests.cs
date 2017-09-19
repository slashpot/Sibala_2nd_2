using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sibala;

namespace Sibala.Tests
{
    [TestClass()]
    public class SibalaGameTests
    {
        private static void Test(List<int> input, string output)
        {
            var actual = new SibalaGame(input).Output;

            Assert.AreEqual(output, actual);
        }

        [TestMethod()]
        public void SibalaGameTest_OneColor()
        {
            Test(new List<int> { 6, 6, 6, 6 }, "One Color");
        }
        [TestMethod()]
        public void SibalaGameTest_DifferentDice_NoPoint()
        {
            Test(new List<int> { 1, 2, 3, 4 }, "No Point");
        }
        [TestMethod()]
        public void SibalaGameTest_3SameNumberDice_NoPoint()
        {
            Test(new List<int> { 5, 2, 5, 5 }, "No Point");
        }
        [TestMethod()]
        public void SibalaGameTest_3121_5Point()
        {
            Test(new List<int> { 3, 1, 2, 1 }, "5 Point");
        }
        [TestMethod()]
        public void SibalaGameTest_4455_10Point()
        {
            Test(new List<int> { 4, 4, 5, 5 }, "10 Point");
        }
        [TestMethod()]
        public void SibalaGameTest_2332_6Point()
        {
            Test(new List<int> { 2, 3, 3, 2 }, "6 Point");
        }
        [TestMethod()]
        public void SibalaGameTest_1123_5Point()
        {
            Test(new List<int> { 1, 1, 2, 3 }, "5 Point");
        }
        [TestMethod()]
        public void SibalaGameTest_3312_BG()
        {
            Test(new List<int> { 3, 3, 1, 2 }, "BG");
        }
        [TestMethod()]
        public void SibalaGameTest_5566_18la()
        {
            Test(new List<int> { 5, 5, 6, 6 }, "18la");
        }

        [TestMethod()]
        public void SibalaGameTest_6623_MaxValue3()
        {
            var actual = new SibalaGame(new List<int> { 6, 6, 2, 3 }).MaxDice;
            Assert.AreEqual(3,actual);
        }



    }
}