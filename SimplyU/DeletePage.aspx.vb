Imports System.Data.SqlClient
Public Class RemovePage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'connection string
        Dim connectionString As String = "Data Source=Karla-Lenovo-Ideapad-3\SQLEXPRESS01;Initial Catalog=CMPG223PROJECTdatabase;Integrated Security=True"

        Dim query As String = "DELETE FROM InventoryTable WHERE ProductName = @ProductName" 'delete

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameter to avoid SQL injection
                cmd.Parameters.AddWithValue("@ProductName", TextBoxDeleteproduct.Text)

                ' Open the connection, execute the query, then close the connection
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                conn.Close()

                ' Provide feedback to the user
                If rowsAffected > 0 Then
                    Response.Write("Product deleted from the inventory!")
                Else
                    Response.Write("No product found.")
                End If
            End Using
        End Using
    End Sub
End Class