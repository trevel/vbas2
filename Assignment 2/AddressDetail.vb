Public Class AddressDetail
    Sub New(custname As String)
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.custName.Text = custname

    End Sub

    Sub New(custname As String, address As Address)
        Me.New(custname)
        Me.tbCity.Text = address.city
        Me.tbStreet.Text = address.street
        Me.tbProvince.Text = address.province
        Me.tbPostalCode.Text = address.postal_code
    End Sub
   
End Class