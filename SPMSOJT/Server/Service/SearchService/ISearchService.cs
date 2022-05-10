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
        Task<List<User>> SearchUser(Search search);
        Task<List<Trainee>> SearchTrainee(Search search);
        Task<List<Organization>> SearchOrganization(Search search);

        Task<List<Trainee>> SearchTraineePerSupervisor(Search search);
        Task<List<Tasks>> SearchTaskPerSupervisor(Search search);
        Task<List<CompiledTask>> SearchCompiledTaskPerSupervisor(Search search);

        Task<List<Tasks>> SearchTaskPerStudent(Search search);
        Task<List<CompiledTask>> SearchCompiledTaskPerStudent(Search search);
    }
}
