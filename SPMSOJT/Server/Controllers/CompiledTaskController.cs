using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.CompiledTaskService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompiledTaskController : ControllerBase
    {
        private readonly ICompiledTaskService _compiledTaskService;

        public CompiledTaskController(ICompiledTaskService compiledTaskService)
        {
            _compiledTaskService = compiledTaskService;
        }

        List<CompiledTask> CompiledTasks = new List<CompiledTask>();
        CompiledTask compiledTask = new CompiledTask();

        [HttpPost("create")]
        public async Task<ActionResult<List<CompiledTask>>> AddTCompiledTask(CompiledTask compiledTask)
        {
            return CompiledTasks = await _compiledTaskService.AddCompiledTask(compiledTask);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<CompiledTask>>> UpdateCompiledTask(CompiledTask compiledTask)
        {
            return CompiledTasks = await _compiledTaskService.UpdateCompiledTask(compiledTask);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<CompiledTask>>> DeleteCompiledTask(CompiledTask compiledTask)
        {
            return CompiledTasks = await _compiledTaskService.RemoveCompiledTask(compiledTask);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<CompiledTask>>> GetAllCompiledTask()
        {
            return CompiledTasks = await _compiledTaskService.LoadAllCompiledTask();
        }

        [HttpGet("displayallpersupervisor/{Id:int}")]
        public async Task<ActionResult<List<CompiledTask>>> GetAllCompiledTaskPerSupervisor(int Id)
        {
            return CompiledTasks = await _compiledTaskService.LoadAllCompiledTaskPerSupervisor(Id);
        }

        [HttpGet("displayallperstudent/{Id:int}")]
        public async Task<ActionResult<List<CompiledTask>>> GetAllCompiledTaskPerStudent(int Id)
        {
            return CompiledTasks = await _compiledTaskService.LoadAllCompiledTaskPerStudent(Id);
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<CompiledTask>> GetCompiledTask(int Id)
        {
            return compiledTask = await _compiledTaskService.GetCompiledTask(Id);
        }
    }
}
