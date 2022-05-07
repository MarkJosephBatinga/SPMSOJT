using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.TaskService
{
    interface ITaskService
    {
        Task<List<Tasks>> AddTasks(Tasks task);

        Task<List<Tasks>> UpdateTasks(Tasks task);

        Task<List<Tasks>> DeleteTasks(Tasks task);

        Task<List<Tasks>> GetAllTasks();

        Task<Tasks> GetTasks(int Id);
    }
}
