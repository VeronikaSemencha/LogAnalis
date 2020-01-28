using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalysisApp
{
    public class SearchLogic
    {
        public static List<string[]> Search(List<string[]> lines, string searchStr)
        {
            List<string[]> filteredList = new List<string[]>(); 
            foreach (var line in lines)
            {
                var item = line.Where(x => x.ToUpper().Contains(searchStr.ToUpper())).FirstOrDefault();
                if (item != null)
                {
                    filteredList.Add(line);
                }
            }
            return filteredList;
        }
    }
}
