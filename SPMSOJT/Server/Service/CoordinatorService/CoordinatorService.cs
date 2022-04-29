using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.CoordinatorService
{
    public class CoordinatorService : ICoordinatorService
    {
        private readonly DataContext _data;

        public CoordinatorService(DataContext data)
        {
            _data = data;
        }

        List<Coordinator> Coordinators = new List<Coordinator>();
        Coordinator coordinator = new Coordinator();

        public async Task<List<Coordinator>> AddCoordinator(Coordinator coordinator)
        {
            await _data.coordinator_info.AddAsync(coordinator);
            await _data.SaveChangesAsync();
            return Coordinators = await _data.coordinator_info.ToListAsync();
        }

        public async Task<Coordinator> GetCoordinator(int coordinatorId)
        {
            return coordinator = await _data.coordinator_info.Where(c => c.Id == coordinatorId).FirstOrDefaultAsync();
        }

        public async Task<List<Coordinator>> LoadAllCoordinators()
        {
            return Coordinators = await _data.coordinator_info.ToListAsync();
        }

        public async Task<List<Coordinator>> RemoveCoordinator(Coordinator coordinator)
        {
            _data.coordinator_info.Remove(coordinator);
            await _data.SaveChangesAsync();
            Coordinators = await _data.coordinator_info.ToListAsync();
            return Coordinators;
        }

        public async Task<List<Coordinator>> UpdateCoordinator(Coordinator coordinator)
        {
            Coordinators = await _data.coordinator_info.ToListAsync();
            var dbCoor = await _data.coordinator_info.FindAsync(coordinator.Id);
            if (dbCoor != null)
            {
                _data.Entry(dbCoor).CurrentValues.SetValues(coordinator);
                await _data.SaveChangesAsync();
            }
            return Coordinators;
        }
    }
}
