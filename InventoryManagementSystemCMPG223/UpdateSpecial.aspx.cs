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
    public partial class UpdateSpecial : System.Web.UI.Page
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Desktop\CMPG223-Project\InventoryManagementSystemCMPG223\App_Data\Specials.mdf;Integrated Security=True");
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
                conn.Open();
                string sql = "UPDATE SpecialsTable SET Discount = @discount WHERE IdSpecial = @id";
                comm = new SqlCommand(sql,conn);

                comm.Parameters.AddWithValue("@discount",decimal.Parse(txtDiscount.Text));
                comm.Parameters.AddWithValue("@id", int.Parse(txtSpecialId.Text));
                comm.ExecuteNonQuery();

                conn.Close();
                
            }

            if ((txtSpecialId.Text != "") && (txtProductId.Text != ""))
            {
                conn.Open();
                string sql = "UPDATE SpecialsTable SET Productid = @productid WHERE IdSpecial = @id";
                comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@productid", int.Parse(txtProductId.Text));
                comm.Parameters.AddWithValue("@id", int.Parse(txtSpecialId.Text));
                comm.ExecuteNonQuery();

                conn.Close();
                
            }

            if ((txtSpecialId.Text != "") && (txtStartDate.Text != ""))
            {
                conn.Open();
                string sql = "UPDATE SpecialsTable SET StartDate = @startdate WHERE IdSpecial = @id";
                comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@startdate",DateTime.Parse(txtStartDate.Text));
                comm.Parameters.AddWithValue("@id", int.Parse(txtSpecialId.Text));
                comm.ExecuteNonQuery();

                conn.Close();
                
            }

            if ((txtSpecialId.Text != "") && (txtEndDate.Text != ""))
            {
                conn.Open();
                string sql = "UPDATE SpecialsTable SET EndDate = @enddate WHERE IdSpecial = @id";
                comm = new SqlCommand(sql, conn);

                comm.Parameters.AddWithValue("@enddate", DateTime.Parse(txtEndDate.Text));
                comm.Parameters.AddWithValue("@id", int.Parse(txtSpecialId.Text));
                comm.ExecuteNonQuery();

                conn.Close();
               
            }
            Response.Redirect("Specials.aspx");
        }
    }
}