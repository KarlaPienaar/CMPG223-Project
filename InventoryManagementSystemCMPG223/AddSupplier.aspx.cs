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
    public partial class AddSupplier : System.Web.UI.Page
    {
        //Connection String
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InventoryManagementDB;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Connection to Database
                conn.Open();
                adap = new SqlDataAdapter();

                string SupplierEmail = txtEmail.Text;
                string SupplierName = txtName.Text;

                //Using InsertSupplier procedure
                comm = new SqlCommand("InsertSupplier", conn);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@SupplierEmail", SupplierEmail);
                comm.Parameters.AddWithValue("@SupplierName", SupplierName);

           

                int count = comm.ExecuteNonQuery();
                if(count > 0)
                {
                    //Redirect to suppliers page
                    Response.Redirect("Suppliers.aspx");
                }
                

            }
            catch (SqlException error)
            {
                //Show error when connection to database failed
                msgError.Text = error.ToString();
            }
            finally {
                //close connection to database
                conn.Close();
            }


        }
    }
}