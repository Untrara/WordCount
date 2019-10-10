using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountCharacters()
        {
            CountCharacters countCharacters = new CountCharacters();
            String test = "hello word ";
            List<string> wordList = countCharacters.wordsNum(test);
            Assert.AreEqual(wordList.Count,2);
           
        }

        [TestMethod]
        public void TestCountWords()
        {
            String test = "hello word ";
            CountWord countWord = new CountWord();
            Assert.AreEqual(countWord.charactersNum(test), 11);

        }
    }
}
