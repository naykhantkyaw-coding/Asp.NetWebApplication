using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetServerName
{
    public class BL_GetServerName
    {
        public string GetServerName()
        {
            string serverName = string.Empty;
            ServerInfoResponseModel result = DA_GetServerName.GetServerName();
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