Public Class formMain

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentClick
        ' e.RowIndex()
    End Sub

    Private Sub btnOrderAdd_Click(sender As Object, e As EventArgs) Handles btnOrderAdd.Click
        Dim od As New OrderDetails()
        od.Show()

    End Sub
End Class
