using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckDatabaseAspDotNetWeb.View.ThemeView
{
    public partial class EditForm : System.Web.UI.Page
    {
        public string idresult = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the 'id' parameter exists in the query string
                if (Request.QueryString["id"] != null)
                {
                    // Retrieve the value of the 'id' parameter
                    string id = Request.QueryString["id"];

                    // Use the 'id' parameter to fetch the corresponding data from your data source
                    // For example:
                    // var item = YourDataRepository.GetItemById(id);

                    // Now you have the id, you can use it in your page logic
                    // For example, you can assign it to a hidden field to access it in client-side code
                    idresult = id;
                }
            }

        }
    }
}