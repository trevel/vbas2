Public Class formMain
    Dim db As New DataClassesDataContext
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim dt = New DataTable
        ProductDataGridView.DataSource = db.Products
        OrderDataGridView.DataSource = db.ExpandedOrders
        CustomerDataGridView.DataSource = db.Customers

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentClick
        ' e.RowIndex()
    End Sub

    Private Sub btnOrderAdd_Click(sender As Object, e As EventArgs) Handles btnOrderAdd.Click
        Dim od As New OrderDetails()
        od.Show()

    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub

    Private Sub CustomerBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerBindingSource.CurrentChanged

    End Sub

    Private Sub OrderBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles OrderBindingSource.CurrentChanged

    End Sub
End Class
