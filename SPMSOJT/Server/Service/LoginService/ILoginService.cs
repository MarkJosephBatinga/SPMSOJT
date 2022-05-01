using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.LoginService
{
    public interface ILoginService
    {
        Task<Supervisor> LoginSupervisor(LoginToken LoginSupervisor);
        Task<User> LoginUser(LoginToken LoginUser);
        Task<Coordinator> LoginCoordinator(LoginToken LoginCoordinator);
    }
}
