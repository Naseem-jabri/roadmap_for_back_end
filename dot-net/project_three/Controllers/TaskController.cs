using Microsoft.AspNetCore.Mvc;
using Task_Management_System.DTOs;
using Task_Management_System.Repository;

namespace Task_Management_System.Controllers
{

    [Route("api/tasks")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly TaskRepository _repo;

        public TaskController(TaskRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] TaskQueryObject query)
        {
            var tasks = await _repo.GetAllAsync(query);
            return Ok(tasks);
        }

        [HttpPost] 
        public async Task<IActionResult> Create([FromBody] CreateTaskDto taskDto)
        {
            var newTask = await _repo.CreateAsync(taskDto);
            return Ok("Task created successfully"); 
        }
    }
}
