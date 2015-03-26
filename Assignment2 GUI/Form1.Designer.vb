<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataManagement
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
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.TabOrders = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoreInventoryEventHandlerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tcMain.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.TabOrders.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoreInventoryEventHandlerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.tabProducts)
        Me.tcMain.Controls.Add(Me.tabCustomers)
        Me.tcMain.Controls.Add(Me.TabOrders)
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(584, 445)
        Me.tcMain.TabIndex = 0
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.DataGridView1)
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProducts.Size = New System.Drawing.Size(576, 419)
        Me.tabProducts.TabIndex = 0
        Me.tabProducts.Text = "Products"
        Me.tabProducts.UseVisualStyleBackColor = True
        '
        'tabCustomers
        '
        Me.tabCustomers.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomers.Size = New System.Drawing.Size(576, 419)
        Me.tabCustomers.TabIndex = 1
        Me.tabCustomers.Text = "Customers"
        Me.tabCustomers.UseVisualStyleBackColor = True
        '
        'TabOrders
        '
        Me.TabOrders.Controls.Add(Me.Button1)
        Me.TabOrders.Location = New System.Drawing.Point(4, 22)
        Me.TabOrders.Name = "TabOrders"
        Me.TabOrders.Size = New System.Drawing.Size(576, 419)
        Me.TabOrders.TabIndex = 0
        Me.TabOrders.Text = "Orders"
        Me.TabOrders.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.InventoryDataGridViewTextBoxColumn, Me.active})
        Me.DataGridView1.DataSource = Me.ProductBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(570, 413)
        Me.DataGridView1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(608, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'active
        '
        Me.active.DataPropertyName = "active"
        Me.active.HeaderText = "active"
        Me.active.Name = "active"
        Me.active.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryDataGridViewTextBoxColumn
        '
        Me.InventoryDataGridViewTextBoxColumn.DataPropertyName = "Inventory"
        Me.InventoryDataGridViewTextBoxColumn.HeaderText = "Inventory"
        Me.InventoryDataGridViewTextBoxColumn.Name = "InventoryDataGridViewTextBoxColumn"
        Me.InventoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(Database.Product)
        '
        'MoreInventoryEventHandlerBindingSource
        '
        Me.MoreInventoryEventHandlerBindingSource.DataSource = GetType(Database.Product.MoreInventoryEventHandler)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formDataManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 469)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tcMain)
        Me.Name = "formDataManagement"
        Me.Text = "Bob's World of Fish Data Management"
        Me.tcMain.ResumeLayout(False)
        Me.tabProducts.ResumeLayout(False)
        Me.TabOrders.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoreInventoryEventHandlerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomers As System.Windows.Forms.TabPage
    Friend WithEvents TabOrders As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MoreInventoryEventHandlerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents active As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
