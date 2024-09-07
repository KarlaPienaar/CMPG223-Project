using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace InventoryManagementSystemCMPG223
{
    public partial class DeletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No specific actions needed on page load for now
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=KARLA-LENOVO-ID\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True;TrustServerCertificate=True";
            string query = "DELETE FROM Inventory WHERE ProductId = @ProductId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("@ProductId", TextBoxDeleteproduct.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        // Provide feedback
                        if (rowsAffected > 0)
                        {
                            Response.Write("Product deleted from the inventory!");
                        }
                        else
                        {
                            Response.Write("No product found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
