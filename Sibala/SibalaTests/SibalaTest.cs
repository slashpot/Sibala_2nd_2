using NUnit.Framework;
using Sibala;
using System.Collections.Generic;

namespace SibalaTests
{
    [TestFixture]
    public class SibalaTest
    {
        [Test]
        public void SamePoint_Should_Bigger_than_NormalPoint()
        {
            var samePointDice = new List<int> { 1, 1, 1, 1 };
            var samePointGame = new SibalaGame(samePointDice);
            var inputResult1 = samePointGame.GetResult();

            var normalPointDice = new List<int>() { 1, 1, 2, 3 };

            var normalGame = new SibalaGame(normalPointDice);
            var inputResult2 = normalGame.GetResult();

            var target = new SibalaMain();
            int actual = target.Compare(inputResult1, inputResult2);
            int expect = 1;

            Assert.AreEqual(expect , actual);
        }
    }
}