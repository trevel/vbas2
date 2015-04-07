Public Class OrderDetails
    Dim db As New DataClassesDataContext
    Private _order As ExpandedOrders
    Public Event OrderChanged(ByVal order As Order)
    Public Event CustChanged(ByVal cust As Customer)

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

        custCombo.DataSource = order.Customers

        btnNewCustomerForm.Visible = False

        populateAddress(order.customer_id, order.Orders.shipping_address_id)

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

    Private Sub populateAddress(id As Integer, selected As Integer)
        lvAddress.Items.Clear()
        Dim a = From add In db.Addresses
                Where add.customer_id = id
                Select add
        For Each item As Address In a
            Dim x = lvAddress.Items.Add(item.street & "," & item.city & ", " & item.province)
            If item.id = selected Then x.Selected = True
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
        Using custD As CustomerDetails = New CustomerDetails()
            custD.ShowDialog()
            db = New DataClassesDataContext
            If (custD.DialogResult = DialogResult.OK) Then
                custCombo.DataSource = db.Customers
                custCombo.SelectedIndex = custCombo.Items.Count - 1
                custCombo.Refresh()
                RaiseEvent CustChanged(custD.cust)
            End If
        End Using
    End Sub

    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnProdAdd.Click
        If prodCombo.SelectedItem IsNot Nothing Then
            Dim prod As Product = prodCombo.SelectedItem
            Dim row As Integer = orderItemGridView.Rows.Add(prod.description, prod.price, 1, Nothing)
            orderItemGridView.Rows.Item(row).Cells.Item(2).ReadOnly = False


        End If
    End Sub


    Private Sub custCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles custCombo.SelectedIndexChanged
        If Me.Visible = True Then
            '    If custCombo.SelectedItem.GetType() = System.String Then Return
            Dim cust As Customer = custCombo.SelectedItem
            populateAddress(cust.id, 0)
        End If
        
    End Sub

    Private Sub save()
        Dim items As New Order_Line
        '  items.id = ?
        '  items.
    End Sub
End Class