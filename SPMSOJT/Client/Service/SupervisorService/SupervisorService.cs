using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.SupervisorService
{
    public class SupervisorService : ISupervisorService
    {
        private readonly HttpClient _http;

        public SupervisorService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Supervisor>> AddSupervisor(Supervisor supervisor)
        {
            var result = await _http.PostAsJsonAsync("api/supervisor/create", supervisor);
            var status = await result.Content.ReadFromJsonAsync<List<Supervisor>>();
            return status;
        }

        public async Task<List<Supervisor>> DeleteSupervisor(Supervisor supervisor)
        {
            var result = await _http.PostAsJsonAsync("api/supervisor/delete", supervisor);
            var status = await result.Content.ReadFromJsonAsync<List<Supervisor>>();
            return status;
        }

        public async Task<List<Supervisor>> GetAllSupervisor()
        {
            var result = await _http.GetFromJsonAsync<List<Supervisor>>($"api/supervisor/displayall");
            return result;
        }

        public async Task<Supervisor> GetSupervisor(int Id)
        {
            var result = await _http.GetFromJsonAsync<Supervisor>($"api/supervisor/display/{Id}");
            return result;
        }

        public async Task<List<Supervisor>> UpdateSupervisor(Supervisor supervisor)
        {
            var result = await _http.PostAsJsonAsync("api/supervisor/update", supervisor);
            var status = await result.Content.ReadFromJsonAsync<List<Supervisor>>();
            return status;
        }
    }
}
