using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ResearchPaperManagementSystem
{
    class Program
    {
        public static ResearchPaper rPaper = new ResearchPaper();
        public static AllResearchPaper allResPaper = new AllResearchPaper();

        static void Main(string[] args)
        {
            Console.WriteLine("This program is to store and maintain info related to resesrch publications");
            bool flag = true;
            
            while(flag)
            {
                Console.WriteLine("Enter\n1. Add publication\n2.Get All Paper Details\n0. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddResearchPaperDetails();
                        break;
                    case 2:
                        GetAllPaperDetails();
                        break;
                    case 0:
                        Console.WriteLine("Thanks For Using");
                        flag = false;
                        break;
                }    
            }

            return;
        }

        public static void AddResearchPaperDetails()
        {
            try
            {
                XmlDeserializationPaper(ref allResPaper);
            }
            catch(Exception ex)
            {
                Console.WriteLine("1st Entry "+ex.Message);
            }
            

            Console.WriteLine("Add ID, Author Name, Publication Title, Department, Date of Publication");
            ResearchPaper rPaper = new ResearchPaper();

            rPaper.Id = int.Parse(Console.ReadLine());
            rPaper.Author = Console.ReadLine();
            rPaper.Title = Console.ReadLine();
            rPaper.Department = Console.ReadLine();
            rPaper.DateOfPublication = Console.ReadLine();
            
            allResPaper.AddPaper(rPaper);


            XMLSerializationPaper(ref allResPaper);

        }

        public static void GetAllPaperDetails()
        {
             
            Console.WriteLine("ID\tAuthor\tPaper Title\tDepartment\tPublication Date");

            XmlDeserializationPaper(ref allResPaper);

            allResPaper.GetResearchPapers();
            /*
            Console.WriteLine(rPaper.Id + "\t" + rPaper.Author + "\t" + rPaper.Title + "\t" + rPaper.Department + "\t" + rPaper.DateOfPublication);
            */
            return;
        }

        public static void XmlDeserializationPaper(ref AllResearchPaper allresPaper)
        {
            //Console.WriteLine("Using Deserialization");
            XmlSerializer xsObj = new XmlSerializer(typeof(AllResearchPaper));
            FileStream fsObj = new FileStream("AllResearchPaperInfo.xml", FileMode.Open, FileAccess.Read);

            allResPaper = xsObj.Deserialize(fsObj) as AllResearchPaper;
            fsObj.Close();

        }

        public static void XMLSerializationPaper(ref AllResearchPaper allresPaper)
        {
            //Console.WriteLine("Saving Employee Details using XML serialization");
            
            XmlSerializer xsObj = new XmlSerializer(typeof(AllResearchPaper));
            FileStream fsObj = new FileStream("AllResearchPaperInfo.xml", FileMode.Create, FileAccess.Write);
            xsObj.Serialize(fsObj, allResPaper);

            fsObj.Close();
        }

    }
}
