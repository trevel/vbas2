Public Class ProductDetails
    Public prod As New Product

    Public Event prodChanged(prod As Product)
    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        prod.id = 0
    End Sub

    Public Sub New(prod As Product)
        Me.New()
        Me.prod = prod

    End Sub

End Class