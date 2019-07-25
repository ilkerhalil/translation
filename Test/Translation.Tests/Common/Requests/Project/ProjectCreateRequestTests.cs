﻿using System;
using System.Collections;

using NUnit.Framework;
using Shouldly;

using Translation.Common.Models.Requests.Project;
using static Translation.Tests.TestHelpers.FakeRequestTestHelper;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.Common.Requests.Project
{
    [TestFixture]
    public class ProjectCreateRequestTests
    {
        [Test]
        public void ProjectCreateRequest_Constructor()
        {
            var request = GetProjectCreateRequest(CurrentUserId, OrganizationOneUid, StringOne,
                                                  HttpUrl, StringOne, StringOne);

            request.CurrentUserId.ShouldBe(CurrentUserId);
            request.OrganizationUid.ShouldBe(OrganizationOneUid);
            request.ProjectName.ShouldBe(StringOne);
            request.Url.ShouldBe(HttpUrl);
            request.Description.ShouldBe(StringOne);
            request.ProjectSlug.ShouldBe(StringOne);
        }

        public static IEnumerable ArgumentTestCases
        {
            get
            {
                yield return new TestCaseData(CurrentUserId, EmptyUid, StringOne,
                                              HttpUrl, StringOne, StringOne);
                yield return new TestCaseData(CurrentUserId, OrganizationOneUid, StringEmpty,
                                              HttpUrl, StringOne, StringOne);
                yield return new TestCaseData(CurrentUserId, OrganizationOneUid, StringOne,
                                              HttpUrl, StringOne, StringEmpty);
                yield return new TestCaseData(CurrentUserId, OrganizationOneUid, StringOne,
                                                StringTwo, StringOne, StringOne);

            }
        }

        [TestCaseSource(nameof(ArgumentTestCases))]
        public void ProjectCreateRequest_Argument_Validations(long currentUserId, Guid organizationUid, string projectName,
            string url, string description, string projectSlug)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new ProjectCreateRequest(currentUserId, organizationUid, projectName,
                                         url, description, projectSlug);
            });
        }
    }
}