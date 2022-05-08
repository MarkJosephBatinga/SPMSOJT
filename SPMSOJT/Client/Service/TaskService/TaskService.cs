using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.TaskService
{
    public class TaskService : ITaskService
    {
        private readonly HttpClient _http;

        public TaskService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Tasks>> AddTasks(Tasks task)
        {
            var result = await _http.PostAsJsonAsync("api/task/create", task);
            var status = await result.Content.ReadFromJsonAsync<List<Tasks>>();
            return status;
        }

        public async Task<List<Tasks>> DeleteTasks(Tasks task)
        {
            var result = await _http.PostAsJsonAsync("api/task/delete", task);
            var status = await result.Content.ReadFromJsonAsync<List<Tasks>>();
            return status;
        }

        public async Task<List<Tasks>> GetAllNonComplyTask(int Id)
        { 
            var result = await _http.GetFromJsonAsync<List<Tasks>>($"api/task/displayallntask/{Id}");
            return result;
        }

        public async Task<List<Tasks>> GetAllTasks()
        {
            var result = await _http.GetFromJsonAsync<List<Tasks>>($"api/task/displayall");
            return result;
        }

        public async Task<Tasks> GetTasks(int Id)
        {
            var result = await _http.GetFromJsonAsync<Tasks>($"api/task/display/{Id}");
            return result;
        }

        public async Task<List<Tasks>> UpdateTasks(Tasks task)
        {
            var result = await _http.PostAsJsonAsync("api/task/update", task);
            var status = await result.Content.ReadFromJsonAsync<List<Tasks>>();
            return status;
        }
    }
}
