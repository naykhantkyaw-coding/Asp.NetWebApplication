using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetServerName
{
    public class BL_GetServerNameController
    {
        public string GetServerName()
        {
            string serverName = string.Empty;
            ServerInfoResponseModel result = DA_GetServerNameController.GetServerName();
            if (result.Data != null && result.Response.IsSuccess)
            {
                foreach (var item in result.Data)
                {
                    if (item.InstanceName == "MSSQLSERVER")
                    {
                        serverName = item.ServerName;
                    }
                    else
                    {
                        serverName = $"{item.ServerName}\\{item.InstanceName}";
                    }
                }
            }
            return serverName;
        }
    }
}