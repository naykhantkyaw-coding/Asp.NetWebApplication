using CheckDatabaseAspDotNetWeb.Controller.GetData;
using CheckDatabaseAspDotNetWeb.Model;
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
        public string tableNameStr = string.Empty;
        public string dbNameStr = string.Empty;
        public string idNameStr = string.Empty;
        public DynamicDataResponseModel resModel = new DynamicDataResponseModel();
        public List<TextBox> TextBoxes = new List<TextBox>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null &&
                     Request.QueryString["dbName"] != null &&
                    Request.QueryString["tableName"] != null &&
                    Request.QueryString["idName"] != null)
                {
                    string id = Request.QueryString["id"];
                    string dbName = Request.QueryString["dbName"];
                    string tableName = Request.QueryString["tableName"];
                    string idName = Request.QueryString["idName"];
                    idresult = id;
                    dbNameStr = dbName;
                    tableNameStr = tableName.Trim();
                    idNameStr = idName.Trim();
                    DataRequestModel reqModel = new DataRequestModel()
                    {
                        DbName = dbName,
                        TableName = tableName,
                        IdName = idName,
                        Id = id,
                    };
                    resModel = DA_GetDataController.GetDataById(reqModel);

                    for (int i = 0; i < resModel.Data.Count; i++)
                    {
                        var textBox = new TextBox();
                        textBox.ID = "txt" + i;
                        textBox.Text = resModel.Data[i];
                        textBox.CssClass = "form-control";
                        textBox.Attributes.Add("runat", "server"); // Ensure it's a server-side control
                        textBox.Attributes.Add("required", "required"); // Add the 'required' attribute
                        //TextBoxes.Add(textBox); // Add the TextBox to the list
                        //form1.Controls.Add(textBox); // Add the TextBox to the page
                        PlaceHolder1.Controls.Add(textBox);

                    }
                }
            }

        }
    }
}