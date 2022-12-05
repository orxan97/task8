using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task8
{


    internal class Group
    {
        public int GroupNumber;
        public byte Limit;
        public static Student[] Students;

        public Group(int groupNumber,byte limit)
        {
            GroupNumber = groupNumber;
            Limit = limit;
            Students = new Student[0];
        }

        public void AddStudent(Student student )
        {
            if (Students.Length<=Limit-1)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
        }

        public void GetStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"{item.Name}   {item.Surname} = {item.Group}");
            }
        }

    }
}
