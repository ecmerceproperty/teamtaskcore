using System;

namespace TeamTaskCore.Net.Model
{
    //接口回调Json实体
    public class WebApiCallBack
    {
        public bool Success { get; set; } = true;
        public int Code { get; set; } = 200;
        public string Message { get; set; } = "接口响应成功";
        public object Data { get; set; }
        public object Other { get; set; } = null;
        public string Description { get; set; } = "";
    }
}
