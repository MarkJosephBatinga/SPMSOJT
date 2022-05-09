using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.EvaluationService
{
    public class EvaluationService : IEvaluationService
    {
        private readonly HttpClient _http;

        public EvaluationService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Evaluation>> AddEvaluation(Evaluation evaluation)
        {
            var result = await _http.PostAsJsonAsync("api/evaluation/create", evaluation);
            var status = await result.Content.ReadFromJsonAsync<List<Evaluation>>();
            return status;
        }

        public async Task<List<Evaluation>> DeleteEvaluation(Evaluation evaluation)
        {
            var result = await _http.PostAsJsonAsync("api/evaluation/delete", evaluation);
            var status = await result.Content.ReadFromJsonAsync<List<Evaluation>>();
            return status;
        }

        public async Task<List<Evaluation>> GetAllEvaluation()
        {
            var result = await _http.GetFromJsonAsync<List<Evaluation>>($"api/evaluation/displayall");
            return result;
        }

        public async Task<Evaluation> GetEvaluation(int Id)
        {
            var result = await _http.GetFromJsonAsync<Evaluation>($"api/evaluation/display/{Id}");
            return result;
        }

        public async Task<Evaluation> GetEvaluationPerTrainee(int Id)
        {
            var result = await _http.GetFromJsonAsync<Evaluation>($"api/evaluation/displaypertrainee/{Id}");
            return result;
        }

        public async Task<List<Evaluation>> UpdateEvaluation(Evaluation evaluation)
        {
            var result = await _http.PostAsJsonAsync("api/evaluation/update", evaluation);
            var status = await result.Content.ReadFromJsonAsync<List<Evaluation>>();
            return status;
        }
    }
}
