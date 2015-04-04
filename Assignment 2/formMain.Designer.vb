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
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.gridProducts = New System.Windows.Forms.DataGridView()
        Me.bindingProductsList = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.tabOrders = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnOrderAdd = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrders.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Controls.Add(Me.tabCustomers)
        Me.TabControl1.Controls.Add(Me.tabOrders)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(503, 481)
        Me.TabControl1.TabIndex = 0
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.gridProducts)
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProducts.Size = New System.Drawing.Size(495, 455)
        Me.tabProducts.TabIndex = 0
        Me.tabProducts.Text = "Products"
        Me.tabProducts.UseVisualStyleBackColor = True
        '
        'gridProducts
        '
        Me.gridProducts.AllowUserToAddRows = False
        Me.gridProducts.AllowUserToDeleteRows = False
        Me.gridProducts.AutoGenerateColumns = False
        Me.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProducts.DataSource = Me.bindingProductsList
        Me.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProducts.Location = New System.Drawing.Point(3, 3)
        Me.gridProducts.Name = "gridProducts"
        Me.gridProducts.ReadOnly = True
        Me.gridProducts.Size = New System.Drawing.Size(489, 449)
        Me.gridProducts.TabIndex = 0
        '
        'tabCustomers
        '
        Me.tabCustomers.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomers.Size = New System.Drawing.Size(495, 455)
        Me.tabCustomers.TabIndex = 1
        Me.tabCustomers.Text = "Customers"
        Me.tabCustomers.UseVisualStyleBackColor = True
        '
        'tabOrders
        '
        Me.tabOrders.Controls.Add(Me.btnOrderAdd)
        Me.tabOrders.Controls.Add(Me.OrderDataGridView)
        Me.tabOrders.Location = New System.Drawing.Point(4, 22)
        Me.tabOrders.Name = "tabOrders"
        Me.tabOrders.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrders.Size = New System.Drawing.Size(495, 455)
        Me.tabOrders.TabIndex = 2
        Me.tabOrders.Text = "Orders"
        Me.tabOrders.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(503, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(80, 17)
        Me.ToolStripStatusLabel1.Text = "Status Update"
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.AllowUserToAddRows = False
        Me.OrderDataGridView.AllowUserToDeleteRows = False
        Me.OrderDataGridView.AutoGenerateColumns = False
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn, Me.ItemcountDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.DataGridViewCheckBoxColumn1})
        Me.OrderDataGridView.DataSource = Me.OrderBindingSource
        Me.OrderDataGridView.Location = New System.Drawing.Point(-4, 35)
        Me.OrderDataGridView.MultiSelect = False
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.ReadOnly = True
        Me.OrderDataGridView.Size = New System.Drawing.Size(503, 437)
        Me.OrderDataGridView.TabIndex = 0
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(Database.Order)
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        Me.CustomeridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "order_date"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcountDataGridViewTextBoxColumn
        '
        Me.ItemcountDataGridViewTextBoxColumn.DataPropertyName = "item_count"
        Me.ItemcountDataGridViewTextBoxColumn.HeaderText = "item_count"
        Me.ItemcountDataGridViewTextBoxColumn.Name = "ItemcountDataGridViewTextBoxColumn"
        Me.ItemcountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'btnOrderAdd
        '
        Me.btnOrderAdd.Location = New System.Drawing.Point(9, 6)
        Me.btnOrderAdd.Name = "btnOrderAdd"
        Me.btnOrderAdd.Size = New System.Drawing.Size(106, 23)
        Me.btnOrderAdd.TabIndex = 1
        Me.btnOrderAdd.Text = "Create New Order"
        Me.btnOrderAdd.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 506)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Bob's World of Fish"
        Me.TabControl1.ResumeLayout(False)
        Me.tabProducts.ResumeLayout(False)
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrders.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomers As System.Windows.Forms.TabPage
    Friend WithEvents tabOrders As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bindingProductsList As System.Windows.Forms.BindingSource
    Friend WithEvents gridProducts As System.Windows.Forms.DataGridView
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemcountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnOrderAdd As System.Windows.Forms.Button

End Class
