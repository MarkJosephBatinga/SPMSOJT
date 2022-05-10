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
