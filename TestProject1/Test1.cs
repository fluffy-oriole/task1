using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace TestTask1
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void Setup() { }

        [TestMethod]
        public void UsualTest()
        {
            string expected = "48 руб. 75 копеек";
            string real = Logic.GetRubCents(4875);
            Assert.AreEqual(expected, real);
        }

        [TestMethod]
        public void NoCents()
        {
            string ans = Logic.GetRubCents(500);
            Assert.AreEqual("5 руб. ровно", ans);
        }

        [TestMethod]
        public void FirstDeclension()
        {
            string ans = Logic.GetRubCents(13);
            Assert.AreEqual("0 руб. 13 копеек", ans);
        }

        [TestMethod]
        public void SecondDeclension()
        {
            string ans = Logic.GetRubCents(1);
            Assert.AreEqual("0 руб. 1 копейка", ans);
        }

        [TestMethod]
        public void FourthWord()
        {
            string ans = Logic.GetRubCents(4);
            Assert.AreEqual("0 руб. 4 копейки", ans);
        }
    }
}
