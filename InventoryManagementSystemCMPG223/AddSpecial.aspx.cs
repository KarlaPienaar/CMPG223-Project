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
    public partial class AddSpecial : System.Web.UI.Page
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
            try
            {
                conn.Open();
                comm = new SqlCommand($"INSERT INTO SpecialsTable(Productid,Discount,StartDate,EndDate) VALUES({int.Parse(txtProductId.Text)},{float.Parse(txtDiscount.Text)},'{DateTime.Parse(txtStartDate.Text)}','{DateTime.Parse(txtEndDate.Text)}')", conn);
                adap = new SqlDataAdapter();
                adap.InsertCommand = comm;

                adap.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException error)
            {
                errorLabel.Text = $"{error.Message}";
            }

            Response.Redirect("Specials.aspx");
        }
    
    }
}