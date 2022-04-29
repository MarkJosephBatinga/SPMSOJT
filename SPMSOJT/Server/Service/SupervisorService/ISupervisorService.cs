using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.SupervisorService
{
    public interface ISupervisorService
    {
        Task<List<Supervisor>> AddSupervisor(Supervisor supervisor);

        Task<Supervisor> GetSupervisor(int supervisorId);

        Task<List<Supervisor>> UpdateSupervisor(Supervisor supervisor);

        Task<List<Supervisor>> RemoveSupervisor(Supervisor supervisor);

        Task<List<Supervisor>> LoadAllSupervisors();
    }
}
