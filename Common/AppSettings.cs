﻿using System.Configuration;

namespace Common
{
    public interface IAppSettings
    {
        string GetWebsiteUrl();
        string GetSetting(AppSettingKey key);
    }

    public class AppSettings : IAppSettings
    {
        public string GetWebsiteUrl()
        {
            var websiteUrl = ConfigurationManager.AppSettings.Get("WebsiteUrl");
            websiteUrl = "https://" + websiteUrl;
            return websiteUrl;
        }

        public string GetSetting(AppSettingKey key)
        {
            return ConfigurationManager.AppSettings.Get(key.ToString());
        }
    }

    public enum AppSettingKey
    {
        MandrillApiKey,
        TestEmailAccount,
        UseRealEmail,
        AdminEmailWhitelist,
        AutoActivateAdmin
    }
}
