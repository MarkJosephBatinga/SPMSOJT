using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.TraineeService
{
    public class TraineeService : ITraineeService
    {
        private readonly HttpClient _http;

        public TraineeService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Trainee>> AddTrainee(Trainee trainee)
        {
            var result = await _http.PostAsJsonAsync("api/trainee/create", trainee);
            var status = await result.Content.ReadFromJsonAsync<List<Trainee>>();
            return status;
        }

        public async Task<List<Trainee>> DeleteTrainee(Trainee trainee)
        {
            var result = await _http.PostAsJsonAsync("api/trainee/delete", trainee);
            var status = await result.Content.ReadFromJsonAsync<List<Trainee>>();
            return status;
        }

        public async Task<List<Trainee>> GetAllTrainee()
        {
            var result = await _http.GetFromJsonAsync<List<Trainee>>($"api/trainee/displayall");
            return result;
        }

        public async Task<Trainee> GetTrainee(int Id)
        {
            var result = await _http.GetFromJsonAsync<Trainee>($"api/trainee/display/{Id}");
            return result;
        }

        public async Task<List<Trainee>> UpdateTrainee(Trainee trainee)
        {
            var result = await _http.PostAsJsonAsync("api/trainee/update", trainee);
            var status = await result.Content.ReadFromJsonAsync<List<Trainee>>();
            return status;
        }
    }
}
