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
            Assert.IsTrue(actual > 0);
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

        [TestMethod]
        public void SamePoint_1_Should_Bigger_than_SamePoint_4()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            _inputResult2 = new SibalaGame(new List<int> { 4, 4, 4, 4 });

            AssertInput1IsBigger();
        }

        [TestMethod]
        public void SamePoint_4_Should_Bigger_than_SamePoint_6()
        {
            _inputResult1 = new SibalaGame(new List<int> { 4, 4, 4, 4 });
            _inputResult2 = new SibalaGame(new List<int> { 6, 6, 6, 6 });

            AssertInput1IsBigger();
        }

        [TestMethod]
        public void NormalPoint_1133_Should_Smaller_than_NormalPoint_1124()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 3, 3 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 1, 2, 4 });

            AssertInputIsSmaller();
        }

        [TestMethod]
        public void NoPoint_1234_Should_Equal_NoPoint_2345()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 2, 3, 4 });
            _inputResult2 = new SibalaGame(new List<int> { 2, 3, 4, 5 });

            AssertInputIsEqual();
        }

        [TestMethod]
        public void SamePoint_1111_Should_Equal_SamePoint_1111()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 1, 1 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 1, 1, 1 });

            AssertInputIsEqual();
        }

        [TestMethod]
        public void NormalPoint_1123_Should_Equal_NormalPoint_1123()
        {
            _inputResult1 = new SibalaGame(new List<int> { 1, 1, 2, 3 });
            _inputResult2 = new SibalaGame(new List<int> { 1, 1, 2, 3 });

            AssertInputIsEqual();
        }

        private void AssertInputIsEqual()
        {
            actual = _target.Compare(_inputResult1, _inputResult2);
            Assert.IsTrue(actual == 0);
        }

        private void AssertInputIsSmaller()
        {
            actual = _target.Compare(_inputResult1, _inputResult2);
            Assert.IsTrue(actual < 0);
        }
    }
}