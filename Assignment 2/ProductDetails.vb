Public Class ProductDetails
    Public prod As New Product

    Public Event prodChanged(prod As Product)
    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        prod.id = 0
        statusProdLbl.Text = "New Product..."
    End Sub

    Public Sub New(prod As Product)
        Me.New()
        Me.prod = prod
        statusProdLbl.Text = "Editing..."
        tbProdDesc.Text = prod.description
        tbProdPrice.Text = prod.price.ToString
        tbProdInv.Text = prod.inventory.ToString
        cbProdActive.Checked = prod.active
    End Sub

    Private Sub btnProdCancel_clicked(sender As Object, e As EventArgs) Handles btnProdCancel.Click
        Me.Close()
    End Sub

    Private Sub btnProdSave_clicked(sender As Object, e As EventArgs) Handles btnProdSave.Click
        Dim p As Database.Product
        Dim price As Double
        Dim inventory As Integer = -1
        Dim dbresult As Integer = -1
        Try
            If Not Double.TryParse(tbProdPrice.Text, price) Then
                price = -1
            End If
            If Not Integer.TryParse(tbProdInv.Text, inventory) Then
                inventory = -1
            End If
            p = New Database.Product(prod.id, tbProdDesc.Text, price, inventory, cbProdActive.Checked)
        Catch ex As Exception
            statusProdLbl.Text = ex.Message
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End Try

        dbresult = DBAccessLib.DBAccessHelper.DBInsertOrUpdateProduct(p)
        If dbresult = -1 Then
            statusProdLbl.Text = "Error saving. Please check your connection."
            DialogResult = Windows.Forms.DialogResult.None
            Return
        End If
        prod.id = p.ID
        prod.description = p.Description
        prod.price = p.Price
        prod.inventory = p.Inventory
        prod.active = p.active
        RaiseEvent prodChanged(prod)
        Me.Close()
    End Sub
End Class