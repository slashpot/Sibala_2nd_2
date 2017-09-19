using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sibala;
using System.Collections.Generic;

namespace SibalaTests
{
    [TestClass]
    public class SibalaTest
    {
        private SibalaGame _inputResult1;
        private SibalaGame _inputResult2;
        private SibalaMain _target = new SibalaMain();
        private int actual;
        private int expected;

        [TestMethod]
        public void SamePoint_Should_Bigger_than_NormalPoint()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 1, 2, 3 });
            
            AssertInput1IsBigger();
        }

        private void AssertInput1IsBigger()
        {
            actual = _target.Compare(_inputResult1, _inputResult2);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void NormalPoint_Should_Bigger_than_NoPoint()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 2, 4 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 5, 2, 3 });

            AssertInput1IsBigger();
        }

        [TestMethod]
        public void SamePoint_Should_Bigger_than_NoPoint()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 5, 2, 3 });

            AssertInput1IsBigger();
        }

        [TestMethod]
        public void NormalPoint_10_Should_Bigger_than_NormalPoint_6()
        {
            _inputResult1 = new SibalaGame(new List<int> { 3, 3, 5, 5 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 1, 3, 3 });

            AssertInput1IsBigger();
        }
    }
}