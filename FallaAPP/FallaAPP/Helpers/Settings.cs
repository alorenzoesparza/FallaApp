﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace FallaAPP.Helpers
{
    public static class Settings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        const string token = "Token";
        const string tokenType = "TokenType";
        static readonly string stringDefault = string.Empty;

        public static string TokenType
        {
            get
            {
                return AppSettings.GetValueOrDefault(tokenType, stringDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(tokenType, value);
            }
        }


        public static string Token
        {
            get
            {
                return AppSettings.GetValueOrDefault(token, stringDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(token, value);
            }
        }
    }
}