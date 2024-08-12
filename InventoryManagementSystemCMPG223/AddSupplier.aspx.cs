using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystemCMPG223
{
    public partial class AddSupplier : System.Web.UI.Page
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Desktop\CMPG223-Project\InventoryManagementSystemCMPG223\App_Data\Supplier.mdf;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            comm = new SqlCommand($"INSERT INTO SuppliersTable(name,email) VALUES('{txtName.Text}','{txtEmail.Text}')", conn);
            adap = new SqlDataAdapter();
            adap.InsertCommand = comm;

            adap.InsertCommand.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Suppliers.aspx");
        }
    }
}