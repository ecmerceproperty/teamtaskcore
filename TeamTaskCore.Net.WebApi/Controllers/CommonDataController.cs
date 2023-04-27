using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json;
using TeamTaskCore.Net.Configuration;
using System.Text;
// using System.Security.Cryptography;

using TeamTaskCore.Net.Model;

namespace TeamTaskCore.Net.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommonDataController : ControllerBase
    {
        //static IConfiguration Configuration { get; set; }

        [HttpGet]
        public WebApiCallBack GetJsonData()
        {
            WebApiCallBack jm = new WebApiCallBack();
            jm.Success = true;
            jm.Code = 200;
            jm.Message = Convert.ToBase64String(Encoding.UTF8.GetBytes(AppSettingConstVar.SqlConnection));
            jm.Data = AppSettingConstVar.SqlConnection;
            return jm;
        }

        [HttpGet]
        public string GetYamlData()
        {

            // Configuration = new ConfigurationBuilder()
            //             .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            //             .Build();

            return JsonConvert.SerializeObject(new
            {
                Code = 200,
                Success = true,
                //Other =  Convert.ToBase64String((new HMACSHA256()).Key),
                //Other = Encoding.UTF8.GetString((new HMACSHA256()).Key),

                //Other = Encoding.Default.GetString(Convert.FromBase64String(AppSettingConstVar.CryptoSqlConnection)),
                Message = Convert.ToBase64String(Encoding.UTF8.GetBytes(AppSettingConstVar.SqlConnection)),
                //Data = "OK"
                //Data = Configuration[string.Join(":", new string[] { "ConnectionStrings", "SqlConnection" })]
                //Data = AppSettingHelper.GetContent(new string[] { "ConnectionStrings", "SqlConnection" })
                Data = AppSettingConstVar.SqlConnection //AppSettingHelper.GetContent("ConnectionStrings","SqlConnection")
            });

            // return JsonSerializer.Serialize(new
            // {
            //     Code = "200",
            //     Success = true,
            //     Message = "请求成功",
            //     Data = Configuration[string.Join(":", new string[] { "Logging", "LogLevel", "Default" })]
            // }, new JsonSerializerOptions(){
            //      Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs, UnicodeRanges.CjkSymbolsandPunctuation)
            // });
        }
    }
}