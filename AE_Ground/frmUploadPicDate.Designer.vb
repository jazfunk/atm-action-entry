<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadPicDate
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
		Me.lblUploadPicDate = New System.Windows.Forms.Label
		Me.mnthCalUploadPicDate = New System.Windows.Forms.MonthCalendar
		Me.btnOK = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnUpload = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'lblUploadPicDate
		'
		Me.lblUploadPicDate.AutoSize = True
		Me.lblUploadPicDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUploadPicDate.Location = New System.Drawing.Point(18, 13)
		Me.lblUploadPicDate.Name = "lblUploadPicDate"
		Me.lblUploadPicDate.Size = New System.Drawing.Size(399, 18)
		Me.lblUploadPicDate.TabIndex = 0
		Me.lblUploadPicDate.Text = "Select the date the images were transfered to the computer:"
		'
		'mnthCalUploadPicDate
		'
		Me.mnthCalUploadPicDate.BackColor = System.Drawing.SystemColors.Window
		Me.mnthCalUploadPicDate.CalendarDimensions = New System.Drawing.Size(1, 2)
		Me.mnthCalUploadPicDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mnthCalUploadPicDate.ForeColor = System.Drawing.SystemColors.InfoText
		Me.mnthCalUploadPicDate.Location = New System.Drawing.Point(104, 53)
		Me.mnthCalUploadPicDate.MaximumSize = New System.Drawing.Size(500, 500)
		Me.mnthCalUploadPicDate.MaxSelectionCount = 1
		Me.mnthCalUploadPicDate.Name = "mnthCalUploadPicDate"
		Me.mnthCalUploadPicDate.TabIndex = 1
		Me.mnthCalUploadPicDate.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.mnthCalUploadPicDate.UseWaitCursor = True
		'
		'btnOK
		'
		Me.btnOK.Location = New System.Drawing.Point(158, 378)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(120, 23)
		Me.btnOK.TabIndex = 2
		Me.btnOK.Text = "View"
		Me.btnOK.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(300, 378)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(120, 23)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnUpload
		'
		Me.btnUpload.Location = New System.Drawing.Point(15, 378)
		Me.btnUpload.Name = "btnUpload"
		Me.btnUpload.Size = New System.Drawing.Size(120, 23)
		Me.btnUpload.TabIndex = 4
		Me.btnUpload.Text = "Upload"
		Me.btnUpload.UseVisualStyleBackColor = True
		'
		'frmUploadPicDate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(435, 413)
		Me.Controls.Add(Me.btnUpload)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.mnthCalUploadPicDate)
		Me.Controls.Add(Me.lblUploadPicDate)
		Me.Name = "frmUploadPicDate"
		Me.Text = "Select Date"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblUploadPicDate As System.Windows.Forms.Label
	Friend WithEvents mnthCalUploadPicDate As System.Windows.Forms.MonthCalendar
	Friend WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnUpload As System.Windows.Forms.Button
End Class
