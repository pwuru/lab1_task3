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
        public void StringIsEmptyTest()
        {
            string testSentence = "";

            var result = Logic.CountLetters(testSentence);

            Assert.IsNull(result, "Expected result to be null for empty string input.");
        }
        
        [TestMethod()]
        public void StringHasNotIdenticalTest()
        {
            string testSentence = "avmo cksnz qpw";

            var result = Logic.CountLetters(testSentence);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod()]
        public void StringHasNotSpacesTest()
        {
            string testSentence = "aaabbaa";

            var result = Logic.CountLetters(testSentence);

            Assert.AreEqual("Количество подряд идущих букв 'a': 3", result[0]);
            Assert.AreEqual("Количество подряд идущих букв 'b': 2", result[1]);
            Assert.AreEqual("Количество подряд идущих букв 'a': 2", result[2]);
        }

        [TestMethod()]
        public void StringHasSpacesTest()
        {
            string testSentence = "aab baa a";

            var result = Logic.CountLetters(testSentence);

            Assert.AreEqual("Количество подряд идущих букв 'a': 2", result[0]);
            Assert.AreEqual("Количество подряд идущих букв 'b': 2", result[1]);
            Assert.AreEqual("Количество подряд идущих букв 'a': 3", result[2]);
        }
    }
}
