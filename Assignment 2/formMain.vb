Public Class formMain
    Dim db As New DataClassesDataContext
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim dt = New DataTable
        ProductDataGridView.DataSource = db.Products
        OrderDataGridView.DataSource = db.ExpandedOrders
        CustomerDataGridView.DataSource = db.Customers

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

    Private Sub btnProductRemove_Click(sender As Object, e As EventArgs) Handles btnProductRemove.Click

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
        RefreshLists()
    End Sub

    Private Sub ProdChangedEventHandler(prod As Product)
        RefreshLists()
    End Sub

    Private Sub OrderchangedEventHandler(order As Order)
        RefreshLists()
    End Sub


End Class
