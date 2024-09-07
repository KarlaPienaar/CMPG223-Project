using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace InventoryManagementSystemCMPG223
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        // Database connection string
        private string ConnString = @"Data Source=KARLA-LENOVO-ID\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True;TrustServerCertificate=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize database connection
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                }
            }
        }

        // Method to update a product in the database
        public void UpdateAProduct(int productId, int quantityInStock, int supplierId, int inventoryId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();

                    // Create a parameterized query to avoid SQL injection
                    string query = "UPDATE Inventory SET QuantityInStock = @QuantityInStock, SupplierID = @SupplierID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        
                        cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        
                        

                        int countUpdated = cmd.ExecuteNonQuery();
                        if (countUpdated > 0)
                        {
                            Feedbacklbl.Text = $"Successfully updated product with ID {productId}";
                        }
                        else
                        {
                            Feedbacklbl.Text = $"Failed to update product with ID {productId}";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Feedbacklbl.Text = $"Error updating product: {ex.Message}";
            }
            catch (Exception e)
            {
                Feedbacklbl.Text = $"Error updating product: {e.Message}";
            }
        }

        // Button click event to handle the update
        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            int productId = Int32.Parse(TextBoxProductID.Text);
          
            int quantityInStock = Int32.Parse(TextBoxQinstock.Text);
            int supplierId = Int32.Parse(TextBoxSupplierID.Text);
            int inventoryId = Int32.Parse(TextBoxInventoryID.Text);
            

            UpdateAProduct(productId, quantityInStock, supplierId, inventoryId);
        }
    }
}
