<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewTime
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
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.pnlTitleBar = New System.Windows.Forms.Panel
		Me.lblClose = New System.Windows.Forms.Label
		Me.cmbTimeSheetDays = New System.Windows.Forms.ComboBox
		Me.lblReviewTime = New System.Windows.Forms.Label
		Me.gbTime = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.rbtnSubmitted = New System.Windows.Forms.RadioButton
		Me.rbtnSaved = New System.Windows.Forms.RadioButton
		Me.dgvReviewTime = New System.Windows.Forms.DataGridView
		Me.pnlTitleBar.SuspendLayout()
		Me.gbTime.SuspendLayout()
		CType(Me.dgvReviewTime, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlTitleBar
		'
		Me.pnlTitleBar.BackgroundImage = Global.AE_Ground.My.Resources.Resources.progressTitleBar2
		Me.pnlTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTitleBar.Controls.Add(Me.lblClose)
		Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleBar.Name = "pnlTitleBar"
		Me.pnlTitleBar.Size = New System.Drawing.Size(973, 24)
		Me.pnlTitleBar.TabIndex = 12
		'
		'lblClose
		'
		Me.lblClose.AutoSize = True
		Me.lblClose.BackColor = System.Drawing.Color.Transparent
		Me.lblClose.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClose.ForeColor = System.Drawing.Color.White
		Me.lblClose.Location = New System.Drawing.Point(950, 0)
		Me.lblClose.Margin = New System.Windows.Forms.Padding(0)
		Me.lblClose.Name = "lblClose"
		Me.lblClose.Size = New System.Drawing.Size(20, 19)
		Me.lblClose.TabIndex = 0
		Me.lblClose.Text = "X"
		'
		'cmbTimeSheetDays
		'
		Me.cmbTimeSheetDays.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cmbTimeSheetDays.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbTimeSheetDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbTimeSheetDays.Location = New System.Drawing.Point(278, 37)
		Me.cmbTimeSheetDays.MaxDropDownItems = 21
		Me.cmbTimeSheetDays.Name = "cmbTimeSheetDays"
		Me.cmbTimeSheetDays.Size = New System.Drawing.Size(162, 28)
		Me.cmbTimeSheetDays.Sorted = True
		Me.cmbTimeSheetDays.TabIndex = 14
		'
		'lblReviewTime
		'
		Me.lblReviewTime.BackColor = System.Drawing.Color.Transparent
		Me.lblReviewTime.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblReviewTime.Location = New System.Drawing.Point(480, 43)
		Me.lblReviewTime.Name = "lblReviewTime"
		Me.lblReviewTime.Size = New System.Drawing.Size(462, 63)
		Me.lblReviewTime.TabIndex = 17
		'
		'gbTime
		'
		Me.gbTime.Controls.Add(Me.Label1)
		Me.gbTime.Controls.Add(Me.rbtnSubmitted)
		Me.gbTime.Controls.Add(Me.rbtnSaved)
		Me.gbTime.Controls.Add(Me.cmbTimeSheetDays)
		Me.gbTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbTime.Location = New System.Drawing.Point(12, 30)
		Me.gbTime.Name = "gbTime"
		Me.gbTime.Size = New System.Drawing.Size(462, 85)
		Me.gbTime.TabIndex = 19
		Me.gbTime.TabStop = False
		Me.gbTime.Text = "Time Review Selection"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(275, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(165, 18)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Select TimeSheet to View"
		'
		'rbtnSubmitted
		'
		Me.rbtnSubmitted.AutoSize = True
		Me.rbtnSubmitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnSubmitted.Location = New System.Drawing.Point(21, 52)
		Me.rbtnSubmitted.Name = "rbtnSubmitted"
		Me.rbtnSubmitted.Size = New System.Drawing.Size(174, 24)
		Me.rbtnSubmitted.TabIndex = 16
		Me.rbtnSubmitted.Text = "Previously Submitted"
		Me.rbtnSubmitted.UseVisualStyleBackColor = True
		'
		'rbtnSaved
		'
		Me.rbtnSaved.AutoSize = True
		Me.rbtnSaved.Checked = True
		Me.rbtnSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnSaved.Location = New System.Drawing.Point(21, 22)
		Me.rbtnSaved.Name = "rbtnSaved"
		Me.rbtnSaved.Size = New System.Drawing.Size(187, 24)
		Me.rbtnSaved.TabIndex = 15
		Me.rbtnSaved.TabStop = True
		Me.rbtnSaved.Text = "Saved - Not Submitted"
		Me.rbtnSaved.UseVisualStyleBackColor = True
		'
		'dgvReviewTime
		'
		Me.dgvReviewTime.AllowUserToAddRows = False
		Me.dgvReviewTime.AllowUserToDeleteRows = False
		Me.dgvReviewTime.AllowUserToResizeRows = False
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
		Me.dgvReviewTime.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
		Me.dgvReviewTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvReviewTime.Location = New System.Drawing.Point(12, 121)
		Me.dgvReviewTime.Name = "dgvReviewTime"
		Me.dgvReviewTime.ReadOnly = True
		Me.dgvReviewTime.Size = New System.Drawing.Size(949, 368)
		Me.dgvReviewTime.TabIndex = 20
		'
		'frmReviewTime
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(973, 501)
		Me.Controls.Add(Me.dgvReviewTime)
		Me.Controls.Add(Me.gbTime)
		Me.Controls.Add(Me.lblReviewTime)
		Me.Controls.Add(Me.pnlTitleBar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmReviewTime"
		Me.Text = "Review Time Entered and Submitted"
		Me.pnlTitleBar.ResumeLayout(False)
		Me.pnlTitleBar.PerformLayout()
		Me.gbTime.ResumeLayout(False)
		Me.gbTime.PerformLayout()
		CType(Me.dgvReviewTime, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
	Friend WithEvents lblClose As System.Windows.Forms.Label
	Friend WithEvents cmbTimeSheetDays As System.Windows.Forms.ComboBox
	Friend WithEvents lblReviewTime As System.Windows.Forms.Label
	Friend WithEvents gbTime As System.Windows.Forms.GroupBox
	Friend WithEvents rbtnSubmitted As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnSaved As System.Windows.Forms.RadioButton
	Friend WithEvents dgvReviewTime As System.Windows.Forms.DataGridView
	Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
