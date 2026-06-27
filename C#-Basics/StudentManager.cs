using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class StudentManager
    {
        public static void RunStudentSystem()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("نورة", 20, 3.8, "علوم حاسب"));
            students.Add(new Student("أحمد", 22, 3.5, "هندسة"));

            Console.WriteLine("list students :");
            foreach(Student s in students)
            {
                Console.WriteLine($"Name: {s.Name} | Major: {s.Major} | GPA: {s.GPA}");
            }


        }
    }
}
