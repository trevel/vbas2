Public Class CustomerDetails
    Public Property cust As New Customer
    Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        cust.id = 0
    End Sub

    Public Event CustChanged(ByVal cust As Object)

    Sub New(ByRef cust As Customer)
        Me.New()
        Me.cust = cust
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Database.Customer
        Try
            c = New Database.Customer(cust.id, tbName.Text, tbEmail.Text, 0, 0, tbPhoneNumber.Text, Double.Parse(tbCreditLimit.Text))
        Catch
            Return
        End Try
        Dim dbresult As Integer
        If c.ID = 0 Then
            dbresult = DBAccessLib.DBAccessHelper.DBInsertCustomer(c)
            c.ID = dbresult
        Else
            dbresult = DBAccessLib.DBAccessHelper.DBUpdateCustomer(c)
        End If
        If dbresult = -1 Then
            Return
        End If
        cust.id = c.ID
        cust.name = c.name
        cust.email = c.email
        cust.credit_limit = c.credit_limit
        RaiseEvent CustChanged(cust)
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class