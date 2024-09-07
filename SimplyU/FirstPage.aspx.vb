Public Class FirstPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Response.Redirect("Addpage.aspx")
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Response.Redirect("DeletePage.aspx")
    End Sub

    Protected Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Response.Redirect("UpdatePage.aspx")
    End Sub

    Protected Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Response.Redirect("ViewPage.aspx")
    End Sub
End Class