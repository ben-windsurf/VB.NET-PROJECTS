Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Shopping_Cart

Namespace Shopping_Cart.Tests
    <TestClass>
    Public Class ShoppingCartServiceTests
        Private _service As ShoppingCartService

        <TestInitialize>
        Public Sub Setup()
            _service = New ShoppingCartService()
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_NoItemsSelected_ReturnsZero()
            Dim result As Integer = _service.CalculateTotal(False, False, False)
            Assert.AreEqual(0, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_OnlyLaptopSelected_Returns50000()
            Dim result As Integer = _service.CalculateTotal(True, False, False)
            Assert.AreEqual(50000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_OnlyMouseSelected_Returns10000()
            Dim result As Integer = _service.CalculateTotal(False, True, False)
            Assert.AreEqual(10000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_OnlyKeyboardSelected_Returns8000()
            Dim result As Integer = _service.CalculateTotal(False, False, True)
            Assert.AreEqual(8000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_LaptopAndMouseSelected_Returns60000()
            Dim result As Integer = _service.CalculateTotal(True, True, False)
            Assert.AreEqual(60000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_LaptopAndKeyboardSelected_Returns58000()
            Dim result As Integer = _service.CalculateTotal(True, False, True)
            Assert.AreEqual(58000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_MouseAndKeyboardSelected_Returns18000()
            Dim result As Integer = _service.CalculateTotal(False, True, True)
            Assert.AreEqual(18000, result)
        End Sub

        <TestMethod>
        Public Sub CalculateTotal_AllItemsSelected_Returns68000()
            Dim result As Integer = _service.CalculateTotal(True, True, True)
            Assert.AreEqual(68000, result)
        End Sub

        <TestMethod>
        Public Sub FormatTotal_Zero_ReturnsFormattedString()
            Dim result As String = _service.FormatTotal(0)
            Assert.AreEqual("Total is : ₹  0", result)
        End Sub

        <TestMethod>
        Public Sub FormatTotal_PositiveValue_ReturnsFormattedString()
            Dim result As String = _service.FormatTotal(50000)
            Assert.AreEqual("Total is : ₹  50000", result)
        End Sub

        <TestMethod>
        Public Sub FormatTotal_MaximumValue_ReturnsFormattedString()
            Dim result As String = _service.FormatTotal(68000)
            Assert.AreEqual("Total is : ₹  68000", result)
        End Sub
    End Class
End Namespace
