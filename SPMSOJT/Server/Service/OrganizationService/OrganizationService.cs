using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.OrganizationService
{
    public class OrganizationService : IOrganizationService
    {
        private readonly DataContext _data;

        public OrganizationService(DataContext data)
        {
            _data = data;
        }

        List<Organization> Organizations = new List<Organization>();
        Organization organization = new Organization();

        public async Task<List<Organization>> AddOrganization(Organization organization)
        {
            await _data.organization_info.AddAsync(organization);
            await _data.SaveChangesAsync();
            return Organizations = await _data.organization_info.ToListAsync();
        }

        public async Task<Organization> GetOrganization(int organizationId)
        {
            return organization = await _data.organization_info.Where(o => o.Id == organizationId).FirstOrDefaultAsync();
        }

        public async Task<List<Organization>> LoadAllOrganizations()
        {
            return Organizations = await _data.organization_info.ToListAsync();
        }

        public async Task<List<Organization>> RemoveOrganization(Organization organization)
        {
            var Trainees = await _data.trainee_info.Where(t => t.organizationId == organization.Id).ToListAsync();
            foreach (var trainee in Trainees)
            {
                _data.trainee_info.Remove(trainee);
            }
            _data.organization_info.Remove(organization);
            await _data.SaveChangesAsync();
            Organizations = await _data.organization_info.ToListAsync();
            return Organizations;
        }

        public async Task<List<Organization>> UpdateOrganization(Organization organization)
        {
            Organizations = await _data.organization_info.ToListAsync();
            var dbOrg = await _data.organization_info.FindAsync(organization.Id);
            if (dbOrg != null)
            {
                _data.Entry(dbOrg).CurrentValues.SetValues(organization);
                await _data.SaveChangesAsync();
            }
            return Organizations;
        }
    }
}
