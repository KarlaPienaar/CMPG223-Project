using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace InventoryManagementSystemCMPG223
{
    public partial class AddPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No specific actions needed on page load for now
        }

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=KARLA-LENOVO-ID\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True;TrustServerCertificate=True";

            // SQL query to check if SupplierId exists in SUPPLIER table
            string queryCheckSupplier = "SELECT COUNT(*) FROM SUPPLIER WHERE SupplierId = @SupplierID";

            // SQL query to insert data into INVENTORY table
            string queryInsertInventory = "INSERT INTO Inventory (QuantityInStock, SupplierID, ProductId) " +
                "VALUES (@QuantityInStock, @SupplierID, @ProductId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmdCheckSupplier = new SqlCommand(queryCheckSupplier, conn))
                {
                    cmdCheckSupplier.Parameters.AddWithValue("@SupplierID", int.TryParse(TextBoxSupplierID.Text, out int supplierId) ? (object)supplierId : DBNull.Value);

                    int count = (int)cmdCheckSupplier.ExecuteScalar();

                    if (count == 0)
                    {
                        FeedbackLbl.Text = "Error: SupplierId does not exist in SUPPLIER table.";
                        return;
                    }
                }

                using (SqlCommand cmdInsertInventory = new SqlCommand(queryInsertInventory, conn))
                {
                    // Add parameters and handle conversion
                    cmdInsertInventory.Parameters.AddWithValue("@QuantityInStock", int.TryParse(TextBoxQinstock.Text, out int quantity) ? (object)quantity : DBNull.Value);
                    cmdInsertInventory.Parameters.AddWithValue("@SupplierID", int.TryParse(TextBoxSupplierID.Text, out int supplierId) ? (object)supplierId : DBNull.Value);
                    cmdInsertInventory.Parameters.AddWithValue("@ProductId", int.TryParse(TextBoxProductID.Text, out int productId) ? (object)productId : DBNull.Value);

                    try
                    {
                        cmdInsertInventory.ExecuteNonQuery();

                        // Provide feedback and redirect
                        FeedbackLbl.Text = "Product added successfully!";
                        Response.Redirect("Products.aspx");
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        FeedbackLbl.Text = "Error: " + ex.Message;
                    }
                }
            }
        }
    }
}
