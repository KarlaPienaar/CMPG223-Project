Imports System.Data.SqlClient

Public Class AddPage
    Inherits System.Web.UI.Page

    Protected Sub ButtonEnter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonEnter.Click
        ' Define connection string (ensure the connection string matches your database configuration)
        Dim connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True"


        ' Create SQL query for inserting data
        Dim query As String = "INSERT INTO InventoryTable (ProductName, QuantityInStock, SupplierId, InventoryId, ProductId, ProductPrice, ProductSize, ProductDescription) " &
                              "VALUES (@ProductName, @QuantityInStock, @SupplierId, @InventoryId, @ProductId, @ProductPrice, @ProductSize, @ProductDescription)"

        ' Create connection and command objects
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameters 
                cmd.Parameters.AddWithValue("@ProductName", TxtProductname.Text)
                cmd.Parameters.AddWithValue("@QuantityInStock", TextBoxQinstock.Text)
                cmd.Parameters.AddWithValue("@SupplierId", TextBoxSupplierID.Text)
                cmd.Parameters.AddWithValue("@InventoryId", TextBoxInventoryID.Text)
                cmd.Parameters.AddWithValue("@ProductId", TextBoxProductID.Text)
                cmd.Parameters.AddWithValue("@ProductPrice", TextBoxProductprice.Text)
                cmd.Parameters.AddWithValue("@ProductSize", TextBoxProductsize.Text)
                cmd.Parameters.AddWithValue("@ProductDescription", TextBoxProductdescription.Text)


                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                ' add feedback for the user
                Response.Write("Product successfully added to the inventory!")
                Response.Redirect("FirstPage.aspx")
            End Using
        End Using
    End Sub
End Class

