using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace TeamTaskCore.Net.Configuration
{
    //获取AppSetting配置信息
    public class AppSettingHelper
    {
        static IConfiguration Configuration { get; set; }

        public AppSettingHelper(string contentPath)
        {
            string Path = "appsettings.json";
            Configuration = new ConfigurationBuilder()
            .SetBasePath(contentPath)
            .Add(new JsonConfigurationSource
            {
                Path = Path,
                Optional = false,
                ReloadOnChange = true
            }).Build();
        }
        
        //取得封装的操作字符
        public static string GetContent(params string[] sections)
        {
            try
            {
                if (sections.Any())
                {
                    return Configuration[string.Join(":", sections)];
                }
            }
            catch (Exception) { }
            return "";
        }

    }
}
