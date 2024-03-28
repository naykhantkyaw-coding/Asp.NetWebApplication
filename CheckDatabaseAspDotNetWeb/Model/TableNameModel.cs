using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class TableNameModel
    {
    }

    public class TableNameRequestModel
    {
        public string DbName { get; set; }
    }

    public class TableNameResponseModel : BaseResponseModel
    {

    }
}