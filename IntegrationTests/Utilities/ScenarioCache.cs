﻿using Common.Extensions;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace IntegrationTests.Utilities
{
    public static class ScenarioCache
    {
        private const string IdKey = "id";
        private const string ResponseKey = "response";

        public static void StoreId(int id)
        {
            ScenarioContext.Current.Add(IdKey, id);
        }

        public static void Store(string key, object item)
        {
            ScenarioContext.Current.Remove(key);
            ScenarioContext.Current.Add(key, item);
        }

        public static T Get<T>(string key)
        {
            AssertKeyExists(key);
            return ScenarioContext.Current.Get<T>(key);
        }

        public static int GetId()
        {
            AssertKeyExists(IdKey);
            return ScenarioContext.Current.Get<int>(IdKey);
        }

        private static void AssertKeyExists(string key)
        {
            Assert.IsTrue(ScenarioContext.Current.ContainsKey(key),
                "Expected to have found the key {0} in the scenario context".FormatWith(key));   
        }

        public static void StoreResponse<T>(IRestResponse<T> response)
        {
            ScenarioContext.Current.Add(ResponseKey, response);
        }

        public static IRestResponse<T> GetResponse<T>()
        {
            AssertKeyExists(ResponseKey);
            return ScenarioContext.Current.Get<IRestResponse<T>>(ResponseKey);
        } 
    }
}
