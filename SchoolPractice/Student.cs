using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name;
        private int _studentId;
        private int _numberOfCredits;
        private double _gpa;

        public string studentName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Id
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public int credits
        {
            get { return _numberOfCredits; }
            set { _numberOfCredits = value; }
        }

        public double gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Student()
        {

        }



    }
}
