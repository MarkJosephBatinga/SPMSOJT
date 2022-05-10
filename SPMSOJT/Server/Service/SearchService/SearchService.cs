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

        public async Task<List<Supervisor>> SearchSupervisor(Search search)
        {
            List<Supervisor> Supervisors = new List<Supervisor>();
            var dbSupervisors = await _data.supervisor_info.Where(s => s.last_name == search.SearchString).ToListAsync();
            if (dbSupervisors != null)
                Supervisors = dbSupervisors;
            return Supervisors;
        }
    }
}
