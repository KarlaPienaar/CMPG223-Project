using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //needed
using System.Data; //needed

namespace InventoryManagementSystemCMPG223
{
    public partial class UpdateSupplier : System.Web.UI.Page
    {
        //connection string
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InventoryManagementDB;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
                // Open Connection to database
                conn.Open();

                //use Update procedure
                string sql = "UpdateSupplier";
                comm = new SqlCommand(sql, conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@SupplierName", txtName.Text);
                comm.Parameters.AddWithValue("@Id", txtSupplierId.Text);
                comm.Parameters.AddWithValue("@SupplierEmail", txtEmail.Text);
                comm.ExecuteNonQuery();

                //Close connection to Database
                conn.Close();

                //Redirect to Suppliers page
                Response.Redirect("Suppliers.aspx");
        }
    }
}