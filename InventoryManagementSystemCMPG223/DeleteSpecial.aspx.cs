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
    public partial class DeleteSpecial : System.Web.UI.Page
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
            //Connecting to Database
            conn.Open();

            //call Delete Special procedure
            string sql ="DeleteSpecial";
            comm = new SqlCommand(sql,conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@Id", int.Parse(txtSpecialId.Text));
            comm.ExecuteNonQuery();

            //Close Connection to Database
            conn.Close();

            //Redirect to specials page 
            Response.Redirect("Specials.aspx");
        }
    }
}