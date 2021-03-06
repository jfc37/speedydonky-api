﻿using System.Collections.Generic;
using System.Net;
using Contracts.Users;
using IntegrationTests.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace IntegrationTests.Steps.Users
{
    [Binding]
    public class RetrieveUserSteps
    {
        [When(@"all users are retreived")]
        public void WhenAllUsersAreRetreived()
        {
            var userResponse = ApiCaller.Get<List<UserModel>>(Routes.Users);
            ScenarioCache.Store(ModelKeys.Response, userResponse.StatusCode);
        }

        [When(@"a user search is performed")]
        public void WhenAUserSearchIsPerformed()
        {
            var userResponse = ApiCaller.Get<List<UserModel>>(Routes.GetUserSearch("surname_=_Chapman"));
            ScenarioCache.Store(ModelKeys.Response, userResponse.StatusCode);
        }

        [When(@"a user is retrieved by id")]
        public void WhenAUserIsRetrievedById()
        {
            var userResponse = ApiCaller.Get<UserModel>(Routes.GetUserById(ScenarioCache.GetId(ModelIdKeys.UserId)));
            ScenarioCache.Store(ModelKeys.Response, userResponse.StatusCode);
        }

        [Then(@"something is retreived")]
        public void ThenSomethingIsRetreived()
        {
            var response = ScenarioCache.Get<HttpStatusCode>(ModelKeys.Response);

            Assert.AreEqual(HttpStatusCode.OK, response);
        }
    }
}
