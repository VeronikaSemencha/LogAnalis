using System;
using System.Collections.Generic;
using LogAnalysisApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ParseLogicFileUnitTest
    {
       [TestMethod]
       public void TwoLineSplitTab_TwoColumn()
       {
         List<string> lines = new List<string>
       {
         "1\t11",
         "2\t22",
       };
       var result = ParseLogFileLogic.ParseLogFile(lines, "\t");
       Assert.AreEqual(2, result.ParseLines.Count);
       Assert.AreEqual(2, result.NumColumns);
       Assert.IsNull(result.Error);
        }
        [TestMethod]
        public void TwoLineSplitTab_ThreeColumn()
        {
        List<string> lines = new List<string>
          {
            "1\t11\t111",
          "2\t22\t222",
        };
        var result = ParseLogFileLogic.ParseLogFile(lines, "\t");
        Assert.AreEqual(2, result.ParseLines.Count);
        Assert.AreEqual(3, result.NumColumns);
        Assert.IsNull(result.Error);
        }
        [TestMethod]
        public void TwoLineSplitTab_OneColumn()
        {
        List<string> lines = new List<string>
          {
            "1\t11",
          "2\t22",
        };
        var result = ParseLogFileLogic.ParseLogFile(lines, "\r");
        Assert.AreEqual(2, result.ParseLines.Count);
        Assert.AreEqual(1, result.NumColumns);
        Assert.IsNull(result.Error);
        }
        [TestMethod]
         public void TwoLineSplitTab_ErrorDiffNumColumns()
        {
        List<string> lines = new List<string>
            {
               "1\t11",
             "2\t22\t222",
        };
        var result = ParseLogFileLogic.ParseLogFile(lines, "\t");
        Assert.AreEqual(2, result.ParseLines.Count);
        Assert.AreEqual(3, result.NumColumns);
        Assert.AreEqual("Файл содержит разные количество столбцов, измените разделитель", result.Error);
        }
        [TestMethod]
        public void TwoLineSplitTab_ErrorNotCorrectSplit()
        {
        List<string> lines = new List<string>
          {
             "1\t11",
           "2\t22",
        };
        var result = ParseLogFileLogic.ParseLogFile(lines, "test");
        Assert.AreEqual(2, result.ParseLines.Count);
        Assert.AreEqual(1, result.NumColumns);
        Assert.AreEqual("Разделитель должен быть 1 символ или его десятичное значение", result.Error);
        }
        [TestMethod]
        public void TwoLineSplitTab_ErrorSplitNull()
        {
        List<string> lines = new List<string>
          {
            "1\t11",
          "2\t22",
        };
        var result = ParseLogFileLogic.ParseLogFile(lines, null);
        Assert.AreEqual(2, result.ParseLines.Count);
        Assert.AreEqual(1, result.NumColumns);
        Assert.AreEqual("Разделитель должен быть 1 символ или его десятичное значение", result.Error);
        }
    }
}
