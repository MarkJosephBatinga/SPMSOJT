using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.CoordinatorService
{
    public interface ICoordinatorService
    {
        Task<List<Coordinator>> AddCoordinator(Coordinator coordinator);

        Task<Coordinator> GetCoordinator(int coordinatorId);

        Task<List<Coordinator>> UpdateCoordinator(Coordinator coordinator);

        Task<List<Coordinator>> RemoveCoordinator(Coordinator coordinator);

        Task<List<Coordinator>> LoadAllCoordinators();
    }
}
