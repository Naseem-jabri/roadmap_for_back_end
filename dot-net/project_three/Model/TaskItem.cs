namespace Task_Management_System.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }           
        public string Priority { get; set; }       
        public DateTime DueDate { get; set; }     
        public bool IsCompleted { get; set; }
    }
}
