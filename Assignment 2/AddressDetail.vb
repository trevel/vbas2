Imports DBAccessLib

Public Class AddressDetail
    Public address As New Address
    Sub New(custname As String)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.custName.Text = custname

    End Sub

    Sub New(custname As String, address As Address)
        Me.New(custname)
        Me.address = address
        Me.tbCity.Text = address.city
        Me.tbStreet.Text = address.street
        Me.tbProvince.Text = address.province
        Me.tbPostalCode.Text = address.postal_code
    End Sub


    Private Sub btnSaveAddress_Click(sender As Object, e As EventArgs) Handles btnSaveAddress.Click
        Dim a As Database.Address
        Try
            a = New Database.Address(0, 0, tbStreet.Text, tbCity.Text, tbProvince.Text, tbPostalCode.Text)
        Catch ex As Exception
            Status.Text = ex.Message
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End Try
        address.city = a.city
        address.street = a.street
        address.province = a.province
        address.postal_code = a.postal_code
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class