namespace Task_Management_System.DTOs
{
    public class TaskQueryObject
    {

        public string? Priority { get; set; }

        //soting
        public string? SortBy { get; set; }
        public bool IsDescending { get; set; } = false; 

        //Pagination
        public int PageNumber { get; set; } = 1; 
        public int PageSize { get; set; } = 10; 
    
}
}
