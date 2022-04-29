using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.OrganizationService
{
    interface IOrganizationService
    {
        Task<List<Organization>> AddOrganization(Organization organization);

        Task<List<Organization>> UpdateOrganization(Organization organization);

        Task<List<Organization>> DeleteOrganization(Organization organization);

        Task<List<Organization>> GetAllOrganization();

        Task<Organization> GetOrganization(int Id);
    }
}
