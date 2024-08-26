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
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Connection String
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InventoryManagementDB;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Select All Suppliers
            string sql_state = "SelectAllSuppliers";

            //Open Connection to Database
            conn.Open();
            ds = new DataSet();
            adap = new SqlDataAdapter();

            comm = new SqlCommand(sql_state, conn);
            adap.SelectCommand = comm;
            comm.CommandType = CommandType.StoredProcedure;
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            //Close Connection to Database
            conn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Redirect to add supplier page
            Response.Redirect("AddSupplier.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //Redirect to Update Supplier page
            Response.Redirect("UpdateSupplier.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Redirect to Delete Supplier Page
            Response.Redirect("DeleteSupplier.aspx");
        }
    }
}