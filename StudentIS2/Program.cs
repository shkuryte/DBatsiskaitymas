// See https://aka.ms/new-console-template for more information


using StudentIS2;

/*DepartamentService departament = new DepartamentService();
departament.CreateDepartment();*/

/*Lecture lecture = new Lecture() { Name = "Kazkokia Nauja Paskaita" };

LectureService newLecture = new LectureService();
newLecture.CreateLecture(lecture);*/

/*StudentService student = new StudentService();
student.CreateStudent();*/

// ***** 2 UŽDUOTIS ***** //

/*DepartamentService departament = new DepartamentService();
departament.CreateDepartmentFirstTask();*/

// ***** 2 UŽDUOTIS ***** //

/*var context = new StudentIS2Context();
*//*Student newStudent = new Student() { Name = "Marija", Surname = "Riaubiškytė" };
Lecture newLecture = new Lecture() { Name = "Anatomija" };*/
/*var lecture = context.Lectures.FirstOrDefault(l => l.Name == "Fiziologija");*//*

// -> bandant prie departameto pridėti egzistuojančią paskaitą ir studentą meta 'possible null' klaidą

var student = context.Students.FirstOrDefault(s => s.Surname == "Jaunius");

var lecture = context.Lectures.FirstOrDefault(l => l.Name == "Studijų įvadas");

DepartamentService departament = new DepartamentService();
departament.AddToDepartment(2, student, lecture);*/


// ***** 3 UŽDUOTIS ***** //

/*var context = new StudentIS2Context();
Lecture newLecture = new Lecture() { Name = "Elektronika" };


DepartamentService department = new DepartamentService();
department.AddLectureToDepartment(2, lecture);*/

// ***** 4 UŽDUOTIS ***** //

/*Student newStudent = new Student() { Name = "Joris", Surname = "Petraitis" };

DepartamentService departament = new DepartamentService();
departament.AddStudentToDepartment(2, newStudent);*/




/*var context = new StudentIS2Context();
var movingStudent = context.Students.FirstOrDefault(s => s.Surname == "Tamasauskas");

DepartamentService departament = new DepartamentService();
departament.MoveStudent(1, movingStudent);*/

// ***** 6 UŽDUOTIS ***** //


var context = new StudentIS2Context();
var printService = new PrintService(context);

var department = context.Departments.FirstOrDefault(d => d.Name == "Fizikos");

var studentList = printService.PrintStudents(department);

foreach (var item in studentList)
{
    Console.WriteLine($"Departamento {department} studentų sąrašas: {item.Name} {item.Surname}");
}







