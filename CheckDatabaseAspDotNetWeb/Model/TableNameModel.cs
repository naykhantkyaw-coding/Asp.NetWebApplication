using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class TableNameModel
    {
        public int No { get; set; }
        public string TableName { get; set; }
    }

    public class TableNameRequestModel
    {
        public string DbName { get; set; }
    }


    public class TableNameResponseModel : BaseResponseModel
    {
        public List<TableNameModel> Data { get; set; }
    }
}