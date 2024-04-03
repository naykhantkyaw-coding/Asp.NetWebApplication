using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
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
    public partial class ThemeForm : System.Web.UI.Page
    {
        public bool isEnterServer;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetServerName();
        }

        protected void GetServerName()
        {
            BL_GetServerNameController getServerName = new BL_GetServerNameController();
            var result = getServerName.GetServerName();
            lblServerName.Text = result;
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            isEnterServer = true;
            if (isEnterServer)
            {
                GetDbName();
            }
        }

        protected List<DbNamesModel> GetDbName()
        {
            var result = DA_GetDbNameController.GetDbNames();
            return result.Data;
        }
    }
}