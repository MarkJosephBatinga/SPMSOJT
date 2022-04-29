using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.TraineeService
{
    interface ITraineeService
    {

        Task<List<Trainee>> AddTrainee(Trainee trainee);

        Task<List<Trainee>> UpdateTrainee(Trainee trainee);

        Task<List<Trainee>> DeleteTrainee(Trainee trainee);

        Task<List<Trainee>> GetAllTrainee();

        Task<Trainee> GetTrainee(int Id);
    }
}
