﻿using System.Net;
using ActionHandlers;
using Common.Extensions;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using Validation;

namespace IntegrationTests.Utilities
{
    public static class ModelKeys
    {
        public const string LevelModelKey = "levelModel";
        public const string PassModelKey = "passModel";
        public const string PassTemplateModelKey = "passTemplateModel";
        public const string BlockModelKey = "blockModel";
        public const string ClassModelKey = "classModel";

        public const string CurrentUserEmail = "currentUserEmail";

        public const string ResponseKey = "response";
    }

    public static class ModelIdKeys
    {
        public const string UserIdKey = "userId";
        public const string TeacherIdKey = "teacherId";
        public const string LevelIdKey = "levelId";
        public const string BlockKeyId = "blockId";
        public const string PassTemplateKeyId = "passTemplateId";
        public const string ClassKeyId = "classId";
    }

    public static class ScenarioCache
    {
        private const string ValidationResultKey = "validationResult";
        private const string ActionResultKey = "actionResultKey";
        private const string ResponseStatusKey = "responseStatusKey";

        public static void StoreUserId(int id)
        {
            Store(ModelIdKeys.UserIdKey, id);
        }

        public static void StoreTeacherId(int id)
        {
            Store(ModelIdKeys.TeacherIdKey, id);
        }

        public static void StoreLevelId(int id)
        {
            Store(ModelIdKeys.LevelIdKey, id);
        }

        public static void Store(string key, object item)
        {
            Clear(key);
            ScenarioContext.Current.Add(key, item);
        }

        public static T Get<T>(string key)
        {
            AssertKeyExists(key);
            return ScenarioContext.Current.Get<T>(key);
        }

        public static int GetUserId()
        {
            return Get<int>(ModelIdKeys.UserIdKey);
        }

        public static int GetTeacherId()
        {
            return Get<int>(ModelIdKeys.TeacherIdKey);
        }

        private static void AssertKeyExists(string key)
        {
            Assert.IsTrue(ScenarioContext.Current.ContainsKey(key),
                "Expected to have found the key {0} in the scenario context".FormatWith(key));   
        }

        private static void Clear(string key)
        {
            ScenarioContext.Current.Remove(key);
        }

        public static void StoreActionResponse<T>(IRestResponse<ActionReponse<T>> response)
        {
            Store(ValidationResultKey, response.Data.ValidationResult);
            Store(ActionResultKey, response.Data.ActionResult);
            Store(ResponseStatusKey, response.StatusCode);
        }

        public static HttpStatusCode GetResponseStatus()
        {
            return Get<HttpStatusCode>(ResponseStatusKey);
        }

        public static T GetActionResponse<T>()
        {
            return Get<T>(ActionResultKey);
        }

        public static ValidationResult GetValidationResult()
        {
            return Get<ValidationResult>(ValidationResultKey);
        }

        public static int GetId(string key)
        {
            return Get<int>(key);
        }
    }
}