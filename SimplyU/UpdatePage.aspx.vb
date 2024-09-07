Imports System.Data.SqlClient
Public Class UpdatePage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Dim productId As Integer = Convert.ToInt32(TextBoxProductID.Text)
        Dim productName As String = TxtProductname.Text
        Dim quantityInStock As Integer = Convert.ToInt32(TextBoxQinstock.Text)
        Dim supplierId As Integer = Convert.ToInt32(TextBoxSupplierID.Text)
        Dim inventoryId As Integer = Convert.ToInt32(TextBoxInventoryID.Text)
        Dim productPrice As Decimal = Convert.ToDecimal(TextBoxProductprice.Text)
        Dim productSize As String = TextBoxProductsize.Text
        Dim productDescription As String = TextBoxProductdescription.Text

        Dim query As String = "UPDATE InventoryTable SET ProductName = @ProductName, QuantityInStock = @QuantityInStock, SupplierID = @SupplierID, " &
                              "InventoryID = @InventoryID, ProductPrice = @ProductPrice, ProductSize = @ProductSize, ProductDescription = @ProductDescription " &
                              "WHERE ProductID = @ProductID"

        Using conn As New SqlConnection("Data Source=Karla-Lenovo-Ideapad-3\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True")
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock)
                cmd.Parameters.AddWithValue("@SupplierID", supplierId)
                cmd.Parameters.AddWithValue("@InventoryID", inventoryId)
                cmd.Parameters.AddWithValue("@ProductPrice", productPrice)
                cmd.Parameters.AddWithValue("@ProductSize", productSize)
                cmd.Parameters.AddWithValue("@ProductDescription", productDescription)
                cmd.Parameters.AddWithValue("@ProductID", productId)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using

        ' Redirect or show a confirmation message
        Response.Redirect("FirstPage.aspx")
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim productId As Integer = Convert.ToInt32(DropDownList1.SelectedValue)

        ' Fetch product details from the database based on the selected ProductID
        Using conn As New SqlConnection("YourConnectionStringHere")
            Dim query As String = "SELECT * FROM InventoryTable WHERE ProductID = @ProductID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", productId)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        TxtProductname.Text = reader("ProductName").ToString()
                        TextBoxQinstock.Text = reader("QuantityInStock").ToString()
                        TextBoxSupplierID.Text = reader("SupplierID").ToString()
                        TextBoxInventoryID.Text = reader("InventoryID").ToString()
                        TextBoxProductID.Text = reader("ProductID").ToString()
                        TextBoxProductprice.Text = reader("ProductPrice").ToString()
                        TextBoxProductsize.Text = reader("ProductSize").ToString()
                        TextBoxProductdescription.Text = reader("ProductDescription").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class