using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.TraineeService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService _traineeService;

        public TraineeController(ITraineeService traineeService)
        {
            _traineeService = traineeService;
        }

        List<Trainee> Trainees = new List<Trainee>();
        Trainee trainee = new Trainee();

        [HttpPost("create")]
        public async Task<ActionResult<List<Trainee>>> AddTrainee(Trainee trainee)
        {
            return Trainees = await _traineeService.AddTrainee(trainee);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Trainee>>> UpdateTrainee(Trainee trainee)
        {
            return Trainees = await _traineeService.UpdateTrainee(trainee);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Trainee>>> DeleteTrainee(Trainee trainee)
        {
            return Trainees = await _traineeService.RemoveTrainee(trainee);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Trainee>>> GetAllTrainee()
        {
            return Trainees = await _traineeService.LoadAllTrainees();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Trainee>> GetTrainee(int Id)
        {
            return trainee = await _traineeService.GetTrainee(Id);
        }
    }
}
