Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles no2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ans.Click

    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        ShowData.Text = Val(value1.Text) + Val(value2.Text)
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        ShowData.Text = Val(value1.Text) - Val(value2.Text)
    End Sub

    Private Sub into_Click(sender As Object, e As EventArgs) Handles into.Click
        ShowData.Text = Val(value1.Text) * Val(value2.Text)
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        ShowData.Text = Val(value1.Text) / Val(value2.Text)
    End Sub
End Class
