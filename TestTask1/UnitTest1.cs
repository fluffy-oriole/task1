using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RubAndCents()
        {
            var expected = new int[] { 48, 75 };
            var real = Logic.GetRubCents(4875);
            CollectionAssert.AreEqual(expected, real);
        }

        [Test]
        public void FirstWord()
        {
            var word = Logic.GetCentsWord(0);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(" ровно", word);
        }

        [Test]
        public void SecondWord()
        {
            var word = Logic.GetCentsWord(13);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("13 копеек", word);
        }

        [Test]
        public void ThirdWord()
        {
            var word = Logic.GetCentsWord(1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("1 копейка", word);
        }

        [Test]
        public void ForthWord()
        {
            var word = Logic.GetCentsWord(4);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("4 копейки", word);
        }
    }
}
