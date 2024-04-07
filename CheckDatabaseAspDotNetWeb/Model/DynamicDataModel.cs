using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class DynamicDataResponseModel : BaseResponseModel
    {
        public Dictionary<string, object> Data { get; set; }
    }
}