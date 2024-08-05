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
    public partial class Specials : System.Web.UI.Page
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Samantha\Desktop\CMPG223-Project\InventoryManagementSystemCMPG223\App_Data\Specials.mdf;Integrated Security=True");
        public SqlCommand comm;
        public DataSet ds;
        public SqlDataAdapter adap;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql_state = "SELECT * FROM SpecialsTable";
            conn.Open();
            ds = new DataSet();
            adap = new SqlDataAdapter();

            comm = new SqlCommand(sql_state, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            conn.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            comm = new SqlCommand($"INSERT INTO SpecialsTable(Productid,Discount,StartDate,EndDate) VALUES({int.Parse(txtProductId.Text)},{float.Parse(txtDiscount.Text)},'{DateTime.Parse(txtStartDate.Text)}','{DateTime.Parse(txtEndDate.Text)}')", conn);
            adap = new SqlDataAdapter();
            adap.InsertCommand = comm;

            adap.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}