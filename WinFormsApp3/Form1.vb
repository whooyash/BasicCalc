Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then
            TextBox3.Text = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)
        End If

        If CheckBox2.Checked = True Then
            TextBox3.Text = Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text)
        End If

        If CheckBox3.Checked = True Then
            TextBox3.Text = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text)
        End If

        If CheckBox4.Checked = True Then
            TextBox3.Text = Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text)
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = BackColor
    End Sub
End Class
