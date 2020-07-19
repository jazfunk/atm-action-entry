<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
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
		Me.chklstCrew = New System.Windows.Forms.CheckedListBox
		Me.dtpStart = New System.Windows.Forms.DateTimePicker
		Me.dtpEnd = New System.Windows.Forms.DateTimePicker
		Me.lblStart = New System.Windows.Forms.Label
		Me.lblEnd = New System.Windows.Forms.Label
		Me.SuspendLayout()
		'
		'chklstCrew
		'
		Me.chklstCrew.FormattingEnabled = True
		Me.chklstCrew.Location = New System.Drawing.Point(12, 57)
		Me.chklstCrew.Name = "chklstCrew"
		Me.chklstCrew.Size = New System.Drawing.Size(137, 394)
		Me.chklstCrew.TabIndex = 0
		'
		'dtpStart
		'
		Me.dtpStart.CustomFormat = "hh:mm tt     MM/dd/yyyy"
		Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpStart.Location = New System.Drawing.Point(169, 161)
		Me.dtpStart.Name = "dtpStart"
		Me.dtpStart.ShowUpDown = True
		Me.dtpStart.Size = New System.Drawing.Size(216, 29)
		Me.dtpStart.TabIndex = 1
		'
		'dtpEnd
		'
		Me.dtpEnd.CustomFormat = "hh:mm tt     MM/dd/yyyy"
		Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEnd.Location = New System.Drawing.Point(169, 314)
		Me.dtpEnd.Name = "dtpEnd"
		Me.dtpEnd.ShowUpDown = True
		Me.dtpEnd.Size = New System.Drawing.Size(216, 29)
		Me.dtpEnd.TabIndex = 2
		'
		'lblStart
		'
		Me.lblStart.AutoSize = True
		Me.lblStart.Location = New System.Drawing.Point(214, 114)
		Me.lblStart.Name = "lblStart"
		Me.lblStart.Size = New System.Drawing.Size(58, 13)
		Me.lblStart.TabIndex = 3
		Me.lblStart.Text = "Start Time:"
		'
		'lblEnd
		'
		Me.lblEnd.AutoSize = True
		Me.lblEnd.Location = New System.Drawing.Point(243, 263)
		Me.lblEnd.Name = "lblEnd"
		Me.lblEnd.Size = New System.Drawing.Size(58, 13)
		Me.lblEnd.TabIndex = 4
		Me.lblEnd.Text = "Start Time:"
		'
		'frmTime
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(607, 463)
		Me.Controls.Add(Me.lblEnd)
		Me.Controls.Add(Me.lblStart)
		Me.Controls.Add(Me.dtpEnd)
		Me.Controls.Add(Me.dtpStart)
		Me.Controls.Add(Me.chklstCrew)
		Me.Name = "frmTime"
		Me.Text = "frmTime"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents chklstCrew As System.Windows.Forms.CheckedListBox
	Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblStart As System.Windows.Forms.Label
	Friend WithEvents lblEnd As System.Windows.Forms.Label
End Class
