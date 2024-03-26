using CheckDatabaseAspDotNetWeb.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller
{
    public class GetServerNameController
    {
        public string GetServerName()
        {
            List<ServerNameModel> lst = new List<ServerNameModel>();
            string serverName = null;
            try
            {
                string machineName = Environment.MachineName;
                RegistryView rv = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rv))
                {
                    RegistryKey subKey = rk.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);

                    if (subKey != null)
                    {
                        foreach (var item in subKey.GetValueNames())
                        {
                            lst.Add(new ServerNameModel { ServerName = machineName, InstanceName = item });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (lst.Count > 0)
            {
                foreach (ServerNameModel obj in lst)
                {
                    if (obj.InstanceName == "MSSQLSERVER")
                    {
                        //Console.WriteLine($"{obj.ServerName}");
                        serverName = obj.ServerName;
                    }
                    else
                    {
                        //Console.WriteLine($"{obj.ServerName}\\{obj.InstanceName}");
                        serverName = $"{obj.ServerName}\\{obj.InstanceName}";
                    }
                }
            }
            return serverName;
        }
    }
}