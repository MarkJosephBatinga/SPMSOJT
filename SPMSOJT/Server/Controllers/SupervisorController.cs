using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.SupervisorService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorController : ControllerBase
    {
        private readonly ISupervisorService _supervisorService;

        public SupervisorController(ISupervisorService supervisorService)
        {
            _supervisorService = supervisorService;
        }

        List<Supervisor> Supervisors = new List<Supervisor>();
        Supervisor supervisor = new Supervisor();

        [HttpPost("create")]
        public async Task<ActionResult<List<Supervisor>>> AddSupervisor(Supervisor supervisor)
        {
            return Supervisors = await _supervisorService.AddSupervisor(supervisor);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Supervisor>>> UpdateSupervisor(Supervisor supervisor)
        {
            return Supervisors = await _supervisorService.UpdateSupervisor(supervisor);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Supervisor>>> DeleteSupervisor(Supervisor supervisor)
        {
            return Supervisors = await _supervisorService.RemoveSupervisor(supervisor);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Supervisor>>> GetAllSupervisor()
        {
            return Supervisors = await _supervisorService.LoadAllSupervisors();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Supervisor>> GetSupervisor(int Id)
        {
            return supervisor = await _supervisorService.GetSupervisor(Id);
        }
    }
}
