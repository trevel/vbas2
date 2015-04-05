Public Class formMain
    Dim db As New DataClassesDataContext
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim dt = New DataTable
        OrderDataGridView.DataSource = db.ExpandedOrders
        CustomerDataGridView.DataSource = db.Customers
    End Sub

    Private Sub OrderDataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentDoubleClick
        Dim exp_order As ExpandedOrders = OrderDataGridView.Rows(e.RowIndex).DataBoundItem
        Dim od As New OrderDetails() 'DBAccessLib.getOrderById(exp_order.id))
        od.Show()
    End Sub

    Private Sub btnOrderAdd_Click(sender As Object, e As EventArgs) Handles btnOrderAdd.Click
        Dim od As New OrderDetails()
        od.Show()
    End Sub
End Class
