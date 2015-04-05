Public Class OrderDetails
    Dim db As New DataClassesDataContext
    Private _order As ExpandedOrders

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.CustomerBindingSource.DataSource = db.Customers
        Me.ProductBindingSource.DataSource = db.Products
    End Sub

    Public Sub New(order As ExpandedOrders)
        MyBase.New()
        InitializeComponent()

        ' TODO: Complete member initialization 
        _order = order

        custCombo.DataSource = Nothing
        custCombo.SelectedItem = custCombo.Items.Add(order.name)

        btnNewCustomerForm.Visible = False

        Dim x As List(Of Date) = From lines In order.Order_Lines
                                 Where lines.ship_date IsNot Nothing
                                 Select lines.ship_date
        If x.Count = 0 Then
            btnNewAddress.Visible = True
            'TODO: Address List box active, nothing has been sent.
        Else
            btnNewAddress.Visible = False
            'TODO: Address List Box inactive. 
        End If

        orderItemGridView.DataSource = order.Order_Lines

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