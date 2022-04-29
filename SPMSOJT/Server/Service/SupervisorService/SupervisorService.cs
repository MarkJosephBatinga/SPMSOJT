using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.SupervisorService
{
    public class SupervisorService : ISupervisorService
    {

        private readonly DataContext _data;

        public SupervisorService(DataContext data)
        {
            _data = data;
        }

        List<Supervisor> Supervisors = new List<Supervisor>();
        Supervisor supervisor = new Supervisor();

        public async Task<List<Supervisor>> AddSupervisor(Supervisor supervisor)
        {
            await _data.supervisor_info.AddAsync(supervisor);
            await _data.SaveChangesAsync();
            return Supervisors = await _data.supervisor_info.ToListAsync();
        }

        public async Task<Supervisor> GetSupervisor(int supervisorId)
        {
            return supervisor = await _data.supervisor_info.Where(s => s.Id == supervisorId).FirstOrDefaultAsync();
        }

        public async Task<List<Supervisor>> LoadAllSupervisors()
        {
            return Supervisors = await _data.supervisor_info.ToListAsync();
        }

        public async Task<List<Supervisor>> RemoveSupervisor(Supervisor supervisor)
        {
            _data.supervisor_info.Remove(supervisor);
            await _data.SaveChangesAsync();
            Supervisors = await _data.supervisor_info.ToListAsync();
            return Supervisors;
        }

        public async Task<List<Supervisor>> UpdateSupervisor(Supervisor supervisor)
        {
            Supervisors = await _data.supervisor_info.ToListAsync();
            var dbSuper = await _data.supervisor_info.FindAsync(supervisor.Id);
            if (dbSuper != null)
            {
                _data.Entry(dbSuper).CurrentValues.SetValues(supervisor);
                await _data.SaveChangesAsync();
            }
            return Supervisors;
        }
    }
}
