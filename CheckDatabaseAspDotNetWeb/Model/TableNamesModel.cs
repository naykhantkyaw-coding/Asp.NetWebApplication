using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Model
{
    public class TableNamesModel
    {
        public int No { get; set; }
        public string TableName { get; set; }
    }

    public class TableNameResponseModel : BaseResponseModel
    {
        public List<TableNamesModel> Data { get; set; }
    }
}