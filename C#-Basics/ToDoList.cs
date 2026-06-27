using System;
using System.Collections.Generic;


namespace MyFirstProject
{
    public class ToDoList
    {
        static List<String> todolist = new List<string>();
        public static void RunList()
        {
            string choice = "";
            while (choice != "4")
            {
                Console.WriteLine("1. Add Task | 2. View Tasks | 3. Remove  | 4. Exit ");
                choice = Console.ReadLine();

                if (choice == "1") AddTask();
                else if (choice == "2") ShowTasks();
                else if (choice == "3") RemoveTask();
            }

        }

    static void AddTask()
        {
            Console.WriteLine("write the task:");
            string task = Console.ReadLine();
            todolist.Add(task);
            Console.WriteLine("done");
        }

    static void ShowTasks()
        {
          Console.WriteLine("your tasks: ");
            foreach (var task in todolist) 
            {
                Console.WriteLine(task);
            }
        }

        static void RemoveTask()
        {
            Console.WriteLine("what the task is remove");
            string retask = Console.ReadLine();

            if (todolist.Contains(retask))
            {
                todolist.Remove(retask);
                Console.WriteLine("done");
            }
            else
            {
                Console.WriteLine("This task does not exist in your list");
            }
        }
    }
}