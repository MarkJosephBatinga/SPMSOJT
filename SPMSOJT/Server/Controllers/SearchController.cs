﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.SearchService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost("supervisor")]
        public async Task<ActionResult<List<Supervisor>>> SearchSupervisor(Search search)
        {
            var Supervisors = await _searchService.SearchSupervisor(search);
            return Supervisors;
        }

        [HttpPost("user")]
        public async Task<ActionResult<List<User>>> SearchUser(Search search)
        {
            var Users = await _searchService.SearchUser(search);
            return Users;
        }

        [HttpPost("trainee")]
        public async Task<ActionResult<List<Trainee>>> SearchTrainee(Search search)
        {
            var Trainees = await _searchService.SearchTrainee(search);
            return Trainees;
        }

        [HttpPost("organization")]
        public async Task<ActionResult<List<Organization>>> SearchOrganization(Search search)
        {
            var Organizations = await _searchService.SearchOrganization(search);
            return Organizations;
        }
    }
}
