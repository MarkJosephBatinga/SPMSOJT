using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.CoordinatorService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {
        private readonly ICoordinatorService _coordinatorService;

        public CoordinatorController(ICoordinatorService coordinatorService)
        {
            _coordinatorService = coordinatorService;
        }

        List<Coordinator> Coordinators = new List<Coordinator>();
        Coordinator coordinator = new Coordinator();

        [HttpPost("create")]
        public async Task<ActionResult<List<Coordinator>>> AddCoordinator(Coordinator coordinator)
        {
            return Coordinators = await _coordinatorService.AddCoordinator(coordinator);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Coordinator>>> UpdateCoordinator(Coordinator coordinator)
        {
            return Coordinators = await _coordinatorService.UpdateCoordinator(coordinator);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Coordinator>>> DeleteCoordinator(Coordinator coordinator)
        {
            return Coordinators = await _coordinatorService.RemoveCoordinator(coordinator);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Coordinator>>> GetAllCoordinator()
        {
            return Coordinators = await _coordinatorService.LoadAllCoordinators();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Coordinator>> GetCoordinator(int Id)
        {
            return coordinator = await _coordinatorService.GetCoordinator(Id);
        }

    }
}
