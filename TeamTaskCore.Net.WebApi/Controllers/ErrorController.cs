using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

using Newtonsoft.Json;

namespace TeamTaskCore.Net.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            string data = JsonConvert.SerializeObject(
                new { Message = Guid.NewGuid().ToString(), Data = "发生位置错误", Code = 500, Success = false }
            );
            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(data, Encoding.GetEncoding("UTF-8"), "application/json")                
            };
        }
    }
}