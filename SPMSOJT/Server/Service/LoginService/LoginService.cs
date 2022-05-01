using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.LoginService
{
    public class LoginService: ILoginService
    {
        private readonly DataContext _data;

        public LoginService(DataContext data)
        {
            _data = data;
        }

        User user = new User();
        Supervisor supervisor = new Supervisor();
        Coordinator coordinator = new Coordinator();

        public async Task<Coordinator> LoginCoordinator(LoginToken LoginCoordinator)
        {
            coordinator = await _data.coordinator_info.Where(c => c.email == LoginCoordinator.email 
            && c.password == LoginCoordinator.password).FirstOrDefaultAsync();
            if(coordinator == null)
            {
                return coordinator = new Coordinator();
            }
            else
            {
                return coordinator;
            }
        }

        public async Task<Supervisor> LoginSupervisor(LoginToken LoginSupervisor)
        {
            supervisor = await _data.supervisor_info.Where(s => s.email == LoginSupervisor.email
            && s.password == LoginSupervisor.password).FirstOrDefaultAsync();
            if (supervisor == null)
            {
                return supervisor = new Supervisor();
            }
            else
            {
                return supervisor;
            }
        }

        public async Task<User> LoginUser(LoginToken LoginUser)
        {
            user = await _data.user_info.Where(u => u.email == LoginUser.email
            && u.password == LoginUser.password).FirstOrDefaultAsync();
            if (user == null)
            {
                return user = new User();
            }
            else
            {
                return user;
            }
        }
    }
}
