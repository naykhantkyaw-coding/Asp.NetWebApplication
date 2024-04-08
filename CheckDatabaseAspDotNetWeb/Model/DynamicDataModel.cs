using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class DynamicDataResponseModel : BaseResponseModel
    {
        public DataTable Data { get; set; }
    }
}