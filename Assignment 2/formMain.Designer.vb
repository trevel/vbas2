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
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.tabOrders = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bindingProductsList = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cvb815a_assign2DataSet = New Assignment_2.cvb815a_assign2DataSet()
        Me.ProductTableAdapter = New Assignment_2.cvb815a_assign2DataSetTableAdapters.ProductTableAdapter()
        Me.gridProducts = New System.Windows.Forms.DataGridView()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cvb815a_assign2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'bindingProductsList
        '
        Me.bindingProductsList.DataMember = "Product"
        Me.bindingProductsList.DataSource = Me.Cvb815a_assign2DataSet
        '
        'Cvb815a_assign2DataSet
        '
        Me.Cvb815a_assign2DataSet.DataSetName = "cvb815a_assign2DataSet"
        Me.Cvb815a_assign2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'gridProducts
        '
        Me.gridProducts.AllowUserToAddRows = False
        Me.gridProducts.AllowUserToDeleteRows = False
        Me.gridProducts.AutoGenerateColumns = False
        Me.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.InventoryDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn})
        Me.gridProducts.DataSource = Me.bindingProductsList
        Me.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProducts.Location = New System.Drawing.Point(3, 3)
        Me.gridProducts.Name = "gridProducts"
        Me.gridProducts.ReadOnly = True
        Me.gridProducts.Size = New System.Drawing.Size(489, 449)
        Me.gridProducts.TabIndex = 0
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryDataGridViewTextBoxColumn
        '
        Me.InventoryDataGridViewTextBoxColumn.DataPropertyName = "inventory"
        Me.InventoryDataGridViewTextBoxColumn.HeaderText = "inventory"
        Me.InventoryDataGridViewTextBoxColumn.Name = "InventoryDataGridViewTextBoxColumn"
        Me.InventoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "active"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.ReadOnly = True
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.bindingProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cvb815a_assign2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProducts, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cvb815a_assign2DataSet As Assignment_2.cvb815a_assign2DataSet
    Friend WithEvents ProductTableAdapter As Assignment_2.cvb815a_assign2DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents gridProducts As System.Windows.Forms.DataGridView
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
