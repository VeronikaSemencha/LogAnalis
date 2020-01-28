using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogAnalysisApp
{
    public class ParseLogFileLogic
    {
        public static ParseFile ParseLogFile(List<string> listLines, string splitStr)
        {
            ParseFile parseFile = new ParseFile();
            List<string[]> parseLines = new List<string[]>();
            char split;
            if (int.TryParse(splitStr, out int splitValue))
            {
                split = Convert.ToChar(splitValue);
            }
            else
            {
                if (!char.TryParse(splitStr, out char charValue))
                {
                    parseFile.Error = "Разделитель должен быть 1 символ или его десятичное значение";
                }
                split = charValue;
            }

            for (int i = 0; i < listLines.Count; i++)
            {
                string[] parseLine = listLines[i].Split(split);
                parseLines.Add(parseLine);
            }
            int minNum = parseLines.Min(x => x.Length);
            int maxNum = parseLines.Max(x => x.Length);
            if (minNum != maxNum)
            {
                parseFile.Error = "Файл содержит разные количество столбцов, измените разделитель";
            }
            Properties.Settings.Default.NumColumns = maxNum;
            Properties.Settings.Default.Save();
            parseFile.NumColumns = maxNum;
            parseFile.ParseLines = parseLines;
            return parseFile;
        }
    }

    public class ParseFile
    {
        public int NumColumns { get; set; }
        public List<string[]> ParseLines { get; set; }
        public string Error { get; set; }
    }
}
