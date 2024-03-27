using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class BaseResponseModel
    {
        public ResponseModel Response { get; set; }
    }

    public class ResponseModel
    {
        public ResponseType ResponseType { get; set; }
        public string ResponseMessage { get; set; }
        public bool IsSuccess => ResponseType == ResponseType.MS;
        public bool IsError => ResponseType == ResponseType.ME;
    }

    public enum ResponseType
    {
        MS, // Success
        MW, // Warning
        ME, // Error
    }

    public static class SubResponseModel
    {
        public static ResponseModel GetResposeSuccess()
        {
            return new ResponseModel
            {
                ResponseMessage = "Success",
                ResponseType = ResponseType.MS,
            };
        }

        public static ResponseModel GetResposeError(this Exception ex)
        {
            return new ResponseModel
            {
                ResponseMessage = ex.Message,
                ResponseType = ResponseType.ME,
            };
        }
    }


}