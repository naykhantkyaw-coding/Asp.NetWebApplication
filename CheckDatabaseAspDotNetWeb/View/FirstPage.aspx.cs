using CheckDatabaseAspDotNetWeb.Controller;
using CheckDatabaseAspDotNetWeb.Controller.GetServerName;
using CheckDatabaseAspDotNetWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckDatabaseAspDotNetWeb.View
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetServerName();
        }

        protected void GetServerName()
        {
            BL_GetServerName getServerName = new BL_GetServerName();
            var result = getServerName.GetServerName();
            lblServerName.Text = result;
        }
    }
}