using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.CompiledTaskService
{
    public class CompiledTaskService : ICompiledTaskService
    {
        private readonly HttpClient _http;

        public CompiledTaskService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<CompiledTask>> AddCompiledTask(CompiledTask compiledTask)
        {
            var result = await _http.PostAsJsonAsync("api/compiledtask/create", compiledTask);
            var status = await result.Content.ReadFromJsonAsync<List<CompiledTask>>();
            return status;
        }

        public async Task<List<CompiledTask>> DeleteCompiledTask(CompiledTask compiledTask)
        {
            var result = await _http.PostAsJsonAsync("api/compiledtask/delete", compiledTask);
            var status = await result.Content.ReadFromJsonAsync<List<CompiledTask>>();
            return status;
        }

        public async Task<List<CompiledTask>> GetAllCompiledTask()
        {
            var result = await _http.GetFromJsonAsync<List<CompiledTask>>($"api/compiledtask/displayall");
            return result;
        }

        public async Task<List<CompiledTask>> GetAllCompiledTaskPerStudent(int studentId)
        {
            var result = await _http.GetFromJsonAsync<List<CompiledTask>>($"api/compiledtask/displayallperstudent/{studentId}");
            return result;
        }

        public async Task<List<CompiledTask>> GetAllCompiledTaskPerSupervisor(int supervisorId)
        {
            var result = await _http.GetFromJsonAsync<List<CompiledTask>>($"api/compiledtask/displayallpersupervisor/{supervisorId}");
            return result;
        }

        public async Task<CompiledTask> GetCompiledTask(int Id)
        {
            var result = await _http.GetFromJsonAsync<CompiledTask>($"api/compiledtask/display/{Id}");
            return result;
        }

        public async Task<List<CompiledTask>> UpdateCompiledTask(CompiledTask compiledTask)
        {
            var result = await _http.PostAsJsonAsync("api/compiledtask/update", compiledTask);
            var status = await result.Content.ReadFromJsonAsync<List<CompiledTask>>();
            return status;
        }
    }
}
