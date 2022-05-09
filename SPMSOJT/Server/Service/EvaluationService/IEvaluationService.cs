using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.EvaluationService
{
    public interface IEvaluationService
    {
        Task<List<Evaluation>> AddEvaluation(Evaluation evaluation);

        Task<Evaluation> GetEvaluation(int evaluationId);

        Task<Evaluation> GetEvaluationPerTrainee(int traineeId);

        Task<List<Evaluation>> UpdateEvaluation(Evaluation evaluation);

        Task<List<Evaluation>> RemoveEvaluation(Evaluation evaluation);

        Task<List<Evaluation>> LoadAllEvaluation();
    }
}
