﻿//using NUnit.Framework;
//using Sibala;
//using System.Collections.Generic;

//namespace SibalaTests
//{
//    //[TestFixture]
//    public class SibalaTest
//    {
//        //[Test]
//        public void SamePoint_Should_Bigger_than_NormalPoint()
//        {
//            var samePointDice = new List<int> { 1, 1, 1, 1 };
//            var samePointGame = new SibalaGame(samePointDice);
//            var inputResult1 = samePointGame.GetResult();

//            var normalPointDice = new List<int>() { 1, 1, 2, 3 };
//            var normalGame = new SibalaGame(normalPointDice);
//            var inputResult2 = normalGame.GetResult();

//            var target = new SibalaMain();
//            int actual = target.Compare(inputResult1, inputResult2);
//            int expect = 1;

//            Assert.AreEqual(expect , actual);
//        }

//        [Test]
//        public void NormalPoint_Should_Bigger_than_NoPoint()
//        {
//            var normalPoint = new List<int> { 1, 1, 2, 4 };
//            var normalPointGame = new SibalaGame(normalPoint);
//            var inputResult1 = normalPointGame.GetResult();

//            var noPoint = new List<int>() { 1, 5, 2, 3 };
//            var noPointGame = new SibalaGame(noPoint);
//            var inputResult2 = noPointGame.GetResult();

//            var target = new SibalaMain();
//            int actual = target.Compare(inputResult1, inputResult2);
//            int expect = 1;

//            Assert.AreEqual(expect, actual);
//        }

//        [Test]
//        public void SamePoint_Should_Bigger_than_NoPoint()
//        {
//            var samePoint = new List<int> { 1, 1, 1, 1 };
//            var samePointGame = new SibalaGame(samePoint);
//            var inputResult1 = samePointGame.GetResult();

//            var noPoint = new List<int>() { 1, 5, 2, 3 };
//            var noPointGame = new SibalaGame(noPoint);
//            var inputResult2 = noPointGame.GetResult();

//            var target = new SibalaMain();
//            int actual = target.Compare(inputResult1, inputResult2);
//            int expect = 1;

//            Assert.AreEqual(expect, actual);
//        }
//    }
//}