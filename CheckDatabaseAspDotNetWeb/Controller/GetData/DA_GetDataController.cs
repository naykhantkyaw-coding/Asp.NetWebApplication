using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using CheckDatabaseAspDotNetWeb.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                if (serverName != null && reqModel.DbName != null)
                {
                    connectionString = $"Data Source = {serverName};Initial Catalog ={reqModel.DbName};Integrated Security = true;";
                }
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    if (reqModel.TableName != null)
                    {
                        using (SqlCommand cmd = new SqlCommand($"select * from {reqModel.TableName}", con))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                List<string> headers = new List<string>();
                                List<string> data = new List<string>();
                                model.Data = JsonConvert.SerializeObject(dt, Formatting.Indented);
                                //foreach (DataRow r in dt.Rows)
                                //{
                                //    foreach (DataColumn c in dt.Columns)
                                //    {
                                //        headers.Add(c.ColumnName);
                                //        data.Add(r[c].ToString());
                                //    }
                                //}
                                //model.Headers = headers;
                                //model.Headers = model.Headers.Distinct().ToList();
                                //model.Data = data;

                            }
                        }
                    }
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