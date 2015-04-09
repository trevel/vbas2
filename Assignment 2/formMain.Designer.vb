<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OrderContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShipSelectedOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.btnProductAdd = New System.Windows.Forms.Button()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.prodContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabOrders = New System.Windows.Forms.TabPage()
        Me.btnOrderAdd = New System.Windows.Forms.Button()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JingleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bindingProductsList = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.OrderContextMenu.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.prodContextMenu.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustomers.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerContextMenu.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrders.SuspendLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.OrderContextMenu
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabCustomers)
        Me.TabControl1.Controls.Add(Me.tabOrders)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(565, 418)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'OrderContextMenu
        '
        Me.OrderContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedOrdersToolStripMenuItem, Me.ShipSelectedOrdersToolStripMenuItem})
        Me.OrderContextMenu.Name = "prodContextMenu"
        Me.OrderContextMenu.Size = New System.Drawing.Size(193, 48)
        '
        'DeleteSelectedOrdersToolStripMenuItem
        '
        Me.DeleteSelectedOrdersToolStripMenuItem.Name = "DeleteSelectedOrdersToolStripMenuItem"
        Me.DeleteSelectedOrdersToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DeleteSelectedOrdersToolStripMenuItem.Text = "Delete Selected Orders"
        '
        'ShipSelectedOrdersToolStripMenuItem
        '
        Me.ShipSelectedOrdersToolStripMenuItem.Name = "ShipSelectedOrdersToolStripMenuItem"
        Me.ShipSelectedOrdersToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ShipSelectedOrdersToolStripMenuItem.Text = "Ship Selected Orders"
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.btnProductAdd)
        Me.tabProducts.Controls.Add(Me.ProductDataGridView)
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProducts.Size = New System.Drawing.Size(557, 392)
        Me.tabProducts.TabIndex = 0
        Me.tabProducts.Text = "Products"
        Me.tabProducts.UseVisualStyleBackColor = True
        '
        'btnProductAdd
        '
        Me.btnProductAdd.Location = New System.Drawing.Point(6, 6)
        Me.btnProductAdd.Name = "btnProductAdd"
        Me.btnProductAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnProductAdd.TabIndex = 2
        Me.btnProductAdd.Text = "New Product"
        Me.btnProductAdd.UseVisualStyleBackColor = True
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.ProductDataGridView.ContextMenuStrip = Me.prodContextMenu
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(551, 338)
        Me.ProductDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Inventory"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Inventory"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'prodContextMenu
        '
        Me.prodContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedProductsToolStripMenuItem})
        Me.prodContextMenu.Name = "prodContextMenu"
        Me.prodContextMenu.Size = New System.Drawing.Size(205, 26)
        '
        'DeleteSelectedProductsToolStripMenuItem
        '
        Me.DeleteSelectedProductsToolStripMenuItem.Name = "DeleteSelectedProductsToolStripMenuItem"
        Me.DeleteSelectedProductsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DeleteSelectedProductsToolStripMenuItem.Text = "Delete Selected Products"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(Database.Product)
        '
        'tabCustomers
        '
        Me.tabCustomers.Controls.Add(Me.btnCustAdd)
        Me.tabCustomers.Controls.Add(Me.CustomerDataGridView)
        Me.tabCustomers.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomers.Size = New System.Drawing.Size(557, 392)
        Me.tabCustomers.TabIndex = 1
        Me.tabCustomers.Text = "Customers"
        Me.tabCustomers.UseVisualStyleBackColor = True
        '
        'btnCustAdd
        '
        Me.btnCustAdd.Location = New System.Drawing.Point(9, 6)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(98, 23)
        Me.btnCustAdd.TabIndex = 1
        Me.btnCustAdd.Text = "New Customer"
        Me.btnCustAdd.UseVisualStyleBackColor = True
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AllowUserToDeleteRows = False
        Me.CustomerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomerDataGridView.ContextMenuStrip = Me.CustomerContextMenu
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.ReadOnly = True
        Me.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CustomerDataGridView.Size = New System.Drawing.Size(551, 339)
        Me.CustomerDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "credit_limit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "credit_limit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CustomerContextMenu
        '
        Me.CustomerContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedCustomersToolStripMenuItem})
        Me.CustomerContextMenu.Name = "prodContextMenu"
        Me.CustomerContextMenu.Size = New System.Drawing.Size(210, 26)
        '
        'DeleteSelectedCustomersToolStripMenuItem
        '
        Me.DeleteSelectedCustomersToolStripMenuItem.Name = "DeleteSelectedCustomersToolStripMenuItem"
        Me.DeleteSelectedCustomersToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DeleteSelectedCustomersToolStripMenuItem.Text = "Delete Selected Customer"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Assignment_2.Customer)
        '
        'tabOrders
        '
        Me.tabOrders.Controls.Add(Me.btnOrderAdd)
        Me.tabOrders.Controls.Add(Me.OrderDataGridView)
        Me.tabOrders.Location = New System.Drawing.Point(4, 22)
        Me.tabOrders.Name = "tabOrders"
        Me.tabOrders.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrders.Size = New System.Drawing.Size(557, 392)
        Me.tabOrders.TabIndex = 2
        Me.tabOrders.Text = "Orders"
        Me.tabOrders.UseVisualStyleBackColor = True
        '
        'btnOrderAdd
        '
        Me.btnOrderAdd.Location = New System.Drawing.Point(3, 6)
        Me.btnOrderAdd.Name = "btnOrderAdd"
        Me.btnOrderAdd.Size = New System.Drawing.Size(106, 23)
        Me.btnOrderAdd.TabIndex = 1
        Me.btnOrderAdd.Text = "New Order"
        Me.btnOrderAdd.UseVisualStyleBackColor = True
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.AllowUserToAddRows = False
        Me.OrderDataGridView.AllowUserToDeleteRows = False
        Me.OrderDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderDataGridView.AutoGenerateColumns = False
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_name, Me.OrderdateDataGridViewTextBoxColumn, Me.subtotal, Me.DiscountDataGridViewTextBoxColumn, Me.total})
        Me.OrderDataGridView.DataSource = Me.OrderBindingSource
        Me.OrderDataGridView.Location = New System.Drawing.Point(-4, 36)
        Me.OrderDataGridView.MultiSelect = False
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.ReadOnly = True
        Me.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDataGridView.Size = New System.Drawing.Size(565, 336)
        Me.OrderDataGridView.TabIndex = 0
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "name"
        Me.customer_name.HeaderText = "customer_name"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "order_date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Assignment_2.ExpandedOrders)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(565, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.JingleToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'JingleToolStripMenuItem
        '
        Me.JingleToolStripMenuItem.Name = "JingleToolStripMenuItem"
        Me.JingleToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.JingleToolStripMenuItem.Text = "Jingle"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(565, 22)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 17)
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 442)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(490, 240)
        Me.Name = "formMain"
        Me.Text = "Bob's World of Fish"
        Me.TabControl1.ResumeLayout(False)
        Me.OrderContextMenu.ResumeLayout(False)
        Me.tabProducts.ResumeLayout(False)
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.prodContextMenu.ResumeLayout(False)
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustomers.ResumeLayout(False)
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerContextMenu.ResumeLayout(False)
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrders.ResumeLayout(False)
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomers As System.Windows.Forms.TabPage
    Friend WithEvents tabOrders As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bindingProductsList As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnOrderAdd As System.Windows.Forms.Button
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnProductAdd As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCustAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSelectedOrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JingleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShipSelectedOrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
