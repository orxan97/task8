namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Group group1  = new Group(242,5);

            Student student1 = new Student("Nicat","Novruzzade",group1.GroupNumber);
            Student student2 = new Student("Hemid","Jamilli",group1.GroupNumber);
            Student student3 = new Student("Togrul","Hezizade",group1.GroupNumber);
            Student student4 = new Student("Mehemmed","Ismayilov",group1.GroupNumber);
            Student student5 = new Student("Orxan","Aslanov",group1.GroupNumber);
            

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddStudent(student4);
            group1.AddStudent(student5);


            group1.GetStudents();

        }
    }
}