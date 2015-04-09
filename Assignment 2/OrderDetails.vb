Public Class OrderDetails
    Dim db As New DataClassesDataContext
    Private _order As New ExpandedOrders
    Public Event OrderChanged()
    Public Event CustChanged(ByVal cust As Customer)

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.custCombo.DataSource = db.Customers
        Me.prodCombo.DataSource = db.Products
        Me.OrderDatePicker.Value = Today.Date
        Me.OrderDatePicker.MaxDate = Today.Date
        _order.id = 0
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
            Dim row As Integer = orderItemGridView.Rows.Add(item.Product.description, item.Product.price, item.quantity, item.ship_date, item.product_id, item.id)
            If item.ship_date Is Nothing Then
                orderItemGridView.Rows(row).Cells("Quantity").ReadOnly = False
            End If
        Next

        tbDiscount.Text = order.discount

        CalculateTotals()
        Me.OrderDatePicker.Value = order.order_date
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
                Dim row As Integer = orderItemGridView.Rows.Add(prod.description, prod.price, 1, Nothing, prod.id, 0)
                orderItemGridView.Rows.Item(row).Cells("Quantity").ReadOnly = False
            Else
                orderItemGridView.Rows.Item(item(0)).Cells.Item("Quantity").Value += 1
            End If
        End If
        CalculateTotals()
    End Sub


    Private Sub custCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles custCombo.SelectedIndexChanged
        'If Me.Visible = True Then
        '    If custCombo.SelectedItem.GetType() = System.String Then Return
        Dim cust As Customer = custCombo.SelectedItem
        populateAddress(cust.id, 0)
        'End If

    End Sub

    Private Function getDiscount() As Double
        Dim discount As Double = 0
        If tbDiscount.Text = "" Then
            discount = 0
        Else
            Double.TryParse(tbDiscount.Text, discount)
        End If
        Return discount
    End Function
    Private Sub CalculateTotals()
        Dim subtotal As Double = 0
        For Each row As DataGridViewRow In orderItemGridView.Rows
            subtotal += row.Cells(1).Value * row.Cells(2).Value
        Next
        Me.subtotal.Text = String.Format("${0:N2}", subtotal)
        Me.Total.Text = String.Format("${0:N2}", subtotal * (100 - getDiscount()) / 100)
    End Sub

    Private Sub orderItemGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles orderItemGridView.CellValueChanged
        CalculateTotals()
    End Sub

    Private Sub tbDiscount_TextChanged(sender As Object, e As EventArgs) Handles tbDiscount.TextChanged
        CalculateTotals()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim order As Database.Order
        Dim items As New List(Of Database.OrderItem)

        Try
            order = New Database.Order(_order.id, Me.custCombo.SelectedItem.id, OrderDatePicker.Value, getDiscount, AddressDataGridView.SelectedRows(0).Cells(4).Value)
        Catch ex As Exception
            Status.Text = ex.Message
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End Try

        For Each row As DataGridViewRow In orderItemGridView.Rows
            Try

                items.Add(New Database.OrderItem(row.Cells("OrderItemId").Value, _order.id, row.Cells("prodid").Value, row.Cells("quantity").Value, row.Cells("ShipDate").Value))
            Catch ex As Exception
                Try
                    Status.Text = ex.Message & " : " & row.Cells("product").Value
                Catch ex2 As Exception
                    Status.Text = ex.Message
                End Try
            End Try
        Next

        Dim dbresult As Integer = DBAccessLib.DBAccessHelper.DBInsertOrUpdateOrder(order, items)
        If dbresult = -1 Then
            Status.Text = "Save failed."
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End If
        RaiseEvent OrderChanged()
        Me.Close()
    End Sub
End Class