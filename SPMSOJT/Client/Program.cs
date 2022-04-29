using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SPMSOJT.Client.Service.CoordinatorService;
using SPMSOJT.Client.Service.OrganizationService;
using SPMSOJT.Client.Service.SupervisorService;
using SPMSOJT.Client.Service.TraineeService;
using SPMSOJT.Client.Service.UserService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazoredToast();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddScoped<ICoordinatorService, CoordinatorService>();
            builder.Services.AddScoped<IOrganizationService, OrganizationService>();
            builder.Services.AddScoped<ISupervisorService, SupervisorService>();
            builder.Services.AddScoped<ITraineeService, TraineeService>();
            builder.Services.AddScoped<IUserService, UserService>();


            await builder.Build().RunAsync();
        }
    }
}
