Public Class OrderDetails

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Sub New(order As Order)
        Me.New()
        ' then fill in details
    End Sub


    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

    End Sub


End Class