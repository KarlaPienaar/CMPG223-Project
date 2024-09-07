using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystemCMPG223
{
    public partial class ViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the connection string for SqlDataSource programmatically
                SqlDataSource1.ConnectionString = @"Data Source=KARLA-LENOVO-ID\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True;TrustServerCertificate=True";
            }
        }
    }
}