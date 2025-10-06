Namespace Shopping_Cart
    Public Class ShoppingCartService
        Private Const LaptopPrice As Integer = 50000
        Private Const MousePrice As Integer = 10000
        Private Const KeyboardPrice As Integer = 8000

        Public Function CalculateTotal(isLaptopSelected As Boolean, isMouseSelected As Boolean, isKeyboardSelected As Boolean) As Integer
            Dim total As Integer = 0

            If isLaptopSelected Then
                total += LaptopPrice
            End If

            If isMouseSelected Then
                total += MousePrice
            End If

            If isKeyboardSelected Then
                total += KeyboardPrice
            End If

            Return total
        End Function

        Public Function FormatTotal(total As Integer) As String
            Return "Total is : ₹ " + Str(total)
        End Function
    End Class
End Namespace
