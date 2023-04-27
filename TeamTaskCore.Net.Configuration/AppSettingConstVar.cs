using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamTaskCore.Net.Configuration
{
    //配置文件常量
    public class AppSettingConstVar
    {
        public static readonly string DataType = AppSettingHelper.GetContent(new string[] { "ConnectionStrings", "DataType" });
        public static readonly string SqlConnection = AppSettingHelper.GetContent(new string[] { "ConnectionStrings", "SqlConnection" });
        public static readonly string CryptoSqlConnection = AppSettingHelper.GetContent(new string[] { "ConnectionStrings", "CryptoSqlConnection" });
    }
}