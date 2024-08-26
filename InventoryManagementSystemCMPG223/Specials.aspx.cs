using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; // needed 
using System.Data; //needed

namespace InventoryManagementSystemCMPG223
{
    public partial class Specials : System.Web.UI.Page
    {
        //Connection String
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=InventoryManagementDB;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql_state = "SelectAllSpecials";

            //Connecting to the Database
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            comm = new SqlCommand(sql_state, conn);
            comm.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand = comm;
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            //Closing Connection to the Database
            conn.Close();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Redirecting to add specials page
            Response.Redirect("AddSpecial.aspx");
            

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //redirecting to update specials page
            Response.Redirect("UpdateSpecial.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //redirecting to Delete Specials Page
            Response.Redirect("DeleteSpecial.aspx");
        }
    }
}