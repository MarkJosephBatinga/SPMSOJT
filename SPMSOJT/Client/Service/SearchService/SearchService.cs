using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.SearchService
{
    public class SearchService : ISearchService
    {
        private readonly HttpClient _http;

        public SearchService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Organization>> SearchOrganization(Search search)
        {
            var result = await _http.PostAsJsonAsync("api/search/organization", search);
            var status = await result.Content.ReadFromJsonAsync<List<Organization>>();
            return status;
        }

        public async Task<List<Supervisor>> SearchSupervisor(Search search)
        {
            var result = await _http.PostAsJsonAsync("api/search/supervisor", search);
            var status = await result.Content.ReadFromJsonAsync<List<Supervisor>>();
            return status;
        }

        public async Task<List<Trainee>> SearchTrainee(Search search)
        {
            var result = await _http.PostAsJsonAsync("api/search/trainee", search);
            var status = await result.Content.ReadFromJsonAsync<List<Trainee>>();
            return status;
        }

        public async Task<List<User>> SearchUser(Search search)
        {
            var result = await _http.PostAsJsonAsync("api/search/user", search);
            var status = await result.Content.ReadFromJsonAsync<List<User>>();
            return status;
        }
    }
}
