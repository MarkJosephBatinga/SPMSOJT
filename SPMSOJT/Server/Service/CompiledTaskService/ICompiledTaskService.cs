using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.CompiledTaskService
{
    public interface ICompiledTaskService
    {
        Task<List<CompiledTask>> AddCompiledTask(CompiledTask compiledTask);

        Task<CompiledTask> GetCompiledTask(int compiledTaskId);

        Task<List<CompiledTask>> UpdateCompiledTask(CompiledTask compiledTask);

        Task<List<CompiledTask>> RemoveCompiledTask(CompiledTask compiledTask);

        Task<List<CompiledTask>> LoadAllCompiledTask();

        Task<List<CompiledTask>> LoadAllCompiledTaskPerSupervisor(int supervisorId);

        Task<List<CompiledTask>> LoadAllCompiledTaskPerStudent(int studentId);
    }
}
