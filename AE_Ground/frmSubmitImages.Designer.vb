<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmitImages
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
		Me.lblDateCaption = New System.Windows.Forms.Label
		Me.lblProcessing = New System.Windows.Forms.Label
		Me.btnOK = New System.Windows.Forms.Button
		Me.btnClose = New System.Windows.Forms.Button
		Me.dtpSubmitImages = New System.Windows.Forms.DateTimePicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'lblDateCaption
		'
		Me.lblDateCaption.AutoSize = True
		Me.lblDateCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDateCaption.Location = New System.Drawing.Point(14, 20)
		Me.lblDateCaption.Name = "lblDateCaption"
		Me.lblDateCaption.Size = New System.Drawing.Size(355, 20)
		Me.lblDateCaption.TabIndex = 0
		Me.lblDateCaption.Text = "Please Select the day the images were downloaded:"
		'
		'lblProcessing
		'
		Me.lblProcessing.AutoSize = True
		Me.lblProcessing.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProcessing.Location = New System.Drawing.Point(89, 143)
		Me.lblProcessing.Name = "lblProcessing"
		Me.lblProcessing.Size = New System.Drawing.Size(184, 20)
		Me.lblProcessing.TabIndex = 1
		Me.lblProcessing.Text = "Processing. Please Wait..."
		Me.lblProcessing.Visible = False
		'
		'btnOK
		'
		Me.btnOK.Location = New System.Drawing.Point(213, 227)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(75, 23)
		Me.btnOK.TabIndex = 2
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(294, 227)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 23)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'dtpSubmitImages
		'
		Me.dtpSubmitImages.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpSubmitImages.Location = New System.Drawing.Point(18, 57)
		Me.dtpSubmitImages.Name = "dtpSubmitImages"
		Me.dtpSubmitImages.Size = New System.Drawing.Size(351, 30)
		Me.dtpSubmitImages.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(89, 163)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(184, 20)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Processing. Please Wait..."
		Me.Label1.Visible = False
		'
		'frmSubmitImages
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(381, 262)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dtpSubmitImages)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.lblProcessing)
		Me.Controls.Add(Me.lblDateCaption)
		Me.Name = "frmSubmitImages"
		Me.Text = "frmSubmitImages"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblDateCaption As System.Windows.Forms.Label
	Friend WithEvents lblProcessing As System.Windows.Forms.Label
	Friend WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents dtpSubmitImages As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
