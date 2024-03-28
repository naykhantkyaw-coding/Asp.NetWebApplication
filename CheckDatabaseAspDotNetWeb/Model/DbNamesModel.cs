using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class DbNamesModel
    {
        public int No { get; set; }
        public string DbName { get; set; }
    }

    public class DbNameResponseModel : BaseResponseModel
    {
        public List<DbNamesModel> Data { get; set; }
    }
}