Public Class CustomerDetails
    Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(cust As Customer)
        Me.New()
    End Sub


End Class