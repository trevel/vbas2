Public Class CustomerDetails
    Public Property cust As New Customer
    Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.cust.id = 0
        status.Text = "New Customer..."
    End Sub

    Public Event CustChanged(ByVal cust As Object)

    Sub New(ByRef cust As Customer)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.cust = cust
        status.Text = "Editing..."
        tbName.Text = cust.name
        tbEmail.Text = cust.email
        tbPhoneNumber.Text = cust.phone
        tbCreditLimit.Text = cust.credit_limit.ToString

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim c As Database.Customer
        Try
            Dim credlimit As Double
            Try
                credlimit = Double.Parse(tbCreditLimit.Text.Trim)
            Catch ex As Exception
                credlimit = -1
            End Try
            c = New Database.Customer(cust.id, tbName.Text, tbEmail.Text, 0, 0, tbPhoneNumber.Text, credlimit)
        Catch ex As Exception
            status.Text = ex.Message
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End Try
        Dim dbresult As Integer
        If c.ID = 0 Then
            dbresult = DBAccessLib.DBAccessHelper.DBInsertCustomer(c)
            c.ID = dbresult
        Else
            If DBAccessLib.DBAccessHelper.DBUpdateCustomer(c) Then
                dbresult = 1
            Else
                dbresult = -1
            End If
        End If
        If dbresult = -1 Then
            status.Text = "Error saving. Please check your connection."
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End If
        cust.id = c.ID
        cust.name = c.name
        cust.email = c.email
        cust.credit_limit = c.credit_limit
        RaiseEvent CustChanged(cust)

        Dim a As Database.Address
        For Each row As DataGridViewRow In AddressDataGridView.Rows
            Dim addressid As Integer
            Try
                addressid = Integer.Parse(row.Cells.Item(4).Value(0))
            Catch ex As Exception
                addressid = 0
            End Try
            a = New Database.Address(addressid, cust.id, row.Cells.Item(0).Value, row.Cells.Item(1).Value, row.Cells.Item(2).Value, row.Cells.Item(3).Value)
            If a.ID = 0 Then
                dbresult = DBAccessLib.DBAccessHelper.DBInsertAddress(a)
            Else
                If DBAccessLib.DBAccessHelper.DBUpdateAddress(a) Then
                    dbresult = 1
                Else
                    dbresult = -1
                End If
            End If
            If dbresult = -1 Then
                MsgBox("Could not save address: " & a.ToString)
            End If
        Next


        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using ad As New AddressDetail(tbName.Text)
            ad.ShowDialog()
            If (ad.DialogResult = DialogResult.OK) Then
                AddressDataGridView.Rows.Add(ad.address.street, ad.address.city, ad.address.province, ad.address.postal_code, 0)
            End If
        End Using

    End Sub
End Class