Public Class OrderDetails
    Dim db As New DataClassesDataContext

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.CustomerBindingSource.DataSource = db.Customers
        Me.ProductBindingSource.DataSource = db.Products
    End Sub

    Public Sub New(order As Order)
        Me.New()
        ' then fill in details
    End Sub


    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

    End Sub


    Private Sub btnNewAddress_Click(sender As Object, e As EventArgs) Handles btnNewAddress.Click
        If Me.custCombo.Text = "" Then Return
        Dim add As New AddressDetail(Me.custCombo.Text)
        add.Show()
    End Sub

    Private Sub btnNewCustomerForm_Click(sender As Object, e As EventArgs) Handles btnNewCustomerForm.Click
        Dim cust = New CustomerDetails()
        cust.Show()
    End Sub
End Class