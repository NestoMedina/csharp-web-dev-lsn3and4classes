using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student newStudent = new Student();
            newStudent.studentName = "Ernesto";
            newStudent.Id = 004;
            newStudent.credits = 1;
            newStudent.gpa = 4.0;

            Course newCourse = new Course();
            newCourse.semester = "Fall";
            newCourse._professorsAndClass.Add("Roger", "C#");
            newCourse.AddDict("Julie", "C++");
            newCourse._roster.Add(newStudent.studentName);
            newCourse.ListCourses();

            Teacher newTeacher = new Teacher();
            newTeacher.First = "John";
            newTeacher.Last = "Doe";
            newTeacher.Subj = "English";
            newTeacher.Years = 9;





            
            

        }
    }
}
