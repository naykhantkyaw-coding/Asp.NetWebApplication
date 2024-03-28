using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CheckDatabaseAspDotNetWeb.Controller.GetTableName
{
    public class DA_GetTableNameController
    {
        public static TableNameResponseModel GetTableNames(TableNameRequestModel reqModel)
        {
            TableNameResponseModel model = new TableNameResponseModel();
            List<TableNameModel> lstTableName = new List<TableNameModel>();
            BL_GetServerNameController blGetServerName = new BL_GetServerNameController();
            string connectionString = string.Empty;
            try
            {
                string serverName = blGetServerName.GetServerName();
                if (reqModel.DbName != null && serverName != null)
                {
                    connectionString = $"Data Source = {serverName};Initial Catlog ={reqModel.DbName};Integrated Security = true;";
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from Information_Schema.Tables", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 1;
                            while (reader.Read())
                            {
                                lstTableName.Add(new TableNameModel { No = i, TableName = reader[2].ToString() });
                            }
                            i++;
                            model.Data = lstTableName;
                        }
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