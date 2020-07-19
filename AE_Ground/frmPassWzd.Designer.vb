<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassWzd
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
		Me.components = New System.ComponentModel.Container
		Dim WindowsClassicWizardRenderer1 As ActiproSoftware.Wizard.WindowsClassicWizardRenderer = New ActiproSoftware.Wizard.WindowsClassicWizardRenderer
		Me.wzd_PassFinish = New ActiproSoftware.Wizard.Wizard
		Me.wzd_PassWelcomePage = New ActiproSoftware.Wizard.WizardWelcomePage
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.wzd_PassCurrentUser = New ActiproSoftware.Wizard.WizardPage
		Me.lblUserNameNote = New System.Windows.Forms.Label
		Me.lblUserName = New System.Windows.Forms.Label
		Me.lblCurrentUserCaption = New System.Windows.Forms.Label
		Me.wzd_PassCurrentPass = New ActiproSoftware.Wizard.WizardPage
		Me.txtCurrentPass = New System.Windows.Forms.MaskedTextBox
		Me.lblCurrentPass = New System.Windows.Forms.Label
		Me.wzd_PassNewPass = New ActiproSoftware.Wizard.WizardPage
		Me.lblHidden = New System.Windows.Forms.Label
		Me.TblUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.txtConfirmPass = New System.Windows.Forms.MaskedTextBox
		Me.lblConfirmPass = New System.Windows.Forms.Label
		Me.txtNewPass = New System.Windows.Forms.MaskedTextBox
		Me.lblNewPass = New System.Windows.Forms.Label
		Me.WizardPage1 = New ActiproSoftware.Wizard.WizardPage
		Me.Label4 = New System.Windows.Forms.Label
		Me.TblUsersTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblUsersTableAdapter
		CType(Me.wzd_PassFinish, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.wzd_PassWelcomePage.SuspendLayout()
		Me.wzd_PassCurrentUser.SuspendLayout()
		Me.wzd_PassCurrentPass.SuspendLayout()
		Me.wzd_PassNewPass.SuspendLayout()
		CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.WizardPage1.SuspendLayout()
		Me.SuspendLayout()
		'
		'wzd_PassFinish
		'
		Me.wzd_PassFinish.Location = New System.Drawing.Point(13, 13)
		Me.wzd_PassFinish.Name = "wzd_PassFinish"
		Me.wzd_PassFinish.Pages.AddRange(New ActiproSoftware.Wizard.WizardPage() {Me.wzd_PassWelcomePage, Me.wzd_PassCurrentUser, Me.wzd_PassCurrentPass, Me.wzd_PassNewPass, Me.WizardPage1})
		Me.wzd_PassFinish.Renderer = WindowsClassicWizardRenderer1
		Me.wzd_PassFinish.Size = New System.Drawing.Size(551, 397)
		Me.wzd_PassFinish.TabIndex = 0
		Me.wzd_PassFinish.Text = "Wizard1"
		'
		'wzd_PassWelcomePage
		'
		Me.wzd_PassWelcomePage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzd_PassWelcomePage.BackColor = System.Drawing.SystemColors.Window
		Me.wzd_PassWelcomePage.Controls.Add(Me.Label3)
		Me.wzd_PassWelcomePage.Controls.Add(Me.Label2)
		Me.wzd_PassWelcomePage.Controls.Add(Me.Label1)
		Me.wzd_PassWelcomePage.IsInteriorPage = False
		Me.wzd_PassWelcomePage.Location = New System.Drawing.Point(0, 0)
		Me.wzd_PassWelcomePage.Name = "wzd_PassWelcomePage"
		Me.wzd_PassWelcomePage.PageCaption = ""
		Me.wzd_PassWelcomePage.PageDescription = ""
		Me.wzd_PassWelcomePage.Size = New System.Drawing.Size(551, 358)
		Me.wzd_PassWelcomePage.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(178, 330)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(120, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "To continue, click Next."
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(178, 69)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(316, 244)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Use this wizard to change the password of the current user."
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(176, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(309, 55)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Welcome to the Change Your Password Wizard"
		'
		'wzd_PassCurrentUser
		'
		Me.wzd_PassCurrentUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzd_PassCurrentUser.Controls.Add(Me.lblUserNameNote)
		Me.wzd_PassCurrentUser.Controls.Add(Me.lblUserName)
		Me.wzd_PassCurrentUser.Controls.Add(Me.lblCurrentUserCaption)
		Me.wzd_PassCurrentUser.Location = New System.Drawing.Point(16, 76)
		Me.wzd_PassCurrentUser.Name = "wzd_PassCurrentUser"
		Me.wzd_PassCurrentUser.PageCaption = "User Name"
		Me.wzd_PassCurrentUser.PageDescription = "Curent User Name"
		Me.wzd_PassCurrentUser.PageTitleBarText = "Current password"
		Me.wzd_PassCurrentUser.Size = New System.Drawing.Size(1021, 460)
		Me.wzd_PassCurrentUser.TabIndex = 1
		'
		'lblUserNameNote
		'
		Me.lblUserNameNote.AutoSize = True
		Me.lblUserNameNote.BackColor = System.Drawing.Color.Transparent
		Me.lblUserNameNote.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUserNameNote.ForeColor = System.Drawing.Color.Red
		Me.lblUserNameNote.Location = New System.Drawing.Point(70, 218)
		Me.lblUserNameNote.Name = "lblUserNameNote"
		Me.lblUserNameNote.Size = New System.Drawing.Size(379, 36)
		Me.lblUserNameNote.TabIndex = 2
		Me.lblUserNameNote.Text = "Note: If you would like to change the password fo another user " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you must login w" & _
			"ith that username."
		Me.lblUserNameNote.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblUserName
		'
		Me.lblUserName.AutoSize = True
		Me.lblUserName.BackColor = System.Drawing.Color.Transparent
		Me.lblUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AE_Ground.My.MySettings.Default, "ae_DisplayName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblUserName.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUserName.Location = New System.Drawing.Point(179, 113)
		Me.lblUserName.Name = "lblUserName"
		Me.lblUserName.Size = New System.Drawing.Size(0, 40)
		Me.lblUserName.TabIndex = 1
		Me.lblUserName.Text = Global.AE_Ground.My.MySettings.Default.ae_DisplayName
		'
		'lblCurrentUserCaption
		'
		Me.lblCurrentUserCaption.AutoSize = True
		Me.lblCurrentUserCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblCurrentUserCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentUserCaption.Location = New System.Drawing.Point(33, 67)
		Me.lblCurrentUserCaption.Name = "lblCurrentUserCaption"
		Me.lblCurrentUserCaption.Size = New System.Drawing.Size(164, 20)
		Me.lblCurrentUserCaption.TabIndex = 0
		Me.lblCurrentUserCaption.Text = "Current logged in user:"
		'
		'wzd_PassCurrentPass
		'
		Me.wzd_PassCurrentPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzd_PassCurrentPass.Controls.Add(Me.txtCurrentPass)
		Me.wzd_PassCurrentPass.Controls.Add(Me.lblCurrentPass)
		Me.wzd_PassCurrentPass.Location = New System.Drawing.Point(16, 76)
		Me.wzd_PassCurrentPass.Name = "wzd_PassCurrentPass"
		Me.wzd_PassCurrentPass.PageCaption = "Current password"
		Me.wzd_PassCurrentPass.PageDescription = "Enter the password for the current user"
		Me.wzd_PassCurrentPass.Size = New System.Drawing.Size(1021, 460)
		Me.wzd_PassCurrentPass.TabIndex = 2
		'
		'txtCurrentPass
		'
		Me.txtCurrentPass.Location = New System.Drawing.Point(164, 123)
		Me.txtCurrentPass.Name = "txtCurrentPass"
		Me.txtCurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtCurrentPass.Size = New System.Drawing.Size(190, 20)
		Me.txtCurrentPass.TabIndex = 2
		'
		'lblCurrentPass
		'
		Me.lblCurrentPass.AutoSize = True
		Me.lblCurrentPass.BackColor = System.Drawing.Color.Transparent
		Me.lblCurrentPass.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentPass.Location = New System.Drawing.Point(42, 54)
		Me.lblCurrentPass.Name = "lblCurrentPass"
		Me.lblCurrentPass.Size = New System.Drawing.Size(205, 20)
		Me.lblCurrentPass.TabIndex = 1
		Me.lblCurrentPass.Text = "Enter your current password:"
		'
		'wzd_PassNewPass
		'
		Me.wzd_PassNewPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzd_PassNewPass.Controls.Add(Me.lblHidden)
		Me.wzd_PassNewPass.Controls.Add(Me.txtConfirmPass)
		Me.wzd_PassNewPass.Controls.Add(Me.lblConfirmPass)
		Me.wzd_PassNewPass.Controls.Add(Me.txtNewPass)
		Me.wzd_PassNewPass.Controls.Add(Me.lblNewPass)
		Me.wzd_PassNewPass.Location = New System.Drawing.Point(16, 76)
		Me.wzd_PassNewPass.Name = "wzd_PassNewPass"
		Me.wzd_PassNewPass.PageCaption = "New Password"
		Me.wzd_PassNewPass.PageDescription = "Enter the new password for the current user"
		Me.wzd_PassNewPass.Size = New System.Drawing.Size(1021, 460)
		Me.wzd_PassNewPass.TabIndex = 3
		'
		'lblHidden
		'
		Me.lblHidden.AutoSize = True
		Me.lblHidden.BackColor = System.Drawing.Color.Transparent
		Me.lblHidden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "pw", True))
		Me.lblHidden.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHidden.Location = New System.Drawing.Point(333, 246)
		Me.lblHidden.Name = "lblHidden"
		Me.lblHidden.Size = New System.Drawing.Size(95, 20)
		Me.lblHidden.TabIndex = 6
		Me.lblHidden.Text = "Hidden Label"
		Me.lblHidden.Visible = False
		'
		'TblUsersBindingSource
		'
		Me.TblUsersBindingSource.DataMember = "tblUsers"
		Me.TblUsersBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'txtConfirmPass
		'
		Me.txtConfirmPass.Location = New System.Drawing.Point(292, 154)
		Me.txtConfirmPass.Name = "txtConfirmPass"
		Me.txtConfirmPass.Size = New System.Drawing.Size(173, 20)
		Me.txtConfirmPass.TabIndex = 5
		Me.txtConfirmPass.UseSystemPasswordChar = True
		'
		'lblConfirmPass
		'
		Me.lblConfirmPass.AutoSize = True
		Me.lblConfirmPass.BackColor = System.Drawing.Color.Transparent
		Me.lblConfirmPass.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfirmPass.Location = New System.Drawing.Point(54, 154)
		Me.lblConfirmPass.Name = "lblConfirmPass"
		Me.lblConfirmPass.Size = New System.Drawing.Size(201, 20)
		Me.lblConfirmPass.TabIndex = 4
		Me.lblConfirmPass.Text = "Confirm your new password:"
		'
		'txtNewPass
		'
		Me.txtNewPass.Location = New System.Drawing.Point(292, 95)
		Me.txtNewPass.Name = "txtNewPass"
		Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtNewPass.Size = New System.Drawing.Size(173, 20)
		Me.txtNewPass.TabIndex = 3
		Me.txtNewPass.UseSystemPasswordChar = True
		'
		'lblNewPass
		'
		Me.lblNewPass.AutoSize = True
		Me.lblNewPass.BackColor = System.Drawing.Color.Transparent
		Me.lblNewPass.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewPass.Location = New System.Drawing.Point(72, 93)
		Me.lblNewPass.Name = "lblNewPass"
		Me.lblNewPass.Size = New System.Drawing.Size(183, 20)
		Me.lblNewPass.TabIndex = 2
		Me.lblNewPass.Text = "Enter your new password:"
		'
		'WizardPage1
		'
		Me.WizardPage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WizardPage1.BackColor = System.Drawing.SystemColors.Window
		Me.WizardPage1.Controls.Add(Me.Label4)
		Me.WizardPage1.IsInteriorPage = False
		Me.WizardPage1.Location = New System.Drawing.Point(0, 0)
		Me.WizardPage1.Name = "WizardPage1"
		Me.WizardPage1.Size = New System.Drawing.Size(1053, 552)
		Me.WizardPage1.TabIndex = 4
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(58, 166)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(435, 27)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "You have sucessfully changed your password."
		'
		'TblUsersTableAdapter
		'
		Me.TblUsersTableAdapter.ClearBeforeFill = True
		'
		'frmPassWzd
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(576, 421)
		Me.Controls.Add(Me.wzd_PassFinish)
		Me.Name = "frmPassWzd"
		Me.Text = "frmPassWzd"
		CType(Me.wzd_PassFinish, System.ComponentModel.ISupportInitialize).EndInit()
		Me.wzd_PassWelcomePage.ResumeLayout(False)
		Me.wzd_PassWelcomePage.PerformLayout()
		Me.wzd_PassCurrentUser.ResumeLayout(False)
		Me.wzd_PassCurrentUser.PerformLayout()
		Me.wzd_PassCurrentPass.ResumeLayout(False)
		Me.wzd_PassCurrentPass.PerformLayout()
		Me.wzd_PassNewPass.ResumeLayout(False)
		Me.wzd_PassNewPass.PerformLayout()
		CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.WizardPage1.ResumeLayout(False)
		Me.WizardPage1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents wzd_PassFinish As ActiproSoftware.Wizard.Wizard
	Friend WithEvents wzd_PassWelcomePage As ActiproSoftware.Wizard.WizardWelcomePage
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents wzd_PassCurrentUser As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblUserNameNote As System.Windows.Forms.Label
	Friend WithEvents lblUserName As System.Windows.Forms.Label
	Friend WithEvents lblCurrentUserCaption As System.Windows.Forms.Label
	Friend WithEvents wzd_PassCurrentPass As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents txtCurrentPass As System.Windows.Forms.MaskedTextBox
	Friend WithEvents lblCurrentPass As System.Windows.Forms.Label
	Friend WithEvents wzd_PassNewPass As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents txtConfirmPass As System.Windows.Forms.MaskedTextBox
	Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
	Friend WithEvents txtNewPass As System.Windows.Forms.MaskedTextBox
	Friend WithEvents lblNewPass As System.Windows.Forms.Label
	Friend WithEvents lblHidden As System.Windows.Forms.Label
	Friend WithEvents WizardPage1 As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents TblUsersBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblUsersTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblUsersTableAdapter
End Class
