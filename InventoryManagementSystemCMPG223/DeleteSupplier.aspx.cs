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
    public partial class DeleteSupplier : System.Web.UI.Page
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
            //Open connection to database
            conn.Open();

            //use DeleteSupplier procedure
            string sql = "DeleteSupplier";
            comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@Id", txtSupplierId.Text);
            comm.ExecuteNonQuery();

            //Close connection to database
            conn.Close();

            //Rediect to Suppliers Page 
            Response.Redirect("Suppliers.aspx");
        }
    }
}