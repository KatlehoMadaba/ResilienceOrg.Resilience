﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResilienceOrg.Resilience.Domain.Domain.Enums;

namespace ResilienceOrg.Resilience.Common.Services.RPersons.Dtos
{
    public class ImdSurvivorRequestDto
    {
        //Person
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? EmailAddress { get; set; }
        public string? DisplayName { get; set; }
        public bool? UseDisplayNameOnly { get; set; }
        public ReflistSex? Sex { get; set; }
        public string? PhoneNumber { get; set; }

        //ImdSurvivor
        public string? AnonymousId { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime? IncidentDate { get; set; }
        public bool HasReceivedMedicalAttention { get; set; }
        public bool HasReportedToAuthorities { get; set; }
    }
}
