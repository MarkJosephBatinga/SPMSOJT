using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.SearchService
{
    public interface ISearchService
    {
        Task<List<Supervisor>> SearchSupervisor(Search search);
    }
}
