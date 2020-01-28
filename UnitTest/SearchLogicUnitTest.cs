using System;
using System.Collections.Generic;
using System.Linq;
using LogAnalysisApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SearchLogicUnitTest
    {
        [TestMethod]
        public void FindStr_Success()
        {
            List<string[]> list = new List<string[]>
            {
                new string[]{ "1", "one"},
                new string[]{ "2", "two"},
                new string[]{ "3", "three"},
            };
            var result = SearchLogic.Search(list, "two");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("2", result.First()[0]);
            Assert.AreEqual("two", result.First()[1]);
        }
        [TestMethod]
        public void FindStr_False()
        {
            List<string[]> list = new List<string[]>
            {
                new string[]{ "1", "one"},
                new string[]{ "2", "two"},
                new string[]{ "3", "three"},
            };
            var result = SearchLogic.Search(list, "four");
            Assert.AreEqual(0, result.Count);
            Assert.IsNull(result.FirstOrDefault());
        }
    }
}
