using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIS2
{
    public class DepartamentService
    {
        public void CreateDepartment()
        {
            var context = new StudentIS2Context();
            var department = new Department() { Name = "Medicinos", };

            context.Departments.Add(department);
            context.SaveChanges();
        }

        public void CreateDepartmentFirstTask()
        {

            var context = new StudentIS2Context();
            var department = new Department()
            {
                Name = "Istorijos",
                Lectures = new List<Lecture>()
                {
                    new Lecture() { Name = "Lietuvos istorija"},
                    new Lecture() { Name = "Pasaulio istorija"},
                    
                },
                Students = new List<Student>()
                {
                    new Student() { Name = "Jonas", Surname = "Petrauskas"},
                    new Student() { Name = "Saulė", Surname = "Petrauskaitė" },
                }

            };

            context.Add(department);
            context.SaveChanges();
        }

        public void AddToDepartment(int id, Student student, Lecture lecture)
        {
            var context = new StudentIS2Context();
            var department = context.Departments.FirstOrDefault(d => d.Id == id);


            department.Students.Add(student);
            department.Lectures.Add(lecture);


            context.Departments.Update(department);
            context.SaveChanges();
        }

        public void AddLectureToDepartment(int id, Lecture newLecture)
        {

            var context = new StudentIS2Context();
            var department = context.Departments.FirstOrDefault(d => d.Id == id);


            department.Lectures.Add(newLecture);
            context.Departments.Update(department);
            context.SaveChanges();
        }


        public void AddStudentToDepartment(int id, Student newStudent)
        {

            var context = new StudentIS2Context();
            var department = context.Departments.FirstOrDefault(d => d.Id == id);


            department.Students.Add(newStudent);
            context.Departments.Update(department);
            context.SaveChanges();
        }

        public void MoveStudent(int id, Student movingStudent)
        {

            var context = new StudentIS2Context();
            var department = context.Departments.FirstOrDefault(d => d.Id == id);


            department.Students.Add(movingStudent);
            context.Departments.Update(department);
            context.SaveChanges();
        }

        
    }
}
