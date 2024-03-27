using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CheckDatabaseAspDotNetWeb.Model;

namespace CheckDatabaseAspDotNetWeb.Controller.GetTableName
{
    public class DA_GetTableNameController
    {
        public static TableNameResponseModel GetTableNames()
        {
            BL_GetServerNameController blGetServerName = new BL_GetServerNameController();
            TableNameResponseModel model = new TableNameResponseModel();
            List<TableNamesModel> lstTable = new List<TableNamesModel>();

            try
            {
                string serverName = blGetServerName.GetServerName();
                string connectionString = $"Data Source = {serverName}; Integrated Security = true;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("select name from sys.databases", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 1;
                            while (reader.Read())
                            {
                                lstTable.Add(new TableNamesModel { No = i, TableName = reader[0].ToString() });
                                i++;
                            }
                            model.Data = lstTable;
                        }
                    }
                    model.Response = SubResponseModel.GetResposeSuccess();
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