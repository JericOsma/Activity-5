Public Class LoginDesign1


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If username.Text = "admin" And password.Text = "admin" Then
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Credentials")
        End If
    End Sub
End Class