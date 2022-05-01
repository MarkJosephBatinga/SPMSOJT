using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.LoginService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        User user = new User();
        Supervisor supervisor = new Supervisor();
        Coordinator coordinator = new Coordinator();

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("user")]
        public async Task<ActionResult<User>> LoginAsUser(LoginToken LoginUser)
        {
            return user = await _loginService.LoginUser(LoginUser);
        }

        [HttpPost("supervisor")]
        public async Task<ActionResult<Supervisor>> LoginAsSupervisor(LoginToken LoginSupervisor)
        {
            return supervisor = await _loginService.LoginSupervisor(LoginSupervisor);
        }

        [HttpPost("coordinator")]
        public async Task<ActionResult<Coordinator>> LoginAsCoordinator(LoginToken LoginCoordinator)
        {
            return coordinator = await _loginService.LoginCoordinator(LoginCoordinator);
        }

        [HttpGet("user/{email}")]
        public async Task<ActionResult<User>> GetUser(string email)
        {
            return user = await _loginService.GetUser(email);
        }

        [HttpGet("coordinator/{email}")]
        public async Task<ActionResult<Coordinator>> GetCoordinator(string email)
        {
            return coordinator = await _loginService.GetCoordinator(email);
        }

        [HttpGet("supervisor/{email}")]
        public async Task<ActionResult<Supervisor>> GetSupervisor(string email)
        {
            return supervisor = await _loginService.GetSupervisor(email);
        }
    }
}
