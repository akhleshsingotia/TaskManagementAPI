 
using TaskManagementAPI.Models;
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Repositories
{
    public interface ITaskRepository
    {
        Task GetById(int id);
        IEnumerable<Task> GetAll();
        void Add(Task task);
        void Update(Task task);
        void Delete(int id);
    }

    public class TaskRepository : ITaskRepository
    {
        private List<Task> _tasks = new List<Task>();

        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        void ITaskRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Task> ITaskRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Task ITaskRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ITaskRepository.Update(Task task)
        {
            throw new NotImplementedException();
        }

         
    }
}
