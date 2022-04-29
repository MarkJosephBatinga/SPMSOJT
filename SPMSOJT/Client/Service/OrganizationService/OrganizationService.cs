using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        private readonly HttpClient _http;

        public OrganizationService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Organization>> AddOrganization(Organization organization)
        {
            var result = await _http.PostAsJsonAsync("api/organization/create", organization);
            var status = await result.Content.ReadFromJsonAsync<List<Organization>>();
            return status;
        }

        public async Task<List<Organization>> DeleteOrganization(Organization organization)
        {
            var result = await _http.PostAsJsonAsync("api/organization/delete", organization);
            var status = await result.Content.ReadFromJsonAsync<List<Organization>>();
            return status;
        }

        public async Task<List<Organization>> GetAllOrganization()
        {
            var result = await _http.GetFromJsonAsync<List<Organization>>($"api/organization/displayall");
            return result;
        }

        public async Task<Organization> GetOrganization(int Id)
        {
            var result = await _http.GetFromJsonAsync<Organization>($"api/organization/display/{Id}");
            return result;
        }

        public async Task<List<Organization>> UpdateOrganization(Organization organization)
        {
            var result = await _http.PostAsJsonAsync("api/organization/update", organization);
            var status = await result.Content.ReadFromJsonAsync<List<Organization>>();
            return status;
        }
    }
}
