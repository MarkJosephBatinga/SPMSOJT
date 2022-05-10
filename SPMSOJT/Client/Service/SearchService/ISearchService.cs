using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.SearchService
{
    interface ISearchService
    {
        Task<List<Supervisor>> SearchSupervisor(Search search);
        Task<List<User>> SearchUser(Search search);
        Task<List<Trainee>> SearchTrainee(Search search);
        Task<List<Organization>> SearchOrganization(Search search);
    }
}
