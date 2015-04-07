<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCreditLimit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.street = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.province = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.postal_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextAddresses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addressDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextAddresses.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(32, 58)
        Me.tbName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(628, 31)
        Me.tbName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(32, 135)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(628, 31)
        Me.tbEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone Number"
        '
        'tbPhoneNumber
        '
        Me.tbPhoneNumber.Location = New System.Drawing.Point(32, 219)
        Me.tbPhoneNumber.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbPhoneNumber.Name = "tbPhoneNumber"
        Me.tbPhoneNumber.Size = New System.Drawing.Size(628, 31)
        Me.tbPhoneNumber.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Credit Limit"
        '
        'tbCreditLimit
        '
        Me.tbCreditLimit.Location = New System.Drawing.Point(26, 304)
        Me.tbCreditLimit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbCreditLimit.Name = "tbCreditLimit"
        Me.tbCreditLimit.Size = New System.Drawing.Size(634, 31)
        Me.tbCreditLimit.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 348)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Addresses"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(698, 325)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 44)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Location = New System.Drawing.Point(630, 610)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 44)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(468, 610)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 44)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 684)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(804, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 17)
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
        Me.AddressDataGridView.ContextMenuStrip = Me.contextAddresses
        Me.AddressDataGridView.Location = New System.Drawing.Point(32, 381)
        Me.AddressDataGridView.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AddressDataGridView.Name = "AddressDataGridView"
        Me.AddressDataGridView.ReadOnly = True
        Me.AddressDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AddressDataGridView.Size = New System.Drawing.Size(748, 217)
        Me.AddressDataGridView.TabIndex = 14
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
        Me.id.ContextMenuStrip = Me.contextAddresses
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'contextAddresses
        '
        Me.contextAddresses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addressDelete})
        Me.contextAddresses.Name = "contextAddresses"
        Me.contextAddresses.Size = New System.Drawing.Size(373, 40)
        '
        'addressDelete
        '
        Me.addressDelete.Name = "addressDelete"
        Me.addressDelete.Size = New System.Drawing.Size(372, 36)
        Me.addressDelete.Text = "Delete Selected Addresses"
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 706)
        Me.Controls.Add(Me.AddressDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbCreditLimit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "CustomerDetails"
        Me.Text = "CustomerDetails"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextAddresses.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCreditLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddressDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents contextAddresses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents addressDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents street As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents city As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents postal_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
