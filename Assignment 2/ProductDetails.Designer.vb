<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetails
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
        Me.lblProdDesc = New System.Windows.Forms.Label()
        Me.tbProdDesc = New System.Windows.Forms.TextBox()
        Me.lblProdPrice = New System.Windows.Forms.Label()
        Me.tbProdPrice = New System.Windows.Forms.TextBox()
        Me.lblProdInv = New System.Windows.Forms.Label()
        Me.tbProdInv = New System.Windows.Forms.TextBox()
        Me.cbProdActive = New System.Windows.Forms.CheckBox()
        Me.btnProdCancel = New System.Windows.Forms.Button()
        Me.btnProdSave = New System.Windows.Forms.Button()
        Me.statusProd = New System.Windows.Forms.StatusStrip()
        Me.statusProdLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProdDesc
        '
        Me.lblProdDesc.AutoSize = True
        Me.lblProdDesc.Location = New System.Drawing.Point(13, 13)
        Me.lblProdDesc.Name = "lblProdDesc"
        Me.lblProdDesc.Size = New System.Drawing.Size(60, 13)
        Me.lblProdDesc.TabIndex = 0
        Me.lblProdDesc.Text = "Description"
        '
        'tbProdDesc
        '
        Me.tbProdDesc.Location = New System.Drawing.Point(16, 30)
        Me.tbProdDesc.Name = "tbProdDesc"
        Me.tbProdDesc.Size = New System.Drawing.Size(221, 20)
        Me.tbProdDesc.TabIndex = 1
        '
        'lblProdPrice
        '
        Me.lblProdPrice.AutoSize = True
        Me.lblProdPrice.Location = New System.Drawing.Point(13, 62)
        Me.lblProdPrice.Name = "lblProdPrice"
        Me.lblProdPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblProdPrice.TabIndex = 2
        Me.lblProdPrice.Text = "Price"
        '
        'tbProdPrice
        '
        Me.tbProdPrice.Location = New System.Drawing.Point(16, 78)
        Me.tbProdPrice.Name = "tbProdPrice"
        Me.tbProdPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbProdPrice.TabIndex = 3
        '
        'lblProdInv
        '
        Me.lblProdInv.AutoSize = True
        Me.lblProdInv.Location = New System.Drawing.Point(13, 114)
        Me.lblProdInv.Name = "lblProdInv"
        Me.lblProdInv.Size = New System.Drawing.Size(51, 13)
        Me.lblProdInv.TabIndex = 4
        Me.lblProdInv.Text = "Inventory"
        '
        'tbProdInv
        '
        Me.tbProdInv.Location = New System.Drawing.Point(16, 130)
        Me.tbProdInv.Name = "tbProdInv"
        Me.tbProdInv.Size = New System.Drawing.Size(100, 20)
        Me.tbProdInv.TabIndex = 5
        '
        'cbProdActive
        '
        Me.cbProdActive.AutoSize = True
        Me.cbProdActive.Location = New System.Drawing.Point(16, 169)
        Me.cbProdActive.Name = "cbProdActive"
        Me.cbProdActive.Size = New System.Drawing.Size(56, 17)
        Me.cbProdActive.TabIndex = 6
        Me.cbProdActive.Text = "Active"
        Me.cbProdActive.UseVisualStyleBackColor = True
        '
        'btnProdCancel
        '
        Me.btnProdCancel.Location = New System.Drawing.Point(127, 213)
        Me.btnProdCancel.Name = "btnProdCancel"
        Me.btnProdCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnProdCancel.TabIndex = 7
        Me.btnProdCancel.Text = "Cancel"
        Me.btnProdCancel.UseVisualStyleBackColor = True
        '
        'btnProdSave
        '
        Me.btnProdSave.Location = New System.Drawing.Point(208, 212)
        Me.btnProdSave.Name = "btnProdSave"
        Me.btnProdSave.Size = New System.Drawing.Size(75, 23)
        Me.btnProdSave.TabIndex = 8
        Me.btnProdSave.Text = "Save"
        Me.btnProdSave.UseVisualStyleBackColor = True
        '
        'statusProd
        '
        Me.statusProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusProdLbl})
        Me.statusProd.Location = New System.Drawing.Point(0, 240)
        Me.statusProd.Name = "statusProd"
        Me.statusProd.Size = New System.Drawing.Size(284, 22)
        Me.statusProd.TabIndex = 9
        Me.statusProd.Text = "Status"
        '
        'statusProdLbl
        '
        Me.statusProdLbl.Name = "statusProdLbl"
        Me.statusProdLbl.Size = New System.Drawing.Size(121, 17)
        Me.statusProdLbl.Text = "ToolStripStatusLabel1"
        '
        'ProductDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.statusProd)
        Me.Controls.Add(Me.btnProdSave)
        Me.Controls.Add(Me.btnProdCancel)
        Me.Controls.Add(Me.cbProdActive)
        Me.Controls.Add(Me.tbProdInv)
        Me.Controls.Add(Me.lblProdInv)
        Me.Controls.Add(Me.tbProdPrice)
        Me.Controls.Add(Me.lblProdPrice)
        Me.Controls.Add(Me.tbProdDesc)
        Me.Controls.Add(Me.lblProdDesc)
        Me.Name = "ProductDetails"
        Me.Text = "ProductDetails"
        Me.statusProd.ResumeLayout(False)
        Me.statusProd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProdDesc As System.Windows.Forms.Label
    Friend WithEvents tbProdDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblProdPrice As System.Windows.Forms.Label
    Friend WithEvents tbProdPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblProdInv As System.Windows.Forms.Label
    Friend WithEvents tbProdInv As System.Windows.Forms.TextBox
    Friend WithEvents cbProdActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnProdCancel As System.Windows.Forms.Button
    Friend WithEvents btnProdSave As System.Windows.Forms.Button
    Friend WithEvents statusProd As System.Windows.Forms.StatusStrip
    Friend WithEvents statusProdLbl As System.Windows.Forms.ToolStripStatusLabel
End Class
