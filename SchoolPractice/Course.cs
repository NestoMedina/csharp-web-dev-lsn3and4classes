using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public Dictionary<string, string> _professorsAndClass = new Dictionary<string, string>();
        private string _semester;
        public List<string> _roster = new List<string>();


        public string semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        public void AddDict(string name, string className)
        {
            _professorsAndClass.Add(name, className);
        }


        //Call methods
        public void ListCourses()
        {
            foreach(KeyValuePair<string, string> kvp in _professorsAndClass)
            {
                Console.WriteLine($"{kvp.Key} is teaching {kvp.Value} in the {_semester} semester.");
            }
            foreach(string name in _roster)
            {
                Console.WriteLine($"The students for this semester is/are {name}");
            }
        }

        public Course()
        {

        }

    }
}
