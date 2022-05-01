using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.LoginService
{
    interface ILoginService
    {
        Task<Supervisor> LoginSupervisor(LoginToken LoginSupervisor);
        Task<User> LoginUser(LoginToken LoginUser);
        Task<Coordinator> LoginCoordinator(LoginToken LoginCoordinator);

    }
}
