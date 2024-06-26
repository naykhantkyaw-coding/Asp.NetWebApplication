﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class ServerInfoResponseModel : BaseResponseModel
    {
        public List<ServerNameModel> Data { get; set; }
    }

    public class ServerNameModel
    {
        public string ServerName { get; set; }
        public string InstanceName { get; set; }
    }


}