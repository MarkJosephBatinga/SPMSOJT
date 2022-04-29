using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.CoordinatorService
{
    interface ICoordinatorService
    {
        Task<List<Coordinator>> AddCoordinator(Coordinator coordinator);

        Task<List<Coordinator>> UpdateCoordinator(Coordinator coordinator);

        Task<List<Coordinator>> DeleteCoordinator(Coordinator coordinator);

        Task<List<Coordinator>> GetAllCoordinator();

        Task<Coordinator> GetCoordinator(int Id);
    }
}
