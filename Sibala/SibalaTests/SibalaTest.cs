using Sibala;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SibalaTests
{
    [TestClass]
    public class SibalaTest
    {
        [TestMethod]
        public void SamePoint_Should_Bigger_than_NormalPoint()
        {
            var inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            var inputResult2 = new SibalaGame(new List<int> {1, 1, 2, 3});

            var target = new SibalaMain();
            int actual = target.Compare(inputResult1, inputResult2);
            int expect = 1;

            Assert.AreEqual(expect , actual);
        }

        [TestMethod]
        public void NormalPoint_Should_Bigger_than_NoPoint()
        {

            var inputResult1 = new SibalaGame(new List<int> { 1, 1, 2, 4 });
            var inputResult2 = new SibalaGame(new List<int> { 1, 5, 2, 3 });
            
            var target = new SibalaMain();
            int actual = target.Compare(inputResult1, inputResult2);
            int expect = 1;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SamePoint_Should_Bigger_than_NoPoint()
        {
            var inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            var inputResult2 = new SibalaGame(new List<int> { 1, 5, 2, 3 });

            var target = new SibalaMain();
            int actual = target.Compare(inputResult1, inputResult2);
            int expect = 1;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void NormalPoint_10_Should_Bigger_than_NormalPoint_6()
        {
            var inputResult1 = new SibalaGame(new List<int> { 3, 3, 5, 5 });
            var inputResult2 = new SibalaGame(new List<int> { 1, 1, 3, 3 });

            var target = new SibalaMain();
            int actual = target.Compare(inputResult1, inputResult2);
            int expect = 1;

            Assert.AreEqual(expect, actual);
        }
    }
}