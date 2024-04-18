using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class DynamicDataResponseModel : BaseResponseModel
    {
        //public DataTable Data { get; set; }
        //public string Data { get; set; }

        public List<string> Headers { get; set; }
        public List<string> Data { get; set; }

    }



}