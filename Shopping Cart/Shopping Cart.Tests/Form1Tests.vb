Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Shopping_Cart

<TestClass()>
Public Class Form1Tests

    <TestMethod()>
    Public Sub Button1_Click_NoCheckboxesSelected_ShowsZeroTotal()
        Dim form As New Form1()
        form.CheckBox1.Checked = False
        form.CheckBox2.Checked = False
        form.CheckBox3.Checked = False

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  0", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_OnlyLaptopSelected_Shows50000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = True
        form.CheckBox2.Checked = False
        form.CheckBox3.Checked = False

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  50000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_OnlyMouseSelected_Shows10000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = False
        form.CheckBox2.Checked = True
        form.CheckBox3.Checked = False

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  10000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_OnlyKeyboardSelected_Shows8000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = False
        form.CheckBox2.Checked = False
        form.CheckBox3.Checked = True

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  8000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_LaptopAndMouseSelected_Shows60000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = True
        form.CheckBox2.Checked = True
        form.CheckBox3.Checked = False

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  60000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_LaptopAndKeyboardSelected_Shows58000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = True
        form.CheckBox2.Checked = False
        form.CheckBox3.Checked = True

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  58000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_MouseAndKeyboardSelected_Shows18000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = False
        form.CheckBox2.Checked = True
        form.CheckBox3.Checked = True

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  18000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button1_Click_AllCheckboxesSelected_Shows68000Total()
        Dim form As New Form1()
        form.CheckBox1.Checked = True
        form.CheckBox2.Checked = True
        form.CheckBox3.Checked = True

        form.Button1.PerformClick()

        Assert.AreEqual("Total is : ₹  68000", form.TextBox1.Text)
    End Sub

    <TestMethod()>
    Public Sub Button2_Click_ClearsAllCheckboxesAndResetsText()
        Dim form As New Form1()
        form.CheckBox1.Checked = True
        form.CheckBox2.Checked = True
        form.CheckBox3.Checked = True
        form.TextBox1.Text = "Total is : ₹  68000"

        form.Button2.PerformClick()

        Assert.AreEqual(False, form.CheckBox1.Checked)
        Assert.AreEqual(False, form.CheckBox2.Checked)
        Assert.AreEqual(False, form.CheckBox3.Checked)
        Assert.AreEqual("Total is :", form.TextBox1.Text)
    End Sub

End Class
