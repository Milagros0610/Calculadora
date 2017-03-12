Public Class CALCULADORA
    Dim r1, r2, r3, r4 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        r1 = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = r1
        r2 = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox4.Text = r2
        r3 = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox5.Text = r3
        r4 = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox6.Text = r4
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
