﻿using Translation.Common.Models.Shared;
using Translation.Data.Entities.Domain;
using Translation.Data.Entities.Main;
using static Translation.Tests.TestHelpers.GetFakeConstantTestHelper;

namespace Translation.Tests.TestHelpers
{
    public class GetFakeEntityTestHelper
    {
        public static Organization GetOrganizationOne()
        {
            var organization = new Organization();
            organization.Id = OrganizationOneId;
            organization.Uid = OrganizationOneUid;
            organization.Name = OrganizationOneName;
            organization.CreatedAt = DateTimeOne;
            organization.Description = StringOne;
            organization.IsActive = true;
            organization.ObfuscationKey = StringSixtyFourOne;

            return organization;
        }

        public static CurrentOrganization GetCurrentOrganizationOne()
        {
            var organization = new CurrentOrganization();
            organization.Id = OrganizationOneId;
            organization.Uid = OrganizationOneUid;
            organization.Name = OrganizationOneName;

            return organization;
        }

        public static Project GetOrganizationOneProjectOne()
        {
            var project = new Project();
            project.Id = OrganizationOneProjectOneId;
            project.Uid = OrganizationOneProjectOneUid;
            project.Name = OrganizationOneProjectOneName;
            project.OrganizationId = OrganizationOneId;
            project.OrganizationUid = OrganizationOneUid;
            project.OrganizationName = OrganizationOneName;
            project.IsActive = true;
            project.Url = HttpUrl;
            project.CreatedAt = DateTimeOne;

            return project;
        }
    }
}