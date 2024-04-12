using CheckDatabaseAspDotNetWeb.Controller.GetData;
using CheckDatabaseAspDotNetWeb.Controller.GetTableName;
using CheckDatabaseAspDotNetWeb.Model;
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
        public readonly bool isEnterTable;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnterTable_Click(object sender, EventArgs e)
        {
            if(isEnterTable)
            {
                TableNameRequestModel reqModel = new TableNameRequestModel();
                reqModel.DbName = txtDbName.Text;
                reqModel.TableName = txtTableName.Text;
                var model = DA_GetDataController.GetData(reqModel);
            }
        }

        //protected List<TableNameModel> GetData()
        //{
        //    if (isEnterTable)
        //    {
        //        TableNameRequestModel reqModel = new TableNameRequestModel();
        //        reqModel.DbName = txtDbName.Text;
        //        reqModel.TableName = txtTableName.Text;
        //       var  model = DA_GetDataController.GetData(reqModel);
        //    }

        //    return model.Data;
        //}
    }
}