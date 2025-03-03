using Microsoft.VisualStudio.TestTools.UnitTesting;
using tech_lab1_task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_lab1_task3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void StringIsNotEmptyTest()
        {
            string testSentence = "Hello, World!";

            int result = Logic.CountLetters(testSentence);

            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void StringIsEmptyTest()
        {
            string testSentence = "";

            int result = Logic.CountLetters(testSentence);

            Assert.AreEqual(-1, result);
        }
    }
}