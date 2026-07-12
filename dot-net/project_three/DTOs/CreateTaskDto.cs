using System;

namespace Task_Management_System.DTOs
{
    public class CreateTaskDto
    {
        public string Title { get; set; }
        public string Priority { get; set; } 
        public DateTime DueDate { get; set; }
    }
}
    