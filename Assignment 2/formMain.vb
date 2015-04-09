Public Class formMain
    Dim db As New DataClassesDataContext(DBAccessLib.DBAccessHelper.getConnectionString)
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim dt = New DataTable
        RefreshLists()
    End Sub

    Private Sub OrderDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentDoubleClick
        Dim exp_order As ExpandedOrders = OrderDataGridView.Rows(e.RowIndex).DataBoundItem
        Dim od As New OrderDetails(exp_order)
        AddHandler od.OrderChanged, AddressOf OrderchangedEventHandler
        od.Show()
    End Sub

    Private Sub CustomerDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentDoubleClick
        Dim cust As Customer = CustomerDataGridView.Rows(e.RowIndex).DataBoundItem
        Dim cd As New CustomerDetails(cust)
        AddHandler cd.CustChanged, AddressOf CustChangedEventHandler
        cd.Show()
    End Sub

    Private Sub ProductDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellContentDoubleClick
        Dim prod As Product = ProductDataGridView.Rows(e.RowIndex).DataBoundItem
        Dim pd As New ProductDetails(prod)
        AddHandler pd.ProdChanged, AddressOf ProdChangedEventHandler
        pd.Show()
    End Sub

    Private Sub RefreshLists()
        db = New DataClassesDataContext
        ProductDataGridView.DataSource = db.Products
        OrderDataGridView.DataSource = db.ExpandedOrders
        CustomerDataGridView.DataSource = db.Customers
    End Sub

    Private Sub btnOrderAdd_Click(sender As Object, e As EventArgs) Handles btnOrderAdd.Click
        Dim od As New OrderDetails()
        AddHandler od.OrderChanged, AddressOf OrderchangedEventHandler
        AddHandler od.CustChanged, AddressOf CustChangedEventHandler
        od.Show()
    End Sub

    Private Sub btnProductAdd_Click(sender As Object, e As EventArgs) Handles btnProductAdd.Click
        Dim prodD As ProductDetails = New ProductDetails()
        AddHandler prodD.prodChanged, AddressOf ProdChangedEventHandler
        prodD.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshLists()
    End Sub

    Private Sub btnCustAdd_Click(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        Dim custD As CustomerDetails = New CustomerDetails()
        AddHandler custD.CustChanged, AddressOf CustChangedEventHandler
        custD.Show()
    End Sub

    Private Sub CustChangedEventHandler(cust As Customer)
        Status.Text = "Customer list updated."
        RefreshLists()
    End Sub

    Private Sub ProdChangedEventHandler(prod As Product)
        Status.Text = "Product list updated."
        RefreshLists()
    End Sub

    Private Sub OrderchangedEventHandler()
        Status.Text = "Order list updated."
        RefreshLists()
    End Sub

    Private Sub deleteSelectedProducts_clicked(sender As Object, e As EventArgs) Handles DeleteSelectedProductsToolStripMenuItem.Click
        Dim bFailed As Boolean = False
        For Each item As DataGridViewRow In ProductDataGridView.SelectedRows
            Dim p As Product = TryCast(item.DataBoundItem, Product)
            If p IsNot Nothing Then
                If Not DBAccessLib.DBAccessHelper.DBDeleteProduct(p.id) Then
                    bFailed = True
                End If
            End If
        Next
        RefreshLists()
        If bFailed Then
            Status.Text = "Failed to remove a product(s)"
        Else
            Status.Text = "Successfully removed product(s)"
        End If
    End Sub


    Private Sub AboutToolStripMenuItem_clicked(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutDlg As AboutBox1 = New AboutBox1()
        aboutDlg.ShowDialog()
    End Sub

    Private Sub DeleteSelectedCustomers_Click(sender As Object, e As EventArgs) Handles DeleteSelectedCustomersToolStripMenuItem.Click
        Dim bFailed As Boolean = False
        For Each item As DataGridViewRow In CustomerDataGridView.SelectedRows
            Dim c As Customer = TryCast(item.DataBoundItem, Customer)
            If c IsNot Nothing Then
                If Not DBAccessLib.DBAccessHelper.DBDeleteCustomer(c.id) Then
                    bFailed = True
                End If
            End If
        Next
        RefreshLists()
        If bFailed Then
            Status.Text = "Failed to remove a customer(s)"
        Else
            Status.Text = "Successfully removed customer(s)"
        End If
    End Sub

    Private Sub DeleteSelectedOrders_Click(sender As Object, e As EventArgs) Handles DeleteSelectedOrdersToolStripMenuItem.Click
        Dim bFailed As Boolean = False
        For Each item As DataGridViewRow In OrderDataGridView.SelectedRows
            Dim o As ExpandedOrders = TryCast(item.DataBoundItem, ExpandedOrders)
            If o IsNot Nothing Then
                If Not DBAccessLib.DBAccessHelper.DBDeleteOrder(o.id) Then
                    bFailed = True
                End If
            End If
        Next
        RefreshLists()
        If bFailed Then
            Status.Text = "Failed to remove an order(s)"
        Else
            Status.Text = "Successfully removed order(s)"
        End If
    End Sub

    Private Sub ShipSelectedOrders_Click(sender As Object, e As EventArgs) Handles ShipSelectedOrdersToolStripMenuItem.Click
        Dim bFailed As Boolean = False
        For Each item As DataGridViewRow In OrderDataGridView.SelectedRows
            Dim o As ExpandedOrders = TryCast(item.DataBoundItem, ExpandedOrders)
            If o IsNot Nothing Then
                If Not DBAccessLib.DBAccessHelper.DBOrderShip(o.id) Then
                    bFailed = True
                End If
            End If
        Next
        RefreshLists()
        If bFailed Then
            Status.Text = "Failed to ship an order(s)"
        Else
            Status.Text = "Successfully shipped order(s)"
        End If
    End Sub

    Private Sub JingleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JingleToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.Bobs_Fish_Jingle, AudioPlayMode.Background)
    End Sub
End Class
