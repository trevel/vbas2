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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cvb815a_assign2DataSet = New Assignment2_GUI.cvb815a_assign2DataSet()
        Me.Cvb815aassign2DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tcMain.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.TabOrders.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cvb815a_assign2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cvb815aassign2DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.Cvb815aassign2DataSetBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(570, 413)
        Me.DataGridView1.TabIndex = 0
        '
        'Cvb815a_assign2DataSet
        '
        Me.Cvb815a_assign2DataSet.DataSetName = "cvb815a_assign2DataSet"
        Me.Cvb815a_assign2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cvb815aassign2DataSetBindingSource
        '
        Me.Cvb815aassign2DataSetBindingSource.DataSource = Me.Cvb815a_assign2DataSet
        Me.Cvb815aassign2DataSetBindingSource.Position = 0
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cvb815a_assign2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cvb815aassign2DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents tabCustomers As System.Windows.Forms.TabPage
    Friend WithEvents TabOrders As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cvb815aassign2DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cvb815a_assign2DataSet As Assignment2_GUI.cvb815a_assign2DataSet

End Class
