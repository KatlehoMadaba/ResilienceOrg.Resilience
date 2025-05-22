using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using Shesha;
using Shesha.Domain;

namespace ResilienceOrg.Resilience.Common.Services
{
    public class SurvivorAppService: SheshaAppServiceBase
    {
        private readonly IRepository<Person, Guid> _personRepository;

        public SurvivorAppService(IRepository<Person, Guid> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<Guid> GetCurrentPersonIdAsync()
        {
            var userId = AbpSession.GetUserId(); // gets current user (ABP)
            var person = await _personRepository.FirstOrDefaultAsync(p=>p.User.Id== userId);
            if (person == null)
            {
                throw new UserFriendlyException("Person not found for current user.");
            }

            return person.Id;
        }
        [HttpGet]
        public async Task<Guid> GetMyPersonId()
        {
            return await GetCurrentPersonIdAsync();
        }

    }
}
