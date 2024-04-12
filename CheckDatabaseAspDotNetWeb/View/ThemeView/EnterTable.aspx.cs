using CheckDatabaseAspDotNetWeb.Controller.GetData;
using CheckDatabaseAspDotNetWeb.Controller.GetTableName;
using CheckDatabaseAspDotNetWeb.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnterTable_Click(object sender, EventArgs e)
        {
            isEnterTable = true;
            GetData(isEnterTable, txtDbName.Text, txtTableName.Text);
        }

        protected void GetData(bool isEnterTable, string dbName, string tableName)
        {
            if (isEnterTable)
            {
                Dictionary<string, object> dd = new Dictionary<string, object>();
                TableNameRequestModel reqModel = new TableNameRequestModel();
                reqModel.DbName = dbName;
                reqModel.TableName = tableName;
                var model = DA_GetDataController.GetData(reqModel);
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
            }

        }
    }
}