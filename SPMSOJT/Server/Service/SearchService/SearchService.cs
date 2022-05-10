using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.SearchService
{
    public class SearchService : ISearchService
    {
        private readonly DataContext _data;

        public SearchService(DataContext data)
        {
            _data = data;
        }

        public async Task<List<CompiledTask>> SearchCompiledTaskPerStudent(Search search)
        {
            List<CompiledTask> CompiledTasks = new List<CompiledTask>();
            var dbTasks = await _data.task_info.Where(s => s.TaskCode == search.SearchString).ToListAsync();
            if (dbTasks != null)
            {
                foreach (var task in dbTasks)
                {
                    var dbCompiledTask = await _data.c_task_info.Where(c => c.TaskId == task.Id && c.StudentId == search.StudentId).FirstOrDefaultAsync();
                    if (dbCompiledTask != null)
                    {
                        CompiledTasks.Add(dbCompiledTask);
                    }
                }
            }
            return CompiledTasks;
        }

        public async Task<List<CompiledTask>> SearchCompiledTaskPerSupervisor(Search search)
        {
            List<CompiledTask> CompiledTasks = new List<CompiledTask>();
            var dbTasks = await _data.task_info.Where(s => s.TaskCode == search.SearchString && s.SupervisorId == search.SupervisorId).ToListAsync();
            if (dbTasks != null)
            {
                foreach (var task in dbTasks)
                {
                    var dbCompiledTask = await _data.c_task_info.Where(c => c.TaskId == task.Id).FirstOrDefaultAsync();
                    if(dbCompiledTask != null)
                    {
                        CompiledTasks.Add(dbCompiledTask);
                    }
                }
            }
            return CompiledTasks;
        }

        public async Task<List<Organization>> SearchOrganization(Search search)
        {
            List<Organization> Organizations = new List<Organization>();
            var dbOrgs = await _data.organization_info.Where(o => o.org_name == search.SearchString).ToListAsync();
            if (dbOrgs != null)
                Organizations = dbOrgs;
            return Organizations;
        }

        public async Task<List<Supervisor>> SearchSupervisor(Search search)
        {
            List<Supervisor> Supervisors = new List<Supervisor>();
            var dbSupervisors = await _data.supervisor_info.Where(s => s.last_name == search.SearchString).ToListAsync();
            if (dbSupervisors != null)
                Supervisors = dbSupervisors;
            return Supervisors;
        }

        public async Task<List<Tasks>> SearchTaskPerStudent(Search search)
        {
            List<Tasks> AllTask = new List<Tasks>();
            var dbTrainee = await _data.trainee_info.Where(t => t.studentId == search.StudentId).FirstOrDefaultAsync();
            var dbTasks = await _data.task_info.Where(s => s.TaskCode == search.SearchString && s.SupervisorId == dbTrainee.supervisorId).ToListAsync();
            if (dbTasks != null)
                AllTask = dbTasks;
            return AllTask;
        }

        public async Task<List<Tasks>> SearchTaskPerSupervisor(Search search)
        {
            List<Tasks> AllTask = new List<Tasks>();
            var dbTasks = await _data.task_info.Where(s => s.TaskCode == search.SearchString && s.SupervisorId == search.SupervisorId).ToListAsync();
            if (dbTasks != null)
                AllTask = dbTasks;
            return AllTask;
        }

        public async Task<List<Trainee>> SearchTrainee(Search search)
        {
            List<Trainee> Trainees = new List<Trainee>();
            var dbUsers = await _data.user_info.Where(u => u.last_name == search.SearchString).ToListAsync();
            if(dbUsers != null)
            {
                foreach (var student in dbUsers)
                {
                    var dbTrainee = await _data.trainee_info.Where(t => t.studentId == student.Id).FirstOrDefaultAsync();
                    if (dbTrainee.Id != 0)
                    {
                        Trainees.Add(dbTrainee);
                    }
                }
            }
            return Trainees;
        }

        public async Task<List<Trainee>> SearchTraineePerSupervisor(Search search)
        {
            List<Trainee> Trainees = new List<Trainee>();
            var dbUsers = await _data.user_info.Where(u => u.last_name == search.SearchString).ToListAsync();
            if (dbUsers != null)
            {
                foreach (var student in dbUsers)
                {
                    var dbTrainee = await _data.trainee_info.Where(t => t.studentId == student.Id && t.supervisorId == search.SupervisorId).FirstOrDefaultAsync();
                    if (dbTrainee != null)
                    {
                        Trainees.Add(dbTrainee);
                    }
                }
            }
            return Trainees;
        }

        public async Task<List<User>> SearchUser(Search search)
        {
            List<User> Users = new List<User>();
            var dbUsers = await _data.user_info.Where(u => u.last_name == search.SearchString).ToListAsync();
            if (dbUsers != null)
                Users = dbUsers;
            return Users;
        }
    }
}
