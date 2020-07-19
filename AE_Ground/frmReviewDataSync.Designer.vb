<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewDataSync
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReviewDataSync))
		Me.QryValidatePWTableAdapter1 = New AE_Ground.ActionEntryDataSetTableAdapters.qryValidatePWTableAdapter
		Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.dgvCloudDP = New System.Windows.Forms.DataGridView
		Me.TblNonPayItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.TblNonPayItemsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblNonPayItemsTableAdapter
		Me.QryUsersDisplayNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryUsersDisplayNamesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
		Me.dgvDPlist = New System.Windows.Forms.DataGridView
		Me.pnlDGVview = New System.Windows.Forms.Panel
		Me.btn6x8 = New System.Windows.Forms.Button
		Me.btn4x6 = New System.Windows.Forms.Button
		Me.btnThree = New System.Windows.Forms.Button
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.btnNPIReview = New System.Windows.Forms.Button
		CType(Me.dgvCloudDP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblNonPayItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvDPlist, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlDGVview.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'QryValidatePWTableAdapter1
		'
		Me.QryValidatePWTableAdapter1.ClearBeforeFill = True
		'
		'CrystalReportViewer1
		'
		Me.CrystalReportViewer1.ActiveViewIndex = -1
		Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CrystalReportViewer1.DisplayGroupTree = False
		Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
		Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
		Me.CrystalReportViewer1.SelectionFormula = ""
		Me.CrystalReportViewer1.Size = New System.Drawing.Size(1152, 440)
		Me.CrystalReportViewer1.TabIndex = 0
		Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
		'
		'dgvCloudDP
		'
		Me.dgvCloudDP.AllowUserToAddRows = False
		Me.dgvCloudDP.AllowUserToDeleteRows = False
		Me.dgvCloudDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvCloudDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCloudDP.Location = New System.Drawing.Point(690, 3)
		Me.dgvCloudDP.Name = "dgvCloudDP"
		Me.dgvCloudDP.ReadOnly = True
		Me.dgvCloudDP.RowHeadersVisible = False
		Me.dgvCloudDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvCloudDP.Size = New System.Drawing.Size(450, 121)
		Me.dgvCloudDP.TabIndex = 2
		'
		'TblNonPayItemsBindingSource
		'
		Me.TblNonPayItemsBindingSource.DataMember = "tblNonPayItems"
		Me.TblNonPayItemsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TblNonPayItemsTableAdapter
		'
		Me.TblNonPayItemsTableAdapter.ClearBeforeFill = True
		'
		'QryUsersDisplayNamesBindingSource
		'
		Me.QryUsersDisplayNamesBindingSource.DataMember = "qryUsersDisplayNames"
		Me.QryUsersDisplayNamesBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryUsersDisplayNamesTableAdapter
		'
		Me.QryUsersDisplayNamesTableAdapter.ClearBeforeFill = True
		'
		'dgvDPlist
		'
		Me.dgvDPlist.AllowUserToAddRows = False
		Me.dgvDPlist.AllowUserToDeleteRows = False
		Me.dgvDPlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDPlist.BackgroundColor = System.Drawing.Color.White
		Me.dgvDPlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDPlist.ColumnHeadersVisible = False
		Me.dgvDPlist.GridColor = System.Drawing.Color.White
		Me.dgvDPlist.Location = New System.Drawing.Point(3, 3)
		Me.dgvDPlist.Name = "dgvDPlist"
		Me.dgvDPlist.ReadOnly = True
		Me.dgvDPlist.RowHeadersVisible = False
		Me.dgvDPlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDPlist.Size = New System.Drawing.Size(684, 83)
		Me.dgvDPlist.TabIndex = 17
		'
		'pnlDGVview
		'
		Me.pnlDGVview.Controls.Add(Me.btnNPIReview)
		Me.pnlDGVview.Controls.Add(Me.btn6x8)
		Me.pnlDGVview.Controls.Add(Me.btn4x6)
		Me.pnlDGVview.Controls.Add(Me.btnThree)
		Me.pnlDGVview.Controls.Add(Me.dgvDPlist)
		Me.pnlDGVview.Controls.Add(Me.dgvCloudDP)
		Me.pnlDGVview.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlDGVview.Location = New System.Drawing.Point(0, 0)
		Me.pnlDGVview.Name = "pnlDGVview"
		Me.pnlDGVview.Size = New System.Drawing.Size(1152, 127)
		Me.pnlDGVview.TabIndex = 18
		'
		'btn6x8
		'
		Me.btn6x8.Location = New System.Drawing.Point(214, 92)
		Me.btn6x8.Name = "btn6x8"
		Me.btn6x8.Size = New System.Drawing.Size(115, 23)
		Me.btn6x8.TabIndex = 20
		Me.btn6x8.Text = "6x8 Wood Posts"
		Me.btn6x8.UseVisualStyleBackColor = True
		'
		'btn4x6
		'
		Me.btn4x6.Location = New System.Drawing.Point(93, 92)
		Me.btn4x6.Name = "btn4x6"
		Me.btn4x6.Size = New System.Drawing.Size(115, 23)
		Me.btn4x6.TabIndex = 19
		Me.btn4x6.Text = "4x6 Wood Posts"
		Me.btn4x6.UseVisualStyleBackColor = True
		'
		'btnThree
		'
		Me.btnThree.Location = New System.Drawing.Point(12, 92)
		Me.btnThree.Name = "btnThree"
		Me.btnThree.Size = New System.Drawing.Size(75, 23)
		Me.btnThree.TabIndex = 18
		Me.btnThree.Text = "3# Posts"
		Me.btnThree.UseVisualStyleBackColor = True
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.pnlDGVview)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1152, 574)
		Me.SplitContainer1.SplitterDistance = 130
		Me.SplitContainer1.TabIndex = 19
		'
		'btnNPIReview
		'
		Me.btnNPIReview.Location = New System.Drawing.Point(421, 92)
		Me.btnNPIReview.Name = "btnNPIReview"
		Me.btnNPIReview.Size = New System.Drawing.Size(212, 23)
		Me.btnNPIReview.TabIndex = 21
		Me.btnNPIReview.Text = "Non-Pay Items by Date Range"
		Me.btnNPIReview.UseVisualStyleBackColor = True
		'
		'frmReviewDataSync
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1152, 574)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmReviewDataSync"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DataSync Review (BETA)"
		CType(Me.dgvCloudDP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblNonPayItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvDPlist, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlDGVview.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents QryValidatePWTableAdapter1 As AE_Ground.ActionEntryDataSetTableAdapters.qryValidatePWTableAdapter
	Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents dgvCloudDP As System.Windows.Forms.DataGridView
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents TblNonPayItemsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblNonPayItemsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblNonPayItemsTableAdapter
	Friend WithEvents QryUsersDisplayNamesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryUsersDisplayNamesTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
	Friend WithEvents dgvDPlist As System.Windows.Forms.DataGridView
	Friend WithEvents pnlDGVview As System.Windows.Forms.Panel
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents btnThree As System.Windows.Forms.Button
	Friend WithEvents btn6x8 As System.Windows.Forms.Button
	Friend WithEvents btn4x6 As System.Windows.Forms.Button
	Friend WithEvents btnNPIReview As System.Windows.Forms.Button
End Class
