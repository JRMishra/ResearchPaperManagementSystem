using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchPaperManagementSystem
{
    [Serializable]
    public class ResearchPaper
    {
        int _id;
        string _author;
        string _title;
        string _department;
        string _dateOfPublication;

        public int Id { get => _id; set => _id = value; }
        public string Author { get => _author; set => _author = value; }
        public string Title { get => _title; set => _title = value; }
        public string Department { get => _department; set => _department = value; }
        public string DateOfPublication { get => _dateOfPublication; set => _dateOfPublication = value; }
    }
}
