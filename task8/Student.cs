using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int Group;

        public Student(string name,string surname,int group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }
    }
}
