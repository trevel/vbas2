<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressDetail
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
        Me.tbStreet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbProvince = New System.Windows.Forms.TextBox()
        Me.tbPostalCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.custName = New System.Windows.Forms.Label()
        Me.btnSaveAddress = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbStreet
        '
        Me.tbStreet.Location = New System.Drawing.Point(13, 61)
        Me.tbStreet.Name = "tbStreet"
        Me.tbStreet.Size = New System.Drawing.Size(333, 20)
        Me.tbStreet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Street"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(13, 105)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(333, 20)
        Me.tbCity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Province"
        '
        'tbProvince
        '
        Me.tbProvince.Location = New System.Drawing.Point(13, 149)
        Me.tbProvince.MaxLength = 2
        Me.tbProvince.Name = "tbProvince"
        Me.tbProvince.Size = New System.Drawing.Size(34, 20)
        Me.tbProvince.TabIndex = 2
        '
        'tbPostalCode
        '
        Me.tbPostalCode.Location = New System.Drawing.Point(139, 149)
        Me.tbPostalCode.Name = "tbPostalCode"
        Me.tbPostalCode.Size = New System.Drawing.Size(64, 20)
        Me.tbPostalCode.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Postal Code"
        '
        'custName
        '
        Me.custName.AutoSize = True
        Me.custName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custName.Location = New System.Drawing.Point(139, 9)
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(0, 20)
        Me.custName.TabIndex = 8
        Me.custName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveAddress
        '
        Me.btnSaveAddress.Location = New System.Drawing.Point(277, 191)
        Me.btnSaveAddress.Name = "btnSaveAddress"
        Me.btnSaveAddress.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAddress.TabIndex = 4
        Me.btnSaveAddress.Text = "Save"
        Me.btnSaveAddress.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(196, 191)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddressDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 226)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveAddress)
        Me.Controls.Add(Me.custName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPostalCode)
        Me.Controls.Add(Me.tbProvince)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbStreet)
        Me.Name = "AddressDetail"
        Me.Text = "AddressDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbProvince As System.Windows.Forms.TextBox
    Friend WithEvents tbPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents custName As System.Windows.Forms.Label
    Friend WithEvents btnSaveAddress As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
