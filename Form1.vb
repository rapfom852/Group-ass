Public Class Form1
    Dim root1, root2, root3, a, b, c As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        root1 = (b ^ 2 - 4.0 * a * c)

        root2 = (-b + (Math.Sqrt(root1)) / (2 * a))
        root3 = (-b - (Math.Sqrt(root1)) / (2 * a))

        Label7.Text = root2
        Label10.Text = root3
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
