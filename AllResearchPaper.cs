using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ResearchPaperManagementSystem 
{
    [Serializable]
    public class AllResearchPaper 
    {
        public List<ResearchPaper> allResearchPaper = new List<ResearchPaper>();

        public void AddPaper(ResearchPaper rPaper)
        {
            allResearchPaper.Add(rPaper);
        }


        public void GetResearchPapers()
        {
            for (int i = 0; i < allResearchPaper.Count; i++)
            {
                Console.WriteLine(allResearchPaper[i].Id+ "\t" +allResearchPaper[i].Author + "\t" + allResearchPaper[i].Title +
                    "\t" + allResearchPaper[i].Department + "\t" + allResearchPaper[i].DateOfPublication);
            }
        }
        
    }
}
