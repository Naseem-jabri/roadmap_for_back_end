using Microsoft.EntityFrameworkCore;
using Task_Management_System.DTOs; 
using Task_Management_System.Model;
using Task_Management_System.data;

namespace Task_Management_System.Repository
{
    public class TaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskItem>> GetAllAsync(TaskQueryObject query)
        {
            var tasks = _context.Tasks.AsQueryable();

            // 1. الفلترة
            if (!string.IsNullOrEmpty(query.Priority))
                tasks = tasks.Where(t => t.Priority == query.Priority);

            // 2. الترتيب
            if (!string.IsNullOrEmpty(query.SortBy))
            {
                if (query.SortBy.ToLower() == "duedate")
                    tasks = query.IsDescending ? tasks.OrderByDescending(t => t.DueDate) : tasks.OrderBy(t => t.DueDate);
            }

            // 3. الترقيم
            var skipNumber = (query.PageNumber - 1) * query.PageSize;
            return await tasks.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<TaskItem> CreateAsync(CreateTaskDto taskDto)
        {
            // 1. تحويل الـ DTO إلى الـ Model (TaskItem)
            var taskModel = new TaskItem
            {
                Title = taskDto.Title,
                Priority = taskDto.Priority,
                DueDate = taskDto.DueDate
            };

            //Context
            await _context.Tasks.AddAsync(taskModel);

            // 3. حفظ التغييرات في قاعدة البيانات
            await _context.SaveChangesAsync();

            // 4. إرجاع المهمة التي تم إنشاؤها
            return taskModel;
        }
    }
}
