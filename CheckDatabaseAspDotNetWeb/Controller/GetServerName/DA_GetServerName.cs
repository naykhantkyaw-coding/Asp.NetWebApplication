using CheckDatabaseAspDotNetWeb.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetServerName
{
    public class DA_GetServerName
    {
        public static ServerInfoResponseModel GetServerName()
        {
            ServerInfoResponseModel model = new ServerInfoResponseModel();
            List<ServerNameModel> lst = new List<ServerNameModel>();
            try
            {
                var serverName = Environment.MachineName;
                RegistryView rv = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rv))
                {
                    RegistryKey subKey = rk.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (subKey != null)
                    {
                        foreach (var item in subKey.GetValueNames())
                        {
                            lst.Add(new ServerNameModel { ServerName = serverName, InstanceName = item });
                        }
                        model.Data = lst;
                    }
                }
                model.Response = SubResponseModel.GetResposeSuccess();
            }
            catch (Exception ex)
            {

                model.Response = ex.GetResposeError();
            }

            return model;
        }
    }
}