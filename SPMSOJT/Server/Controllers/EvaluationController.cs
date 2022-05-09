using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.EvaluationService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationController : ControllerBase
    {
        private readonly IEvaluationService _evaluationService;

        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        List<Evaluation> Evaluations = new List<Evaluation>();
        Evaluation evaluation = new Evaluation();

        [HttpPost("create")]
        public async Task<ActionResult<List<Evaluation>>> AddEvaluation(Evaluation evaluation)
        {
            return Evaluations = await _evaluationService.AddEvaluation(evaluation);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Evaluation>>> UpdateEvaluation(Evaluation evaluation)
        {
            return Evaluations = await _evaluationService.UpdateEvaluation(evaluation);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Evaluation>>> DeleteEvaluation(Evaluation evaluation)
        {
            return Evaluations = await _evaluationService.RemoveEvaluation(evaluation);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Evaluation>>> GetAllEvaluation()
        {
            return Evaluations = await _evaluationService.LoadAllEvaluation();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Evaluation>> GetEvaluation(int Id)
        {
            return evaluation = await _evaluationService.GetEvaluation(Id);
        }

        [HttpGet("displaypertrainee/{Id:int}")]
        public async Task<ActionResult<Evaluation>> GetEvaluationPerTrainee(int Id)
        {
            return evaluation = await _evaluationService.GetEvaluationPerTrainee(Id);
        }
    }
}
