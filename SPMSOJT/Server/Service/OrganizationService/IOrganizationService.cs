using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.OrganizationService
{
    public interface IOrganizationService
    {
        Task<List<Organization>> AddOrganization(Organization organization);

        Task<Organization> GetOrganization(int organizationId);

        Task<List<Organization>> UpdateOrganization(Organization organization);

        Task<List<Organization>> RemoveOrganization(Organization organization);

        Task<List<Organization>> LoadAllOrganizations();
    }
}
