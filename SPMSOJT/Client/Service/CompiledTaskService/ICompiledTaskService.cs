using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.CompiledTaskService
{
    interface ICompiledTaskService
    {
        Task<List<CompiledTask>> AddCompiledTask(CompiledTask compiledTask);

        Task<List<CompiledTask>> UpdateCompiledTask(CompiledTask compiledTask);

        Task<List<CompiledTask>> DeleteCompiledTask(CompiledTask compiledTask);

        Task<List<CompiledTask>> GetAllCompiledTask();

        Task<CompiledTask> GetCompiledTask(int Id);
    }
}
