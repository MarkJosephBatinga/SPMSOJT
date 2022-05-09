using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.TasksService
{
    public interface ITaskService
    {
        Task<List<Tasks>> AddTasks(Tasks task);

        Task<Tasks> GetTasks(int taskId);

        Task<List<Tasks>> UpdateTasks(Tasks task);

        Task<List<Tasks>> RemoveTasks(Tasks task);

        Task<List<Tasks>> LoadAllTasks();

        Task<List<Tasks>> LoadAllNotComplyTask(int userId);

        Task<List<Tasks>> LoadAllTaskPerSupervisor(int supervisorId);

        Task<List<Tasks>> LoadAllTaskPerStudent(int studentId);
    }
}
