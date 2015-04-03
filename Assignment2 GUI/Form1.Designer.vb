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
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.TabOrders = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tcMain.SuspendLayout()
        Me.TabOrders.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.TabOrders.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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

End Class
