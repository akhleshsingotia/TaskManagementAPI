using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Services;
using TaskManagementAPI.Models; 
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public IActionResult AddTask(Task task)
        {
            _taskService.AddTask(task);
            return Ok();
        }

        // Implement other controller actions
    }
}
