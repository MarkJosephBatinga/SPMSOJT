using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.EvaluationService
{
    interface IEvaluationService
    {
        Task<List<Evaluation>> AddEvaluation(Evaluation evaluation);

        Task<List<Evaluation>> UpdateEvaluation(Evaluation evaluation);

        Task<List<Evaluation>> DeleteEvaluation(Evaluation evaluation);

        Task<List<Evaluation>> GetAllEvaluation();

        Task<Evaluation> GetEvaluation(int Id);

        Task<Evaluation> GetEvaluationPerTrainee(int Id);
    }
}
