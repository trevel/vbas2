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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OrderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.orderItemGridView = New System.Windows.Forms.DataGridView()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetQuantityTo0ToDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip.SuspendLayout()
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
        Me.custCombo.Location = New System.Drawing.Point(26, 67)
        Me.custCombo.Margin = New System.Windows.Forms.Padding(6)
        Me.custCombo.Name = "custCombo"
        Me.custCombo.Size = New System.Drawing.Size(778, 33)
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
        Me.btnNewCustomerForm.Location = New System.Drawing.Point(820, 67)
        Me.btnNewCustomerForm.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNewCustomerForm.Name = "btnNewCustomerForm"
        Me.btnNewCustomerForm.Size = New System.Drawing.Size(184, 44)
        Me.btnNewCustomerForm.TabIndex = 2
        Me.btnNewCustomerForm.Text = "New Customer"
        Me.btnNewCustomerForm.UseVisualStyleBackColor = True
        '
        'btnNewAddress
        '
        Me.btnNewAddress.Location = New System.Drawing.Point(820, 154)
        Me.btnNewAddress.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNewAddress.Name = "btnNewAddress"
        Me.btnNewAddress.Size = New System.Drawing.Size(184, 44)
        Me.btnNewAddress.TabIndex = 3
        Me.btnNewAddress.Text = "New Address"
        Me.btnNewAddress.UseVisualStyleBackColor = True
        '
        'prodCombo
        '
        Me.prodCombo.DataSource = Me.ProductBindingSource
        Me.prodCombo.DisplayMember = "description"
        Me.prodCombo.FormattingEnabled = True
        Me.prodCombo.Location = New System.Drawing.Point(24, 430)
        Me.prodCombo.Margin = New System.Windows.Forms.Padding(6)
        Me.prodCombo.Name = "prodCombo"
        Me.prodCombo.Size = New System.Drawing.Size(540, 33)
        Me.prodCombo.TabIndex = 4
        Me.prodCombo.ValueMember = "id"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(Assignment_2.Product)
        '
        'btnProdAdd
        '
        Me.btnProdAdd.Location = New System.Drawing.Point(576, 417)
        Me.btnProdAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnProdAdd.Name = "btnProdAdd"
        Me.btnProdAdd.Size = New System.Drawing.Size(80, 44)
        Me.btnProdAdd.TabIndex = 6
        Me.btnProdAdd.Text = "Add"
        Me.btnProdAdd.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(420, 1059)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 31)
        Me.TextBox2.TabIndex = 8
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
        Me.orderItemGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Price, Me.Quantity, Me.ShipDate})
        Me.orderItemGridView.Location = New System.Drawing.Point(24, 473)
        Me.orderItemGridView.Margin = New System.Windows.Forms.Padding(6)
        Me.orderItemGridView.Name = "orderItemGridView"
        Me.orderItemGridView.Size = New System.Drawing.Size(980, 533)
        Me.orderItemGridView.TabIndex = 9
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
        'AddressesBindingSource
        '
        Me.AddressesBindingSource.DataMember = "Addresses"
        Me.AddressesBindingSource.DataSource = Me.CustomerBindingSource
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1113)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1044, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 17)
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetQuantityTo0ToDeleteToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(372, 40)
        '
        'SetQuantityTo0ToDeleteToolStripMenuItem
        '
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Name = "SetQuantityTo0ToDeleteToolStripMenuItem"
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Size = New System.Drawing.Size(371, 36)
        Me.SetQuantityTo0ToDeleteToolStripMenuItem.Text = "Set quantity to 0 to delete"
        '
        'AddressDataGridView
        '
        Me.AddressDataGridView.AllowUserToAddRows = False
        Me.AddressDataGridView.AllowUserToDeleteRows = False
        Me.AddressDataGridView.AllowUserToOrderColumns = True
        Me.AddressDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.street, Me.city, Me.province, Me.postal_code, Me.id})
        Me.AddressDataGridView.Location = New System.Drawing.Point(26, 154)
        Me.AddressDataGridView.Margin = New System.Windows.Forms.Padding(6)
        Me.AddressDataGridView.MultiSelect = False
        Me.AddressDataGridView.Name = "AddressDataGridView"
        Me.AddressDataGridView.ReadOnly = True
        Me.AddressDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AddressDataGridView.Size = New System.Drawing.Size(778, 217)
        Me.AddressDataGridView.TabIndex = 15
        '
        'street
        '
        Me.street.HeaderText = "Street"
        Me.street.Name = "street"
        Me.street.ReadOnly = True
        Me.street.Width = 94
        '
        'city
        '
        Me.city.HeaderText = "City"
        Me.city.Name = "city"
        Me.city.ReadOnly = True
        Me.city.Width = 74
        '
        'province
        '
        Me.province.HeaderText = "Province"
        Me.province.MaxInputLength = 2
        Me.province.Name = "province"
        Me.province.ReadOnly = True
        Me.province.Width = 121
        '
        'postal_code
        '
        Me.postal_code.HeaderText = "PostalCode"
        Me.postal_code.MaxInputLength = 7
        Me.postal_code.Name = "postal_code"
        Me.postal_code.ReadOnly = True
        Me.postal_code.Width = 148
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 1059)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 31)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 1028)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Discount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 1028)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Order Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Shipping Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Products To Order"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(250, 1028)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(104, 25)
        Me.subtotal.TabIndex = 22
        Me.subtotal.Text = "SubTotal:"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(640, 1028)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(66, 25)
        Me.total.TabIndex = 23
        Me.total.Text = "Total:"
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 1135)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.AddressDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.orderItemGridView)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnProdAdd)
        Me.Controls.Add(Me.prodCombo)
        Me.Controls.Add(Me.btnNewAddress)
        Me.Controls.Add(Me.btnNewCustomerForm)
        Me.Controls.Add(Me.custCombo)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "OrderDetails"
        Me.Text = "OrderDetails"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents custCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewCustomerForm As System.Windows.Forms.Button
    Friend WithEvents btnNewAddress As System.Windows.Forms.Button
    Friend WithEvents prodCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btnProdAdd As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents orderItemGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SetQuantityTo0ToDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddressDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents street As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents city As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents postal_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents subtotal As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
End Class
