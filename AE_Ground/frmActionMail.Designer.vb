<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActionMail
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActionMail))
		Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.TblUsersDataGridView = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TblUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.DataGridView1 = New System.Windows.Forms.DataGridView
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
		Me.dgvUserList = New System.Windows.Forms.DataGridView
		Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.AddTo = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.lblSubject = New System.Windows.Forms.Label
		Me.rtbMessage = New System.Windows.Forms.RichTextBox
		Me.txtSUBJECT = New System.Windows.Forms.TextBox
		Me.btnSendMail = New System.Windows.Forms.Button
		Me.rtbActionMessage = New System.Windows.Forms.RichTextBox
		Me.dgvActionMessages = New System.Windows.Forms.DataGridView
		Me.btnCheckMail = New System.Windows.Forms.Button
		Me.TblActionMessagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DsAE_DataSync = New AE_Ground.dsAE_DataSync
		Me.TblUsersTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblUsersTableAdapter
		Me.TableAdapterManager = New AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.SplitContainerMain.Panel1.SuspendLayout()
		Me.SplitContainerMain.Panel2.SuspendLayout()
		Me.SplitContainerMain.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.TblUsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvActionMessages, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblActionMessagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsAE_DataSync, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitContainerMain
		'
		Me.SplitContainerMain.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainerMain.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainerMain.Name = "SplitContainerMain"
		'
		'SplitContainerMain.Panel1
		'
		Me.SplitContainerMain.Panel1.Controls.Add(Me.SplitContainer1)
		Me.SplitContainerMain.Panel1MinSize = 333
		'
		'SplitContainerMain.Panel2
		'
		Me.SplitContainerMain.Panel2.Controls.Add(Me.rtbActionMessage)
		Me.SplitContainerMain.Panel2.Controls.Add(Me.dgvActionMessages)
		Me.SplitContainerMain.Panel2.Controls.Add(Me.btnCheckMail)
		Me.SplitContainerMain.Size = New System.Drawing.Size(829, 436)
		Me.SplitContainerMain.SplitterDistance = 333
		Me.SplitContainerMain.TabIndex = 0
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.TblUsersDataGridView)
		Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
		Me.SplitContainer1.Panel1Collapsed = True
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
		Me.SplitContainer1.Size = New System.Drawing.Size(333, 436)
		Me.SplitContainer1.SplitterDistance = 109
		Me.SplitContainer1.TabIndex = 0
		'
		'TblUsersDataGridView
		'
		Me.TblUsersDataGridView.AllowUserToAddRows = False
		Me.TblUsersDataGridView.AllowUserToDeleteRows = False
		Me.TblUsersDataGridView.AllowUserToResizeRows = False
		Me.TblUsersDataGridView.AutoGenerateColumns = False
		Me.TblUsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.TblUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.TblUsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
		Me.TblUsersDataGridView.DataSource = Me.TblUsersBindingSource
		Me.TblUsersDataGridView.Location = New System.Drawing.Point(12, 12)
		Me.TblUsersDataGridView.Name = "TblUsersDataGridView"
		Me.TblUsersDataGridView.RowHeadersVisible = False
		Me.TblUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.TblUsersDataGridView.Size = New System.Drawing.Size(139, 72)
		Me.TblUsersDataGridView.TabIndex = 0
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
		Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "groupID"
		Me.DataGridViewTextBoxColumn2.HeaderText = "groupID"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.Visible = False
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "userName"
		Me.DataGridViewTextBoxColumn3.HeaderText = "userName"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.Visible = False
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "firstName"
		Me.DataGridViewTextBoxColumn4.HeaderText = "firstName"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "lastName"
		Me.DataGridViewTextBoxColumn5.HeaderText = "lastName"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "ph"
		Me.DataGridViewTextBoxColumn6.HeaderText = "ph"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		Me.DataGridViewTextBoxColumn6.Visible = False
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
		Me.DataGridViewTextBoxColumn7.HeaderText = "email"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		Me.DataGridViewTextBoxColumn7.Visible = False
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "pw"
		Me.DataGridViewTextBoxColumn8.HeaderText = "pw"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		Me.DataGridViewTextBoxColumn8.Visible = False
		'
		'DataGridViewTextBoxColumn9
		'
		Me.DataGridViewTextBoxColumn9.DataPropertyName = "entryDate"
		Me.DataGridViewTextBoxColumn9.HeaderText = "entryDate"
		Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
		Me.DataGridViewTextBoxColumn9.Visible = False
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
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(157, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(118, 76)
		Me.DataGridView1.TabIndex = 6
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.dgvUserList)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.lblSubject)
		Me.SplitContainer2.Panel2.Controls.Add(Me.rtbMessage)
		Me.SplitContainer2.Panel2.Controls.Add(Me.txtSUBJECT)
		Me.SplitContainer2.Panel2.Controls.Add(Me.btnSendMail)
		Me.SplitContainer2.Size = New System.Drawing.Size(333, 436)
		Me.SplitContainer2.SplitterDistance = 222
		Me.SplitContainer2.TabIndex = 0
		'
		'dgvUserList
		'
		Me.dgvUserList.AllowUserToAddRows = False
		Me.dgvUserList.AllowUserToDeleteRows = False
		Me.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fullName, Me.AddTo})
		Me.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvUserList.Location = New System.Drawing.Point(0, 0)
		Me.dgvUserList.Name = "dgvUserList"
		Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvUserList.Size = New System.Drawing.Size(333, 222)
		Me.dgvUserList.TabIndex = 8
		'
		'ID
		'
		Me.ID.HeaderText = "ID"
		Me.ID.Name = "ID"
		Me.ID.ReadOnly = True
		Me.ID.Visible = False
		'
		'fullName
		'
		Me.fullName.HeaderText = "Name"
		Me.fullName.Name = "fullName"
		Me.fullName.ReadOnly = True
		'
		'AddTo
		'
		Me.AddTo.HeaderText = "AddTo"
		Me.AddTo.Name = "AddTo"
		'
		'lblSubject
		'
		Me.lblSubject.AutoSize = True
		Me.lblSubject.Location = New System.Drawing.Point(12, 34)
		Me.lblSubject.Name = "lblSubject"
		Me.lblSubject.Size = New System.Drawing.Size(46, 13)
		Me.lblSubject.TabIndex = 6
		Me.lblSubject.Text = "Subject:"
		'
		'rtbMessage
		'
		Me.rtbMessage.Location = New System.Drawing.Point(12, 76)
		Me.rtbMessage.Name = "rtbMessage"
		Me.rtbMessage.Size = New System.Drawing.Size(296, 89)
		Me.rtbMessage.TabIndex = 5
		Me.rtbMessage.Text = ""
		'
		'txtSUBJECT
		'
		Me.txtSUBJECT.Location = New System.Drawing.Point(12, 50)
		Me.txtSUBJECT.Name = "txtSUBJECT"
		Me.txtSUBJECT.Size = New System.Drawing.Size(296, 20)
		Me.txtSUBJECT.TabIndex = 4
		'
		'btnSendMail
		'
		Me.btnSendMail.Location = New System.Drawing.Point(233, 171)
		Me.btnSendMail.Name = "btnSendMail"
		Me.btnSendMail.Size = New System.Drawing.Size(75, 23)
		Me.btnSendMail.TabIndex = 0
		Me.btnSendMail.Text = "Send"
		Me.btnSendMail.UseVisualStyleBackColor = True
		'
		'rtbActionMessage
		'
		Me.rtbActionMessage.Location = New System.Drawing.Point(28, 286)
		Me.rtbActionMessage.Name = "rtbActionMessage"
		Me.rtbActionMessage.ReadOnly = True
		Me.rtbActionMessage.Size = New System.Drawing.Size(435, 134)
		Me.rtbActionMessage.TabIndex = 13
		Me.rtbActionMessage.Text = ""
		'
		'dgvActionMessages
		'
		Me.dgvActionMessages.AllowUserToAddRows = False
		Me.dgvActionMessages.AllowUserToDeleteRows = False
		Me.dgvActionMessages.AllowUserToResizeRows = False
		Me.dgvActionMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvActionMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvActionMessages.Location = New System.Drawing.Point(28, 43)
		Me.dgvActionMessages.Name = "dgvActionMessages"
		Me.dgvActionMessages.RowHeadersVisible = False
		Me.dgvActionMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvActionMessages.Size = New System.Drawing.Size(435, 221)
		Me.dgvActionMessages.TabIndex = 9
		'
		'btnCheckMail
		'
		Me.btnCheckMail.Location = New System.Drawing.Point(343, 14)
		Me.btnCheckMail.Name = "btnCheckMail"
		Me.btnCheckMail.Size = New System.Drawing.Size(120, 23)
		Me.btnCheckMail.TabIndex = 7
		Me.btnCheckMail.Text = "Check Mail"
		Me.btnCheckMail.UseVisualStyleBackColor = True
		'
		'TblActionMessagesBindingSource
		'
		Me.TblActionMessagesBindingSource.DataMember = "tblActionMessages"
		Me.TblActionMessagesBindingSource.DataSource = Me.DsAE_DataSync
		'
		'DsAE_DataSync
		'
		Me.DsAE_DataSync.DataSetName = "dsAE_DataSync"
		Me.DsAE_DataSync.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TblUsersTableAdapter
		'
		Me.TblUsersTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.DPTableAdapter = Nothing
		Me.TableAdapterManager.qryDPTableAdapter = Nothing
		Me.TableAdapterManager.qryNPIprodTableAdapter = Nothing
		Me.TableAdapterManager.tblDailyProductionsTableAdapter = Nothing
		Me.TableAdapterManager.tblGroupsTableAdapter = Nothing
		Me.TableAdapterManager.tblGuardRailDailyProductionsTableAdapter = Nothing
		Me.TableAdapterManager.tblGuardRailNonPayItemsTableAdapter = Nothing
		Me.TableAdapterManager.tblJobPayItemsTableAdapter = Nothing
		Me.TableAdapterManager.tblJobsTableAdapter = Nothing
		Me.TableAdapterManager.tblNonPayItemsTableAdapter = Nothing
		Me.TableAdapterManager.tblNonPIProductionsTableAdapter = Nothing
		Me.TableAdapterManager.tblPayItemPickListTableAdapter = Nothing
		Me.TableAdapterManager.tblPermissionsTableAdapter = Nothing
		Me.TableAdapterManager.tblPunchListCategoriesTableAdapter = Nothing
		Me.TableAdapterManager.tblPunchListTableAdapter = Nothing
		Me.TableAdapterManager.tblUsersTableAdapter = Me.TblUsersTableAdapter
		Me.TableAdapterManager.UpdateOrder = AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'BackgroundWorker1
		'
		Me.BackgroundWorker1.WorkerReportsProgress = True
		Me.BackgroundWorker1.WorkerSupportsCancellation = True
		'
		'Timer1
		'
		Me.Timer1.Interval = 60000
		'
		'BackgroundWorker2
		'
		Me.BackgroundWorker2.WorkerReportsProgress = True
		Me.BackgroundWorker2.WorkerSupportsCancellation = True
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "ActionMail"
		Me.NotifyIcon1.Visible = True
		'
		'frmActionMail
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(829, 436)
		Me.Controls.Add(Me.SplitContainerMain)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "frmActionMail"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ActionMail"
		Me.SplitContainerMain.Panel1.ResumeLayout(False)
		Me.SplitContainerMain.Panel2.ResumeLayout(False)
		Me.SplitContainerMain.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.TblUsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		Me.SplitContainer2.Panel2.PerformLayout()
		Me.SplitContainer2.ResumeLayout(False)
		CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvActionMessages, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblActionMessagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsAE_DataSync, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
	Friend WithEvents DsAE_DataSync As AE_Ground.dsAE_DataSync
	Friend WithEvents TblActionMessagesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents btnSendMail As System.Windows.Forms.Button
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents TblUsersBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblUsersTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblUsersTableAdapter
	Friend WithEvents TableAdapterManager As AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager
	Friend WithEvents TblUsersDataGridView As System.Windows.Forms.DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents txtSUBJECT As System.Windows.Forms.TextBox
	Friend WithEvents rtbMessage As System.Windows.Forms.RichTextBox
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents btnCheckMail As System.Windows.Forms.Button
	Friend WithEvents dgvUserList As System.Windows.Forms.DataGridView
	Friend WithEvents dgvActionMessages As System.Windows.Forms.DataGridView
	Friend WithEvents rtbActionMessage As System.Windows.Forms.RichTextBox
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
	Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents fullName As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents AddTo As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
	Friend WithEvents lblSubject As System.Windows.Forms.Label
	Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
