<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.custCombo = New System.Windows.Forms.ComboBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNewCustomerForm = New System.Windows.Forms.Button()
        Me.btnNewAddress = New System.Windows.Forms.Button()
        Me.prodCombo = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnProdAdd = New System.Windows.Forms.Button()
        Me.tbDiscount = New System.Windows.Forms.TextBox()
        Me.OrderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.orderItemGridView = New System.Windows.Forms.DataGridView()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderItemContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetQuantityTo0ToDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderItemContextMenuStrip.SuspendLayout()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'custCombo
        '
        Me.custCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomerBindingSource, "id", True))
        Me.custCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.CustomerBindingSource, "name", True))
        Me.custCombo.DataSource = Me.CustomerBindingSource
        Me.custCombo.DisplayMember = "name"
        Me.custCombo.FormattingEnabled = True
        Me.custCombo.Location = New System.Drawing.Point(13, 35)
        Me.custCombo.Name = "custCombo"
        Me.custCombo.Size = New System.Drawing.Size(391, 21)
        Me.custCombo.TabIndex = 0
        Me.custCombo.ValueMember = "ID"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Assignment_2.Customer)
        Me.CustomerBindingSource.Filter = ""
        '
        'btnNewCustomerForm
        '
        Me.btnNewCustomerForm.Location = New System.Drawing.Point(410, 35)
        Me.btnNewCustomerForm.Name = "btnNewCustomerForm"
        Me.btnNewCustomerForm.Size = New System.Drawing.Size(92, 23)
        Me.btnNewCustomerForm.TabIndex = 1
        Me.btnNewCustomerForm.Text = "New Customer"
        Me.btnNewCustomerForm.UseVisualStyleBackColor = True
        '
        'btnNewAddress
        '
        Me.btnNewAddress.Location = New System.Drawing.Point(410, 80)
        Me.btnNewAddress.Name = "btnNewAddress"
        Me.btnNewAddress.Size = New System.Drawing.Size(92, 23)
        Me.btnNewAddress.TabIndex = 3
        Me.btnNewAddress.Text = "New Address"
        Me.btnNewAddress.UseVisualStyleBackColor = True
        '
        'prodCombo
        '
        Me.prodCombo.DataSource = Me.ProductBindingSource
        Me.prodCombo.DisplayMember = "description"
        Me.prodCombo.FormattingEnabled = True
        Me.prodCombo.Location = New System.Drawing.Point(12, 224)
        Me.prodCombo.Name = "prodCombo"
        Me.prodCombo.Size = New System.Drawing.Size(272, 21)
        Me.prodCombo.TabIndex = 4
        Me.prodCombo.ValueMember = "id"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(Assignment_2.Product)
        '
        'btnProdAdd
        '
        Me.btnProdAdd.Location = New System.Drawing.Point(290, 222)
        Me.btnProdAdd.Name = "btnProdAdd"
        Me.btnProdAdd.Size = New System.Drawing.Size(40, 23)
        Me.btnProdAdd.TabIndex = 5
        Me.btnProdAdd.Text = "Add"
        Me.btnProdAdd.UseVisualStyleBackColor = True
        '
        'tbDiscount
        '
        Me.tbDiscount.Location = New System.Drawing.Point(358, 542)
        Me.tbDiscount.Name = "tbDiscount"
        Me.tbDiscount.Size = New System.Drawing.Size(38, 20)
        Me.tbDiscount.TabIndex = 8
        '
        'OrderItemBindingSource
        '
        Me.OrderItemBindingSource.DataSource = GetType(Assignment_2.Order_Line)
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataSource = GetType(Assignment_2.Address)
        '
        'orderItemGridView
        '
        Me.orderItemGridView.AllowUserToAddRows = False
        Me.orderItemGridView.AllowUserToDeleteRows = False
        Me.orderItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderItemGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Price, Me.Quantity, Me.ShipDate, Me.prodid, Me.OrderItemId})
        Me.orderItemGridView.ContextMenuStrip = Me.OrderItemContextMenuStrip
        Me.orderItemGridView.Location = New System.Drawing.Point(12, 246)
        Me.orderItemGridView.Name = "orderItemGridView"
        Me.orderItemGridView.Size = New System.Drawing.Size(490, 277)
        Me.orderItemGridView.TabIndex = 6
        '
        'Product
        '
        Me.Product.DataPropertyName = "Product"
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ShipDate
        '
        Me.ShipDate.HeaderText = "Shipping Date"
        Me.ShipDate.Name = "ShipDate"
        Me.ShipDate.ReadOnly = True
        '
        'prodid
        '
        Me.prodid.HeaderText = "Prodid"
        Me.prodid.Name = "prodid"
        Me.prodid.ReadOnly = True
        Me.prodid.Visible = False
        '
        'OrderItemId
        '
        Me.OrderItemId.HeaderText = "OrderItemId"
        Me.OrderItemId.Name = "OrderItemId"
        Me.OrderItemId.ReadOnly = True
        Me.OrderItemId.Visible = False
        '
        'OrderItemContextMenuStrip
        '
        Me.OrderItemContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetQuantityTo0ToDeleteToolStripMenuItem})
        Me.OrderItemContextMenuStrip.Name = "ContextMenuStrip"
        Me.OrderItemContextMenuStrip.Size = New System.Drawing.Size(210, 26)
        '
        'SetQuantityTo0ToDeleteToolStripMenuItem
        '
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Name = "SetQuantityTo0ToDeleteToolStripMenuItem"
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Text = "Set quantity to 0 to delete"
        '
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.CustomerBindingSource
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(526, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 0)
        '
        'AddressDataGridView
        '
        Me.AddressDataGridView.AllowUserToAddRows = False
        Me.AddressDataGridView.AllowUserToDeleteRows = False
        Me.AddressDataGridView.AllowUserToOrderColumns = True
        Me.AddressDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.street, Me.city, Me.province, Me.postal_code, Me.id})
        Me.AddressDataGridView.Location = New System.Drawing.Point(13, 80)
        Me.AddressDataGridView.MultiSelect = False
        Me.AddressDataGridView.Name = "AddressDataGridView"
        Me.AddressDataGridView.ReadOnly = True
        Me.AddressDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AddressDataGridView.Size = New System.Drawing.Size(390, 121)
        Me.AddressDataGridView.TabIndex = 2
        '
        'street
        '
        Me.street.HeaderText = "Street"
        Me.street.Name = "street"
        Me.street.ReadOnly = True
        Me.street.Width = 60
        '
        'city
        '
        Me.city.HeaderText = "City"
        Me.city.Name = "city"
        Me.city.ReadOnly = True
        Me.city.Width = 49
        '
        'province
        '
        Me.province.HeaderText = "Province"
        Me.province.MaxInputLength = 2
        Me.province.Name = "province"
        Me.province.ReadOnly = True
        Me.province.Width = 74
        '
        'postal_code
        '
        Me.postal_code.HeaderText = "PostalCode"
        Me.postal_code.MaxInputLength = 7
        Me.postal_code.Name = "postal_code"
        Me.postal_code.ReadOnly = True
        Me.postal_code.Width = 86
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'OrderDatePicker
        '
        Me.OrderDatePicker.CustomFormat = "yyyy-mm-dd"
        Me.OrderDatePicker.Location = New System.Drawing.Point(13, 591)
        Me.OrderDatePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderDatePicker.Name = "OrderDatePicker"
        Me.OrderDatePicker.Size = New System.Drawing.Size(199, 20)
        Me.OrderDatePicker.TabIndex = 7
        Me.OrderDatePicker.Value = New Date(2015, 4, 7, 19, 49, 21, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 526)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Discount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 576)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Order Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Shipping Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Products To Order"
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Location = New System.Drawing.Point(273, 526)
        Me.subtotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(53, 13)
        Me.subtotalLabel.TabIndex = 22
        Me.subtotalLabel.Text = "SubTotal:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(436, 526)
        Me.LabelTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(34, 13)
        Me.LabelTotal.TabIndex = 23
        Me.LabelTotal.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(390, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "%"
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(370, 592)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(451, 591)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(273, 544)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(39, 13)
        Me.subtotal.TabIndex = 27
        Me.subtotal.Text = "Label7"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(436, 544)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(39, 13)
        Me.Total.TabIndex = 28
        Me.Total.Text = "Label8"
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 640)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderDatePicker)
        Me.Controls.Add(Me.AddressDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.orderItemGridView)
        Me.Controls.Add(Me.tbDiscount)
        Me.Controls.Add(Me.btnProdAdd)
        Me.Controls.Add(Me.prodCombo)
        Me.Controls.Add(Me.btnNewAddress)
        Me.Controls.Add(Me.btnNewCustomerForm)
        Me.Controls.Add(Me.custCombo)
        Me.Name = "OrderDetails"
        Me.Text = "OrderDetails"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderItemContextMenuStrip.ResumeLayout(False)
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents custCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewCustomerForm As System.Windows.Forms.Button
    Friend WithEvents btnNewAddress As System.Windows.Forms.Button
    Friend WithEvents prodCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btnProdAdd As System.Windows.Forms.Button
    Friend WithEvents tbDiscount As System.Windows.Forms.TextBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents orderItemGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OrderItemContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetQuantityTo0ToDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddressDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents street As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents city As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents postal_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents subtotalLabel As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents subtotal As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderItemId As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
