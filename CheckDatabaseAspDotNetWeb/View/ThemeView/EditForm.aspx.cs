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
                    DA_GetDataController.GetDataById(reqModel);
                }
            }

        }
    }
}