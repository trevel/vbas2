Public Class formMain

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cvb815a_assign2DataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.Cvb815a_assign2DataSet.Product)

    End Sub
End Class
