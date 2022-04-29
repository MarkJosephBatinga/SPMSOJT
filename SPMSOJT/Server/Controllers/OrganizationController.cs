using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.OrganizationService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;

        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        List<Organization> Organizations = new List<Organization>();
        Organization organization = new Organization();

        [HttpPost("create")]
        public async Task<ActionResult<List<Organization>>> AddOrganization(Organization organization)
        {
            return Organizations = await _organizationService.AddOrganization(organization);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Organization>>> UpdateOrganization(Organization organization)
        {
            return Organizations = await _organizationService.UpdateOrganization(organization);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Organization>>> DeleteOrganization(Organization organization)
        {
            return Organizations = await _organizationService.RemoveOrganization(organization);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Organization>>> GetAllOrganization()
        {
            return Organizations = await _organizationService.LoadAllOrganizations();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Organization>> GetOrganization(int Id)
        {
            return organization = await _organizationService.GetOrganization(Id);
        }
    }
}
