using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.CoordinatorService
{
    public class CoordinatorService : ICoordinatorService
    {
        private readonly HttpClient _http;

        public CoordinatorService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Coordinator>> AddCoordinator(Coordinator coordinator)
        {
            var result = await _http.PostAsJsonAsync("api/coordinator/create", coordinator);
            var status = await result.Content.ReadFromJsonAsync<List<Coordinator>>();
            return status;
        }

        public async Task<List<Coordinator>> DeleteCoordinator(Coordinator coordinator)
        {
            var result = await _http.PostAsJsonAsync("api/coordinator/delete", coordinator);
            var status = await result.Content.ReadFromJsonAsync<List<Coordinator>>();
            return status;
        }

        public async Task<List<Coordinator>> GetAllCoordinator()
        {
            var result = await _http.GetFromJsonAsync<List<Coordinator>>($"api/organization/displayall");
            return result;
        }

        public async Task<Coordinator> GetCoordinator(int Id)
        {
            var result = await _http.GetFromJsonAsync<Coordinator>($"api/organization/display/{Id}");
            return result;
        }

        public async Task<List<Coordinator>> UpdateCoordinator(Coordinator coordinator)
        {
            var result = await _http.PostAsJsonAsync("api/coordinator/update", coordinator);
            var status = await result.Content.ReadFromJsonAsync<List<Coordinator>>();
            return status;
        }
    }
}
