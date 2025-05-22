//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Abp.Domain.Repositories;
//using Abp.UI;
//using Microsoft.AspNetCore.Mvc;
//using ResilienceOrg.Resilience.Common.Services.RPersons.Dtos;
//using ResilienceOrg.Resilience.Domain.Domain.RPersons;
//using Shesha;
//using Shesha.DynamicEntities.Dtos;

//namespace ResilienceOrg.Resilience.Common.Services.RPersons
//{
//    public class ImmediateSurvivorAppService : SheshaAppServiceBase
//    {
//        private readonly ImmediateSurvivorManager _immediateSurvivorManager;
//        private readonly IRepository<ImmediateSurvivor, Guid> _immediateSurvivorRepo;
//        public ImmediateSurvivorAppService(ImmediateSurvivorManager immediateSurvivorManager, IRepository<ImmediateSurvivor, Guid> immediateSurvivorRepo)
//        {
//            _immediateSurvivorManager = immediateSurvivorManager;
//            _immediateSurvivorRepo = immediateSurvivorRepo;
//        }
//        [HttpPost]
//        public async Task<DynamicDto<ImmediateSurvivor, Guid>> CreateImmediateSurvivor
//            (
//            ImdSurvivorRequestDto input
//            )
//        {
//            var immediateSurvivor = await _immediateSurvivorManager.CreateImdSurvivorAsync(
//             input.Name,
//             input.Surname,
//             input.EmailAddress,
//             input.UserName,
//             input.Password,
//             input.AnonymousId,
//             input.DisplayName,
//             input.UseDisplayNameOnly,
//             input.Sex,
//             input.PhoneNumber,
//             input.IncidentDate,
//             input.HasReceivedMedicalAttention,
//             input.HasReportedToAuthorities
//             );
//            if (immediateSurvivor == null)
//            {
//                throw new UserFriendlyException("Couldnt create Immediate survivor");
//            }
//            return await MapToDynamicDtoAsync<ImmediateSurvivor, Guid>(immediateSurvivor);
//        }
//    }
//}
