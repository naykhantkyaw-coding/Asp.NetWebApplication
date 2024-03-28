using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetTableName
{
    public class DA_GetTableNameController
    {
        public static TableNameResponseModel GetTableNames(TableNameRequestModel reqModel)
        {
            TableNameResponseModel model = new TableNameResponseModel();
            BL_GetServerNameController blGetServerName = new BL_GetServerNameController();
            string serverName = blGetServerName.GetServerName();
            if (reqModel.DbName != null && serverName != null)
            {
                string connectionString = $"Data Source = {serverName};Initial catlog ={reqModel.DbName};Integrated Security = true;";
            }

            return model;
        }
    }
}