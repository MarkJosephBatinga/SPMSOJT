using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.EvaluationService
{
    public class EvaluationService : IEvaluationService
    {
        private readonly DataContext _data;

        public EvaluationService(DataContext data)
        {
            _data = data;
        }

        List<Evaluation> Evaluations = new List<Evaluation>();
        Evaluation evaluation = new Evaluation();

        public async Task<List<Evaluation>> AddEvaluation(Evaluation evaluation)
        {
            await _data.evaluation_info.AddAsync(evaluation);
            await _data.SaveChangesAsync();
            return Evaluations = await _data.evaluation_info.ToListAsync();
        }

        public async Task<Evaluation> GetEvaluation(int evaluationId)
        {
            return evaluation = await _data.evaluation_info.Where(e => e.Id == evaluationId).FirstOrDefaultAsync();
        }

        public async Task<List<Evaluation>> LoadAllEvaluation()
        {
            return Evaluations = await _data.evaluation_info.ToListAsync();
        }

        public async Task<List<Evaluation>> RemoveEvaluation(Evaluation evaluation)
        {
            _data.evaluation_info.Remove(evaluation);
            await _data.SaveChangesAsync();
            Evaluations = await _data.evaluation_info.ToListAsync();
            return Evaluations;
        }

        public async Task<List<Evaluation>> UpdateEvaluation(Evaluation evaluation)
        {
            Evaluations = await _data.evaluation_info.ToListAsync();
            var dbEval = await _data.evaluation_info.FindAsync(evaluation.Id);
            if (dbEval != null)
            {
                _data.Entry(dbEval).CurrentValues.SetValues(evaluation);
                await _data.SaveChangesAsync();
            }
            return Evaluations;
        }

        public async Task<Evaluation> GetEvaluationPerTrainee(int traineeId)
        {
            var dbEval = await _data.evaluation_info.Where(e => e.TraineeId == traineeId).FirstOrDefaultAsync();
            if(dbEval != null)
            {
                evaluation = dbEval;
            }
            return evaluation;
        }
    }
}
