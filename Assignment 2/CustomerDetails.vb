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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Database.Customer
        Try
            c = New Database.Customer(0, tbName.Text, tbEmail.Text, 0, 0, tbPhoneNumber.Text, Double.Parse(tbCreditLimit.Text))
        Catch
            Return
        End Try
        c.ID = DBAccessLib.DBAccessHelper.DBInsertCustomer(c)
        If c.ID = -1 Then
            Return
        End If

        Me.Close()
    End Sub
End Class