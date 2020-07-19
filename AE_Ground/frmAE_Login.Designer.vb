<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmAE_Login
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
	Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
	Friend WithEvents UsernameLabel As System.Windows.Forms.Label
	Friend WithEvents PasswordLabel As System.Windows.Forms.Label
	Friend WithEvents txtPW As System.Windows.Forms.TextBox
	Friend WithEvents OK As System.Windows.Forms.Button
	Friend WithEvents Cancel As System.Windows.Forms.Button

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Me.LogoPictureBox = New System.Windows.Forms.PictureBox
		Me.UsernameLabel = New System.Windows.Forms.Label
		Me.PasswordLabel = New System.Windows.Forms.Label
		Me.txtPW = New System.Windows.Forms.TextBox
		Me.OK = New System.Windows.Forms.Button
		Me.Cancel = New System.Windows.Forms.Button
		Me.cmbUsers = New System.Windows.Forms.ComboBox
		Me.QryUsersDisplayNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryValidatePWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryValidatePWTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryValidatePWTableAdapter
		Me.QryUsersDisplayNamesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
		Me.ckbRetain = New System.Windows.Forms.CheckBox
		Me.pnlLoginMain = New System.Windows.Forms.Panel
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryValidatePWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLoginMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'LogoPictureBox
		'
		Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LogoPictureBox.Image = Global.AE_Ground.My.Resources.Resources.AE_LT
		Me.LogoPictureBox.Location = New System.Drawing.Point(-1, -1)
		Me.LogoPictureBox.Name = "LogoPictureBox"
		Me.LogoPictureBox.Size = New System.Drawing.Size(165, 192)
		Me.LogoPictureBox.TabIndex = 0
		Me.LogoPictureBox.TabStop = False
		'
		'UsernameLabel
		'
		Me.UsernameLabel.Location = New System.Drawing.Point(192, 10)
		Me.UsernameLabel.Name = "UsernameLabel"
		Me.UsernameLabel.Size = New System.Drawing.Size(149, 23)
		Me.UsernameLabel.TabIndex = 0
		Me.UsernameLabel.Text = "&Name"
		Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'PasswordLabel
		'
		Me.PasswordLabel.Location = New System.Drawing.Point(192, 73)
		Me.PasswordLabel.Name = "PasswordLabel"
		Me.PasswordLabel.Size = New System.Drawing.Size(149, 23)
		Me.PasswordLabel.TabIndex = 2
		Me.PasswordLabel.Text = "&Password"
		Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtPW
		'
		Me.txtPW.Location = New System.Drawing.Point(192, 99)
		Me.txtPW.Name = "txtPW"
		Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPW.Size = New System.Drawing.Size(176, 20)
		Me.txtPW.TabIndex = 1
		Me.txtPW.UseSystemPasswordChar = True
		'
		'OK
		'
		Me.OK.Location = New System.Drawing.Point(225, 158)
		Me.OK.Name = "OK"
		Me.OK.Size = New System.Drawing.Size(77, 23)
		Me.OK.TabIndex = 3
		Me.OK.Text = "&OK"
		'
		'Cancel
		'
		Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel.Location = New System.Drawing.Point(309, 158)
		Me.Cancel.Name = "Cancel"
		Me.Cancel.Size = New System.Drawing.Size(77, 23)
		Me.Cancel.TabIndex = 4
		Me.Cancel.Text = "&Cancel"
		'
		'cmbUsers
		'
		Me.cmbUsers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbUsers.DataSource = Me.QryUsersDisplayNamesBindingSource
		Me.cmbUsers.DisplayMember = "displayName"
		Me.cmbUsers.FormattingEnabled = True
		Me.cmbUsers.Location = New System.Drawing.Point(192, 36)
		Me.cmbUsers.Name = "cmbUsers"
		Me.cmbUsers.Size = New System.Drawing.Size(176, 21)
		Me.cmbUsers.TabIndex = 0
		Me.cmbUsers.ValueMember = "ID"
		'
		'QryUsersDisplayNamesBindingSource
		'
		Me.QryUsersDisplayNamesBindingSource.DataMember = "qryUsersDisplayNames"
		Me.QryUsersDisplayNamesBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'QryValidatePWBindingSource
		'
		Me.QryValidatePWBindingSource.DataMember = "qryValidatePW"
		Me.QryValidatePWBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryValidatePWTableAdapter
		'
		Me.QryValidatePWTableAdapter.ClearBeforeFill = True
		'
		'QryUsersDisplayNamesTableAdapter
		'
		Me.QryUsersDisplayNamesTableAdapter.ClearBeforeFill = True
		'
		'ckbRetain
		'
		Me.ckbRetain.AutoSize = True
		Me.ckbRetain.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ckbRetain.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbRetain.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ckbRetain.Location = New System.Drawing.Point(287, 125)
		Me.ckbRetain.Name = "ckbRetain"
		Me.ckbRetain.Size = New System.Drawing.Size(81, 16)
		Me.ckbRetain.TabIndex = 2
		Me.ckbRetain.Text = "Rememer Me"
		Me.ckbRetain.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.ckbRetain.UseVisualStyleBackColor = True
		'
		'pnlLoginMain
		'
		Me.pnlLoginMain.BackColor = System.Drawing.Color.Transparent
		Me.pnlLoginMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.pnlLoginMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlLoginMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlLoginMain.Controls.Add(Me.LogoPictureBox)
		Me.pnlLoginMain.Controls.Add(Me.ckbRetain)
		Me.pnlLoginMain.Controls.Add(Me.Cancel)
		Me.pnlLoginMain.Controls.Add(Me.cmbUsers)
		Me.pnlLoginMain.Controls.Add(Me.UsernameLabel)
		Me.pnlLoginMain.Controls.Add(Me.PasswordLabel)
		Me.pnlLoginMain.Controls.Add(Me.OK)
		Me.pnlLoginMain.Controls.Add(Me.txtPW)
		Me.pnlLoginMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlLoginMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlLoginMain.Name = "pnlLoginMain"
		Me.pnlLoginMain.Size = New System.Drawing.Size(401, 192)
		Me.pnlLoginMain.TabIndex = 5
		'
		'frmAE_Login
		'
		Me.AcceptButton = Me.OK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.CancelButton = Me.Cancel
		Me.ClientSize = New System.Drawing.Size(401, 192)
		Me.Controls.Add(Me.pnlLoginMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAE_Login"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Action Entry Login"
		CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryValidatePWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLoginMain.ResumeLayout(False)
		Me.pnlLoginMain.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents cmbUsers As System.Windows.Forms.ComboBox
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryValidatePWBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryValidatePWTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryValidatePWTableAdapter
	Friend WithEvents QryUsersDisplayNamesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryUsersDisplayNamesTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
	Friend WithEvents ckbRetain As System.Windows.Forms.CheckBox
	Friend WithEvents pnlLoginMain As System.Windows.Forms.Panel

End Class
