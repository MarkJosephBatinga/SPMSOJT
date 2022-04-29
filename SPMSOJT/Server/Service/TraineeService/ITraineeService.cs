using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.TraineeService
{
    public interface ITraineeService
    {
        Task<List<Trainee>> AddTrainee(Trainee trainee);

        Task<Trainee> GetTrainee(int traineeId);

        Task<List<Trainee>> UpdateTrainee(Trainee trainee);

        Task<List<Trainee>> RemoveTrainee(Trainee trainee);

        Task<List<Trainee>> LoadAllTrainees();
    }
}
