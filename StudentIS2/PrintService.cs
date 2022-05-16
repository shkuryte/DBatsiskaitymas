using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIS2
{
    public class PrintService
    {
        

        public readonly StudentIS2Context _context;
        public PrintService(StudentIS2Context context)
        {
            _context = context;

        }
               
        public List<Student> PrintStudents(Department department)
        {
            return department.Students.ToList();
        }

        public List<Lecture> PrintLectures(Department department)
        {
            return department.Lectures.ToList();
        }

       
        public void PrintStudentLectures()
        {
            return;
        }

    }
}
