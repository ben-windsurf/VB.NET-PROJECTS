Public Class Form1
    Private ReadOnly _cartService As New Shopping_Cart.ShoppingCartService()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer = _cartService.CalculateTotal(
            CheckBox1.Checked,
            CheckBox2.Checked,
            CheckBox3.Checked
        )
        TextBox1.Text = _cartService.FormatTotal(total)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        TextBox1.Text = "Total is :"
    End Sub
End Class
