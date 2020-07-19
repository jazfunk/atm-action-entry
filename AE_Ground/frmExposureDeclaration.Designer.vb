<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExposureDeclaration
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExposureDeclaration))
		Me.lblSilicaExposure = New System.Windows.Forms.Label
		Me.lbl100AirMile = New System.Windows.Forms.Label
		Me.grpSilica = New System.Windows.Forms.GroupBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.llblSE = New System.Windows.Forms.LinkLabel
		Me.chklstCrew_SE = New System.Windows.Forms.CheckedListBox
		Me.rbo_SE_No = New System.Windows.Forms.RadioButton
		Me.rbo_SE_Yes = New System.Windows.Forms.RadioButton
		Me.grp100AirMile = New System.Windows.Forms.GroupBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.llblAM = New System.Windows.Forms.LinkLabel
		Me.chklstCrew_AM = New System.Windows.Forms.CheckedListBox
		Me.rbo_100AirMile_No = New System.Windows.Forms.RadioButton
		Me.rbo_100AirMile_Yes = New System.Windows.Forms.RadioButton
		Me.btnOK = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.grpSilica.SuspendLayout()
		Me.grp100AirMile.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblSilicaExposure
		'
		Me.lblSilicaExposure.Location = New System.Drawing.Point(6, 38)
		Me.lblSilicaExposure.Name = "lblSilicaExposure"
		Me.lblSilicaExposure.Size = New System.Drawing.Size(294, 29)
		Me.lblSilicaExposure.TabIndex = 4
		Me.lblSilicaExposure.Text = "Did any of your crew exceed the Company Policy Guidelines for Silica Exposure dur" & _
			"ing today's workday?"
		'
		'lbl100AirMile
		'
		Me.lbl100AirMile.Location = New System.Drawing.Point(6, 38)
		Me.lbl100AirMile.Name = "lbl100AirMile"
		Me.lbl100AirMile.Size = New System.Drawing.Size(294, 43)
		Me.lbl100AirMile.TabIndex = 4
		Me.lbl100AirMile.Text = "Did any of your crew exceed the Company Policy Guidelines for compliance with the" & _
			" FMCSA 100 Air-Mile Exemption during today's workday?"
		'
		'grpSilica
		'
		Me.grpSilica.BackColor = System.Drawing.Color.Transparent
		Me.grpSilica.Controls.Add(Me.Label1)
		Me.grpSilica.Controls.Add(Me.llblSE)
		Me.grpSilica.Controls.Add(Me.chklstCrew_SE)
		Me.grpSilica.Controls.Add(Me.rbo_SE_No)
		Me.grpSilica.Controls.Add(Me.rbo_SE_Yes)
		Me.grpSilica.Controls.Add(Me.lblSilicaExposure)
		Me.grpSilica.Location = New System.Drawing.Point(12, 12)
		Me.grpSilica.Name = "grpSilica"
		Me.grpSilica.Size = New System.Drawing.Size(545, 158)
		Me.grpSilica.TabIndex = 0
		Me.grpSilica.TabStop = False
		Me.grpSilica.Text = "Silica Exposure"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(325, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(137, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "If 'Yes', Check all that apply"
		'
		'llblSE
		'
		Me.llblSE.AutoSize = True
		Me.llblSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.llblSE.Location = New System.Drawing.Point(6, 67)
		Me.llblSE.Name = "llblSE"
		Me.llblSE.Size = New System.Drawing.Size(196, 17)
		Me.llblSE.TabIndex = 3
		Me.llblSE.TabStop = True
		Me.llblSE.Text = "Guidelines for Silica Exposure"
		'
		'chklstCrew_SE
		'
		Me.chklstCrew_SE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.chklstCrew_SE.CheckOnClick = True
		Me.chklstCrew_SE.Enabled = False
		Me.chklstCrew_SE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chklstCrew_SE.FormattingEnabled = True
		Me.chklstCrew_SE.Location = New System.Drawing.Point(328, 38)
		Me.chklstCrew_SE.Margin = New System.Windows.Forms.Padding(1)
		Me.chklstCrew_SE.Name = "chklstCrew_SE"
		Me.chklstCrew_SE.Size = New System.Drawing.Size(201, 116)
		Me.chklstCrew_SE.TabIndex = 2
		'
		'rbo_SE_No
		'
		Me.rbo_SE_No.AutoSize = True
		Me.rbo_SE_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbo_SE_No.ForeColor = System.Drawing.Color.DimGray
		Me.rbo_SE_No.Location = New System.Drawing.Point(230, 115)
		Me.rbo_SE_No.Name = "rbo_SE_No"
		Me.rbo_SE_No.Size = New System.Drawing.Size(70, 37)
		Me.rbo_SE_No.TabIndex = 0
		Me.rbo_SE_No.TabStop = True
		Me.rbo_SE_No.Text = "No"
		Me.rbo_SE_No.UseVisualStyleBackColor = True
		'
		'rbo_SE_Yes
		'
		Me.rbo_SE_Yes.AutoSize = True
		Me.rbo_SE_Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbo_SE_Yes.ForeColor = System.Drawing.Color.DimGray
		Me.rbo_SE_Yes.Location = New System.Drawing.Point(100, 115)
		Me.rbo_SE_Yes.Name = "rbo_SE_Yes"
		Me.rbo_SE_Yes.Size = New System.Drawing.Size(84, 37)
		Me.rbo_SE_Yes.TabIndex = 1
		Me.rbo_SE_Yes.TabStop = True
		Me.rbo_SE_Yes.Text = "Yes"
		Me.rbo_SE_Yes.UseVisualStyleBackColor = True
		'
		'grp100AirMile
		'
		Me.grp100AirMile.BackColor = System.Drawing.Color.Transparent
		Me.grp100AirMile.Controls.Add(Me.Label2)
		Me.grp100AirMile.Controls.Add(Me.llblAM)
		Me.grp100AirMile.Controls.Add(Me.chklstCrew_AM)
		Me.grp100AirMile.Controls.Add(Me.rbo_100AirMile_No)
		Me.grp100AirMile.Controls.Add(Me.rbo_100AirMile_Yes)
		Me.grp100AirMile.Controls.Add(Me.lbl100AirMile)
		Me.grp100AirMile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grp100AirMile.Location = New System.Drawing.Point(12, 176)
		Me.grp100AirMile.Name = "grp100AirMile"
		Me.grp100AirMile.Size = New System.Drawing.Size(545, 158)
		Me.grp100AirMile.TabIndex = 1
		Me.grp100AirMile.TabStop = False
		Me.grp100AirMile.Text = "100 Air-Mile Exemption"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(328, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(137, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "If 'Yes', Check all that apply"
		'
		'llblAM
		'
		Me.llblAM.AutoSize = True
		Me.llblAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.llblAM.Location = New System.Drawing.Point(6, 81)
		Me.llblAM.Name = "llblAM"
		Me.llblAM.Size = New System.Drawing.Size(294, 17)
		Me.llblAM.TabIndex = 3
		Me.llblAM.TabStop = True
		Me.llblAM.Text = "Guidelines for FMCSA 100 Air-Mile Exemption"
		'
		'chklstCrew_AM
		'
		Me.chklstCrew_AM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.chklstCrew_AM.CheckOnClick = True
		Me.chklstCrew_AM.Enabled = False
		Me.chklstCrew_AM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chklstCrew_AM.FormattingEnabled = True
		Me.chklstCrew_AM.Location = New System.Drawing.Point(328, 38)
		Me.chklstCrew_AM.Margin = New System.Windows.Forms.Padding(1)
		Me.chklstCrew_AM.Name = "chklstCrew_AM"
		Me.chklstCrew_AM.Size = New System.Drawing.Size(201, 116)
		Me.chklstCrew_AM.TabIndex = 2
		'
		'rbo_100AirMile_No
		'
		Me.rbo_100AirMile_No.AutoSize = True
		Me.rbo_100AirMile_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbo_100AirMile_No.ForeColor = System.Drawing.Color.DimGray
		Me.rbo_100AirMile_No.Location = New System.Drawing.Point(230, 115)
		Me.rbo_100AirMile_No.Name = "rbo_100AirMile_No"
		Me.rbo_100AirMile_No.Size = New System.Drawing.Size(70, 37)
		Me.rbo_100AirMile_No.TabIndex = 0
		Me.rbo_100AirMile_No.TabStop = True
		Me.rbo_100AirMile_No.Text = "No"
		Me.rbo_100AirMile_No.UseVisualStyleBackColor = True
		'
		'rbo_100AirMile_Yes
		'
		Me.rbo_100AirMile_Yes.AutoSize = True
		Me.rbo_100AirMile_Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbo_100AirMile_Yes.ForeColor = System.Drawing.Color.DimGray
		Me.rbo_100AirMile_Yes.Location = New System.Drawing.Point(100, 115)
		Me.rbo_100AirMile_Yes.Name = "rbo_100AirMile_Yes"
		Me.rbo_100AirMile_Yes.Size = New System.Drawing.Size(84, 37)
		Me.rbo_100AirMile_Yes.TabIndex = 1
		Me.rbo_100AirMile_Yes.TabStop = True
		Me.rbo_100AirMile_Yes.Text = "Yes"
		Me.rbo_100AirMile_Yes.UseVisualStyleBackColor = True
		'
		'btnOK
		'
		Me.btnOK.Location = New System.Drawing.Point(385, 340)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(75, 23)
		Me.btnOK.TabIndex = 2
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.CausesValidation = False
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(466, 340)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'frmExposureDeclaration
		'
		Me.AcceptButton = Me.btnOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(568, 378)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOK)
		Me.Controls.Add(Me.grp100AirMile)
		Me.Controls.Add(Me.grpSilica)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmExposureDeclaration"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Exposure Declaration"
		Me.TopMost = True
		Me.grpSilica.ResumeLayout(False)
		Me.grpSilica.PerformLayout()
		Me.grp100AirMile.ResumeLayout(False)
		Me.grp100AirMile.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblSilicaExposure As System.Windows.Forms.Label
	Friend WithEvents lbl100AirMile As System.Windows.Forms.Label
	Friend WithEvents grpSilica As System.Windows.Forms.GroupBox
	Friend WithEvents rbo_SE_No As System.Windows.Forms.RadioButton
	Friend WithEvents rbo_SE_Yes As System.Windows.Forms.RadioButton
	Friend WithEvents grp100AirMile As System.Windows.Forms.GroupBox
	Friend WithEvents rbo_100AirMile_No As System.Windows.Forms.RadioButton
	Friend WithEvents rbo_100AirMile_Yes As System.Windows.Forms.RadioButton
	Friend WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents chklstCrew_SE As System.Windows.Forms.CheckedListBox
	Friend WithEvents chklstCrew_AM As System.Windows.Forms.CheckedListBox
	Friend WithEvents llblSE As System.Windows.Forms.LinkLabel
	Friend WithEvents llblAM As System.Windows.Forms.LinkLabel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
