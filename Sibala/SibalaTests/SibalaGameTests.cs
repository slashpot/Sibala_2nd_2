using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sibala;

namespace Sibala.Tests
{
    [TestClass()]
    public class SibalaGameTests
    {
        [TestMethod()]
        public void SibalaGameTest()
        {
            var actual = new SibalaGame(new List<int>() { 6, 6, 6, 6 }).Output;
            
            Assert.AreEqual("One Color", actual);
        }
    }
}