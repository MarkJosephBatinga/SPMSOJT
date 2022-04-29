using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.TraineeService
{
    public class TraineeService : ITraineeService
    {

        private readonly DataContext _data;

        public TraineeService(DataContext data)
        {
            _data = data;
        }

        List<Trainee> Trainees = new List<Trainee>();
        Trainee trainee = new Trainee();

        public async Task<List<Trainee>> AddTrainee(Trainee trainee)
        {
            await _data.trainee_info.AddAsync(trainee);
            await _data.SaveChangesAsync();
            return Trainees = await _data.trainee_info.ToListAsync();
        }

        public async Task<Trainee> GetTrainee(int traineeId)
        {
            return trainee = await _data.trainee_info.Where(t => t.Id == traineeId).FirstOrDefaultAsync();
        }

        public async Task<List<Trainee>> LoadAllTrainees()
        {
            return Trainees = await _data.trainee_info.ToListAsync();
        }

        public async Task<List<Trainee>> RemoveTrainee(Trainee trainee)
        {
            _data.trainee_info.Remove(trainee);
            await _data.SaveChangesAsync();
            Trainees = await _data.trainee_info.ToListAsync();
            return Trainees;
        }

        public async Task<List<Trainee>> UpdateTrainee(Trainee trainee)
        {
            Trainees = await _data.trainee_info.ToListAsync();
            var dbTrain = await _data.trainee_info.FindAsync(trainee.Id);
            if (dbTrain != null)
            {
                _data.Entry(dbTrain).CurrentValues.SetValues(trainee);
                await _data.SaveChangesAsync();
            }
            return Trainees;
        }
    }
}
