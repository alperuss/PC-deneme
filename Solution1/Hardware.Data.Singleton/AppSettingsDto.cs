using System;
using System.Collections.Generic;
using System.Text;

namespace Hardware.Data.Singleton
{
    public class AppSettingsDto
    {
        public static AppSettings AppSetting { get; set; }

        public class AppSettings
        {
            public string ConnectionString { get; set; }
        }
    }
}