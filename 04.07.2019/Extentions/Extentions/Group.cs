using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    public class Group
    {
        public string Name { get; set; }

        private Student[] students;

        private Student[] students1;

        //indexer
        public Student this[int i]
        {
            get
            {
                return students[i];
            }
            set
            {
                students[i] = value;
            }
        }

        public Group(string Name,int countStudent)
        {
            Name = Name;
            students = new Student[countStudent];
        }
    }
}
