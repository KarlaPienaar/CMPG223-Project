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
    public partial class UpdateSpecial : System.Web.UI.Page
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
            if ((txtSpecialId.Text != "") && (txtDiscount.Text != "") )
            {

                //Connecting to Database
                conn.Open();
                string sql = "UpdateSpecial";
                comm = new SqlCommand(sql,conn);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@ProductId", int.Parse(txtProductId.Text));
                comm.Parameters.AddWithValue("@Discount", decimal.Parse(txtDiscount.Text));
                comm.Parameters.AddWithValue("@StartDate", Calendar1.SelectedDate);
                comm.Parameters.AddWithValue("@EndDate", Calendar2.SelectedDate);
                comm.Parameters.AddWithValue("@Id", int.Parse(txtSpecialId.Text));
                comm.ExecuteNonQuery();

                //Close Connection to Database
                conn.Close();
                
            }
            //Redirect to Specials page
            Response.Redirect("Specials.aspx");
        }
    }
}