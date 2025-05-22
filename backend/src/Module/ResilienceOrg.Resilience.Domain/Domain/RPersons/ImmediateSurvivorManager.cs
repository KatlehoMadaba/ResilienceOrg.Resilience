using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using NHibernate.Linq;
using ResilienceOrg.Resilience.Domain.Domain.Enums;
using Shesha.Authorization.Users;
using Shesha.Domain;


namespace ResilienceOrg.Resilience.Domain.Domain.RPersons
{
    public class ImmediateSurvivorManager : DomainService
    {
        private readonly UserManager _userManager;
        private readonly IRepository<ImmediateSurvivor, Guid> _imdsurvivorRepository;
        private readonly IRepository<Person, Guid> _personRepository;

        public ImmediateSurvivorManager
            (
            UserManager userManager,
            IRepository<ImmediateSurvivor, Guid> imdsurvivorRepository,
            IRepository<Person, Guid> personRepository)
        {
            _userManager = userManager;
            _imdsurvivorRepository = imdsurvivorRepository;
            _personRepository = personRepository;
        }
        public async Task<ImmediateSurvivor> CreateImdSurvivorAsync(
            string? name,
            string? surname,
            string? emailAddress,
            string? username,
            string? password,
            string? anonymousId,
            string? displayName,
            bool? useDisplayNameOnly,
            ReflistSex? sex,
            string? phoneNumber,
            DateTime? incidentDate,
            bool? hasReceivedMedicalAttention,
            bool? hasReportedToAuthorities
        )
        {
            ImmediateSurvivor survivor;
            try
            {
                //1.Create Person 
                var person = new Person
                {
                    FirstName = name,
                    LastName = surname,
                    EmailAddress1 = emailAddress,
                    TenantId = 1
                };


                //2.Create user
                var user = new User
                {
                    Name = name,
                    Surname = surname,
                    EmailAddress = emailAddress,
                    UserName = username,
                    TenantId = 1
                };

                var userCreationResult = await _userManager.CreateAsync(user, password);
                if (!userCreationResult.Succeeded)
                {
                    throw new UserFriendlyException("Failed to create user: " + string.Join(", ", userCreationResult.Errors));
                }

                await _userManager.AddToRoleAsync(user, "immediatesurvivor");
                //return Id of person
               var personCreation= await _personRepository.InsertAndGetIdAsync(person);
                // 2. Create ImmediateSurvivor (inherits from RPerson)
                var immediateSurvivor = new ImmediateSurvivor
                {
                    //UserId = user.Id,
                    PersonId = personCreation,
                    AnonymousId = anonymousId,
                    DisplayName = displayName,
                    UseDisplayNameOnly = useDisplayNameOnly,
                    Sex = sex,
                    PhoneNumber = phoneNumber,
                    IsAnonymous = false,
                    IncidentDate = incidentDate,
                    HasReceivedMedicalAttention = hasReceivedMedicalAttention ?? false,
                    HasReportedToAuthorities = hasReportedToAuthorities ?? false,
                    Testimonies = new List<Testimony>()
                };

                await _imdsurvivorRepository.InsertAsync(immediateSurvivor);
              
                // Optional: fetch again if you need navigation properties
                survivor = immediateSurvivor;


            }
            catch (Exception ex)
            {
                Logger.Error($"Error creating ImmediateSurvivor: {ex.Message}", ex);
                if (ex.InnerException != null)
                    Logger.Error($"Inner exception: {ex.InnerException.Message}");
                throw new UserFriendlyException("An error occurred while creating the ImmediateSurvivor", ex);
            }

            return survivor;
        }


        public async Task<ImmediateSurvivor> GetImmediateSurvivorByPersonIdAsync(Guid id)
        {
            try
            {

                var query = _imdsurvivorRepository.GetAllIncluding(p => p.Person);

                var immediateSurvivor = await query.FirstOrDefaultAsync(p => p.PersonId == id);

                return immediateSurvivor;

            }
            catch (Exception ex)
            {

                Logger.Error($"Error creating ImmediateSurvivor: {ex.Message}", ex);
                if (ex.InnerException != null)
                    Logger.Error($"Inner exception: {ex.InnerException.Message}");
                throw new UserFriendlyException("An error occurred while creating the ImmediateSurvivor", ex);
            }

        }

        //public async Task<ImmediateSurvivor> GetImmediateSurvivorByUserIdAsync(long userId)
        //{
        //        var ImmediateSurvivors = _imdsurvivorRepository.GetAllIncluding(p=>p.);

        //        var ImmediateSurvivor = await ImmediateSurvivors.FirstOrDefaultAsync(p => p.UserId == userId);
        //        if (ImmediateSurvivor == null)
        //        {
        //            throw new UserFriendlyException("ImmediateSurvivor not found");
        //        }

        //        return ImmediateSurvivor;
        //    }
        //}


    }
}
