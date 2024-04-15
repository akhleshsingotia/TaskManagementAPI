using NUnit.Framework;
using Moq;
using TaskManagementAPI.Services;
using TaskManagementAPI.Models;
using TaskManagementAPI.Repositories;
using Microsoft.AspNetCore.Routing;
using TaskManagementAPI.Repositories;
using TaskManagementAPI.Services;
using Task = TaskManagementAPI.Models.Task;

namespace TaskManagementAPI.Tests
{
    public class TaskServiceTests
    {
        [Test]
        public void AddTask_ValidTask_TaskAddedSuccessfully()
        {
            // Arrange
            var mockRepository = new Mock<ITaskRepository>();
            var taskService = new TaskService(mockRepository.Object);
            var task = new Task { Name = "Test Task", Description = "This is a test task", Deadline = DateTime.Now };

            // Act
            taskService.AddTask(task);

            // Assert
            mockRepository.Verify(r => r.Add(task), Times.Once);
        }

        // Add more tests for other service methods
    }
}
