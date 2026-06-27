using MyFirstProject;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace MyFirstProject
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public interface IPrintable
    {
        void prent();
    }

    public class student : Person, IPrintable
    {
        public double GPA { get; set; }
        public void prent()
        {
            Console.WriteLine($"student {Name}, GPA {GPA}");
        }

    }

    public class StudentManage
    {
        public static void runSystem()
        {
            student s = new student { Name = "sara", Age = 25, GPA = 4.50 };
            s.prent();
        }
    }
}