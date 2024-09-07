using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystemCMPG223
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Declare the necessary variables for database connection
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlCommand cmd;
        private string ConnString = @"Data Source=KARLA-LENOVO-ID\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True;TrustServerCertificate=True";


        protected void Page_Load(object sender, EventArgs e)
        {
            // Call the GetProducts method only on the initial page load, not on postbacks
            if (!IsPostBack)
            {
                GetProducts();
            }
        }

        // Method to retrieve products and bind them to the GridView
        public void GetProducts()
        {
            try
            {
                conn = new SqlConnection(ConnString);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                conn.Open();

                cmd = new SqlCommand("SelectAllProducts", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (SqlException ex)
            {
                feedbacklabel.Text = ex.ToString();
            }
            catch (Exception e)
            {
                feedbacklabel.Text = e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addpage.aspx");
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeletePage.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePage.aspx");
        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPage.aspx");
        }
    }
}