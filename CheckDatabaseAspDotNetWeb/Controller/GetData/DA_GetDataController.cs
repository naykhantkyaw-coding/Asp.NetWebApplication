using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetData
{
    public class DA_GetDataController
    {
        public static DynamicDataResponseModel GetData(TableNameRequestModel reqModel)
        {
            DynamicDataResponseModel model = new DynamicDataResponseModel();
            BL_GetServerNameController getServerName = new BL_GetServerNameController();
            string connectionString = string.Empty;
            try
            {
                string serverName = getServerName.GetServerName();
                if(serverName != null && reqModel.DbName != null)
                {
                    connectionString = $""
                }
            }
            catch (Exception ex)
            {

                model.Response = ex.GetResposeError();
            }

            return model;
        }
    }
}