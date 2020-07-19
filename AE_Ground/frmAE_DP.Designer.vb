<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAE_DP
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
		Dim SignWidthLabel As System.Windows.Forms.Label
		Dim SignHeightLabel As System.Windows.Forms.Label
		Dim SignCodeLabel As System.Windows.Forms.Label
		Dim lblXforBY As System.Windows.Forms.Label
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAE_DP))
		Me.drpActiveJobs = New Microsoft.VisualBasic.PowerPacks.DataRepeater
		Me.QryActiveJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.lblJobNumber = New System.Windows.Forms.Label
		Me.dgvJobPayItems = New System.Windows.Forms.DataGridView
		Me.ckbSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.JobNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.PayItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.QryPayItemsByJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.txtDisplay = New System.Windows.Forms.TextBox
		Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
		Me.ckbCompletedItems = New System.Windows.Forms.CheckBox
		Me.ckbJobList = New System.Windows.Forms.CheckBox
		Me.ckbPayItems = New System.Windows.Forms.CheckBox
		Me.ckbDailyProductions = New System.Windows.Forms.CheckBox
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
		Me.lblHide = New System.Windows.Forms.Label
		Me.lblFullScreen = New System.Windows.Forms.Label
		Me.lblExitDP = New System.Windows.Forms.Label
		Me.LocationLabel1 = New System.Windows.Forms.Label
		Me.JobNumLabel1 = New System.Windows.Forms.Label
		Me.SplitContainerContentMain = New System.Windows.Forms.SplitContainer
		Me.SplitContainerJobPIandDP = New System.Windows.Forms.SplitContainer
		Me.btnViewSelected = New System.Windows.Forms.Button
		Me.SplitC_SiteListAndDetail = New System.Windows.Forms.SplitContainer
		Me.splitCNavDP = New System.Windows.Forms.SplitContainer
		Me.dgvDP = New System.Windows.Forms.DataGridView
		Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JobNumDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.PayItemIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.StationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.CodeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DescriptionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.UnitDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DpIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DpQtyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.CQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SignCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SignWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SignHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SiteNotesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ForemanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.EntryDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SptQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnStationSearch = New System.Windows.Forms.Button
		Me.txtSearchCriteria = New System.Windows.Forms.TextBox
		Me.btnManualEntry = New System.Windows.Forms.Button
		Me.lblRecCount = New System.Windows.Forms.Label
		Me.panNonPayItemsMain = New System.Windows.Forms.Panel
		Me.lblWorkingDate = New System.Windows.Forms.Label
		Me.tabNonPayItems = New System.Windows.Forms.TabControl
		Me.tbpWoodSteelPosts = New System.Windows.Forms.TabPage
		Me.pnlFDN = New System.Windows.Forms.Panel
		Me.lblWpFDNQty = New System.Windows.Forms.Label
		Me.btnSubmitWpFDN = New System.Windows.Forms.Button
		Me.lblCurrentPostType = New System.Windows.Forms.Label
		Me.panPosts = New System.Windows.Forms.Panel
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblLeftPost = New System.Windows.Forms.Label
		Me.cmbPost1_Actual = New System.Windows.Forms.ComboBox
		Me.lblRightPost = New System.Windows.Forms.Label
		Me.cmbPost2_Actual = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblPost2 = New System.Windows.Forms.Label
		Me.lblPost1 = New System.Windows.Forms.Label
		Me.cmbPost1 = New System.Windows.Forms.ComboBox
		Me.btnSubmitPostLengths = New System.Windows.Forms.Button
		Me.cmbPost2 = New System.Windows.Forms.ComboBox
		Me.tbpColumns = New System.Windows.Forms.TabPage
		Me.DataGridView2 = New System.Windows.Forms.DataGridView
		Me.lblColumnsTitle = New System.Windows.Forms.Label
		Me.panBreakAway = New System.Windows.Forms.Panel
		Me.btnReportElevations = New System.Windows.Forms.Button
		Me.nudR = New System.Windows.Forms.NumericUpDown
		Me.nudL = New System.Windows.Forms.NumericUpDown
		Me.lblNudRUnit = New System.Windows.Forms.Label
		Me.lblNudLUnit = New System.Windows.Forms.Label
		Me.lblNudR = New System.Windows.Forms.Label
		Me.lblNudL = New System.Windows.Forms.Label
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.tbpSlipBases = New System.Windows.Forms.TabPage
		Me.DataGridView3 = New System.Windows.Forms.DataGridView
		Me.lblSlipBaseTitle = New System.Windows.Forms.Label
		Me.panSlipBases = New System.Windows.Forms.Panel
		Me.btnSubmitSlipBaseFoundation = New System.Windows.Forms.Button
		Me.nudSlipBaseFoundation = New System.Windows.Forms.NumericUpDown
		Me.tbpNPI = New System.Windows.Forms.TabPage
		Me.dgvNPIdataSync = New System.Windows.Forms.DataGridView
		Me.lstNPI = New System.Windows.Forms.ListBox
		Me.lblNPI = New System.Windows.Forms.Label
		Me.tbpSignDetails = New System.Windows.Forms.TabPage
		Me.grpSignDetails = New System.Windows.Forms.GroupBox
		Me.SignHeightTextBox = New System.Windows.Forms.TextBox
		Me.SignWidthTextBox = New System.Windows.Forms.TextBox
		Me.picImagePreview = New System.Windows.Forms.PictureBox
		Me.SignCodeTextBox = New System.Windows.Forms.TextBox
		Me.tbpGuardRail = New System.Windows.Forms.TabPage
		Me.lblGRrunNotes = New System.Windows.Forms.Label
		Me.lblGRrunQty = New System.Windows.Forms.Label
		Me.lblGRrunID = New System.Windows.Forms.Label
		Me.lblGuardRailRunTotal = New System.Windows.Forms.Label
		Me.btnGrSave = New System.Windows.Forms.Button
		Me.txtRunNotes = New System.Windows.Forms.TextBox
		Me.txtRunID = New System.Windows.Forms.TextBox
		Me.btnAddGrRun = New System.Windows.Forms.Button
		Me.txtRunQty = New System.Windows.Forms.TextBox
		Me.dgvGuardRailProductions = New System.Windows.Forms.DataGridView
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JobNumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.RunIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.GrQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.RunNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.RunDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ForemanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TblGuardRailDailyProductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.tbpCurrentList = New System.Windows.Forms.TabPage
		Me.btnViewProduction = New System.Windows.Forms.Button
		Me.DataGridView1 = New System.Windows.Forms.DataGridView
		Me.lblDateAndTime = New System.Windows.Forms.Label
		Me.panPayItemsMain = New System.Windows.Forms.Panel
		Me.pnlNavigationSubmit = New System.Windows.Forms.Panel
		Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
		Me.lblSmallPayItemDescription = New System.Windows.Forms.Label
		Me.tlpNav = New System.Windows.Forms.TableLayoutPanel
		Me.lblLast = New System.Windows.Forms.Label
		Me.lblNext = New System.Windows.Forms.Label
		Me.btnFirst = New System.Windows.Forms.Button
		Me.lblPrevious = New System.Windows.Forms.Label
		Me.btnNext = New System.Windows.Forms.Button
		Me.btnPrev = New System.Windows.Forms.Button
		Me.lblFirst = New System.Windows.Forms.Label
		Me.btnLast = New System.Windows.Forms.Button
		Me.CQtyLabel1 = New System.Windows.Forms.Label
		Me.lblDPQty = New System.Windows.Forms.Label
		Me.lblNav = New System.Windows.Forms.Label
		Me.btnQtyValid = New System.Windows.Forms.Button
		Me.lblPlanQty = New System.Windows.Forms.Label
		Me.btnModifyQty = New System.Windows.Forms.Button
		Me.lblInstalledQty = New System.Windows.Forms.Label
		Me.lblSubmit = New System.Windows.Forms.Label
		Me.UnitLabel1 = New System.Windows.Forms.Label
		Me.btnSelect = New System.Windows.Forms.Button
		Me.lblModAuto = New System.Windows.Forms.Label
		Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.pnlItemDetails = New System.Windows.Forms.Panel
		Me.lblEntryDate = New System.Windows.Forms.Label
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
		Me.Label2 = New System.Windows.Forms.Label
		Me.SiteLabel1 = New System.Windows.Forms.Label
		Me.lblNotesTitle = New System.Windows.Forms.Label
		Me.DescriptionLabel1 = New System.Windows.Forms.Label
		Me.SiteNotesRichTextBox = New System.Windows.Forms.RichTextBox
		Me.TblNonPayItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
		Me.QryNPIdataSyncBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryNPIprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblNonPIProductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryMyDPTodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryDPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblDailyProductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryActiveJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
		Me.TableAdapterManager = New AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager
		Me.DPTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.DPTableAdapter
		Me.QryDPTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryDPTableAdapter
		Me.QryNPIprodTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryNPIprodTableAdapter
		Me.TblDailyProductionsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblDailyProductionsTableAdapter
		Me.TblGuardRailDailyProductionsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblGuardRailDailyProductionsTableAdapter
		Me.TblNonPayItemsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblNonPayItemsTableAdapter
		Me.TblNonPIProductionsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblNonPIProductionsTableAdapter
		Me.QryPayItemsByJobTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryPayItemsByJobTableAdapter
		Me.QryJobPayItemsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryJobPayItemsTableAdapter
		Me.QryMyDPTodayTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
		Me.QryNonPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryNonPITableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.QryNonPITableAdapter
		Me.QryNPIdataSyncTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryNPIdataSyncTableAdapter
		SignWidthLabel = New System.Windows.Forms.Label
		SignHeightLabel = New System.Windows.Forms.Label
		SignCodeLabel = New System.Windows.Forms.Label
		lblXforBY = New System.Windows.Forms.Label
		Me.drpActiveJobs.ItemTemplate.SuspendLayout()
		Me.drpActiveJobs.SuspendLayout()
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvJobPayItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryPayItemsByJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainerMain.Panel1.SuspendLayout()
		Me.SplitContainerMain.Panel2.SuspendLayout()
		Me.SplitContainerMain.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SplitContainerContentMain.Panel1.SuspendLayout()
		Me.SplitContainerContentMain.Panel2.SuspendLayout()
		Me.SplitContainerContentMain.SuspendLayout()
		Me.SplitContainerJobPIandDP.Panel1.SuspendLayout()
		Me.SplitContainerJobPIandDP.Panel2.SuspendLayout()
		Me.SplitContainerJobPIandDP.SuspendLayout()
		Me.SplitC_SiteListAndDetail.Panel1.SuspendLayout()
		Me.SplitC_SiteListAndDetail.Panel2.SuspendLayout()
		Me.SplitC_SiteListAndDetail.SuspendLayout()
		Me.splitCNavDP.Panel1.SuspendLayout()
		Me.splitCNavDP.Panel2.SuspendLayout()
		Me.splitCNavDP.SuspendLayout()
		CType(Me.dgvDP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panNonPayItemsMain.SuspendLayout()
		Me.tabNonPayItems.SuspendLayout()
		Me.tbpWoodSteelPosts.SuspendLayout()
		Me.pnlFDN.SuspendLayout()
		Me.panPosts.SuspendLayout()
		Me.tbpColumns.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panBreakAway.SuspendLayout()
		CType(Me.nudR, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudL, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tbpSlipBases.SuspendLayout()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panSlipBases.SuspendLayout()
		CType(Me.nudSlipBaseFoundation, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tbpNPI.SuspendLayout()
		CType(Me.dgvNPIdataSync, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tbpSignDetails.SuspendLayout()
		Me.grpSignDetails.SuspendLayout()
		CType(Me.picImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tbpGuardRail.SuspendLayout()
		CType(Me.dgvGuardRailProductions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblGuardRailDailyProductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tbpCurrentList.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panPayItemsMain.SuspendLayout()
		Me.pnlNavigationSubmit.SuspendLayout()
		Me.tlpNav.SuspendLayout()
		Me.pnlItemDetails.SuspendLayout()
		CType(Me.TblNonPayItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryNPIdataSyncBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryNPIprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblNonPIProductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryDPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblDailyProductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryNonPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SignWidthLabel
		'
		SignWidthLabel.AutoSize = True
		SignWidthLabel.Location = New System.Drawing.Point(35, 163)
		SignWidthLabel.Name = "SignWidthLabel"
		SignWidthLabel.Size = New System.Drawing.Size(65, 16)
		SignWidthLabel.TabIndex = 14
		SignWidthLabel.Text = "Sign Width:"
		'
		'SignHeightLabel
		'
		SignHeightLabel.AutoSize = True
		SignHeightLabel.Location = New System.Drawing.Point(184, 163)
		SignHeightLabel.Name = "SignHeightLabel"
		SignHeightLabel.Size = New System.Drawing.Size(68, 16)
		SignHeightLabel.TabIndex = 16
		SignHeightLabel.Text = "Sign Height:"
		'
		'SignCodeLabel
		'
		SignCodeLabel.AutoSize = True
		SignCodeLabel.Location = New System.Drawing.Point(35, 221)
		SignCodeLabel.Name = "SignCodeLabel"
		SignCodeLabel.Size = New System.Drawing.Size(60, 16)
		SignCodeLabel.TabIndex = 10
		SignCodeLabel.Text = "Sign Code:"
		'
		'lblXforBY
		'
		lblXforBY.AutoSize = True
		lblXforBY.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		lblXforBY.Location = New System.Drawing.Point(152, 184)
		lblXforBY.Name = "lblXforBY"
		lblXforBY.Size = New System.Drawing.Size(20, 22)
		lblXforBY.TabIndex = 21
		lblXforBY.Text = "X"
		'
		'drpActiveJobs
		'
		Me.drpActiveJobs.AllowUserToAddItems = False
		Me.drpActiveJobs.AllowUserToDeleteItems = False
		Me.drpActiveJobs.BackColor = System.Drawing.Color.White
		Me.drpActiveJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.drpActiveJobs.DataSource = Me.QryActiveJobsBindingSource
		Me.drpActiveJobs.Dock = System.Windows.Forms.DockStyle.Fill
		Me.drpActiveJobs.ItemHeaderSize = 12
		Me.drpActiveJobs.ItemHeaderVisible = False
		'
		'drpActiveJobs.ItemTemplate
		'
		Me.drpActiveJobs.ItemTemplate.BackColor = System.Drawing.Color.White
		Me.drpActiveJobs.ItemTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.drpActiveJobs.ItemTemplate.Controls.Add(Me.lblJobNumber)
		Me.drpActiveJobs.ItemTemplate.Size = New System.Drawing.Size(92, 35)
		Me.drpActiveJobs.Location = New System.Drawing.Point(0, 0)
		Me.drpActiveJobs.Name = "drpActiveJobs"
		Me.drpActiveJobs.Size = New System.Drawing.Size(100, 477)
		Me.drpActiveJobs.TabIndex = 0
		Me.drpActiveJobs.Text = "DataRepeater1"
		'
		'QryActiveJobsBindingSource
		'
		Me.QryActiveJobsBindingSource.DataMember = "qryActiveJobs"
		Me.QryActiveJobsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'lblJobNumber
		'
		Me.lblJobNumber.BackColor = System.Drawing.Color.White
		Me.lblJobNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryActiveJobsBindingSource, "jobNum", True))
		Me.lblJobNumber.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumber.ForeColor = System.Drawing.Color.Black
		Me.lblJobNumber.Location = New System.Drawing.Point(0, 0)
		Me.lblJobNumber.Margin = New System.Windows.Forms.Padding(0)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(76, 27)
		Me.lblJobNumber.TabIndex = 0
		Me.lblJobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dgvJobPayItems
		'
		Me.dgvJobPayItems.AllowUserToAddRows = False
		Me.dgvJobPayItems.AllowUserToDeleteRows = False
		Me.dgvJobPayItems.AutoGenerateColumns = False
		Me.dgvJobPayItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvJobPayItems.BackgroundColor = System.Drawing.Color.White
		Me.dgvJobPayItems.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvJobPayItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvJobPayItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgvJobPayItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ckbSelect, Me.JobNumDataGridViewTextBoxColumn, Me.PayItemIDDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn})
		Me.dgvJobPayItems.DataSource = Me.QryPayItemsByJobBindingSource
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvJobPayItems.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvJobPayItems.Location = New System.Drawing.Point(0, 0)
		Me.dgvJobPayItems.Name = "dgvJobPayItems"
		Me.dgvJobPayItems.RowHeadersVisible = False
		Me.dgvJobPayItems.RowHeadersWidth = 16
		Me.dgvJobPayItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvJobPayItems.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvJobPayItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvJobPayItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvJobPayItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvJobPayItems.Size = New System.Drawing.Size(272, 447)
		Me.dgvJobPayItems.TabIndex = 3
		'
		'ckbSelect
		'
		Me.ckbSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.NullValue = False
		DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
		Me.ckbSelect.DefaultCellStyle = DataGridViewCellStyle1
		Me.ckbSelect.FillWeight = 14.98202!
		Me.ckbSelect.HeaderText = ""
		Me.ckbSelect.MinimumWidth = 20
		Me.ckbSelect.Name = "ckbSelect"
		Me.ckbSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.ckbSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.ckbSelect.ToolTipText = "Add this item to your Daily Production.  Adjust quantity, if necessary."
		'
		'JobNumDataGridViewTextBoxColumn
		'
		Me.JobNumDataGridViewTextBoxColumn.DataPropertyName = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn.FillWeight = 48.01283!
		Me.JobNumDataGridViewTextBoxColumn.HeaderText = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn.Name = "JobNumDataGridViewTextBoxColumn"
		Me.JobNumDataGridViewTextBoxColumn.ReadOnly = True
		Me.JobNumDataGridViewTextBoxColumn.Visible = False
		'
		'PayItemIDDataGridViewTextBoxColumn
		'
		Me.PayItemIDDataGridViewTextBoxColumn.DataPropertyName = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn.FillWeight = 48.01283!
		Me.PayItemIDDataGridViewTextBoxColumn.HeaderText = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn.Name = "PayItemIDDataGridViewTextBoxColumn"
		Me.PayItemIDDataGridViewTextBoxColumn.ReadOnly = True
		Me.PayItemIDDataGridViewTextBoxColumn.Visible = False
		'
		'CodeDataGridViewTextBoxColumn
		'
		Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
		Me.CodeDataGridViewTextBoxColumn.FillWeight = 48.01283!
		Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
		Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
		Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
		Me.CodeDataGridViewTextBoxColumn.Visible = False
		'
		'DescriptionDataGridViewTextBoxColumn
		'
		Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
		Me.DescriptionDataGridViewTextBoxColumn.FillWeight = 213.4364!
		Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
		Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
		Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
		Me.DescriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		'
		'UnitDataGridViewTextBoxColumn
		'
		Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "unit"
		Me.UnitDataGridViewTextBoxColumn.FillWeight = 48.01283!
		Me.UnitDataGridViewTextBoxColumn.HeaderText = "unit"
		Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
		Me.UnitDataGridViewTextBoxColumn.ReadOnly = True
		Me.UnitDataGridViewTextBoxColumn.Visible = False
		'
		'QryPayItemsByJobBindingSource
		'
		Me.QryPayItemsByJobBindingSource.DataMember = "qryPayItemsByJob"
		Me.QryPayItemsByJobBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'txtDisplay
		'
		Me.txtDisplay.BackColor = System.Drawing.Color.WhiteSmoke
		Me.txtDisplay.Location = New System.Drawing.Point(955, 494)
		Me.txtDisplay.Multiline = True
		Me.txtDisplay.Name = "txtDisplay"
		Me.txtDisplay.Size = New System.Drawing.Size(35, 23)
		Me.txtDisplay.TabIndex = 7
		'
		'SplitContainerMain
		'
		Me.SplitContainerMain.BackColor = System.Drawing.Color.White
		Me.SplitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainerMain.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainerMain.Margin = New System.Windows.Forms.Padding(0)
		Me.SplitContainerMain.Name = "SplitContainerMain"
		Me.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainerMain.Panel1
		'
		Me.SplitContainerMain.Panel1.AutoScroll = True
		Me.SplitContainerMain.Panel1.BackColor = System.Drawing.Color.Azure
		Me.SplitContainerMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainerMain.Panel1.Controls.Add(Me.DateTimePicker1)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ckbCompletedItems)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ckbJobList)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ckbPayItems)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ckbDailyProductions)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.TableLayoutPanel2)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.LocationLabel1)
		Me.SplitContainerMain.Panel1.Controls.Add(Me.JobNumLabel1)
		Me.SplitContainerMain.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SplitContainerMain.Panel1.ForeColor = System.Drawing.Color.DarkGreen
		Me.SplitContainerMain.Panel1MinSize = 50
		'
		'SplitContainerMain.Panel2
		'
		Me.SplitContainerMain.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainerMain.Panel2.Controls.Add(Me.SplitContainerContentMain)
		Me.SplitContainerMain.Size = New System.Drawing.Size(1000, 530)
		Me.SplitContainerMain.SplitterWidth = 1
		Me.SplitContainerMain.TabIndex = 8
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker1.CustomFormat = "MM-dd-yyyy"
		Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker1.Location = New System.Drawing.Point(619, 11)
		Me.DateTimePicker1.MaxDate = New Date(2022, 7, 5, 0, 0, 0, 0)
		Me.DateTimePicker1.MinDate = New Date(2011, 6, 5, 0, 0, 0, 0)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.ShowCheckBox = True
		Me.DateTimePicker1.Size = New System.Drawing.Size(161, 26)
		Me.DateTimePicker1.TabIndex = 44
		Me.DateTimePicker1.Value = New Date(2011, 6, 5, 0, 0, 0, 0)
		'
		'ckbCompletedItems
		'
		Me.ckbCompletedItems.AutoSize = True
		Me.ckbCompletedItems.BackColor = System.Drawing.Color.Transparent
		Me.ckbCompletedItems.Enabled = False
		Me.ckbCompletedItems.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbCompletedItems.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ckbCompletedItems.Location = New System.Drawing.Point(796, 6)
		Me.ckbCompletedItems.Name = "ckbCompletedItems"
		Me.ckbCompletedItems.Size = New System.Drawing.Size(68, 14)
		Me.ckbCompletedItems.TabIndex = 43
		Me.ckbCompletedItems.Text = "Completed"
		Me.ckbCompletedItems.UseVisualStyleBackColor = False
		'
		'ckbJobList
		'
		Me.ckbJobList.AutoSize = True
		Me.ckbJobList.BackColor = System.Drawing.Color.Transparent
		Me.ckbJobList.Checked = True
		Me.ckbJobList.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckbJobList.Enabled = False
		Me.ckbJobList.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbJobList.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ckbJobList.Location = New System.Drawing.Point(874, 6)
		Me.ckbJobList.Name = "ckbJobList"
		Me.ckbJobList.Size = New System.Drawing.Size(42, 14)
		Me.ckbJobList.TabIndex = 0
		Me.ckbJobList.Text = "Jobs"
		Me.ckbJobList.UseVisualStyleBackColor = False
		'
		'ckbPayItems
		'
		Me.ckbPayItems.AutoSize = True
		Me.ckbPayItems.BackColor = System.Drawing.Color.Transparent
		Me.ckbPayItems.Checked = True
		Me.ckbPayItems.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ckbPayItems.Enabled = False
		Me.ckbPayItems.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbPayItems.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ckbPayItems.Location = New System.Drawing.Point(874, 28)
		Me.ckbPayItems.Name = "ckbPayItems"
		Me.ckbPayItems.Size = New System.Drawing.Size(47, 14)
		Me.ckbPayItems.TabIndex = 1
		Me.ckbPayItems.Text = "Items"
		Me.ckbPayItems.UseVisualStyleBackColor = False
		'
		'ckbDailyProductions
		'
		Me.ckbDailyProductions.AutoSize = True
		Me.ckbDailyProductions.BackColor = System.Drawing.Color.Transparent
		Me.ckbDailyProductions.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ckbDailyProductions.ForeColor = System.Drawing.Color.MidnightBlue
		Me.ckbDailyProductions.Location = New System.Drawing.Point(796, 28)
		Me.ckbDailyProductions.Name = "ckbDailyProductions"
		Me.ckbDailyProductions.Size = New System.Drawing.Size(69, 14)
		Me.ckbDailyProductions.TabIndex = 2
		Me.ckbDailyProductions.Text = "Jobs/Items"
		Me.ckbDailyProductions.UseVisualStyleBackColor = False
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.Controls.Add(Me.lblHide, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.lblFullScreen, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.lblExitDP, 2, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(926, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(69, 40)
		Me.TableLayoutPanel2.TabIndex = 40
		'
		'lblHide
		'
		Me.lblHide.BackColor = System.Drawing.Color.Transparent
		Me.lblHide.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lblHide.ForeColor = System.Drawing.Color.Black
		Me.lblHide.Location = New System.Drawing.Point(3, 0)
		Me.lblHide.Name = "lblHide"
		Me.lblHide.Size = New System.Drawing.Size(17, 22)
		Me.lblHide.TabIndex = 38
		Me.lblHide.Text = "0"
		Me.lblHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblFullScreen
		'
		Me.lblFullScreen.BackColor = System.Drawing.Color.Transparent
		Me.lblFullScreen.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lblFullScreen.ForeColor = System.Drawing.Color.Black
		Me.lblFullScreen.Location = New System.Drawing.Point(26, 0)
		Me.lblFullScreen.Name = "lblFullScreen"
		Me.lblFullScreen.Size = New System.Drawing.Size(17, 26)
		Me.lblFullScreen.TabIndex = 37
		Me.lblFullScreen.Text = "1"
		Me.lblFullScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblExitDP
		'
		Me.lblExitDP.BackColor = System.Drawing.Color.Transparent
		Me.lblExitDP.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.lblExitDP.ForeColor = System.Drawing.Color.Black
		Me.lblExitDP.Location = New System.Drawing.Point(49, 0)
		Me.lblExitDP.Name = "lblExitDP"
		Me.lblExitDP.Size = New System.Drawing.Size(16, 24)
		Me.lblExitDP.TabIndex = 36
		Me.lblExitDP.Text = "r"
		Me.lblExitDP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'LocationLabel1
		'
		Me.LocationLabel1.BackColor = System.Drawing.Color.Transparent
		Me.LocationLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LocationLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryActiveJobsBindingSource, "location", True))
		Me.LocationLabel1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LocationLabel1.ForeColor = System.Drawing.Color.Crimson
		Me.LocationLabel1.Location = New System.Drawing.Point(101, 3)
		Me.LocationLabel1.Name = "LocationLabel1"
		Me.LocationLabel1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
		Me.LocationLabel1.Size = New System.Drawing.Size(502, 45)
		Me.LocationLabel1.TabIndex = 13
		Me.LocationLabel1.Text = "Job Location"
		Me.LocationLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'JobNumLabel1
		'
		Me.JobNumLabel1.BackColor = System.Drawing.Color.Transparent
		Me.JobNumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.JobNumLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryActiveJobsBindingSource, "jobNum", True))
		Me.JobNumLabel1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.JobNumLabel1.ForeColor = System.Drawing.Color.Black
		Me.JobNumLabel1.Location = New System.Drawing.Point(3, 3)
		Me.JobNumLabel1.Name = "JobNumLabel1"
		Me.JobNumLabel1.Size = New System.Drawing.Size(97, 45)
		Me.JobNumLabel1.TabIndex = 12
		Me.JobNumLabel1.Text = "Job #"
		Me.JobNumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'SplitContainerContentMain
		'
		Me.SplitContainerContentMain.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainerContentMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerContentMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainerContentMain.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainerContentMain.Name = "SplitContainerContentMain"
		'
		'SplitContainerContentMain.Panel1
		'
		Me.SplitContainerContentMain.Panel1.Controls.Add(Me.drpActiveJobs)
		Me.SplitContainerContentMain.Panel1MinSize = 0
		'
		'SplitContainerContentMain.Panel2
		'
		Me.SplitContainerContentMain.Panel2.Controls.Add(Me.SplitContainerJobPIandDP)
		Me.SplitContainerContentMain.Panel2MinSize = 0
		Me.SplitContainerContentMain.Size = New System.Drawing.Size(998, 477)
		Me.SplitContainerContentMain.SplitterDistance = 100
		Me.SplitContainerContentMain.SplitterWidth = 1
		Me.SplitContainerContentMain.TabIndex = 0
		'
		'SplitContainerJobPIandDP
		'
		Me.SplitContainerJobPIandDP.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainerJobPIandDP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerJobPIandDP.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainerJobPIandDP.Name = "SplitContainerJobPIandDP"
		'
		'SplitContainerJobPIandDP.Panel1
		'
		Me.SplitContainerJobPIandDP.Panel1.Controls.Add(Me.dgvJobPayItems)
		Me.SplitContainerJobPIandDP.Panel1.Controls.Add(Me.btnViewSelected)
		Me.SplitContainerJobPIandDP.Panel1MinSize = 0
		'
		'SplitContainerJobPIandDP.Panel2
		'
		Me.SplitContainerJobPIandDP.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainerJobPIandDP.Panel2.Controls.Add(Me.SplitC_SiteListAndDetail)
		Me.SplitContainerJobPIandDP.Panel2MinSize = 0
		Me.SplitContainerJobPIandDP.Size = New System.Drawing.Size(897, 477)
		Me.SplitContainerJobPIandDP.SplitterDistance = 272
		Me.SplitContainerJobPIandDP.SplitterWidth = 1
		Me.SplitContainerJobPIandDP.TabIndex = 0
		'
		'btnViewSelected
		'
		Me.btnViewSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnViewSelected.ForeColor = System.Drawing.Color.Black
		Me.btnViewSelected.Location = New System.Drawing.Point(2, 448)
		Me.btnViewSelected.Margin = New System.Windows.Forms.Padding(0)
		Me.btnViewSelected.Name = "btnViewSelected"
		Me.btnViewSelected.Size = New System.Drawing.Size(268, 26)
		Me.btnViewSelected.TabIndex = 42
		Me.btnViewSelected.Text = "View Items"
		Me.ToolTip1.SetToolTip(Me.btnViewSelected, "Select only the Pay Items needed.  Whether All are selected or NONE are selected," & _
				" the result will be ALL Records displayed.")
		Me.btnViewSelected.UseVisualStyleBackColor = True
		'
		'SplitC_SiteListAndDetail
		'
		Me.SplitC_SiteListAndDetail.BackColor = System.Drawing.Color.Transparent
		Me.SplitC_SiteListAndDetail.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitC_SiteListAndDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitC_SiteListAndDetail.Location = New System.Drawing.Point(0, 0)
		Me.SplitC_SiteListAndDetail.Name = "SplitC_SiteListAndDetail"
		'
		'SplitC_SiteListAndDetail.Panel1
		'
		Me.SplitC_SiteListAndDetail.Panel1.AutoScroll = True
		Me.SplitC_SiteListAndDetail.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.SplitC_SiteListAndDetail.Panel1.Controls.Add(Me.splitCNavDP)
		'
		'SplitC_SiteListAndDetail.Panel2
		'
		Me.SplitC_SiteListAndDetail.Panel2.AutoScroll = True
		Me.SplitC_SiteListAndDetail.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
		Me.SplitC_SiteListAndDetail.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitC_SiteListAndDetail.Panel2.Controls.Add(Me.panNonPayItemsMain)
		Me.SplitC_SiteListAndDetail.Panel2.Controls.Add(Me.panPayItemsMain)
		Me.SplitC_SiteListAndDetail.Size = New System.Drawing.Size(624, 477)
		Me.SplitC_SiteListAndDetail.SplitterDistance = 272
		Me.SplitC_SiteListAndDetail.SplitterWidth = 1
		Me.SplitC_SiteListAndDetail.TabIndex = 6
		'
		'splitCNavDP
		'
		Me.splitCNavDP.BackColor = System.Drawing.Color.Transparent
		Me.splitCNavDP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitCNavDP.Location = New System.Drawing.Point(0, 0)
		Me.splitCNavDP.Name = "splitCNavDP"
		Me.splitCNavDP.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'splitCNavDP.Panel1
		'
		Me.splitCNavDP.Panel1.Controls.Add(Me.dgvDP)
		'
		'splitCNavDP.Panel2
		'
		Me.splitCNavDP.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.splitCNavDP.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.splitCNavDP.Panel2.Controls.Add(Me.btnStationSearch)
		Me.splitCNavDP.Panel2.Controls.Add(Me.txtSearchCriteria)
		Me.splitCNavDP.Panel2.Controls.Add(Me.btnManualEntry)
		Me.splitCNavDP.Panel2.Controls.Add(Me.lblRecCount)
		Me.splitCNavDP.Size = New System.Drawing.Size(272, 477)
		Me.splitCNavDP.SplitterDistance = 400
		Me.splitCNavDP.SplitterWidth = 1
		Me.splitCNavDP.TabIndex = 1
		'
		'dgvDP
		'
		Me.dgvDP.AllowUserToAddRows = False
		Me.dgvDP.AllowUserToDeleteRows = False
		Me.dgvDP.AllowUserToResizeRows = False
		Me.dgvDP.AutoGenerateColumns = False
		Me.dgvDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDP.BackgroundColor = System.Drawing.Color.White
		Me.dgvDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		Me.dgvDP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.JobNumDataGridViewTextBoxColumn2, Me.PayItemIDDataGridViewTextBoxColumn2, Me.StationDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn2, Me.DescriptionDataGridViewTextBoxColumn2, Me.UnitDataGridViewTextBoxColumn1, Me.DpIDDataGridViewTextBoxColumn2, Me.DpQtyDataGridViewTextBoxColumn1, Me.CQtyDataGridViewTextBoxColumn, Me.SignCodeDataGridViewTextBoxColumn, Me.SignWidthDataGridViewTextBoxColumn, Me.SignHeightDataGridViewTextBoxColumn, Me.SiteNotesDataGridViewTextBoxColumn1, Me.ForemanDataGridViewTextBoxColumn1, Me.EntryDateDataGridViewTextBoxColumn1, Me.SptQtyDataGridViewTextBoxColumn})
		Me.dgvDP.DataSource = Me.DPBindingSource
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDP.DefaultCellStyle = DataGridViewCellStyle5
		Me.dgvDP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvDP.GridColor = System.Drawing.Color.White
		Me.dgvDP.Location = New System.Drawing.Point(0, 0)
		Me.dgvDP.Name = "dgvDP"
		Me.dgvDP.ReadOnly = True
		Me.dgvDP.RowHeadersVisible = False
		Me.dgvDP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
		Me.dgvDP.RowsDefaultCellStyle = DataGridViewCellStyle6
		Me.dgvDP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDP.Size = New System.Drawing.Size(272, 400)
		Me.dgvDP.TabIndex = 1
		'
		'IDDataGridViewTextBoxColumn2
		'
		Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
		Me.IDDataGridViewTextBoxColumn2.ReadOnly = True
		Me.IDDataGridViewTextBoxColumn2.Visible = False
		'
		'JobNumDataGridViewTextBoxColumn2
		'
		Me.JobNumDataGridViewTextBoxColumn2.DataPropertyName = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn2.HeaderText = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn2.Name = "JobNumDataGridViewTextBoxColumn2"
		Me.JobNumDataGridViewTextBoxColumn2.ReadOnly = True
		Me.JobNumDataGridViewTextBoxColumn2.Visible = False
		'
		'PayItemIDDataGridViewTextBoxColumn2
		'
		Me.PayItemIDDataGridViewTextBoxColumn2.DataPropertyName = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn2.HeaderText = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn2.Name = "PayItemIDDataGridViewTextBoxColumn2"
		Me.PayItemIDDataGridViewTextBoxColumn2.ReadOnly = True
		Me.PayItemIDDataGridViewTextBoxColumn2.Visible = False
		'
		'StationDataGridViewTextBoxColumn
		'
		Me.StationDataGridViewTextBoxColumn.DataPropertyName = "station"
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StationDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
		Me.StationDataGridViewTextBoxColumn.FillWeight = 55.0!
		Me.StationDataGridViewTextBoxColumn.HeaderText = "Station"
		Me.StationDataGridViewTextBoxColumn.Name = "StationDataGridViewTextBoxColumn"
		Me.StationDataGridViewTextBoxColumn.ReadOnly = True
		'
		'CodeDataGridViewTextBoxColumn2
		'
		Me.CodeDataGridViewTextBoxColumn2.DataPropertyName = "code"
		Me.CodeDataGridViewTextBoxColumn2.HeaderText = "code"
		Me.CodeDataGridViewTextBoxColumn2.Name = "CodeDataGridViewTextBoxColumn2"
		Me.CodeDataGridViewTextBoxColumn2.ReadOnly = True
		Me.CodeDataGridViewTextBoxColumn2.Visible = False
		'
		'DescriptionDataGridViewTextBoxColumn2
		'
		Me.DescriptionDataGridViewTextBoxColumn2.DataPropertyName = "description"
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DescriptionDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
		Me.DescriptionDataGridViewTextBoxColumn2.FillWeight = 45.0!
		Me.DescriptionDataGridViewTextBoxColumn2.HeaderText = "Description"
		Me.DescriptionDataGridViewTextBoxColumn2.Name = "DescriptionDataGridViewTextBoxColumn2"
		Me.DescriptionDataGridViewTextBoxColumn2.ReadOnly = True
		'
		'UnitDataGridViewTextBoxColumn1
		'
		Me.UnitDataGridViewTextBoxColumn1.DataPropertyName = "unit"
		Me.UnitDataGridViewTextBoxColumn1.HeaderText = "unit"
		Me.UnitDataGridViewTextBoxColumn1.Name = "UnitDataGridViewTextBoxColumn1"
		Me.UnitDataGridViewTextBoxColumn1.ReadOnly = True
		Me.UnitDataGridViewTextBoxColumn1.Visible = False
		'
		'DpIDDataGridViewTextBoxColumn2
		'
		Me.DpIDDataGridViewTextBoxColumn2.DataPropertyName = "dpID"
		Me.DpIDDataGridViewTextBoxColumn2.HeaderText = "dpID"
		Me.DpIDDataGridViewTextBoxColumn2.Name = "DpIDDataGridViewTextBoxColumn2"
		Me.DpIDDataGridViewTextBoxColumn2.ReadOnly = True
		Me.DpIDDataGridViewTextBoxColumn2.Visible = False
		'
		'DpQtyDataGridViewTextBoxColumn1
		'
		Me.DpQtyDataGridViewTextBoxColumn1.DataPropertyName = "dpQty"
		Me.DpQtyDataGridViewTextBoxColumn1.HeaderText = "dpQty"
		Me.DpQtyDataGridViewTextBoxColumn1.Name = "DpQtyDataGridViewTextBoxColumn1"
		Me.DpQtyDataGridViewTextBoxColumn1.ReadOnly = True
		Me.DpQtyDataGridViewTextBoxColumn1.Visible = False
		'
		'CQtyDataGridViewTextBoxColumn
		'
		Me.CQtyDataGridViewTextBoxColumn.DataPropertyName = "cQty"
		Me.CQtyDataGridViewTextBoxColumn.HeaderText = "cQty"
		Me.CQtyDataGridViewTextBoxColumn.Name = "CQtyDataGridViewTextBoxColumn"
		Me.CQtyDataGridViewTextBoxColumn.ReadOnly = True
		Me.CQtyDataGridViewTextBoxColumn.Visible = False
		'
		'SignCodeDataGridViewTextBoxColumn
		'
		Me.SignCodeDataGridViewTextBoxColumn.DataPropertyName = "signCode"
		Me.SignCodeDataGridViewTextBoxColumn.HeaderText = "signCode"
		Me.SignCodeDataGridViewTextBoxColumn.Name = "SignCodeDataGridViewTextBoxColumn"
		Me.SignCodeDataGridViewTextBoxColumn.ReadOnly = True
		Me.SignCodeDataGridViewTextBoxColumn.Visible = False
		'
		'SignWidthDataGridViewTextBoxColumn
		'
		Me.SignWidthDataGridViewTextBoxColumn.DataPropertyName = "signWidth"
		Me.SignWidthDataGridViewTextBoxColumn.HeaderText = "signWidth"
		Me.SignWidthDataGridViewTextBoxColumn.Name = "SignWidthDataGridViewTextBoxColumn"
		Me.SignWidthDataGridViewTextBoxColumn.ReadOnly = True
		Me.SignWidthDataGridViewTextBoxColumn.Visible = False
		'
		'SignHeightDataGridViewTextBoxColumn
		'
		Me.SignHeightDataGridViewTextBoxColumn.DataPropertyName = "signHeight"
		Me.SignHeightDataGridViewTextBoxColumn.HeaderText = "signHeight"
		Me.SignHeightDataGridViewTextBoxColumn.Name = "SignHeightDataGridViewTextBoxColumn"
		Me.SignHeightDataGridViewTextBoxColumn.ReadOnly = True
		Me.SignHeightDataGridViewTextBoxColumn.Visible = False
		'
		'SiteNotesDataGridViewTextBoxColumn1
		'
		Me.SiteNotesDataGridViewTextBoxColumn1.DataPropertyName = "siteNotes"
		Me.SiteNotesDataGridViewTextBoxColumn1.HeaderText = "siteNotes"
		Me.SiteNotesDataGridViewTextBoxColumn1.Name = "SiteNotesDataGridViewTextBoxColumn1"
		Me.SiteNotesDataGridViewTextBoxColumn1.ReadOnly = True
		Me.SiteNotesDataGridViewTextBoxColumn1.Visible = False
		'
		'ForemanDataGridViewTextBoxColumn1
		'
		Me.ForemanDataGridViewTextBoxColumn1.DataPropertyName = "foreman"
		Me.ForemanDataGridViewTextBoxColumn1.HeaderText = "foreman"
		Me.ForemanDataGridViewTextBoxColumn1.Name = "ForemanDataGridViewTextBoxColumn1"
		Me.ForemanDataGridViewTextBoxColumn1.ReadOnly = True
		Me.ForemanDataGridViewTextBoxColumn1.Visible = False
		'
		'EntryDateDataGridViewTextBoxColumn1
		'
		Me.EntryDateDataGridViewTextBoxColumn1.DataPropertyName = "entryDate"
		Me.EntryDateDataGridViewTextBoxColumn1.HeaderText = "entryDate"
		Me.EntryDateDataGridViewTextBoxColumn1.Name = "EntryDateDataGridViewTextBoxColumn1"
		Me.EntryDateDataGridViewTextBoxColumn1.ReadOnly = True
		Me.EntryDateDataGridViewTextBoxColumn1.Visible = False
		'
		'SptQtyDataGridViewTextBoxColumn
		'
		Me.SptQtyDataGridViewTextBoxColumn.DataPropertyName = "sptQty"
		Me.SptQtyDataGridViewTextBoxColumn.HeaderText = "sptQty"
		Me.SptQtyDataGridViewTextBoxColumn.Name = "SptQtyDataGridViewTextBoxColumn"
		Me.SptQtyDataGridViewTextBoxColumn.ReadOnly = True
		Me.SptQtyDataGridViewTextBoxColumn.Visible = False
		'
		'DPBindingSource
		'
		Me.DPBindingSource.DataMember = "DP"
		Me.DPBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'btnStationSearch
		'
		Me.btnStationSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnStationSearch.ForeColor = System.Drawing.Color.Black
		Me.btnStationSearch.Location = New System.Drawing.Point(188, 0)
		Me.btnStationSearch.Margin = New System.Windows.Forms.Padding(0)
		Me.btnStationSearch.Name = "btnStationSearch"
		Me.btnStationSearch.Size = New System.Drawing.Size(84, 26)
		Me.btnStationSearch.TabIndex = 45
		Me.btnStationSearch.Text = "Search"
		Me.ToolTip1.SetToolTip(Me.btnStationSearch, "Click to Search")
		Me.btnStationSearch.UseVisualStyleBackColor = True
		'
		'txtSearchCriteria
		'
		Me.txtSearchCriteria.Location = New System.Drawing.Point(2, 3)
		Me.txtSearchCriteria.Name = "txtSearchCriteria"
		Me.txtSearchCriteria.Size = New System.Drawing.Size(183, 20)
		Me.txtSearchCriteria.TabIndex = 2
		Me.txtSearchCriteria.Text = "Type your Search"
		'
		'btnManualEntry
		'
		Me.btnManualEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnManualEntry.ForeColor = System.Drawing.Color.Black
		Me.btnManualEntry.Location = New System.Drawing.Point(2, 47)
		Me.btnManualEntry.Margin = New System.Windows.Forms.Padding(0)
		Me.btnManualEntry.Name = "btnManualEntry"
		Me.btnManualEntry.Size = New System.Drawing.Size(270, 26)
		Me.btnManualEntry.TabIndex = 44
		Me.btnManualEntry.Text = "Manual Entry"
		Me.ToolTip1.SetToolTip(Me.btnManualEntry, "Manually Enter Items Not Listed.")
		Me.btnManualEntry.UseVisualStyleBackColor = True
		'
		'lblRecCount
		'
		Me.lblRecCount.BackColor = System.Drawing.Color.Transparent
		Me.lblRecCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblRecCount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecCount.Location = New System.Drawing.Point(0, 27)
		Me.lblRecCount.Margin = New System.Windows.Forms.Padding(0)
		Me.lblRecCount.Name = "lblRecCount"
		Me.lblRecCount.Size = New System.Drawing.Size(272, 19)
		Me.lblRecCount.TabIndex = 29
		Me.lblRecCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panNonPayItemsMain
		'
		Me.panNonPayItemsMain.BackColor = System.Drawing.Color.Transparent
		Me.panNonPayItemsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panNonPayItemsMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panNonPayItemsMain.Controls.Add(Me.lblWorkingDate)
		Me.panNonPayItemsMain.Controls.Add(Me.tabNonPayItems)
		Me.panNonPayItemsMain.Controls.Add(Me.lblDateAndTime)
		Me.panNonPayItemsMain.Location = New System.Drawing.Point(355, 6)
		Me.panNonPayItemsMain.Name = "panNonPayItemsMain"
		Me.panNonPayItemsMain.Size = New System.Drawing.Size(364, 446)
		Me.panNonPayItemsMain.TabIndex = 33
		'
		'lblWorkingDate
		'
		Me.lblWorkingDate.BackColor = System.Drawing.Color.Transparent
		Me.lblWorkingDate.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWorkingDate.ForeColor = System.Drawing.Color.Black
		Me.lblWorkingDate.Location = New System.Drawing.Point(5, 5)
		Me.lblWorkingDate.Margin = New System.Windows.Forms.Padding(1)
		Me.lblWorkingDate.Name = "lblWorkingDate"
		Me.lblWorkingDate.Size = New System.Drawing.Size(90, 12)
		Me.lblWorkingDate.TabIndex = 46
		Me.lblWorkingDate.Text = "Working Date:"
		Me.lblWorkingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'tabNonPayItems
		'
		Me.tabNonPayItems.Controls.Add(Me.tbpWoodSteelPosts)
		Me.tabNonPayItems.Controls.Add(Me.tbpColumns)
		Me.tabNonPayItems.Controls.Add(Me.tbpSlipBases)
		Me.tabNonPayItems.Controls.Add(Me.tbpNPI)
		Me.tabNonPayItems.Controls.Add(Me.tbpSignDetails)
		Me.tabNonPayItems.Controls.Add(Me.tbpGuardRail)
		Me.tabNonPayItems.Controls.Add(Me.tbpCurrentList)
		Me.tabNonPayItems.Location = New System.Drawing.Point(6, 53)
		Me.tabNonPayItems.Margin = New System.Windows.Forms.Padding(0)
		Me.tabNonPayItems.Name = "tabNonPayItems"
		Me.tabNonPayItems.Padding = New System.Drawing.Point(0, 0)
		Me.tabNonPayItems.SelectedIndex = 0
		Me.tabNonPayItems.Size = New System.Drawing.Size(350, 388)
		Me.tabNonPayItems.TabIndex = 35
		'
		'tbpWoodSteelPosts
		'
		Me.tbpWoodSteelPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.tbpWoodSteelPosts.Controls.Add(Me.pnlFDN)
		Me.tbpWoodSteelPosts.Controls.Add(Me.lblCurrentPostType)
		Me.tbpWoodSteelPosts.Controls.Add(Me.panPosts)
		Me.tbpWoodSteelPosts.Location = New System.Drawing.Point(4, 22)
		Me.tbpWoodSteelPosts.Name = "tbpWoodSteelPosts"
		Me.tbpWoodSteelPosts.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpWoodSteelPosts.Size = New System.Drawing.Size(342, 362)
		Me.tbpWoodSteelPosts.TabIndex = 0
		Me.tbpWoodSteelPosts.Text = "Posts"
		Me.tbpWoodSteelPosts.UseVisualStyleBackColor = True
		'
		'pnlFDN
		'
		Me.pnlFDN.Controls.Add(Me.lblWpFDNQty)
		Me.pnlFDN.Controls.Add(Me.btnSubmitWpFDN)
		Me.pnlFDN.Location = New System.Drawing.Point(3, 51)
		Me.pnlFDN.Name = "pnlFDN"
		Me.pnlFDN.Size = New System.Drawing.Size(329, 98)
		Me.pnlFDN.TabIndex = 33
		'
		'lblWpFDNQty
		'
		Me.lblWpFDNQty.BackColor = System.Drawing.Color.Transparent
		Me.lblWpFDNQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblWpFDNQty.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWpFDNQty.ForeColor = System.Drawing.Color.Black
		Me.lblWpFDNQty.Location = New System.Drawing.Point(113, 11)
		Me.lblWpFDNQty.Margin = New System.Windows.Forms.Padding(0)
		Me.lblWpFDNQty.Name = "lblWpFDNQty"
		Me.lblWpFDNQty.Size = New System.Drawing.Size(100, 43)
		Me.lblWpFDNQty.TabIndex = 32
		Me.lblWpFDNQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.lblWpFDNQty, "Left Post Length - Click to adjust.")
		'
		'btnSubmitWpFDN
		'
		Me.btnSubmitWpFDN.Location = New System.Drawing.Point(73, 57)
		Me.btnSubmitWpFDN.Name = "btnSubmitWpFDN"
		Me.btnSubmitWpFDN.Size = New System.Drawing.Size(178, 29)
		Me.btnSubmitWpFDN.TabIndex = 31
		Me.btnSubmitWpFDN.Text = "Report Wood Post Foundation(s)"
		Me.btnSubmitWpFDN.UseVisualStyleBackColor = True
		'
		'lblCurrentPostType
		'
		Me.lblCurrentPostType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentPostType.ForeColor = System.Drawing.Color.Navy
		Me.lblCurrentPostType.Location = New System.Drawing.Point(6, 23)
		Me.lblCurrentPostType.Name = "lblCurrentPostType"
		Me.lblCurrentPostType.Size = New System.Drawing.Size(324, 20)
		Me.lblCurrentPostType.TabIndex = 29
		'
		'panPosts
		'
		Me.panPosts.Controls.Add(Me.Label4)
		Me.panPosts.Controls.Add(Me.Label3)
		Me.panPosts.Controls.Add(Me.lblLeftPost)
		Me.panPosts.Controls.Add(Me.cmbPost1_Actual)
		Me.panPosts.Controls.Add(Me.lblRightPost)
		Me.panPosts.Controls.Add(Me.cmbPost2_Actual)
		Me.panPosts.Controls.Add(Me.Label1)
		Me.panPosts.Controls.Add(Me.lblPost2)
		Me.panPosts.Controls.Add(Me.lblPost1)
		Me.panPosts.Controls.Add(Me.cmbPost1)
		Me.panPosts.Controls.Add(Me.btnSubmitPostLengths)
		Me.panPosts.Controls.Add(Me.cmbPost2)
		Me.panPosts.Location = New System.Drawing.Point(3, 155)
		Me.panPosts.Name = "panPosts"
		Me.panPosts.Size = New System.Drawing.Size(329, 184)
		Me.panPosts.TabIndex = 30
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(10, 93)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(99, 15)
		Me.Label4.TabIndex = 35
		Me.Label4.Text = "Actual (+Drop)"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(47, 41)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(62, 15)
		Me.Label3.TabIndex = 34
		Me.Label3.Text = "Installed"
		'
		'lblLeftPost
		'
		Me.lblLeftPost.BackColor = System.Drawing.Color.Transparent
		Me.lblLeftPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblLeftPost.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLeftPost.ForeColor = System.Drawing.Color.Black
		Me.lblLeftPost.Location = New System.Drawing.Point(37, 141)
		Me.lblLeftPost.Margin = New System.Windows.Forms.Padding(0)
		Me.lblLeftPost.Name = "lblLeftPost"
		Me.lblLeftPost.Size = New System.Drawing.Size(45, 18)
		Me.lblLeftPost.TabIndex = 29
		Me.lblLeftPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.lblLeftPost, "Left Post Length - Click to adjust.")
		Me.lblLeftPost.Visible = False
		'
		'cmbPost1_Actual
		'
		Me.cmbPost1_Actual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbPost1_Actual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPost1_Actual.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPost1_Actual.FormattingEnabled = True
		Me.cmbPost1_Actual.Location = New System.Drawing.Point(115, 80)
		Me.cmbPost1_Actual.Name = "cmbPost1_Actual"
		Me.cmbPost1_Actual.Size = New System.Drawing.Size(100, 37)
		Me.cmbPost1_Actual.TabIndex = 32
		'
		'lblRightPost
		'
		Me.lblRightPost.BackColor = System.Drawing.Color.Transparent
		Me.lblRightPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblRightPost.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRightPost.ForeColor = System.Drawing.Color.Black
		Me.lblRightPost.Location = New System.Drawing.Point(37, 162)
		Me.lblRightPost.Margin = New System.Windows.Forms.Padding(0)
		Me.lblRightPost.Name = "lblRightPost"
		Me.lblRightPost.Size = New System.Drawing.Size(45, 18)
		Me.lblRightPost.TabIndex = 30
		Me.lblRightPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.lblRightPost, "Right Post Length - Click to adjust")
		Me.lblRightPost.Visible = False
		'
		'cmbPost2_Actual
		'
		Me.cmbPost2_Actual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbPost2_Actual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPost2_Actual.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPost2_Actual.FormattingEnabled = True
		Me.cmbPost2_Actual.Location = New System.Drawing.Point(221, 80)
		Me.cmbPost2_Actual.Name = "cmbPost2_Actual"
		Me.cmbPost2_Actual.Size = New System.Drawing.Size(100, 37)
		Me.cmbPost2_Actual.TabIndex = 33
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(2, 160)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(32, 20)
		Me.Label1.TabIndex = 31
		Me.Label1.Visible = False
		'
		'lblPost2
		'
		Me.lblPost2.AutoSize = True
		Me.lblPost2.BackColor = System.Drawing.Color.Transparent
		Me.lblPost2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPost2.Location = New System.Drawing.Point(218, 19)
		Me.lblPost2.Name = "lblPost2"
		Me.lblPost2.Size = New System.Drawing.Size(81, 15)
		Me.lblPost2.TabIndex = 28
		Me.lblPost2.Text = "Post 2 (Right)"
		'
		'lblPost1
		'
		Me.lblPost1.AutoSize = True
		Me.lblPost1.BackColor = System.Drawing.Color.Transparent
		Me.lblPost1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPost1.Location = New System.Drawing.Point(112, 19)
		Me.lblPost1.Name = "lblPost1"
		Me.lblPost1.Size = New System.Drawing.Size(72, 15)
		Me.lblPost1.TabIndex = 27
		Me.lblPost1.Text = "Post 1 (Left)"
		'
		'cmbPost1
		'
		Me.cmbPost1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbPost1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPost1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPost1.FormattingEnabled = True
		Me.cmbPost1.Location = New System.Drawing.Point(115, 37)
		Me.cmbPost1.Name = "cmbPost1"
		Me.cmbPost1.Size = New System.Drawing.Size(100, 37)
		Me.cmbPost1.TabIndex = 22
		'
		'btnSubmitPostLengths
		'
		Me.btnSubmitPostLengths.Location = New System.Drawing.Point(135, 135)
		Me.btnSubmitPostLengths.Name = "btnSubmitPostLengths"
		Me.btnSubmitPostLengths.Size = New System.Drawing.Size(178, 29)
		Me.btnSubmitPostLengths.TabIndex = 26
		Me.btnSubmitPostLengths.Text = "Report Post Lengths"
		Me.btnSubmitPostLengths.UseVisualStyleBackColor = True
		'
		'cmbPost2
		'
		Me.cmbPost2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbPost2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPost2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPost2.FormattingEnabled = True
		Me.cmbPost2.Location = New System.Drawing.Point(221, 37)
		Me.cmbPost2.Name = "cmbPost2"
		Me.cmbPost2.Size = New System.Drawing.Size(100, 37)
		Me.cmbPost2.TabIndex = 23
		'
		'tbpColumns
		'
		Me.tbpColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.tbpColumns.Controls.Add(Me.DataGridView2)
		Me.tbpColumns.Controls.Add(Me.lblColumnsTitle)
		Me.tbpColumns.Controls.Add(Me.panBreakAway)
		Me.tbpColumns.Location = New System.Drawing.Point(4, 22)
		Me.tbpColumns.Name = "tbpColumns"
		Me.tbpColumns.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpColumns.Size = New System.Drawing.Size(342, 362)
		Me.tbpColumns.TabIndex = 1
		Me.tbpColumns.Text = "Columns"
		Me.tbpColumns.UseVisualStyleBackColor = True
		'
		'DataGridView2
		'
		Me.DataGridView2.AllowUserToAddRows = False
		Me.DataGridView2.AllowUserToDeleteRows = False
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(353, 35)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.ReadOnly = True
		Me.DataGridView2.Size = New System.Drawing.Size(23, 43)
		Me.DataGridView2.TabIndex = 34
		'
		'lblColumnsTitle
		'
		Me.lblColumnsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblColumnsTitle.ForeColor = System.Drawing.Color.Navy
		Me.lblColumnsTitle.Location = New System.Drawing.Point(12, 12)
		Me.lblColumnsTitle.Name = "lblColumnsTitle"
		Me.lblColumnsTitle.Size = New System.Drawing.Size(316, 20)
		Me.lblColumnsTitle.TabIndex = 30
		'
		'panBreakAway
		'
		Me.panBreakAway.BackColor = System.Drawing.Color.Transparent
		Me.panBreakAway.Controls.Add(Me.btnReportElevations)
		Me.panBreakAway.Controls.Add(Me.nudR)
		Me.panBreakAway.Controls.Add(Me.nudL)
		Me.panBreakAway.Controls.Add(Me.lblNudRUnit)
		Me.panBreakAway.Controls.Add(Me.lblNudLUnit)
		Me.panBreakAway.Controls.Add(Me.lblNudR)
		Me.panBreakAway.Controls.Add(Me.lblNudL)
		Me.panBreakAway.Controls.Add(Me.ShapeContainer1)
		Me.panBreakAway.Enabled = False
		Me.panBreakAway.Location = New System.Drawing.Point(12, 35)
		Me.panBreakAway.Name = "panBreakAway"
		Me.panBreakAway.Size = New System.Drawing.Size(322, 222)
		Me.panBreakAway.TabIndex = 29
		'
		'btnReportElevations
		'
		Me.btnReportElevations.Location = New System.Drawing.Point(36, 155)
		Me.btnReportElevations.Name = "btnReportElevations"
		Me.btnReportElevations.Size = New System.Drawing.Size(230, 23)
		Me.btnReportElevations.TabIndex = 7
		Me.btnReportElevations.Text = "Report Elevations && Foundations"
		Me.btnReportElevations.UseVisualStyleBackColor = True
		'
		'nudR
		'
		Me.nudR.DecimalPlaces = 2
		Me.nudR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudR.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
		Me.nudR.Location = New System.Drawing.Point(161, 101)
		Me.nudR.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
		Me.nudR.Minimum = New Decimal(New Integer() {250, 0, 0, -2147483648})
		Me.nudR.Name = "nudR"
		Me.nudR.Size = New System.Drawing.Size(105, 26)
		Me.nudR.TabIndex = 6
		Me.nudR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudR.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'nudL
		'
		Me.nudL.DecimalPlaces = 2
		Me.nudL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudL.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
		Me.nudL.Location = New System.Drawing.Point(6, 101)
		Me.nudL.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
		Me.nudL.Minimum = New Decimal(New Integer() {250, 0, 0, -2147483648})
		Me.nudL.Name = "nudL"
		Me.nudL.Size = New System.Drawing.Size(106, 26)
		Me.nudL.TabIndex = 5
		Me.nudL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudL.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
		'
		'lblNudRUnit
		'
		Me.lblNudRUnit.AutoSize = True
		Me.lblNudRUnit.Location = New System.Drawing.Point(272, 109)
		Me.lblNudRUnit.Name = "lblNudRUnit"
		Me.lblNudRUnit.Size = New System.Drawing.Size(21, 13)
		Me.lblNudRUnit.TabIndex = 4
		Me.lblNudRUnit.Text = "IN."
		'
		'lblNudLUnit
		'
		Me.lblNudLUnit.AutoSize = True
		Me.lblNudLUnit.Location = New System.Drawing.Point(118, 109)
		Me.lblNudLUnit.Name = "lblNudLUnit"
		Me.lblNudLUnit.Size = New System.Drawing.Size(21, 13)
		Me.lblNudLUnit.TabIndex = 3
		Me.lblNudLUnit.Text = "IN."
		'
		'lblNudR
		'
		Me.lblNudR.AutoSize = True
		Me.lblNudR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNudR.Location = New System.Drawing.Point(211, 70)
		Me.lblNudR.Name = "lblNudR"
		Me.lblNudR.Size = New System.Drawing.Size(21, 20)
		Me.lblNudR.TabIndex = 2
		Me.lblNudR.Text = "R"
		'
		'lblNudL
		'
		Me.lblNudL.AutoSize = True
		Me.lblNudL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNudL.Location = New System.Drawing.Point(67, 70)
		Me.lblNudL.Name = "lblNudL"
		Me.lblNudL.Size = New System.Drawing.Size(18, 20)
		Me.lblNudL.TabIndex = 1
		Me.lblNudL.Text = "L"
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
		Me.ShapeContainer1.Size = New System.Drawing.Size(322, 222)
		Me.ShapeContainer1.TabIndex = 0
		Me.ShapeContainer1.TabStop = False
		'
		'LineShape2
		'
		Me.LineShape2.Name = "LineShape2"
		Me.LineShape2.X1 = 149
		Me.LineShape2.X2 = 149
		Me.LineShape2.Y1 = 70
		Me.LineShape2.Y2 = 131
		'
		'LineShape1
		'
		Me.LineShape1.Name = "LineShape1"
		Me.LineShape1.X1 = 7
		Me.LineShape1.X2 = 293
		Me.LineShape1.Y1 = 93
		Me.LineShape1.Y2 = 93
		'
		'tbpSlipBases
		'
		Me.tbpSlipBases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.tbpSlipBases.Controls.Add(Me.DataGridView3)
		Me.tbpSlipBases.Controls.Add(Me.lblSlipBaseTitle)
		Me.tbpSlipBases.Controls.Add(Me.panSlipBases)
		Me.tbpSlipBases.Location = New System.Drawing.Point(4, 22)
		Me.tbpSlipBases.Name = "tbpSlipBases"
		Me.tbpSlipBases.Size = New System.Drawing.Size(342, 362)
		Me.tbpSlipBases.TabIndex = 2
		Me.tbpSlipBases.Text = "Slip Base"
		Me.tbpSlipBases.UseVisualStyleBackColor = True
		'
		'DataGridView3
		'
		Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView3.Location = New System.Drawing.Point(12, 264)
		Me.DataGridView3.Name = "DataGridView3"
		Me.DataGridView3.Size = New System.Drawing.Size(312, 56)
		Me.DataGridView3.TabIndex = 47
		'
		'lblSlipBaseTitle
		'
		Me.lblSlipBaseTitle.AutoSize = True
		Me.lblSlipBaseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSlipBaseTitle.ForeColor = System.Drawing.Color.Navy
		Me.lblSlipBaseTitle.Location = New System.Drawing.Point(12, 12)
		Me.lblSlipBaseTitle.Name = "lblSlipBaseTitle"
		Me.lblSlipBaseTitle.Size = New System.Drawing.Size(290, 20)
		Me.lblSlipBaseTitle.TabIndex = 35
		Me.lblSlipBaseTitle.Text = "Enter Number of Slip Base Foundations"
		'
		'panSlipBases
		'
		Me.panSlipBases.Controls.Add(Me.btnSubmitSlipBaseFoundation)
		Me.panSlipBases.Controls.Add(Me.nudSlipBaseFoundation)
		Me.panSlipBases.Enabled = False
		Me.panSlipBases.Location = New System.Drawing.Point(12, 35)
		Me.panSlipBases.Name = "panSlipBases"
		Me.panSlipBases.Size = New System.Drawing.Size(322, 144)
		Me.panSlipBases.TabIndex = 31
		'
		'btnSubmitSlipBaseFoundation
		'
		Me.btnSubmitSlipBaseFoundation.Location = New System.Drawing.Point(65, 99)
		Me.btnSubmitSlipBaseFoundation.Name = "btnSubmitSlipBaseFoundation"
		Me.btnSubmitSlipBaseFoundation.Size = New System.Drawing.Size(178, 29)
		Me.btnSubmitSlipBaseFoundation.TabIndex = 32
		Me.btnSubmitSlipBaseFoundation.Text = "Report Slip Base Foundations"
		Me.btnSubmitSlipBaseFoundation.UseVisualStyleBackColor = True
		'
		'nudSlipBaseFoundation
		'
		Me.nudSlipBaseFoundation.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudSlipBaseFoundation.Location = New System.Drawing.Point(95, 25)
		Me.nudSlipBaseFoundation.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
		Me.nudSlipBaseFoundation.Name = "nudSlipBaseFoundation"
		Me.nudSlipBaseFoundation.Size = New System.Drawing.Size(118, 62)
		Me.nudSlipBaseFoundation.TabIndex = 7
		Me.nudSlipBaseFoundation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tbpNPI
		'
		Me.tbpNPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.tbpNPI.Controls.Add(Me.dgvNPIdataSync)
		Me.tbpNPI.Controls.Add(Me.lstNPI)
		Me.tbpNPI.Controls.Add(Me.lblNPI)
		Me.tbpNPI.Location = New System.Drawing.Point(4, 22)
		Me.tbpNPI.Name = "tbpNPI"
		Me.tbpNPI.Size = New System.Drawing.Size(342, 362)
		Me.tbpNPI.TabIndex = 3
		Me.tbpNPI.Text = "NPI"
		Me.tbpNPI.UseVisualStyleBackColor = True
		'
		'dgvNPIdataSync
		'
		Me.dgvNPIdataSync.AllowUserToAddRows = False
		Me.dgvNPIdataSync.AllowUserToDeleteRows = False
		Me.dgvNPIdataSync.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dgvNPIdataSync.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvNPIdataSync.Location = New System.Drawing.Point(7, 158)
		Me.dgvNPIdataSync.Name = "dgvNPIdataSync"
		Me.dgvNPIdataSync.ReadOnly = True
		Me.dgvNPIdataSync.RowHeadersVisible = False
		Me.dgvNPIdataSync.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvNPIdataSync.Size = New System.Drawing.Size(332, 150)
		Me.dgvNPIdataSync.TabIndex = 37
		Me.dgvNPIdataSync.Visible = False
		'
		'lstNPI
		'
		Me.lstNPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstNPI.FormattingEnabled = True
		Me.lstNPI.Location = New System.Drawing.Point(7, 50)
		Me.lstNPI.Name = "lstNPI"
		Me.lstNPI.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
		Me.lstNPI.Size = New System.Drawing.Size(332, 95)
		Me.lstNPI.TabIndex = 36
		'
		'lblNPI
		'
		Me.lblNPI.AutoSize = True
		Me.lblNPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNPI.ForeColor = System.Drawing.Color.Navy
		Me.lblNPI.Location = New System.Drawing.Point(31, 14)
		Me.lblNPI.Name = "lblNPI"
		Me.lblNPI.Size = New System.Drawing.Size(270, 20)
		Me.lblNPI.TabIndex = 34
		Me.lblNPI.Text = "Non Pay Items Listing @ this location"
		'
		'tbpSignDetails
		'
		Me.tbpSignDetails.BackColor = System.Drawing.Color.Transparent
		Me.tbpSignDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.tbpSignDetails.Controls.Add(Me.grpSignDetails)
		Me.tbpSignDetails.Location = New System.Drawing.Point(4, 22)
		Me.tbpSignDetails.Name = "tbpSignDetails"
		Me.tbpSignDetails.Size = New System.Drawing.Size(342, 362)
		Me.tbpSignDetails.TabIndex = 4
		Me.tbpSignDetails.Text = "Sign"
		Me.tbpSignDetails.UseVisualStyleBackColor = True
		'
		'grpSignDetails
		'
		Me.grpSignDetails.BackColor = System.Drawing.Color.Transparent
		Me.grpSignDetails.Controls.Add(Me.SignHeightTextBox)
		Me.grpSignDetails.Controls.Add(Me.SignWidthTextBox)
		Me.grpSignDetails.Controls.Add(lblXforBY)
		Me.grpSignDetails.Controls.Add(SignCodeLabel)
		Me.grpSignDetails.Controls.Add(Me.picImagePreview)
		Me.grpSignDetails.Controls.Add(SignHeightLabel)
		Me.grpSignDetails.Controls.Add(Me.SignCodeTextBox)
		Me.grpSignDetails.Controls.Add(SignWidthLabel)
		Me.grpSignDetails.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpSignDetails.Location = New System.Drawing.Point(35, 28)
		Me.grpSignDetails.Name = "grpSignDetails"
		Me.grpSignDetails.Size = New System.Drawing.Size(319, 246)
		Me.grpSignDetails.TabIndex = 20
		Me.grpSignDetails.TabStop = False
		Me.grpSignDetails.Text = "Sign Details:"
		'
		'SignHeightTextBox
		'
		Me.SignHeightTextBox.BackColor = System.Drawing.Color.White
		Me.SignHeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "signHeight", True))
		Me.SignHeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SignHeightTextBox.Location = New System.Drawing.Point(187, 182)
		Me.SignHeightTextBox.Name = "SignHeightTextBox"
		Me.SignHeightTextBox.ReadOnly = True
		Me.SignHeightTextBox.Size = New System.Drawing.Size(96, 26)
		Me.SignHeightTextBox.TabIndex = 20
		Me.SignHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'SignWidthTextBox
		'
		Me.SignWidthTextBox.BackColor = System.Drawing.Color.White
		Me.SignWidthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "signWidth", True))
		Me.SignWidthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SignWidthTextBox.Location = New System.Drawing.Point(38, 182)
		Me.SignWidthTextBox.Name = "SignWidthTextBox"
		Me.SignWidthTextBox.ReadOnly = True
		Me.SignWidthTextBox.Size = New System.Drawing.Size(96, 26)
		Me.SignWidthTextBox.TabIndex = 19
		Me.SignWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'picImagePreview
		'
		Me.picImagePreview.BackColor = System.Drawing.Color.White
		Me.picImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picImagePreview.Location = New System.Drawing.Point(38, 19)
		Me.picImagePreview.Name = "picImagePreview"
		Me.picImagePreview.Size = New System.Drawing.Size(245, 141)
		Me.picImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.picImagePreview.TabIndex = 18
		Me.picImagePreview.TabStop = False
		'
		'SignCodeTextBox
		'
		Me.SignCodeTextBox.BackColor = System.Drawing.Color.White
		Me.SignCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.SignCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "signCode", True))
		Me.SignCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SignCodeTextBox.Location = New System.Drawing.Point(104, 214)
		Me.SignCodeTextBox.Name = "SignCodeTextBox"
		Me.SignCodeTextBox.ReadOnly = True
		Me.SignCodeTextBox.Size = New System.Drawing.Size(179, 26)
		Me.SignCodeTextBox.TabIndex = 11
		Me.SignCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tbpGuardRail
		'
		Me.tbpGuardRail.AutoScroll = True
		Me.tbpGuardRail.Controls.Add(Me.lblGRrunNotes)
		Me.tbpGuardRail.Controls.Add(Me.lblGRrunQty)
		Me.tbpGuardRail.Controls.Add(Me.lblGRrunID)
		Me.tbpGuardRail.Controls.Add(Me.lblGuardRailRunTotal)
		Me.tbpGuardRail.Controls.Add(Me.btnGrSave)
		Me.tbpGuardRail.Controls.Add(Me.txtRunNotes)
		Me.tbpGuardRail.Controls.Add(Me.txtRunID)
		Me.tbpGuardRail.Controls.Add(Me.btnAddGrRun)
		Me.tbpGuardRail.Controls.Add(Me.txtRunQty)
		Me.tbpGuardRail.Controls.Add(Me.dgvGuardRailProductions)
		Me.tbpGuardRail.Location = New System.Drawing.Point(4, 22)
		Me.tbpGuardRail.Name = "tbpGuardRail"
		Me.tbpGuardRail.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpGuardRail.Size = New System.Drawing.Size(342, 362)
		Me.tbpGuardRail.TabIndex = 6
		Me.tbpGuardRail.Text = "Guard Rail"
		Me.tbpGuardRail.UseVisualStyleBackColor = True
		'
		'lblGRrunNotes
		'
		Me.lblGRrunNotes.AutoSize = True
		Me.lblGRrunNotes.BackColor = System.Drawing.Color.Transparent
		Me.lblGRrunNotes.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGRrunNotes.ForeColor = System.Drawing.Color.Black
		Me.lblGRrunNotes.Location = New System.Drawing.Point(36, 254)
		Me.lblGRrunNotes.Margin = New System.Windows.Forms.Padding(0)
		Me.lblGRrunNotes.Name = "lblGRrunNotes"
		Me.lblGRrunNotes.Size = New System.Drawing.Size(81, 12)
		Me.lblGRrunNotes.TabIndex = 43
		Me.lblGRrunNotes.Text = "Qty Completed"
		'
		'lblGRrunQty
		'
		Me.lblGRrunQty.AutoSize = True
		Me.lblGRrunQty.BackColor = System.Drawing.Color.Transparent
		Me.lblGRrunQty.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGRrunQty.ForeColor = System.Drawing.Color.Black
		Me.lblGRrunQty.Location = New System.Drawing.Point(36, 228)
		Me.lblGRrunQty.Margin = New System.Windows.Forms.Padding(0)
		Me.lblGRrunQty.Name = "lblGRrunQty"
		Me.lblGRrunQty.Size = New System.Drawing.Size(81, 12)
		Me.lblGRrunQty.TabIndex = 42
		Me.lblGRrunQty.Text = "Qty Completed"
		'
		'lblGRrunID
		'
		Me.lblGRrunID.AutoSize = True
		Me.lblGRrunID.BackColor = System.Drawing.Color.Transparent
		Me.lblGRrunID.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGRrunID.ForeColor = System.Drawing.Color.Black
		Me.lblGRrunID.Location = New System.Drawing.Point(77, 202)
		Me.lblGRrunID.Margin = New System.Windows.Forms.Padding(0)
		Me.lblGRrunID.Name = "lblGRrunID"
		Me.lblGRrunID.Size = New System.Drawing.Size(40, 12)
		Me.lblGRrunID.TabIndex = 41
		Me.lblGRrunID.Text = "Run ID"
		'
		'lblGuardRailRunTotal
		'
		Me.lblGuardRailRunTotal.BackColor = System.Drawing.Color.Transparent
		Me.lblGuardRailRunTotal.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGuardRailRunTotal.ForeColor = System.Drawing.Color.Black
		Me.lblGuardRailRunTotal.Location = New System.Drawing.Point(5, 145)
		Me.lblGuardRailRunTotal.Margin = New System.Windows.Forms.Padding(0)
		Me.lblGuardRailRunTotal.Name = "lblGuardRailRunTotal"
		Me.lblGuardRailRunTotal.Size = New System.Drawing.Size(246, 26)
		Me.lblGuardRailRunTotal.TabIndex = 40
		Me.lblGuardRailRunTotal.Text = "Run Total"
		'
		'btnGrSave
		'
		Me.btnGrSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGrSave.ForeColor = System.Drawing.Color.Black
		Me.btnGrSave.Location = New System.Drawing.Point(252, 145)
		Me.btnGrSave.Margin = New System.Windows.Forms.Padding(0)
		Me.btnGrSave.Name = "btnGrSave"
		Me.btnGrSave.Size = New System.Drawing.Size(84, 26)
		Me.btnGrSave.TabIndex = 4
		Me.btnGrSave.Text = "Save"
		Me.ToolTip1.SetToolTip(Me.btnGrSave, "Save")
		Me.btnGrSave.UseVisualStyleBackColor = True
		'
		'txtRunNotes
		'
		Me.txtRunNotes.Location = New System.Drawing.Point(120, 250)
		Me.txtRunNotes.Multiline = True
		Me.txtRunNotes.Name = "txtRunNotes"
		Me.txtRunNotes.Size = New System.Drawing.Size(151, 57)
		Me.txtRunNotes.TabIndex = 2
		'
		'txtRunID
		'
		Me.txtRunID.Location = New System.Drawing.Point(120, 198)
		Me.txtRunID.Name = "txtRunID"
		Me.txtRunID.Size = New System.Drawing.Size(110, 20)
		Me.txtRunID.TabIndex = 0
		'
		'btnAddGrRun
		'
		Me.btnAddGrRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddGrRun.ForeColor = System.Drawing.Color.Black
		Me.btnAddGrRun.Location = New System.Drawing.Point(120, 310)
		Me.btnAddGrRun.Margin = New System.Windows.Forms.Padding(0)
		Me.btnAddGrRun.Name = "btnAddGrRun"
		Me.btnAddGrRun.Size = New System.Drawing.Size(84, 26)
		Me.btnAddGrRun.TabIndex = 3
		Me.btnAddGrRun.Text = "Add"
		Me.ToolTip1.SetToolTip(Me.btnAddGrRun, "Add")
		Me.btnAddGrRun.UseVisualStyleBackColor = True
		'
		'txtRunQty
		'
		Me.txtRunQty.Location = New System.Drawing.Point(120, 224)
		Me.txtRunQty.Name = "txtRunQty"
		Me.txtRunQty.Size = New System.Drawing.Size(110, 20)
		Me.txtRunQty.TabIndex = 1
		'
		'dgvGuardRailProductions
		'
		Me.dgvGuardRailProductions.AllowUserToAddRows = False
		Me.dgvGuardRailProductions.AutoGenerateColumns = False
		Me.dgvGuardRailProductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvGuardRailProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvGuardRailProductions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.JobNumDataGridViewTextBoxColumn1, Me.SiteDataGridViewTextBoxColumn, Me.RunIDDataGridViewTextBoxColumn, Me.GrQtyDataGridViewTextBoxColumn, Me.RunNotesDataGridViewTextBoxColumn, Me.RunDateDataGridViewTextBoxColumn, Me.ForemanDataGridViewTextBoxColumn})
		Me.dgvGuardRailProductions.DataSource = Me.TblGuardRailDailyProductionsBindingSource
		Me.dgvGuardRailProductions.Location = New System.Drawing.Point(7, 6)
		Me.dgvGuardRailProductions.Name = "dgvGuardRailProductions"
		Me.dgvGuardRailProductions.RowHeadersVisible = False
		Me.dgvGuardRailProductions.RowHeadersWidth = 30
		Me.dgvGuardRailProductions.Size = New System.Drawing.Size(329, 136)
		Me.dgvGuardRailProductions.TabIndex = 0
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		Me.IDDataGridViewTextBoxColumn.Visible = False
		'
		'JobNumDataGridViewTextBoxColumn1
		'
		Me.JobNumDataGridViewTextBoxColumn1.DataPropertyName = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn1.HeaderText = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn1.Name = "JobNumDataGridViewTextBoxColumn1"
		Me.JobNumDataGridViewTextBoxColumn1.Visible = False
		'
		'SiteDataGridViewTextBoxColumn
		'
		Me.SiteDataGridViewTextBoxColumn.DataPropertyName = "site"
		Me.SiteDataGridViewTextBoxColumn.HeaderText = "site"
		Me.SiteDataGridViewTextBoxColumn.Name = "SiteDataGridViewTextBoxColumn"
		Me.SiteDataGridViewTextBoxColumn.Visible = False
		'
		'RunIDDataGridViewTextBoxColumn
		'
		Me.RunIDDataGridViewTextBoxColumn.DataPropertyName = "runID"
		Me.RunIDDataGridViewTextBoxColumn.HeaderText = "Run ID"
		Me.RunIDDataGridViewTextBoxColumn.Name = "RunIDDataGridViewTextBoxColumn"
		Me.RunIDDataGridViewTextBoxColumn.ToolTipText = "Run Identifier"
		'
		'GrQtyDataGridViewTextBoxColumn
		'
		Me.GrQtyDataGridViewTextBoxColumn.DataPropertyName = "grQty"
		Me.GrQtyDataGridViewTextBoxColumn.HeaderText = "Qty"
		Me.GrQtyDataGridViewTextBoxColumn.Name = "GrQtyDataGridViewTextBoxColumn"
		Me.GrQtyDataGridViewTextBoxColumn.ToolTipText = "Quantity completed this run"
		'
		'RunNotesDataGridViewTextBoxColumn
		'
		Me.RunNotesDataGridViewTextBoxColumn.DataPropertyName = "runNotes"
		Me.RunNotesDataGridViewTextBoxColumn.HeaderText = "Notes"
		Me.RunNotesDataGridViewTextBoxColumn.Name = "RunNotesDataGridViewTextBoxColumn"
		Me.RunNotesDataGridViewTextBoxColumn.ToolTipText = "Comments associated with this run."
		'
		'RunDateDataGridViewTextBoxColumn
		'
		Me.RunDateDataGridViewTextBoxColumn.DataPropertyName = "runDate"
		Me.RunDateDataGridViewTextBoxColumn.HeaderText = "Date"
		Me.RunDateDataGridViewTextBoxColumn.Name = "RunDateDataGridViewTextBoxColumn"
		Me.RunDateDataGridViewTextBoxColumn.ToolTipText = "Date completed"
		'
		'ForemanDataGridViewTextBoxColumn
		'
		Me.ForemanDataGridViewTextBoxColumn.DataPropertyName = "foreman"
		Me.ForemanDataGridViewTextBoxColumn.HeaderText = "foreman"
		Me.ForemanDataGridViewTextBoxColumn.Name = "ForemanDataGridViewTextBoxColumn"
		Me.ForemanDataGridViewTextBoxColumn.Visible = False
		'
		'TblGuardRailDailyProductionsBindingSource
		'
		Me.TblGuardRailDailyProductionsBindingSource.DataMember = "tblGuardRailDailyProductions"
		Me.TblGuardRailDailyProductionsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'tbpCurrentList
		'
		Me.tbpCurrentList.Controls.Add(Me.btnViewProduction)
		Me.tbpCurrentList.Controls.Add(Me.DataGridView1)
		Me.tbpCurrentList.Location = New System.Drawing.Point(4, 22)
		Me.tbpCurrentList.Margin = New System.Windows.Forms.Padding(0)
		Me.tbpCurrentList.Name = "tbpCurrentList"
		Me.tbpCurrentList.Size = New System.Drawing.Size(342, 362)
		Me.tbpCurrentList.TabIndex = 5
		Me.tbpCurrentList.Text = "Today"
		Me.tbpCurrentList.UseVisualStyleBackColor = True
		'
		'btnViewProduction
		'
		Me.btnViewProduction.Location = New System.Drawing.Point(52, 305)
		Me.btnViewProduction.Name = "btnViewProduction"
		Me.btnViewProduction.Size = New System.Drawing.Size(239, 23)
		Me.btnViewProduction.TabIndex = 36
		Me.btnViewProduction.Text = "View Today's Production"
		Me.btnViewProduction.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(-2, 5)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.Size = New System.Drawing.Size(341, 294)
		Me.DataGridView1.TabIndex = 33
		Me.ToolTip1.SetToolTip(Me.DataGridView1, "XML - DataSync")
		'
		'lblDateAndTime
		'
		Me.lblDateAndTime.BackColor = System.Drawing.Color.Transparent
		Me.lblDateAndTime.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDateAndTime.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblDateAndTime.Location = New System.Drawing.Point(3, 18)
		Me.lblDateAndTime.Name = "lblDateAndTime"
		Me.lblDateAndTime.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
		Me.lblDateAndTime.Size = New System.Drawing.Size(348, 32)
		Me.lblDateAndTime.TabIndex = 44
		Me.lblDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'panPayItemsMain
		'
		Me.panPayItemsMain.BackColor = System.Drawing.Color.Transparent
		Me.panPayItemsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.panPayItemsMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panPayItemsMain.Controls.Add(Me.pnlNavigationSubmit)
		Me.panPayItemsMain.Controls.Add(Me.pnlItemDetails)
		Me.panPayItemsMain.Location = New System.Drawing.Point(4, 6)
		Me.panPayItemsMain.Margin = New System.Windows.Forms.Padding(0)
		Me.panPayItemsMain.Name = "panPayItemsMain"
		Me.panPayItemsMain.Size = New System.Drawing.Size(344, 446)
		Me.panPayItemsMain.TabIndex = 34
		'
		'pnlNavigationSubmit
		'
		Me.pnlNavigationSubmit.Controls.Add(Me.LinkLabel2)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblSmallPayItemDescription)
		Me.pnlNavigationSubmit.Controls.Add(Me.tlpNav)
		Me.pnlNavigationSubmit.Controls.Add(Me.CQtyLabel1)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblDPQty)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblNav)
		Me.pnlNavigationSubmit.Controls.Add(Me.btnQtyValid)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblPlanQty)
		Me.pnlNavigationSubmit.Controls.Add(Me.btnModifyQty)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblInstalledQty)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblSubmit)
		Me.pnlNavigationSubmit.Controls.Add(Me.UnitLabel1)
		Me.pnlNavigationSubmit.Controls.Add(Me.btnSelect)
		Me.pnlNavigationSubmit.Controls.Add(Me.lblModAuto)
		Me.pnlNavigationSubmit.Controls.Add(Me.ShapeContainer3)
		Me.pnlNavigationSubmit.Location = New System.Drawing.Point(3, 209)
		Me.pnlNavigationSubmit.Name = "pnlNavigationSubmit"
		Me.pnlNavigationSubmit.Size = New System.Drawing.Size(338, 235)
		Me.pnlNavigationSubmit.TabIndex = 46
		'
		'LinkLabel2
		'
		Me.LinkLabel2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel2.Location = New System.Drawing.Point(266, 45)
		Me.LinkLabel2.Name = "LinkLabel2"
		Me.LinkLabel2.Size = New System.Drawing.Size(66, 12)
		Me.LinkLabel2.TabIndex = 49
		Me.LinkLabel2.TabStop = True
		Me.LinkLabel2.Text = "Reset"
		Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.ToolTip1.SetToolTip(Me.LinkLabel2, "Reset this Item to Original Value.")
		'
		'lblSmallPayItemDescription
		'
		Me.lblSmallPayItemDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblSmallPayItemDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "description", True))
		Me.lblSmallPayItemDescription.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSmallPayItemDescription.ForeColor = System.Drawing.Color.Red
		Me.lblSmallPayItemDescription.Location = New System.Drawing.Point(5, 62)
		Me.lblSmallPayItemDescription.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lblSmallPayItemDescription.Name = "lblSmallPayItemDescription"
		Me.lblSmallPayItemDescription.Size = New System.Drawing.Size(331, 14)
		Me.lblSmallPayItemDescription.TabIndex = 47
		Me.lblSmallPayItemDescription.Text = "Pay Item Description"
		Me.lblSmallPayItemDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'tlpNav
		'
		Me.tlpNav.BackColor = System.Drawing.Color.Transparent
		Me.tlpNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.tlpNav.ColumnCount = 4
		Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5122!))
		Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.4878!))
		Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.4878!))
		Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.5122!))
		Me.tlpNav.Controls.Add(Me.lblLast, 3, 1)
		Me.tlpNav.Controls.Add(Me.lblNext, 2, 1)
		Me.tlpNav.Controls.Add(Me.btnFirst, 0, 0)
		Me.tlpNav.Controls.Add(Me.lblPrevious, 1, 1)
		Me.tlpNav.Controls.Add(Me.btnNext, 2, 0)
		Me.tlpNav.Controls.Add(Me.btnPrev, 1, 0)
		Me.tlpNav.Controls.Add(Me.lblFirst, 0, 1)
		Me.tlpNav.Controls.Add(Me.btnLast, 3, 0)
		Me.tlpNav.Location = New System.Drawing.Point(7, 104)
		Me.tlpNav.Margin = New System.Windows.Forms.Padding(0)
		Me.tlpNav.Name = "tlpNav"
		Me.tlpNav.RowCount = 2
		Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.7619!))
		Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.23809!))
		Me.tlpNav.Size = New System.Drawing.Size(202, 82)
		Me.tlpNav.TabIndex = 41
		'
		'lblLast
		'
		Me.lblLast.AutoSize = True
		Me.lblLast.BackColor = System.Drawing.Color.Transparent
		Me.lblLast.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblLast.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLast.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.lblLast.Location = New System.Drawing.Point(161, 65)
		Me.lblLast.Margin = New System.Windows.Forms.Padding(0)
		Me.lblLast.Name = "lblLast"
		Me.lblLast.Size = New System.Drawing.Size(41, 17)
		Me.lblLast.TabIndex = 36
		Me.lblLast.Text = "Last"
		Me.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblNext
		'
		Me.lblNext.AutoSize = True
		Me.lblNext.BackColor = System.Drawing.Color.Transparent
		Me.lblNext.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblNext.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNext.ForeColor = System.Drawing.Color.Black
		Me.lblNext.Location = New System.Drawing.Point(100, 65)
		Me.lblNext.Margin = New System.Windows.Forms.Padding(0)
		Me.lblNext.Name = "lblNext"
		Me.lblNext.Size = New System.Drawing.Size(61, 17)
		Me.lblNext.TabIndex = 38
		Me.lblNext.Text = "Next"
		Me.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnFirst
		'
		Me.btnFirst.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnFirst.Font = New System.Drawing.Font("Wingdings 3", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnFirst.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnFirst.Location = New System.Drawing.Point(2, 12)
		Me.btnFirst.Margin = New System.Windows.Forms.Padding(2, 12, 6, 12)
		Me.btnFirst.Name = "btnFirst"
		Me.btnFirst.Size = New System.Drawing.Size(31, 41)
		Me.btnFirst.TabIndex = 27
		Me.btnFirst.Text = "+"
		Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ToolTip1.SetToolTip(Me.btnFirst, "First")
		Me.btnFirst.UseVisualStyleBackColor = True
		'
		'lblPrevious
		'
		Me.lblPrevious.AutoSize = True
		Me.lblPrevious.BackColor = System.Drawing.Color.Transparent
		Me.lblPrevious.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblPrevious.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrevious.ForeColor = System.Drawing.Color.Black
		Me.lblPrevious.Location = New System.Drawing.Point(39, 65)
		Me.lblPrevious.Margin = New System.Windows.Forms.Padding(0)
		Me.lblPrevious.Name = "lblPrevious"
		Me.lblPrevious.Size = New System.Drawing.Size(61, 17)
		Me.lblPrevious.TabIndex = 37
		Me.lblPrevious.Text = "Previous"
		Me.lblPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnNext
		'
		Me.btnNext.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnNext.Font = New System.Drawing.Font("Wingdings", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnNext.ForeColor = System.Drawing.Color.Black
		Me.btnNext.Location = New System.Drawing.Point(102, 4)
		Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 4, 8, 4)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(51, 57)
		Me.btnNext.TabIndex = 19
		Me.btnNext.Text = "ò"
		Me.ToolTip1.SetToolTip(Me.btnNext, "Next")
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnPrev.Font = New System.Drawing.Font("Wingdings", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnPrev.ForeColor = System.Drawing.Color.DarkOliveGreen
		Me.btnPrev.Location = New System.Drawing.Point(47, 4)
		Me.btnPrev.Margin = New System.Windows.Forms.Padding(8, 4, 2, 4)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(51, 57)
		Me.btnPrev.TabIndex = 26
		Me.btnPrev.Text = "ñ"
		Me.ToolTip1.SetToolTip(Me.btnPrev, "Previous")
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'lblFirst
		'
		Me.lblFirst.AutoSize = True
		Me.lblFirst.BackColor = System.Drawing.Color.Transparent
		Me.lblFirst.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblFirst.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFirst.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.lblFirst.Location = New System.Drawing.Point(0, 65)
		Me.lblFirst.Margin = New System.Windows.Forms.Padding(0)
		Me.lblFirst.Name = "lblFirst"
		Me.lblFirst.Size = New System.Drawing.Size(39, 17)
		Me.lblFirst.TabIndex = 35
		Me.lblFirst.Text = "First"
		Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnLast
		'
		Me.btnLast.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnLast.Font = New System.Drawing.Font("Wingdings 3", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnLast.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnLast.Location = New System.Drawing.Point(167, 12)
		Me.btnLast.Margin = New System.Windows.Forms.Padding(6, 12, 4, 12)
		Me.btnLast.Name = "btnLast"
		Me.btnLast.Size = New System.Drawing.Size(31, 41)
		Me.btnLast.TabIndex = 28
		Me.btnLast.Text = ","
		Me.ToolTip1.SetToolTip(Me.btnLast, "Last")
		Me.btnLast.UseVisualStyleBackColor = True
		'
		'CQtyLabel1
		'
		Me.CQtyLabel1.BackColor = System.Drawing.Color.Transparent
		Me.CQtyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CQtyLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "cQty", True))
		Me.CQtyLabel1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CQtyLabel1.ForeColor = System.Drawing.Color.Black
		Me.CQtyLabel1.Location = New System.Drawing.Point(5, 2)
		Me.CQtyLabel1.Margin = New System.Windows.Forms.Padding(0)
		Me.CQtyLabel1.Name = "CQtyLabel1"
		Me.CQtyLabel1.Size = New System.Drawing.Size(122, 43)
		Me.CQtyLabel1.TabIndex = 9
		Me.CQtyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.CQtyLabel1, "Plan Quantity")
		'
		'lblDPQty
		'
		Me.lblDPQty.BackColor = System.Drawing.Color.Transparent
		Me.lblDPQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDPQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "dpQty", True))
		Me.lblDPQty.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDPQty.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblDPQty.Location = New System.Drawing.Point(185, 2)
		Me.lblDPQty.Margin = New System.Windows.Forms.Padding(0)
		Me.lblDPQty.Name = "lblDPQty"
		Me.lblDPQty.Size = New System.Drawing.Size(149, 43)
		Me.lblDPQty.TabIndex = 22
		Me.lblDPQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ToolTip1.SetToolTip(Me.lblDPQty, "Actual Installed Quantity")
		'
		'lblNav
		'
		Me.lblNav.BackColor = System.Drawing.Color.Transparent
		Me.lblNav.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNav.ForeColor = System.Drawing.Color.Black
		Me.lblNav.Location = New System.Drawing.Point(4, 88)
		Me.lblNav.Margin = New System.Windows.Forms.Padding(0)
		Me.lblNav.Name = "lblNav"
		Me.lblNav.Size = New System.Drawing.Size(205, 16)
		Me.lblNav.TabIndex = 43
		Me.lblNav.Text = "NAVIGATION"
		Me.lblNav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnQtyValid
		'
		Me.btnQtyValid.BackColor = System.Drawing.Color.Transparent
		Me.btnQtyValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnQtyValid.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnQtyValid.ForeColor = System.Drawing.Color.Red
		Me.btnQtyValid.Location = New System.Drawing.Point(256, 84)
		Me.btnQtyValid.Margin = New System.Windows.Forms.Padding(0)
		Me.btnQtyValid.Name = "btnQtyValid"
		Me.btnQtyValid.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
		Me.btnQtyValid.Size = New System.Drawing.Size(75, 39)
		Me.btnQtyValid.TabIndex = 42
		Me.btnQtyValid.Text = "AUTO"
		Me.ToolTip1.SetToolTip(Me.btnQtyValid, "Click to Auto-Fill Qty.")
		Me.btnQtyValid.UseVisualStyleBackColor = False
		'
		'lblPlanQty
		'
		Me.lblPlanQty.BackColor = System.Drawing.Color.Transparent
		Me.lblPlanQty.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlanQty.ForeColor = System.Drawing.Color.Black
		Me.lblPlanQty.Location = New System.Drawing.Point(3, 45)
		Me.lblPlanQty.Margin = New System.Windows.Forms.Padding(0)
		Me.lblPlanQty.Name = "lblPlanQty"
		Me.lblPlanQty.Size = New System.Drawing.Size(110, 12)
		Me.lblPlanQty.TabIndex = 39
		Me.lblPlanQty.Text = "Plan Qty"
		'
		'btnModifyQty
		'
		Me.btnModifyQty.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModifyQty.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnModifyQty.Location = New System.Drawing.Point(211, 84)
		Me.btnModifyQty.Margin = New System.Windows.Forms.Padding(0)
		Me.btnModifyQty.Name = "btnModifyQty"
		Me.btnModifyQty.Size = New System.Drawing.Size(45, 39)
		Me.btnModifyQty.TabIndex = 23
		Me.btnModifyQty.Text = "+/-"
		Me.ToolTip1.SetToolTip(Me.btnModifyQty, "Click to Modify Qty.")
		Me.btnModifyQty.UseVisualStyleBackColor = True
		'
		'lblInstalledQty
		'
		Me.lblInstalledQty.BackColor = System.Drawing.Color.Transparent
		Me.lblInstalledQty.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInstalledQty.ForeColor = System.Drawing.Color.Black
		Me.lblInstalledQty.Location = New System.Drawing.Point(183, 45)
		Me.lblInstalledQty.Margin = New System.Windows.Forms.Padding(0)
		Me.lblInstalledQty.Name = "lblInstalledQty"
		Me.lblInstalledQty.Size = New System.Drawing.Size(81, 12)
		Me.lblInstalledQty.TabIndex = 38
		Me.lblInstalledQty.Text = "Installed Qty"
		'
		'lblSubmit
		'
		Me.lblSubmit.BackColor = System.Drawing.Color.Transparent
		Me.lblSubmit.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubmit.ForeColor = System.Drawing.Color.Black
		Me.lblSubmit.Location = New System.Drawing.Point(238, 183)
		Me.lblSubmit.Margin = New System.Windows.Forms.Padding(1)
		Me.lblSubmit.Name = "lblSubmit"
		Me.lblSubmit.Size = New System.Drawing.Size(93, 12)
		Me.lblSubmit.TabIndex = 45
		Me.lblSubmit.Text = "SUBMIT QTY"
		Me.lblSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'UnitLabel1
		'
		Me.UnitLabel1.BackColor = System.Drawing.Color.Transparent
		Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "unit", True))
		Me.UnitLabel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.UnitLabel1.Location = New System.Drawing.Point(127, 2)
		Me.UnitLabel1.Name = "UnitLabel1"
		Me.UnitLabel1.Size = New System.Drawing.Size(58, 43)
		Me.UnitLabel1.TabIndex = 5
		Me.UnitLabel1.Text = "sft"
		Me.UnitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSelect
		'
		Me.btnSelect.Font = New System.Drawing.Font("Wingdings", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnSelect.ForeColor = System.Drawing.Color.Navy
		Me.btnSelect.Location = New System.Drawing.Point(211, 139)
		Me.btnSelect.Margin = New System.Windows.Forms.Padding(0)
		Me.btnSelect.Name = "btnSelect"
		Me.btnSelect.Size = New System.Drawing.Size(120, 44)
		Me.btnSelect.TabIndex = 22
		Me.btnSelect.Text = "ü"
		Me.ToolTip1.SetToolTip(Me.btnSelect, "Submit")
		Me.btnSelect.UseVisualStyleBackColor = True
		'
		'lblModAuto
		'
		Me.lblModAuto.BackColor = System.Drawing.Color.Transparent
		Me.lblModAuto.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblModAuto.ForeColor = System.Drawing.Color.Black
		Me.lblModAuto.Location = New System.Drawing.Point(209, 124)
		Me.lblModAuto.Margin = New System.Windows.Forms.Padding(0)
		Me.lblModAuto.Name = "lblModAuto"
		Me.lblModAuto.Size = New System.Drawing.Size(122, 14)
		Me.lblModAuto.TabIndex = 37
		Me.lblModAuto.Text = " MOD/ AUTO QTY"
		Me.lblModAuto.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'ShapeContainer3
		'
		Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer3.Name = "ShapeContainer3"
		Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
		Me.ShapeContainer3.Size = New System.Drawing.Size(338, 235)
		Me.ShapeContainer3.TabIndex = 46
		Me.ShapeContainer3.TabStop = False
		'
		'LineShape3
		'
		Me.LineShape3.BorderColor = System.Drawing.Color.Black
		Me.LineShape3.Name = "LineShape3"
		Me.LineShape3.X1 = 5
		Me.LineShape3.X2 = 335
		Me.LineShape3.Y1 = 79
		Me.LineShape3.Y2 = 79
		'
		'pnlItemDetails
		'
		Me.pnlItemDetails.BackColor = System.Drawing.Color.Transparent
		Me.pnlItemDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlItemDetails.Controls.Add(Me.lblEntryDate)
		Me.pnlItemDetails.Controls.Add(Me.LinkLabel1)
		Me.pnlItemDetails.Controls.Add(Me.Label2)
		Me.pnlItemDetails.Controls.Add(Me.SiteLabel1)
		Me.pnlItemDetails.Controls.Add(Me.lblNotesTitle)
		Me.pnlItemDetails.Controls.Add(Me.DescriptionLabel1)
		Me.pnlItemDetails.Controls.Add(Me.SiteNotesRichTextBox)
		Me.pnlItemDetails.Location = New System.Drawing.Point(2, 3)
		Me.pnlItemDetails.Name = "pnlItemDetails"
		Me.pnlItemDetails.Size = New System.Drawing.Size(338, 200)
		Me.pnlItemDetails.TabIndex = 26
		'
		'lblEntryDate
		'
		Me.lblEntryDate.BackColor = System.Drawing.Color.Red
		Me.lblEntryDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEntryDate.ForeColor = System.Drawing.Color.White
		Me.lblEntryDate.Location = New System.Drawing.Point(6, 181)
		Me.lblEntryDate.Name = "lblEntryDate"
		Me.lblEntryDate.Size = New System.Drawing.Size(248, 14)
		Me.lblEntryDate.TabIndex = 48
		Me.lblEntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LinkLabel1
		'
		Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.LinkLabel1.Location = New System.Drawing.Point(6, 181)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(329, 13)
		Me.LinkLabel1.TabIndex = 41
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "[+] Expand"
		Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Expand the 'Notes' panel visible area.  Unlimited* characters.")
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "code", True))
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DimGray
		Me.Label2.Location = New System.Drawing.Point(6, 77)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(329, 16)
		Me.Label2.TabIndex = 48
		Me.Label2.Text = "payItemCode"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'SiteLabel1
		'
		Me.SiteLabel1.BackColor = System.Drawing.Color.Transparent
		Me.SiteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "station", True))
		Me.SiteLabel1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SiteLabel1.ForeColor = System.Drawing.Color.Black
		Me.SiteLabel1.Location = New System.Drawing.Point(6, 2)
		Me.SiteLabel1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.SiteLabel1.Name = "SiteLabel1"
		Me.SiteLabel1.Size = New System.Drawing.Size(329, 40)
		Me.SiteLabel1.TabIndex = 1
		Me.SiteLabel1.Text = "Station Number/Site"
		Me.SiteLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblNotesTitle
		'
		Me.lblNotesTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblNotesTitle.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNotesTitle.ForeColor = System.Drawing.Color.Black
		Me.lblNotesTitle.Location = New System.Drawing.Point(6, 100)
		Me.lblNotesTitle.Margin = New System.Windows.Forms.Padding(0)
		Me.lblNotesTitle.Name = "lblNotesTitle"
		Me.lblNotesTitle.Size = New System.Drawing.Size(41, 15)
		Me.lblNotesTitle.TabIndex = 40
		Me.lblNotesTitle.Text = "Notes:"
		Me.lblNotesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'DescriptionLabel1
		'
		Me.DescriptionLabel1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.DescriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "description", True))
		Me.DescriptionLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DescriptionLabel1.ForeColor = System.Drawing.Color.Black
		Me.DescriptionLabel1.Location = New System.Drawing.Point(6, 46)
		Me.DescriptionLabel1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.DescriptionLabel1.Name = "DescriptionLabel1"
		Me.DescriptionLabel1.Size = New System.Drawing.Size(329, 30)
		Me.DescriptionLabel1.TabIndex = 3
		Me.DescriptionLabel1.Text = "Pay Item Description"
		Me.DescriptionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'SiteNotesRichTextBox
		'
		Me.SiteNotesRichTextBox.AutoWordSelection = True
		Me.SiteNotesRichTextBox.BackColor = System.Drawing.Color.White
		Me.SiteNotesRichTextBox.BulletIndent = 2
		Me.SiteNotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DPBindingSource, "siteNotes", True))
		Me.SiteNotesRichTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SiteNotesRichTextBox.ForeColor = System.Drawing.Color.Black
		Me.SiteNotesRichTextBox.Location = New System.Drawing.Point(6, 118)
		Me.SiteNotesRichTextBox.Name = "SiteNotesRichTextBox"
		Me.SiteNotesRichTextBox.Size = New System.Drawing.Size(329, 60)
		Me.SiteNotesRichTextBox.TabIndex = 21
		Me.SiteNotesRichTextBox.Text = ""
		Me.ToolTip1.SetToolTip(Me.SiteNotesRichTextBox, "Any comments/concerns regarding this specific location.  Click 'Expand' if more v" & _
				"isible area is needed.  Unlimited characters.")
		'
		'TblNonPayItemsBindingSource
		'
		Me.TblNonPayItemsBindingSource.DataMember = "tblNonPayItems"
		Me.TblNonPayItemsBindingSource.DataSource = Me.ActionEntryDataSetBindingSource
		'
		'ActionEntryDataSetBindingSource
		'
		Me.ActionEntryDataSetBindingSource.DataSource = Me.ActionEntryDataSet
		Me.ActionEntryDataSetBindingSource.Position = 0
		'
		'BackgroundWorker1
		'
		'
		'QryNPIdataSyncBindingSource
		'
		Me.QryNPIdataSyncBindingSource.DataMember = "qryNPIdataSync"
		Me.QryNPIdataSyncBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryNPIprodBindingSource
		'
		Me.QryNPIprodBindingSource.DataMember = "qryNPIprod"
		Me.QryNPIprodBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'TblNonPIProductionsBindingSource
		'
		Me.TblNonPIProductionsBindingSource.DataMember = "tblNonPIProductions"
		Me.TblNonPIProductionsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryMyDPTodayBindingSource
		'
		Me.QryMyDPTodayBindingSource.DataMember = "qryMyDPToday"
		Me.QryMyDPTodayBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryDPBindingSource
		'
		Me.QryDPBindingSource.DataMember = "qryDP"
		Me.QryDPBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'TblDailyProductionsBindingSource
		'
		Me.TblDailyProductionsBindingSource.DataMember = "tblDailyProductions"
		Me.TblDailyProductionsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryActiveJobsTableAdapter
		'
		Me.QryActiveJobsTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.DPTableAdapter = Me.DPTableAdapter
		Me.TableAdapterManager.qryDPTableAdapter = Me.QryDPTableAdapter
		Me.TableAdapterManager.qryNPIprodTableAdapter = Me.QryNPIprodTableAdapter
		Me.TableAdapterManager.tblDailyProductionsTableAdapter = Me.TblDailyProductionsTableAdapter
		Me.TableAdapterManager.tblGroupsTableAdapter = Nothing
		Me.TableAdapterManager.tblGuardRailDailyProductionsTableAdapter = Me.TblGuardRailDailyProductionsTableAdapter
		Me.TableAdapterManager.tblGuardRailNonPayItemsTableAdapter = Nothing
		Me.TableAdapterManager.tblJobPayItemsTableAdapter = Nothing
		Me.TableAdapterManager.tblJobsTableAdapter = Nothing
		Me.TableAdapterManager.tblNonPayItemsTableAdapter = Me.TblNonPayItemsTableAdapter
		Me.TableAdapterManager.tblNonPIProductionsTableAdapter = Me.TblNonPIProductionsTableAdapter
		Me.TableAdapterManager.tblPayItemPickListTableAdapter = Nothing
		Me.TableAdapterManager.tblPermissionsTableAdapter = Nothing
		Me.TableAdapterManager.tblPunchListCategoriesTableAdapter = Nothing
		Me.TableAdapterManager.tblPunchListTableAdapter = Nothing
		Me.TableAdapterManager.tblUsersTableAdapter = Nothing
		Me.TableAdapterManager.UpdateOrder = AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'DPTableAdapter
		'
		Me.DPTableAdapter.ClearBeforeFill = True
		'
		'QryDPTableAdapter
		'
		Me.QryDPTableAdapter.ClearBeforeFill = True
		'
		'QryNPIprodTableAdapter
		'
		Me.QryNPIprodTableAdapter.ClearBeforeFill = True
		'
		'TblDailyProductionsTableAdapter
		'
		Me.TblDailyProductionsTableAdapter.ClearBeforeFill = True
		'
		'TblGuardRailDailyProductionsTableAdapter
		'
		Me.TblGuardRailDailyProductionsTableAdapter.ClearBeforeFill = True
		'
		'TblNonPayItemsTableAdapter
		'
		Me.TblNonPayItemsTableAdapter.ClearBeforeFill = True
		'
		'TblNonPIProductionsTableAdapter
		'
		Me.TblNonPIProductionsTableAdapter.ClearBeforeFill = True
		'
		'QryPayItemsByJobTableAdapter
		'
		Me.QryPayItemsByJobTableAdapter.ClearBeforeFill = True
		'
		'QryJobPayItemsTableAdapter
		'
		Me.QryJobPayItemsTableAdapter.ClearBeforeFill = True
		'
		'QryMyDPTodayTableAdapter
		'
		Me.QryMyDPTodayTableAdapter.ClearBeforeFill = True
		'
		'QryNonPIBindingSource
		'
		Me.QryNonPIBindingSource.DataMember = "QryNonPI"
		Me.QryNonPIBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryNonPITableAdapter
		'
		Me.QryNonPITableAdapter.ClearBeforeFill = True
		'
		'QryNPIdataSyncTableAdapter
		'
		Me.QryNPIdataSyncTableAdapter.ClearBeforeFill = True
		'
		'frmAE_DP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1000, 530)
		Me.Controls.Add(Me.SplitContainerMain)
		Me.Controls.Add(Me.txtDisplay)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmAE_DP"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " DailyProduction - ActionEntry"
		Me.drpActiveJobs.ItemTemplate.ResumeLayout(False)
		Me.drpActiveJobs.ResumeLayout(False)
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvJobPayItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryPayItemsByJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainerMain.Panel1.ResumeLayout(False)
		Me.SplitContainerMain.Panel1.PerformLayout()
		Me.SplitContainerMain.Panel2.ResumeLayout(False)
		Me.SplitContainerMain.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.SplitContainerContentMain.Panel1.ResumeLayout(False)
		Me.SplitContainerContentMain.Panel2.ResumeLayout(False)
		Me.SplitContainerContentMain.ResumeLayout(False)
		Me.SplitContainerJobPIandDP.Panel1.ResumeLayout(False)
		Me.SplitContainerJobPIandDP.Panel2.ResumeLayout(False)
		Me.SplitContainerJobPIandDP.ResumeLayout(False)
		Me.SplitC_SiteListAndDetail.Panel1.ResumeLayout(False)
		Me.SplitC_SiteListAndDetail.Panel2.ResumeLayout(False)
		Me.SplitC_SiteListAndDetail.ResumeLayout(False)
		Me.splitCNavDP.Panel1.ResumeLayout(False)
		Me.splitCNavDP.Panel2.ResumeLayout(False)
		Me.splitCNavDP.Panel2.PerformLayout()
		Me.splitCNavDP.ResumeLayout(False)
		CType(Me.dgvDP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panNonPayItemsMain.ResumeLayout(False)
		Me.tabNonPayItems.ResumeLayout(False)
		Me.tbpWoodSteelPosts.ResumeLayout(False)
		Me.pnlFDN.ResumeLayout(False)
		Me.panPosts.ResumeLayout(False)
		Me.panPosts.PerformLayout()
		Me.tbpColumns.ResumeLayout(False)
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panBreakAway.ResumeLayout(False)
		Me.panBreakAway.PerformLayout()
		CType(Me.nudR, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudL, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbpSlipBases.ResumeLayout(False)
		Me.tbpSlipBases.PerformLayout()
		CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panSlipBases.ResumeLayout(False)
		CType(Me.nudSlipBaseFoundation, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbpNPI.ResumeLayout(False)
		Me.tbpNPI.PerformLayout()
		CType(Me.dgvNPIdataSync, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbpSignDetails.ResumeLayout(False)
		Me.grpSignDetails.ResumeLayout(False)
		Me.grpSignDetails.PerformLayout()
		CType(Me.picImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbpGuardRail.ResumeLayout(False)
		Me.tbpGuardRail.PerformLayout()
		CType(Me.dgvGuardRailProductions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblGuardRailDailyProductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tbpCurrentList.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panPayItemsMain.ResumeLayout(False)
		Me.pnlNavigationSubmit.ResumeLayout(False)
		Me.tlpNav.ResumeLayout(False)
		Me.tlpNav.PerformLayout()
		Me.pnlItemDetails.ResumeLayout(False)
		CType(Me.TblNonPayItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryNPIdataSyncBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryNPIprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblNonPIProductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryDPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblDailyProductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryNonPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents drpActiveJobs As Microsoft.VisualBasic.PowerPacks.DataRepeater
	Friend WithEvents lblJobNumber As System.Windows.Forms.Label
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryActiveJobsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryActiveJobsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
	Friend WithEvents dgvJobPayItems As System.Windows.Forms.DataGridView
	Friend WithEvents TableAdapterManager As AE_Ground.ActionEntryDataSetTableAdapters.TableAdapterManager
	Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
	Friend WithEvents QryPayItemsByJobBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryPayItemsByJobTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryPayItemsByJobTableAdapter
	Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
	Friend WithEvents SplitContainerContentMain As System.Windows.Forms.SplitContainer
	Friend WithEvents SplitContainerJobPIandDP As System.Windows.Forms.SplitContainer
	Friend WithEvents ActionEntryDataSetBindingSource As System.Windows.Forms.BindingSource
	'Friend WithEvents QryDP1DataGridView As System.Windows.Forms.DataGridView
	Friend WithEvents SplitC_SiteListAndDetail As System.Windows.Forms.SplitContainer
	Friend WithEvents UnitLabel1 As System.Windows.Forms.Label
	Friend WithEvents DescriptionLabel1 As System.Windows.Forms.Label
	Friend WithEvents SiteLabel1 As System.Windows.Forms.Label
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents SignCodeTextBox As System.Windows.Forms.TextBox
	Friend WithEvents grpSignDetails As System.Windows.Forms.GroupBox
	Friend WithEvents ckbDailyProductions As System.Windows.Forms.CheckBox
	Friend WithEvents ckbPayItems As System.Windows.Forms.CheckBox
	Friend WithEvents ckbJobList As System.Windows.Forms.CheckBox
	Friend WithEvents SiteNotesRichTextBox As System.Windows.Forms.RichTextBox
	Friend WithEvents picImagePreview As System.Windows.Forms.PictureBox
	Friend WithEvents SignHeightTextBox As System.Windows.Forms.TextBox
	Friend WithEvents SignWidthTextBox As System.Windows.Forms.TextBox
	Friend WithEvents QryJobPayItemsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryJobPayItemsTableAdapter
	Friend WithEvents JobNumLabel1 As System.Windows.Forms.Label
	Friend WithEvents LocationLabel1 As System.Windows.Forms.Label
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents QryDPBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryDPTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryDPTableAdapter
	Friend WithEvents btnSelect As System.Windows.Forms.Button
	Friend WithEvents btnModifyQty As System.Windows.Forms.Button
	Friend WithEvents btnFirst As System.Windows.Forms.Button
	Friend WithEvents lblExitDP As System.Windows.Forms.Label
	Friend WithEvents lblFullScreen As System.Windows.Forms.Label
	Friend WithEvents lblHide As System.Windows.Forms.Label
	Friend WithEvents splitCNavDP As System.Windows.Forms.SplitContainer
	Friend WithEvents lblRecCount As System.Windows.Forms.Label
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btnViewSelected As System.Windows.Forms.Button
	Friend WithEvents btnSubmitPostLengths As System.Windows.Forms.Button
	Friend WithEvents cmbPost2 As System.Windows.Forms.ComboBox
	Friend WithEvents cmbPost1 As System.Windows.Forms.ComboBox
	Friend WithEvents lblPost2 As System.Windows.Forms.Label
	Friend WithEvents lblPost1 As System.Windows.Forms.Label
	Friend WithEvents panBreakAway As System.Windows.Forms.Panel
	Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents nudR As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudL As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblNudRUnit As System.Windows.Forms.Label
	Friend WithEvents lblNudLUnit As System.Windows.Forms.Label
	Friend WithEvents lblNudR As System.Windows.Forms.Label
	Friend WithEvents lblNudL As System.Windows.Forms.Label
	Friend WithEvents panSlipBases As System.Windows.Forms.Panel
	Friend WithEvents panPosts As System.Windows.Forms.Panel
	Friend WithEvents lblCurrentPostType As System.Windows.Forms.Label
	Friend WithEvents panNonPayItemsMain As System.Windows.Forms.Panel
	Friend WithEvents panPayItemsMain As System.Windows.Forms.Panel
	Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
	Friend WithEvents TblNonPIProductionsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblNonPayItemsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblNonPayItemsTableAdapter
	Friend WithEvents TblNonPIProductionsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblNonPIProductionsTableAdapter
	Friend WithEvents TblNonPayItemsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ckbSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents JobNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PayItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ckbCompletedItems As System.Windows.Forms.CheckBox
	Friend WithEvents tabNonPayItems As System.Windows.Forms.TabControl
	Friend WithEvents tbpWoodSteelPosts As System.Windows.Forms.TabPage
	Friend WithEvents tbpColumns As System.Windows.Forms.TabPage
	Friend WithEvents tbpSlipBases As System.Windows.Forms.TabPage
	Friend WithEvents tbpNPI As System.Windows.Forms.TabPage
	Friend WithEvents tbpSignDetails As System.Windows.Forms.TabPage
	Friend WithEvents tbpCurrentList As System.Windows.Forms.TabPage
	Friend WithEvents btnManualEntry As System.Windows.Forms.Button
	Friend WithEvents lblNPI As System.Windows.Forms.Label
	Friend WithEvents nudSlipBaseFoundation As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblColumnsTitle As System.Windows.Forms.Label
	Friend WithEvents lblSlipBaseTitle As System.Windows.Forms.Label
	Friend WithEvents lblDPQty As System.Windows.Forms.Label
	Friend WithEvents btnReportElevations As System.Windows.Forms.Button
	Friend WithEvents lblFirst As System.Windows.Forms.Label
	Friend WithEvents tlpNav As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents btnLast As System.Windows.Forms.Button
	Friend WithEvents lblLast As System.Windows.Forms.Label
	Friend WithEvents lblNext As System.Windows.Forms.Label
	Friend WithEvents lblPrevious As System.Windows.Forms.Label
	Friend WithEvents lblPlanQty As System.Windows.Forms.Label
	Friend WithEvents lblInstalledQty As System.Windows.Forms.Label
	Friend WithEvents lblRightPost As System.Windows.Forms.Label
	Friend WithEvents lblLeftPost As System.Windows.Forms.Label
	Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents btnQtyValid As System.Windows.Forms.Button
	Friend WithEvents lblNotesTitle As System.Windows.Forms.Label
	Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
	Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblModAuto As System.Windows.Forms.Label
	Friend WithEvents lblNav As System.Windows.Forms.Label
	Friend WithEvents pnlItemDetails As System.Windows.Forms.Panel
	Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents lblSubmit As System.Windows.Forms.Label
	Friend WithEvents pnlNavigationSubmit As System.Windows.Forms.Panel
	Friend WithEvents CQtyLabel1 As System.Windows.Forms.Label
	Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Friend WithEvents lblDateAndTime As System.Windows.Forms.Label
	Friend WithEvents lblWorkingDate As System.Windows.Forms.Label
	Friend WithEvents lblSmallPayItemDescription As System.Windows.Forms.Label
	Friend WithEvents QryMyDPTodayBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryMyDPTodayTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
	Friend WithEvents TblDailyProductionsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblDailyProductionsTableAdapter
	Friend WithEvents TblDailyProductionsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents btnViewProduction As System.Windows.Forms.Button
	Friend WithEvents lblWpFDNQty As System.Windows.Forms.Label
	Friend WithEvents btnSubmitWpFDN As System.Windows.Forms.Button
	Friend WithEvents pnlFDN As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents QryNonPIBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryNonPITableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.QryNonPITableAdapter
	Friend WithEvents QryNPIprodBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryNPIprodTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryNPIprodTableAdapter
	Friend WithEvents dgvDP As System.Windows.Forms.DataGridView
	Friend WithEvents DPBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents DPTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.DPTableAdapter
	Friend WithEvents lblEntryDate As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents lstNPI As System.Windows.Forms.ListBox
	Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
	Friend WithEvents dgvNPIdataSync As System.Windows.Forms.DataGridView
	Friend WithEvents QryNPIdataSyncBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryNPIdataSyncTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryNPIdataSyncTableAdapter
	Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents JobNumDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PayItemIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents StationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CodeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UnitDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DpIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DpQtyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SignCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SignWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SignHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SiteNotesDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ForemanDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EntryDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SptQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents txtSearchCriteria As System.Windows.Forms.TextBox
	Friend WithEvents btnStationSearch As System.Windows.Forms.Button
	Friend WithEvents tbpGuardRail As System.Windows.Forms.TabPage
	Friend WithEvents dgvGuardRailProductions As System.Windows.Forms.DataGridView
	Friend WithEvents TblGuardRailDailyProductionsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblGuardRailDailyProductionsTableAdapter
	Friend WithEvents TblGuardRailDailyProductionsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents AeDpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents btnAddGrRun As System.Windows.Forms.Button
	Friend WithEvents txtRunQty As System.Windows.Forms.TextBox
	Friend WithEvents txtRunNotes As System.Windows.Forms.TextBox
	Friend WithEvents txtRunID As System.Windows.Forms.TextBox
	Friend WithEvents btnGrSave As System.Windows.Forms.Button
	Friend WithEvents lblGuardRailRunTotal As System.Windows.Forms.Label
	Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents JobNumDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RunIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents GrQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RunNotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RunDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ForemanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents cmbPost1_Actual As System.Windows.Forms.ComboBox
	Friend WithEvents cmbPost2_Actual As System.Windows.Forms.ComboBox
	Friend WithEvents lblGRrunID As System.Windows.Forms.Label
	Friend WithEvents lblGRrunQty As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblGRrunNotes As System.Windows.Forms.Label
	Friend WithEvents btnSubmitSlipBaseFoundation As System.Windows.Forms.Button
End Class
