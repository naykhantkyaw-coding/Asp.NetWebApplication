using CheckDatabaseAspDotNetWeb.Controller.GetData;
using CheckDatabaseAspDotNetWeb.Controller.GetTableName;
using CheckDatabaseAspDotNetWeb.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckDatabaseAspDotNetWeb.View.ThemeView
{
    public partial class EnterTable : System.Web.UI.Page
    {
        public bool isEnterTable;
        public List<string> testingData;
        public List<string> testingresult;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnterTable_Click(object sender, EventArgs e)
        {
            isEnterTable = true;
           var data = GetData(isEnterTable, txtDbName.Text, txtTableName.Text);
            //testingData = data.Headers;
            //testingresult = data.Data;

        }

        protected DynamicDataResponseModel GetData(bool isEnterTable = false, string dbName = null, string tableName = null)
        {
            DynamicDataResponseModel model = new DynamicDataResponseModel();
            if (isEnterTable)
            {
                TableNameRequestModel reqModel = new TableNameRequestModel();
                reqModel.DbName = dbName;
                reqModel.TableName = tableName;
                var result = DA_GetDataController.GetData(reqModel);
                var jsonString = result.Data;

                var de = new DynamicTesteingModel
                {
                    Data = JsonConvert.DeserializeObject<List<dynamic>>(jsonString)
                };

                //var jsonString = JsonConvert.DeserializeObject<>(model.Data);
                //var obj = JObject.Parse(model.Data);
                //var result = obj.Descendants()
                //        .OfType<JProperty>()
                //         .Select(p => new KeyValuePair<string, object>(p.Path,
                //             p.Value.Type == JTokenType.Array || p.Value.Type == JTokenType.Object
                //               ? null : p.Value));

                //foreach (var item in result)
                //{
                //    dd.Add(item.Key, item.Value);
                //}
                model = result;
            }
            return model;
        }
    }
}


