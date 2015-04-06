Public Class OrderDetails
    Dim db As New DataClassesDataContext
    Private _order As ExpandedOrders

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.custCombo.DataSource = db.Customers
        Me.prodCombo.DataSource = db.Products
    End Sub

    Public Sub New(order As ExpandedOrders)
        MyBase.New()
        InitializeComponent()

        ' TODO: Complete member initialization 
        _order = order

        custCombo.DataSource = Nothing
        custCombo.SelectedItem = custCombo.Items.Add(order.name)

        btnNewCustomerForm.Visible = False

        Me.prodCombo.DataSource = db.Products

        Dim x As Integer = Aggregate lines In order.Order_Lines
                                 Where lines.ship_date IsNot Nothing
                                 Into Count()
        If x = 0 Then
            btnNewAddress.Visible = True
            'TODO: Address List box active, nothing has been sent.
        Else
            btnNewAddress.Visible = False
            'TODO: Address List Box inactive. 
        End If

        For Each item As Order_Line In order.Order_Lines
            Dim row As Integer = orderItemGridView.Rows.Add(item.Product.description, item.Product.price, item.quantity, item.ship_date)
            If item.ship_date Is Nothing Then
                orderItemGridView.Rows.Item(row).Cells.Item(2).ReadOnly = False
            End If
        Next



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

    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnProdAdd.Click
        If prodCombo.SelectedItem IsNot Nothing Then
            Dim prod As Product = prodCombo.SelectedItem
            Dim row As Integer = orderItemGridView.Rows.Add(prod.description, prod.price, 1, Nothing)
            orderItemGridView.Rows.Item(row).Cells.Item(2).ReadOnly = False


        End If
    End Sub
End Class