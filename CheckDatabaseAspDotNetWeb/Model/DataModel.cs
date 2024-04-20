using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class DataModel
    {
    }

    public class DataRequestModel
    {
        public string DbName { get; set; }
        public string TableName { get; set; }
        public string IdName { get; set; }
        public string Id { get; set; }
    }
}