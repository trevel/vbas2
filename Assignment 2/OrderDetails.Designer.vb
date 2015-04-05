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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnNewCustomerForm.TabIndex = 2
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 218)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(272, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 529)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(Assignment_2.Product)
        '
        'OrderItemBindingSource
        '
        Me.OrderItemBindingSource.DataSource = GetType(Assignment_2.Order_Line)
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataSource = GetType(Assignment_2.Address)
        '
        'ShipdateDataGridViewTextBoxColumn
        '
        Me.ShipdateDataGridViewTextBoxColumn.DataPropertyName = "ship_date"
        Me.ShipdateDataGridViewTextBoxColumn.HeaderText = "ship_date"
        Me.ShipdateDataGridViewTextBoxColumn.Name = "ShipdateDataGridViewTextBoxColumn"
        Me.ShipdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Product
        '
        Me.Product.DataPropertyName = "Product"
        Me.Product.DataSource = Me.ProductBindingSource
        Me.Product.DisplayMember = "description"
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.ValueMember = "description"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.QuantityDataGridViewTextBoxColumn, Me.ShipdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(490, 277)
        Me.DataGridView1.TabIndex = 9
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 590)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.btnNewAddress)
        Me.Controls.Add(Me.btnNewCustomerForm)
        Me.Controls.Add(Me.custCombo)
        Me.Name = "OrderDetails"
        Me.Text = "OrderDetails"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents custCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNewCustomerForm As System.Windows.Forms.Button
    Friend WithEvents btnNewAddress As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShipdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
