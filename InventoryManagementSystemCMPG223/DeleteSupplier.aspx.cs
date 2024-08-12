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
    public partial class DeleteSupplier : System.Web.UI.Page
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
            string sql = "DELETE FROM SuppliersTable WHERE SupplierId = @id";
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", txtSupplierId.Text);
            comm.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("Suppliers.aspx");
        }
    }
}