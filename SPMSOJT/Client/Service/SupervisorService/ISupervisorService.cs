using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.SupervisorService
{
    interface ISupervisorService
    {
        Task<List<Supervisor>> AddSupervisor(Supervisor supervisor);

        Task<List<Supervisor>> UpdateSupervisor(Supervisor supervisor);

        Task<List<Supervisor>> DeleteSupervisor(Supervisor supervisor);

        Task<List<Supervisor>> GetAllSupervisor();

        Task<Supervisor> GetSupervisor(int Id);
    }
}
