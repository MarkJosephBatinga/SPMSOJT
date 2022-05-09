using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.CompiledTaskService
{
    public class CompiledTaskService : ICompiledTaskService
    {
        private readonly DataContext _data;

        public CompiledTaskService(DataContext data)
        {
            _data = data;
        }

        List<CompiledTask> CompiledTasks = new List<CompiledTask>();
        CompiledTask compiledTask = new CompiledTask();

        public async Task<List<CompiledTask>> AddCompiledTask(CompiledTask compiledTask)
        {
            await _data.c_task_info.AddAsync(compiledTask);
            await _data.SaveChangesAsync();
            return CompiledTasks = await _data.c_task_info.ToListAsync();
        }

        public async Task<CompiledTask> GetCompiledTask(int compiledTaskId)
        {
            return compiledTask = await _data.c_task_info.Where(c => c.Id == compiledTaskId).FirstOrDefaultAsync();
        }

        public async Task<List<CompiledTask>> LoadAllCompiledTask()
        {
            return CompiledTasks = await _data.c_task_info.ToListAsync();
        }

        public async Task<List<CompiledTask>> RemoveCompiledTask(CompiledTask compiledTask)
        {
            _data.c_task_info.Remove(compiledTask);
            await _data.SaveChangesAsync();
            CompiledTasks = await _data.c_task_info.ToListAsync();
            return CompiledTasks;
        }

        public async Task<List<CompiledTask>> UpdateCompiledTask(CompiledTask compiledTask)
        {
            CompiledTasks = await _data.c_task_info.ToListAsync();
            var dbCompiled = await _data.c_task_info.FindAsync(compiledTask.Id);
            if (dbCompiled != null)
            {
                _data.Entry(dbCompiled).CurrentValues.SetValues(compiledTask);
                await _data.SaveChangesAsync();
            }
            return CompiledTasks;
        }

        public async Task<List<CompiledTask>> LoadAllCompiledTaskPerSupervisor(int supervisorId)
        {
            var dbAllTask = await _data.task_info.Where(t => t.SupervisorId == supervisorId).ToListAsync();
            foreach (var task in dbAllTask)
            {
                var cTask = await _data.c_task_info.Where(c => c.TaskId == task.Id).ToListAsync();
                if(cTask != null)
                {
                    CompiledTasks.AddRange(cTask);
                }
            }
            return CompiledTasks;
        }

        public async Task<List<CompiledTask>> LoadAllCompiledTaskPerStudent(int studentId)
        {
            return CompiledTasks = await _data.c_task_info.Where(c => c.StudentId == studentId).ToListAsync();
        }

        //get the task id
        //find if task id is in the compiled task
        //get the task
    }
}
