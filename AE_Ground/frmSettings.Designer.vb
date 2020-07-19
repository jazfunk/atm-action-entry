<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
		Me.lblUserId = New System.Windows.Forms.Label
		Me.lblCurrentJob = New System.Windows.Forms.Label
		Me.lblDisplayName = New System.Windows.Forms.Label
		Me.lblPayItemFilter = New System.Windows.Forms.Label
		Me.lblUserCred = New System.Windows.Forms.Label
		Me.txtUserId = New System.Windows.Forms.TextBox
		Me.txtPayItemFilter = New System.Windows.Forms.TextBox
		Me.txtUserCred = New System.Windows.Forms.TextBox
		Me.txtDisplayName = New System.Windows.Forms.TextBox
		Me.txtCurrentJob = New System.Windows.Forms.TextBox
		Me.ckbRetainUser = New System.Windows.Forms.CheckBox
		Me.btnExit = New System.Windows.Forms.Button
		Me.pnlSettingsMain = New System.Windows.Forms.Panel
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.pGridMyAppSettings = New System.Windows.Forms.PropertyGrid
		Me.pnlSettingsMain.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblUserId
		'
		Me.lblUserId.AutoSize = True
		Me.lblUserId.Location = New System.Drawing.Point(11, 27)
		Me.lblUserId.Name = "lblUserId"
		Me.lblUserId.Size = New System.Drawing.Size(43, 13)
		Me.lblUserId.TabIndex = 0
		Me.lblUserId.Text = "User ID"
		'
		'lblCurrentJob
		'
		Me.lblCurrentJob.AutoSize = True
		Me.lblCurrentJob.Location = New System.Drawing.Point(11, 62)
		Me.lblCurrentJob.Name = "lblCurrentJob"
		Me.lblCurrentJob.Size = New System.Drawing.Size(61, 13)
		Me.lblCurrentJob.TabIndex = 1
		Me.lblCurrentJob.Text = "Current Job"
		'
		'lblDisplayName
		'
		Me.lblDisplayName.AutoSize = True
		Me.lblDisplayName.Location = New System.Drawing.Point(11, 97)
		Me.lblDisplayName.Name = "lblDisplayName"
		Me.lblDisplayName.Size = New System.Drawing.Size(72, 13)
		Me.lblDisplayName.TabIndex = 2
		Me.lblDisplayName.Text = "Display Name"
		'
		'lblPayItemFilter
		'
		Me.lblPayItemFilter.AutoSize = True
		Me.lblPayItemFilter.Location = New System.Drawing.Point(11, 132)
		Me.lblPayItemFilter.Name = "lblPayItemFilter"
		Me.lblPayItemFilter.Size = New System.Drawing.Size(73, 13)
		Me.lblPayItemFilter.TabIndex = 3
		Me.lblPayItemFilter.Text = "Pay Item Filter"
		'
		'lblUserCred
		'
		Me.lblUserCred.AutoSize = True
		Me.lblUserCred.Location = New System.Drawing.Point(11, 215)
		Me.lblUserCred.Name = "lblUserCred"
		Me.lblUserCred.Size = New System.Drawing.Size(84, 13)
		Me.lblUserCred.TabIndex = 4
		Me.lblUserCred.Text = "User Credentials"
		'
		'txtUserId
		'
		Me.txtUserId.Location = New System.Drawing.Point(99, 24)
		Me.txtUserId.Name = "txtUserId"
		Me.txtUserId.ReadOnly = True
		Me.txtUserId.Size = New System.Drawing.Size(100, 20)
		Me.txtUserId.TabIndex = 5
		'
		'txtPayItemFilter
		'
		Me.txtPayItemFilter.Location = New System.Drawing.Point(99, 129)
		Me.txtPayItemFilter.Multiline = True
		Me.txtPayItemFilter.Name = "txtPayItemFilter"
		Me.txtPayItemFilter.ReadOnly = True
		Me.txtPayItemFilter.Size = New System.Drawing.Size(283, 77)
		Me.txtPayItemFilter.TabIndex = 6
		'
		'txtUserCred
		'
		Me.txtUserCred.Location = New System.Drawing.Point(99, 212)
		Me.txtUserCred.Name = "txtUserCred"
		Me.txtUserCred.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtUserCred.ReadOnly = True
		Me.txtUserCred.Size = New System.Drawing.Size(100, 20)
		Me.txtUserCred.TabIndex = 7
		Me.txtUserCred.UseSystemPasswordChar = True
		'
		'txtDisplayName
		'
		Me.txtDisplayName.Location = New System.Drawing.Point(99, 94)
		Me.txtDisplayName.Multiline = True
		Me.txtDisplayName.Name = "txtDisplayName"
		Me.txtDisplayName.ReadOnly = True
		Me.txtDisplayName.Size = New System.Drawing.Size(100, 20)
		Me.txtDisplayName.TabIndex = 8
		'
		'txtCurrentJob
		'
		Me.txtCurrentJob.Location = New System.Drawing.Point(99, 59)
		Me.txtCurrentJob.Name = "txtCurrentJob"
		Me.txtCurrentJob.ReadOnly = True
		Me.txtCurrentJob.Size = New System.Drawing.Size(100, 20)
		Me.txtCurrentJob.TabIndex = 9
		'
		'ckbRetainUser
		'
		Me.ckbRetainUser.AutoSize = True
		Me.ckbRetainUser.Location = New System.Drawing.Point(99, 260)
		Me.ckbRetainUser.Name = "ckbRetainUser"
		Me.ckbRetainUser.Size = New System.Drawing.Size(82, 17)
		Me.ckbRetainUser.TabIndex = 10
		Me.ckbRetainUser.Text = "Retain User"
		Me.ckbRetainUser.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(307, 210)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 11
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'pnlSettingsMain
		'
		Me.pnlSettingsMain.BackColor = System.Drawing.Color.Transparent
		Me.pnlSettingsMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.pnlSettingsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlSettingsMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlSettingsMain.Controls.Add(Me.lblUserId)
		Me.pnlSettingsMain.Controls.Add(Me.btnExit)
		Me.pnlSettingsMain.Controls.Add(Me.lblCurrentJob)
		Me.pnlSettingsMain.Controls.Add(Me.ckbRetainUser)
		Me.pnlSettingsMain.Controls.Add(Me.lblDisplayName)
		Me.pnlSettingsMain.Controls.Add(Me.txtCurrentJob)
		Me.pnlSettingsMain.Controls.Add(Me.lblPayItemFilter)
		Me.pnlSettingsMain.Controls.Add(Me.txtDisplayName)
		Me.pnlSettingsMain.Controls.Add(Me.lblUserCred)
		Me.pnlSettingsMain.Controls.Add(Me.txtUserCred)
		Me.pnlSettingsMain.Controls.Add(Me.txtUserId)
		Me.pnlSettingsMain.Controls.Add(Me.txtPayItemFilter)
		Me.pnlSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlSettingsMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlSettingsMain.Name = "pnlSettingsMain"
		Me.pnlSettingsMain.Size = New System.Drawing.Size(400, 406)
		Me.pnlSettingsMain.TabIndex = 12
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.pnlSettingsMain)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.pGridMyAppSettings)
		Me.SplitContainer1.Size = New System.Drawing.Size(624, 406)
		Me.SplitContainer1.SplitterDistance = 400
		Me.SplitContainer1.TabIndex = 13
		'
		'pGridMyAppSettings
		'
		Me.pGridMyAppSettings.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pGridMyAppSettings.Location = New System.Drawing.Point(0, 0)
		Me.pGridMyAppSettings.Name = "pGridMyAppSettings"
		Me.pGridMyAppSettings.Size = New System.Drawing.Size(220, 406)
		Me.pGridMyAppSettings.TabIndex = 1
		'
		'frmSettings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(624, 406)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmSettings"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "User Settings"
		Me.pnlSettingsMain.ResumeLayout(False)
		Me.pnlSettingsMain.PerformLayout()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblUserId As System.Windows.Forms.Label
	Friend WithEvents lblCurrentJob As System.Windows.Forms.Label
	Friend WithEvents lblDisplayName As System.Windows.Forms.Label
	Friend WithEvents lblPayItemFilter As System.Windows.Forms.Label
	Friend WithEvents lblUserCred As System.Windows.Forms.Label
	Friend WithEvents txtUserId As System.Windows.Forms.TextBox
	Friend WithEvents txtPayItemFilter As System.Windows.Forms.TextBox
	Friend WithEvents txtUserCred As System.Windows.Forms.TextBox
	Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
	Friend WithEvents txtCurrentJob As System.Windows.Forms.TextBox
	Friend WithEvents ckbRetainUser As System.Windows.Forms.CheckBox
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents pnlSettingsMain As System.Windows.Forms.Panel
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents pGridMyAppSettings As System.Windows.Forms.PropertyGrid
End Class
