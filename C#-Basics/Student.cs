using System;

namespace MyFirstProject
{
    public class Student
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public string Major {  get; set; }


        public Student(string name, int age, double gpa , string major)
        {
            Name = name;
            Age = age;
            GPA = gpa;
            Major = major;
        }

    }
}
