 
using TaskManagementAPI.Repositories;
using TaskManagementAPI.Models;
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddTask(Task task)
        {
            _taskRepository.Add(task);
        }

        // Implement other service methods
    }
}
