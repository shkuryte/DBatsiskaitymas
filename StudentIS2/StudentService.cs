using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIS2
{
    public class StudentService
    {
        public void CreateStudent()
        {
            var context = new StudentIS2Context();
            var student = new Student() { Name = "Tomas", Surname = "Tamasauskas", };

            context.Students.Add(student);
            context.SaveChanges();
        }

        /*public void PrintStudents()
        {
            var context = new StudentIS2Context();
            Student student = null;
            var studService = new StudService(context);
            var records = studService.GetStudentRecords(student);
            foreach (var item in records)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
        }*/
    }
}
