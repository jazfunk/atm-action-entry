<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeReporting
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.chklstCrew = New System.Windows.Forms.CheckedListBox
		Me.dtpStart = New System.Windows.Forms.DateTimePicker
		Me.dtpEnd = New System.Windows.Forms.DateTimePicker
		Me.lblStart = New System.Windows.Forms.Label
		Me.lblEnd = New System.Windows.Forms.Label
		Me.grpBoxTime = New System.Windows.Forms.GroupBox
		Me.PictureBox2 = New System.Windows.Forms.PictureBox
		Me.grpWorkType = New System.Windows.Forms.GroupBox
		Me.rboSigns = New System.Windows.Forms.RadioButton
		Me.rboOther = New System.Windows.Forms.RadioButton
		Me.rboGuardrail = New System.Windows.Forms.RadioButton
		Me.rboFence = New System.Windows.Forms.RadioButton
		Me.ckbSelectAll = New System.Windows.Forms.CheckBox
		Me.btnEnterTime = New System.Windows.Forms.Button
		Me.btnViewAll = New System.Windows.Forms.Button
		Me.dtpDate = New System.Windows.Forms.DateTimePicker
		Me.btnSaveCrew = New System.Windows.Forms.Button
		Me.dgvTime = New System.Windows.Forms.DataGridView
		Me.lblJobNumber = New System.Windows.Forms.Label
		Me.btnSave = New System.Windows.Forms.Button
		Me.btnDelete = New System.Windows.Forms.Button
		Me.lblJobNumberCaption = New System.Windows.Forms.Label
		Me.cmbJobNumber = New System.Windows.Forms.ComboBox
		Me.pnlTitleBar = New System.Windows.Forms.Panel
		Me.Label1 = New System.Windows.Forms.Label
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.lblClose = New System.Windows.Forms.Label
		Me.btnOK = New System.Windows.Forms.Button
		Me.Panel1 = New System.Windows.Forms.Panel
		Me.btnSite = New System.Windows.Forms.Button
		Me.btnDriveLoad = New System.Windows.Forms.Button
		Me.btnNext = New System.Windows.Forms.Button
		Me.btnPrev = New System.Windows.Forms.Button
		Me.btnAddNotes = New System.Windows.Forms.Button
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryUsersDisplayNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryUsersDisplayNamesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
		Me.QryActiveJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblJobsTableAdapter
		Me.QryActiveJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
		Me.TimeReporting = New AE_Ground.TimeReporting
		Me.AtmTimeDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.grpBoxTime.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grpWorkType.SuspendLayout()
		CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlTitleBar.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TimeReporting, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AtmTimeDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'chklstCrew
		'
		Me.chklstCrew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.chklstCrew.CheckOnClick = True
		Me.chklstCrew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chklstCrew.FormattingEnabled = True
		Me.chklstCrew.Location = New System.Drawing.Point(8, 19)
		Me.chklstCrew.Margin = New System.Windows.Forms.Padding(1)
		Me.chklstCrew.Name = "chklstCrew"
		Me.chklstCrew.Size = New System.Drawing.Size(201, 268)
		Me.chklstCrew.TabIndex = 0
		'
		'dtpStart
		'
		Me.dtpStart.CustomFormat = "hh:mm tt"
		Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpStart.Location = New System.Drawing.Point(215, 96)
		Me.dtpStart.Name = "dtpStart"
		Me.dtpStart.ShowUpDown = True
		Me.dtpStart.Size = New System.Drawing.Size(149, 38)
		Me.dtpStart.TabIndex = 1
		'
		'dtpEnd
		'
		Me.dtpEnd.CustomFormat = "hh:mm tt"
		Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEnd.Location = New System.Drawing.Point(216, 155)
		Me.dtpEnd.Name = "dtpEnd"
		Me.dtpEnd.ShowUpDown = True
		Me.dtpEnd.Size = New System.Drawing.Size(149, 38)
		Me.dtpEnd.TabIndex = 2
		'
		'lblStart
		'
		Me.lblStart.AutoSize = True
		Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStart.ForeColor = System.Drawing.Color.DimGray
		Me.lblStart.Location = New System.Drawing.Point(213, 78)
		Me.lblStart.Name = "lblStart"
		Me.lblStart.Size = New System.Drawing.Size(35, 15)
		Me.lblStart.TabIndex = 3
		Me.lblStart.Text = "Start:"
		'
		'lblEnd
		'
		Me.lblEnd.AutoSize = True
		Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEnd.ForeColor = System.Drawing.Color.DimGray
		Me.lblEnd.Location = New System.Drawing.Point(213, 137)
		Me.lblEnd.Name = "lblEnd"
		Me.lblEnd.Size = New System.Drawing.Size(32, 15)
		Me.lblEnd.TabIndex = 4
		Me.lblEnd.Text = "End:"
		'
		'grpBoxTime
		'
		Me.grpBoxTime.BackColor = System.Drawing.Color.Transparent
		Me.grpBoxTime.Controls.Add(Me.PictureBox2)
		Me.grpBoxTime.Controls.Add(Me.grpWorkType)
		Me.grpBoxTime.Controls.Add(Me.ckbSelectAll)
		Me.grpBoxTime.Controls.Add(Me.btnEnterTime)
		Me.grpBoxTime.Controls.Add(Me.btnViewAll)
		Me.grpBoxTime.Controls.Add(Me.dtpDate)
		Me.grpBoxTime.Controls.Add(Me.btnSaveCrew)
		Me.grpBoxTime.Controls.Add(Me.chklstCrew)
		Me.grpBoxTime.Controls.Add(Me.dtpStart)
		Me.grpBoxTime.Controls.Add(Me.lblEnd)
		Me.grpBoxTime.Controls.Add(Me.dtpEnd)
		Me.grpBoxTime.Controls.Add(Me.lblStart)
		Me.grpBoxTime.Location = New System.Drawing.Point(3, 3)
		Me.grpBoxTime.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
		Me.grpBoxTime.Name = "grpBoxTime"
		Me.grpBoxTime.Padding = New System.Windows.Forms.Padding(3, 3, 3, 1)
		Me.grpBoxTime.Size = New System.Drawing.Size(371, 328)
		Me.grpBoxTime.TabIndex = 5
		Me.grpBoxTime.TabStop = False
		Me.grpBoxTime.Text = "Crew/Time"
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.Image = Global.AE_Ground.My.Resources.Resources.ATM_Logo_SEPARATED2
		Me.PictureBox2.Location = New System.Drawing.Point(240, 8)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(94, 44)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 22
		Me.PictureBox2.TabStop = False
		'
		'grpWorkType
		'
		Me.grpWorkType.Controls.Add(Me.rboSigns)
		Me.grpWorkType.Controls.Add(Me.rboOther)
		Me.grpWorkType.Controls.Add(Me.rboGuardrail)
		Me.grpWorkType.Controls.Add(Me.rboFence)
		Me.grpWorkType.Location = New System.Drawing.Point(216, 199)
		Me.grpWorkType.Name = "grpWorkType"
		Me.grpWorkType.Size = New System.Drawing.Size(149, 66)
		Me.grpWorkType.TabIndex = 25
		Me.grpWorkType.TabStop = False
		Me.grpWorkType.Text = "Work Type"
		'
		'rboSigns
		'
		Me.rboSigns.AutoSize = True
		Me.rboSigns.Location = New System.Drawing.Point(10, 17)
		Me.rboSigns.Name = "rboSigns"
		Me.rboSigns.Size = New System.Drawing.Size(51, 17)
		Me.rboSigns.TabIndex = 21
		Me.rboSigns.TabStop = True
		Me.rboSigns.Text = "Signs"
		Me.rboSigns.UseVisualStyleBackColor = True
		'
		'rboOther
		'
		Me.rboOther.AutoSize = True
		Me.rboOther.Location = New System.Drawing.Point(88, 40)
		Me.rboOther.Name = "rboOther"
		Me.rboOther.Size = New System.Drawing.Size(51, 17)
		Me.rboOther.TabIndex = 24
		Me.rboOther.TabStop = True
		Me.rboOther.Text = "Other"
		Me.rboOther.UseVisualStyleBackColor = True
		'
		'rboGuardrail
		'
		Me.rboGuardrail.AutoSize = True
		Me.rboGuardrail.Location = New System.Drawing.Point(10, 40)
		Me.rboGuardrail.Name = "rboGuardrail"
		Me.rboGuardrail.Size = New System.Drawing.Size(67, 17)
		Me.rboGuardrail.TabIndex = 22
		Me.rboGuardrail.TabStop = True
		Me.rboGuardrail.Text = "Guardrail"
		Me.rboGuardrail.UseVisualStyleBackColor = True
		'
		'rboFence
		'
		Me.rboFence.AutoSize = True
		Me.rboFence.Location = New System.Drawing.Point(88, 17)
		Me.rboFence.Name = "rboFence"
		Me.rboFence.Size = New System.Drawing.Size(55, 17)
		Me.rboFence.TabIndex = 23
		Me.rboFence.TabStop = True
		Me.rboFence.Text = "Fence"
		Me.rboFence.UseVisualStyleBackColor = True
		'
		'ckbSelectAll
		'
		Me.ckbSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ckbSelectAll.Location = New System.Drawing.Point(218, 268)
		Me.ckbSelectAll.Name = "ckbSelectAll"
		Me.ckbSelectAll.Size = New System.Drawing.Size(139, 20)
		Me.ckbSelectAll.TabIndex = 19
		Me.ckbSelectAll.Text = "Select All"
		Me.ckbSelectAll.UseVisualStyleBackColor = True
		'
		'btnEnterTime
		'
		Me.btnEnterTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEnterTime.ForeColor = System.Drawing.Color.MidnightBlue
		Me.btnEnterTime.Location = New System.Drawing.Point(215, 291)
		Me.btnEnterTime.Name = "btnEnterTime"
		Me.btnEnterTime.Size = New System.Drawing.Size(150, 33)
		Me.btnEnterTime.TabIndex = 5
		Me.btnEnterTime.Text = "ADD TIME ->"
		Me.btnEnterTime.UseVisualStyleBackColor = True
		'
		'btnViewAll
		'
		Me.btnViewAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnViewAll.Location = New System.Drawing.Point(8, 291)
		Me.btnViewAll.Name = "btnViewAll"
		Me.btnViewAll.Size = New System.Drawing.Size(113, 33)
		Me.btnViewAll.TabIndex = 18
		Me.btnViewAll.Text = "View All Employees"
		Me.btnViewAll.UseVisualStyleBackColor = True
		'
		'dtpDate
		'
		Me.dtpDate.CustomFormat = "ddd MM/dd/yyyy"
		Me.dtpDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDate.Location = New System.Drawing.Point(213, 52)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(149, 23)
		Me.dtpDate.TabIndex = 6
		'
		'btnSaveCrew
		'
		Me.btnSaveCrew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveCrew.Location = New System.Drawing.Point(127, 291)
		Me.btnSaveCrew.Name = "btnSaveCrew"
		Me.btnSaveCrew.Size = New System.Drawing.Size(82, 33)
		Me.btnSaveCrew.TabIndex = 17
		Me.btnSaveCrew.Text = "Save Crew"
		Me.btnSaveCrew.UseVisualStyleBackColor = True
		'
		'dgvTime
		'
		Me.dgvTime.AllowUserToAddRows = False
		Me.dgvTime.AllowUserToDeleteRows = False
		Me.dgvTime.AllowUserToResizeRows = False
		Me.dgvTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvTime.BackgroundColor = System.Drawing.Color.White
		Me.dgvTime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvTime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvTime.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvTime.Location = New System.Drawing.Point(380, 5)
		Me.dgvTime.Name = "dgvTime"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvTime.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvTime.RowHeadersVisible = False
		Me.dgvTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvTime.ShowEditingIcon = False
		Me.dgvTime.Size = New System.Drawing.Size(614, 319)
		Me.dgvTime.TabIndex = 6
		'
		'lblJobNumber
		'
		Me.lblJobNumber.AutoSize = True
		Me.lblJobNumber.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumber.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumber.Location = New System.Drawing.Point(10, 331)
		Me.lblJobNumber.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(102, 40)
		Me.lblJobNumber.TabIndex = 6
		Me.lblJobNumber.Text = "17005"
		'
		'btnSave
		'
		Me.btnSave.Enabled = False
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
		Me.btnSave.Location = New System.Drawing.Point(896, 330)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(98, 62)
		Me.btnSave.TabIndex = 6
		Me.btnSave.Text = "SAVE"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Enabled = False
		Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.Crimson
		Me.btnDelete.Location = New System.Drawing.Point(546, 330)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(160, 61)
		Me.btnDelete.TabIndex = 7
		Me.btnDelete.Text = "Delete:"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'lblJobNumberCaption
		'
		Me.lblJobNumberCaption.AutoSize = True
		Me.lblJobNumberCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumberCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumberCaption.ForeColor = System.Drawing.Color.DimGray
		Me.lblJobNumberCaption.Location = New System.Drawing.Point(14, 377)
		Me.lblJobNumberCaption.Name = "lblJobNumberCaption"
		Me.lblJobNumberCaption.Size = New System.Drawing.Size(199, 16)
		Me.lblJobNumberCaption.TabIndex = 9
		Me.lblJobNumberCaption.Text = "Click on Job Number to Change."
		'
		'cmbJobNumber
		'
		Me.cmbJobNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cmbJobNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbJobNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbJobNumber.FormattingEnabled = True
		Me.cmbJobNumber.IntegralHeight = False
		Me.cmbJobNumber.Items.AddRange(New Object() {"20166", "20165", "20164", "20163", "20162", "20160", "20159", "20158", "20157", "20156", "20155", "20154", "20153", "20151", "20149", "20148", "20147", "20146", "20145", "20144", "20142", "20141", "20140", "20139", "20138", "20137", "20136", "20133", "20132", "20128", "20127", "20126", "20124", "20122", "20121", "20120", "20119", "20118", "20117", "20116", "20115", "20114", "20113", "20112", "20111", "20109", "20108", "20106", "20105", "20104", "20103", "20101", "20100", "20099", "20098", "20097", "20095", "20091", "20090", "20086", "20085", "20083", "20082", "20081", "20079", "20078", "20076", "20075", "20073", "20070", "20069", "20068", "20067", "20066", "20064", "20063", "20062", "20059", "20057", "20056", "20055", "20052", "20051", "20049", "20046", "20045", "20044", "20043", "20042", "20041", "20040", "20039", "20038", "20036", "20032", "20030", "20028", "20027", "20026", "20025", "20024", "20023", "20022", "20021", "20018", "20017", "20016", "20015", "20014", "20012", "20006", "20004", "20003", "20002", "20001", "20000", "19160", "19159", "19158", "19156", "19155", "19153", "19152", "19148", "19145", "19140", "19139", "19137", "19135", "19134", "19123", "19106", "19095", "19061M", "19061", "19059", "19056", "19048", "19047", "19033", "19018", "19013", "18199", "18190a", "18190", "18177", "18174", "18103"})
		Me.cmbJobNumber.Location = New System.Drawing.Point(247, 333)
		Me.cmbJobNumber.Name = "cmbJobNumber"
		Me.cmbJobNumber.Size = New System.Drawing.Size(121, 28)
		Me.cmbJobNumber.TabIndex = 10
		Me.cmbJobNumber.Text = "Select"
		Me.cmbJobNumber.Visible = False
		'
		'pnlTitleBar
		'
		Me.pnlTitleBar.BackgroundImage = Global.AE_Ground.My.Resources.Resources.progressTitleBar2
		Me.pnlTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTitleBar.Controls.Add(Me.Label1)
		Me.pnlTitleBar.Controls.Add(Me.PictureBox1)
		Me.pnlTitleBar.Controls.Add(Me.lblClose)
		Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleBar.Name = "pnlTitleBar"
		Me.pnlTitleBar.Size = New System.Drawing.Size(1004, 28)
		Me.pnlTitleBar.TabIndex = 11
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(40, 7)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(174, 16)
		Me.Label1.TabIndex = 22
		Me.Label1.Text = "ActionEntry - Enter Time"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Image = Global.AE_Ground.My.Resources.Resources.clock_1
		Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'lblClose
		'
		Me.lblClose.AutoSize = True
		Me.lblClose.BackColor = System.Drawing.Color.Transparent
		Me.lblClose.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClose.ForeColor = System.Drawing.Color.White
		Me.lblClose.Location = New System.Drawing.Point(980, 2)
		Me.lblClose.Margin = New System.Windows.Forms.Padding(0)
		Me.lblClose.Name = "lblClose"
		Me.lblClose.Size = New System.Drawing.Size(22, 23)
		Me.lblClose.TabIndex = 0
		Me.lblClose.Text = "X"
		'
		'btnOK
		'
		Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.Location = New System.Drawing.Point(247, 365)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(121, 26)
		Me.btnOK.TabIndex = 12
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = True
		Me.btnOK.Visible = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.btnSite)
		Me.Panel1.Controls.Add(Me.btnDriveLoad)
		Me.Panel1.Controls.Add(Me.btnNext)
		Me.Panel1.Controls.Add(Me.btnPrev)
		Me.Panel1.Controls.Add(Me.btnAddNotes)
		Me.Panel1.Controls.Add(Me.btnOK)
		Me.Panel1.Controls.Add(Me.grpBoxTime)
		Me.Panel1.Controls.Add(Me.cmbJobNumber)
		Me.Panel1.Controls.Add(Me.dgvTime)
		Me.Panel1.Controls.Add(Me.lblJobNumberCaption)
		Me.Panel1.Controls.Add(Me.lblJobNumber)
		Me.Panel1.Controls.Add(Me.btnSave)
		Me.Panel1.Controls.Add(Me.btnDelete)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 28)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1004, 402)
		Me.Panel1.TabIndex = 13
		'
		'btnSite
		'
		Me.btnSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSite.Location = New System.Drawing.Point(767, 363)
		Me.btnSite.Name = "btnSite"
		Me.btnSite.Size = New System.Drawing.Size(123, 28)
		Me.btnSite.TabIndex = 15
		Me.btnSite.Text = "Site"
		Me.btnSite.UseVisualStyleBackColor = True
		'
		'btnDriveLoad
		'
		Me.btnDriveLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDriveLoad.Location = New System.Drawing.Point(767, 330)
		Me.btnDriveLoad.Name = "btnDriveLoad"
		Me.btnDriveLoad.Size = New System.Drawing.Size(123, 28)
		Me.btnDriveLoad.TabIndex = 14
		Me.btnDriveLoad.Text = "Drive/Load"
		Me.btnDriveLoad.UseVisualStyleBackColor = True
		'
		'btnNext
		'
		Me.btnNext.Enabled = False
		Me.btnNext.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnNext.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnNext.Location = New System.Drawing.Point(712, 363)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(49, 28)
		Me.btnNext.TabIndex = 21
		Me.btnNext.Text = "ê"
		Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Enabled = False
		Me.btnPrev.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnPrev.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnPrev.Location = New System.Drawing.Point(712, 330)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(49, 28)
		Me.btnPrev.TabIndex = 20
		Me.btnPrev.Text = "é"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnAddNotes
		'
		Me.btnAddNotes.Enabled = False
		Me.btnAddNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddNotes.Location = New System.Drawing.Point(380, 330)
		Me.btnAddNotes.Name = "btnAddNotes"
		Me.btnAddNotes.Size = New System.Drawing.Size(160, 61)
		Me.btnAddNotes.TabIndex = 19
		Me.btnAddNotes.Text = "Add notes for:"
		Me.btnAddNotes.UseVisualStyleBackColor = True
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
		'QryActiveJobsBindingSource
		'
		Me.QryActiveJobsBindingSource.DataMember = "qryActiveJobs"
		Me.QryActiveJobsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'TblJobsBindingSource
		'
		Me.TblJobsBindingSource.DataMember = "tblJobs"
		Me.TblJobsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'TblJobsTableAdapter
		'
		Me.TblJobsTableAdapter.ClearBeforeFill = True
		'
		'QryActiveJobsTableAdapter
		'
		Me.QryActiveJobsTableAdapter.ClearBeforeFill = True
		'
		'TimeReporting
		'
		Me.TimeReporting.DataSetName = "TimeReporting"
		Me.TimeReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'AtmTimeDSBindingSource
		'
		Me.AtmTimeDSBindingSource.DataMember = "atmTimeDT"
		Me.AtmTimeDSBindingSource.DataSource = Me.TimeReporting
		'
		'frmTimeReporting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1004, 430)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlTitleBar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmTimeReporting"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Time Reporting"
		Me.grpBoxTime.ResumeLayout(False)
		Me.grpBoxTime.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grpWorkType.ResumeLayout(False)
		Me.grpWorkType.PerformLayout()
		CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlTitleBar.ResumeLayout(False)
		Me.pnlTitleBar.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TimeReporting, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AtmTimeDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents chklstCrew As System.Windows.Forms.CheckedListBox
	Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblStart As System.Windows.Forms.Label
	Friend WithEvents lblEnd As System.Windows.Forms.Label
	Friend WithEvents grpBoxTime As System.Windows.Forms.GroupBox
	Friend WithEvents btnEnterTime As System.Windows.Forms.Button
	Friend WithEvents dgvTime As System.Windows.Forms.DataGridView
	Friend WithEvents lblJobNumber As System.Windows.Forms.Label
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnDelete As System.Windows.Forms.Button
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryUsersDisplayNamesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryUsersDisplayNamesTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
	Friend WithEvents lblJobNumberCaption As System.Windows.Forms.Label
	Friend WithEvents cmbJobNumber As System.Windows.Forms.ComboBox
	Friend WithEvents TblJobsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblJobsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblJobsTableAdapter
	Friend WithEvents QryActiveJobsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryActiveJobsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
	Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
	Friend WithEvents lblClose As System.Windows.Forms.Label
	Friend WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents TimeReporting As AE_Ground.TimeReporting
	Friend WithEvents AtmTimeDSBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents btnSaveCrew As System.Windows.Forms.Button
	Friend WithEvents btnViewAll As System.Windows.Forms.Button
	Friend WithEvents btnAddNotes As System.Windows.Forms.Button
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents ckbSelectAll As System.Windows.Forms.CheckBox
	Friend WithEvents rboFence As System.Windows.Forms.RadioButton
	Friend WithEvents rboGuardrail As System.Windows.Forms.RadioButton
	Friend WithEvents rboSigns As System.Windows.Forms.RadioButton
	Friend WithEvents rboOther As System.Windows.Forms.RadioButton
	Friend WithEvents grpWorkType As System.Windows.Forms.GroupBox
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
	Friend WithEvents btnSite As System.Windows.Forms.Button
	Friend WithEvents btnDriveLoad As System.Windows.Forms.Button
End Class
