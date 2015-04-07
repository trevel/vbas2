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
            AddressDataGridView.Enabled = True
        Else
            btnNewAddress.Visible = False
            AddressDataGridView.Enabled = False
        End If

        For Each item As Order_Line In order.Order_Lines
            Dim row As Integer = orderItemGridView.Rows.Add(item.Product.description, item.Product.price, item.quantity, item.ship_date)
            If item.ship_date Is Nothing Then
                orderItemGridView.Rows.Item(row).Cells.Item(2).ReadOnly = False
            End If
        Next
    End Sub

    Private Sub populateAddress(id As Integer, selected As Integer)
        AddressDataGridView.Rows.Clear()
        Dim a = From add In db.Addresses
                Where add.customer_id = id
                Select add
        For Each ad As Address In a
            AddressDataGridView.Rows.Add(ad.street, ad.city, ad.province, ad.postal_code, ad.id)
        Next
        For Each row As DataGridViewRow In AddressDataGridView.Rows
            If row.Cells.Item(4).Value = selected Then
                row.Selected = True
            End If
        Next
    End Sub

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
    End Sub

    Private Sub btnNewAddress_Click(sender As Object, e As EventArgs) Handles btnNewAddress.Click
        Dim a As Database.Address

        If Me.custCombo.Text = "" Then Return
        Using add As New AddressDetail(Me.custCombo.Text)
            add.ShowDialog()
            If add.DialogResult = Windows.Forms.DialogResult.OK Then
                a = New Database.Address(add.address.id, Me.custCombo.SelectedItem.id, add.address.street, add.address.city, add.address.province, add.address.postal_code)
                If a.ID = 0 Then
                    a.ID = DBAccessLib.DBAccessHelper.DBInsertAddress(a)
                End If
                If a.ID = -1 Then
                    MsgBox("Could not save address: " & a.ToString)
                End If
                populateAddress(Me.custCombo.SelectedItem.id, a.ID)
            End If
        End Using

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
                Status.Text = "New customer created"
            End If
        End Using
    End Sub

    Private Sub btnProdAdd_Click(sender As Object, e As EventArgs) Handles btnProdAdd.Click
        If prodCombo.SelectedItem IsNot Nothing Then
            Dim prod As Product = prodCombo.SelectedItem
            Dim item = From rows As DataGridViewRow In orderItemGridView.Rows
                       Where rows.Cells.Item(0).Value = prod.description And ShipDate Is Nothing
                       Select rows.Index
            If item Is Nothing Or item.Count = 0 Then
                Dim row As Integer = orderItemGridView.Rows.Add(prod.description, prod.price, 1, Nothing)
                orderItemGridView.Rows.Item(row).Cells.Item(2).ReadOnly = False
            Else
                orderItemGridView.Rows.Item(item(0)).Cells.Item(2).Value += 1
            End If
        End If
    End Sub


    Private Sub custCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles custCombo.SelectedIndexChanged
        'If Me.Visible = True Then
        '    If custCombo.SelectedItem.GetType() = System.String Then Return
        Dim cust As Customer = custCombo.SelectedItem
        populateAddress(cust.id, 0)
        'End If

    End Sub

    Private Sub save()
        Dim items As New Order_Line

        ' step one: validate customer/address
        ' step two: validate order items
        ' step three: validate discount/order date
        ' step four: save all 

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class