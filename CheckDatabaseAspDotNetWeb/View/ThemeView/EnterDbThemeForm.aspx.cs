using CheckDatabaseAspDotNetWeb.Controller.GetTableName;
using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckDatabaseAspDotNetWeb.View
{
    public partial class EnterDbThemeForm : System.Web.UI.Page
    {
        public bool isEnterDb;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            isEnterDb = true;
            if (isEnterDb)
            {
                GetTableName();
            }

        }

        protected List<TableNameModel> GetTableName()
        {
            TableNameResponseModel model = new TableNameResponseModel();
            if (isEnterDb)
            {
                TableNameRequestModel reqModel = new TableNameRequestModel();
                reqModel.DbName = txtDbName.Text;
                model = DA_GetTableNameController.GetTableNames(reqModel);
            }

            return model.Data;
        }
    }
}