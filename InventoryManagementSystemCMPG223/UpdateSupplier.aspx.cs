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
    public partial class UpdateSupplier : System.Web.UI.Page
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
            if ((txtSupplierId.Text != "") && (txtName.Text != ""))
            {
                conn.Open();
                string sql = "UPDATE SuppliersTable SET name = @name WHERE SupplierId = @id";
                comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@name", txtName.Text);
                comm.Parameters.AddWithValue("@id", txtSupplierId.Text);
                comm.ExecuteNonQuery();

                conn.Close();
                
            }

            if ((txtSupplierId.Text != "") && (txtEmail.Text != ""))
            {
                conn.Open();
                string sql = "UPDATE SuppliersTable SET email = @email WHERE SupplierId = @id";
                comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@email", txtEmail.Text);
                comm.Parameters.AddWithValue("@id", txtSupplierId.Text);
                comm.ExecuteNonQuery();

                conn.Close();
                
            }
            Response.Redirect("Suppliers.aspx");
        }
    }
}