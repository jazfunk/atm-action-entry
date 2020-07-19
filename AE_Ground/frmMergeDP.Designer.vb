<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMergeDP
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMergeDP))
		Me.lblJobNum = New System.Windows.Forms.Label
		Me.lblStationNum = New System.Windows.Forms.Label
		Me.grbFieldWork = New System.Windows.Forms.GroupBox
		Me.cmbPayItem = New System.Windows.Forms.ComboBox
		Me.lblFieldPayItemCode = New System.Windows.Forms.Label
		Me.lblFieldDescription = New System.Windows.Forms.Label
		Me.rtxtFieldNotes = New System.Windows.Forms.RichTextBox
		Me.lblFieldUnits = New System.Windows.Forms.Label
		Me.txtQty = New System.Windows.Forms.TextBox
		Me.lblFieldNotes = New System.Windows.Forms.Label
		Me.lblFieldQty = New System.Windows.Forms.Label
		Me.lblFieldDate = New System.Windows.Forms.Label
		Me.lblFieldName = New System.Windows.Forms.Label
		Me.lblFieldId = New System.Windows.Forms.Label
		Me.grbConfirmedWork = New System.Windows.Forms.GroupBox
		Me.lblConfSite = New System.Windows.Forms.Label
		Me.lblStatus = New System.Windows.Forms.Label
		Me.lblConfContQtyUnits = New System.Windows.Forms.Label
		Me.lblConfContractQty = New System.Windows.Forms.Label
		Me.lblConfQty = New System.Windows.Forms.Label
		Me.lblCapContractQty = New System.Windows.Forms.Label
		Me.rtxtConfNotes = New System.Windows.Forms.RichTextBox
		Me.lblConfQtyUnits = New System.Windows.Forms.Label
		Me.lblConfNotes = New System.Windows.Forms.Label
		Me.lblCapConfQty = New System.Windows.Forms.Label
		Me.lblConfDescription = New System.Windows.Forms.Label
		Me.lblConfDate = New System.Windows.Forms.Label
		Me.lblConfName = New System.Windows.Forms.Label
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblConfId = New System.Windows.Forms.Label
		Me.btnPrev = New System.Windows.Forms.Button
		Me.btnNext = New System.Windows.Forms.Button
		Me.lblRecordCount = New System.Windows.Forms.Label
		Me.lblSignCode = New System.Windows.Forms.Label
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.btnUpdate = New System.Windows.Forms.Button
		Me.dgvNPI = New System.Windows.Forms.DataGridView
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.rbtnWarehouse = New System.Windows.Forms.RadioButton
		Me.rbtnUnconfirmed = New System.Windows.Forms.RadioButton
		Me.btnMove = New System.Windows.Forms.Button
		Me.btnViewNPiDGV = New System.Windows.Forms.Button
		Me.btnViewDGV = New System.Windows.Forms.Button
		Me.btnLoadDataSync = New System.Windows.Forms.Button
		Me.btnDownloadDP = New System.Windows.Forms.Button
		Me.dgvDPlist = New System.Windows.Forms.DataGridView
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryUsersDisplayNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryUsersDisplayNamesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
		Me.btnRefresh = New System.Windows.Forms.Button
		Me.grbFieldWork.SuspendLayout()
		Me.grbConfirmedWork.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvNPI, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.dgvDPlist, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblJobNum
		'
		Me.lblJobNum.BackColor = System.Drawing.Color.WhiteSmoke
		Me.lblJobNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblJobNum.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNum.Location = New System.Drawing.Point(344, 55)
		Me.lblJobNum.Name = "lblJobNum"
		Me.lblJobNum.Size = New System.Drawing.Size(165, 42)
		Me.lblJobNum.TabIndex = 0
		Me.lblJobNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblStationNum
		'
		Me.lblStationNum.BackColor = System.Drawing.Color.Transparent
		Me.lblStationNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblStationNum.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblStationNum.Font = New System.Drawing.Font("Arial Black", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStationNum.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblStationNum.Location = New System.Drawing.Point(0, 0)
		Me.lblStationNum.Name = "lblStationNum"
		Me.lblStationNum.Padding = New System.Windows.Forms.Padding(96, 0, 0, 0)
		Me.lblStationNum.Size = New System.Drawing.Size(853, 52)
		Me.lblStationNum.TabIndex = 1
		Me.lblStationNum.Text = "Station Number"
		Me.lblStationNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'grbFieldWork
		'
		Me.grbFieldWork.Controls.Add(Me.cmbPayItem)
		Me.grbFieldWork.Controls.Add(Me.lblFieldPayItemCode)
		Me.grbFieldWork.Controls.Add(Me.lblFieldDescription)
		Me.grbFieldWork.Controls.Add(Me.rtxtFieldNotes)
		Me.grbFieldWork.Controls.Add(Me.lblFieldUnits)
		Me.grbFieldWork.Controls.Add(Me.txtQty)
		Me.grbFieldWork.Controls.Add(Me.lblFieldNotes)
		Me.grbFieldWork.Controls.Add(Me.lblFieldQty)
		Me.grbFieldWork.Controls.Add(Me.lblFieldDate)
		Me.grbFieldWork.Controls.Add(Me.lblFieldName)
		Me.grbFieldWork.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grbFieldWork.Location = New System.Drawing.Point(3, 65)
		Me.grbFieldWork.Name = "grbFieldWork"
		Me.grbFieldWork.Size = New System.Drawing.Size(338, 349)
		Me.grbFieldWork.TabIndex = 2
		Me.grbFieldWork.TabStop = False
		Me.grbFieldWork.Text = "Field Work:"
		'
		'cmbPayItem
		'
		Me.cmbPayItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
		Me.cmbPayItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPayItem.Dock = System.Windows.Forms.DockStyle.Top
		Me.cmbPayItem.FormattingEnabled = True
		Me.cmbPayItem.Location = New System.Drawing.Point(3, 161)
		Me.cmbPayItem.Name = "cmbPayItem"
		Me.cmbPayItem.Size = New System.Drawing.Size(332, 26)
		Me.cmbPayItem.TabIndex = 3
		Me.cmbPayItem.Visible = False
		'
		'lblFieldPayItemCode
		'
		Me.lblFieldPayItemCode.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblFieldPayItemCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldPayItemCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblFieldPayItemCode.Location = New System.Drawing.Point(3, 137)
		Me.lblFieldPayItemCode.Name = "lblFieldPayItemCode"
		Me.lblFieldPayItemCode.Size = New System.Drawing.Size(332, 24)
		Me.lblFieldPayItemCode.TabIndex = 1
		Me.lblFieldPayItemCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblFieldDescription
		'
		Me.lblFieldDescription.BackColor = System.Drawing.Color.Snow
		Me.lblFieldDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblFieldDescription.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblFieldDescription.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldDescription.ForeColor = System.Drawing.Color.DarkOliveGreen
		Me.lblFieldDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblFieldDescription.Location = New System.Drawing.Point(3, 97)
		Me.lblFieldDescription.Name = "lblFieldDescription"
		Me.lblFieldDescription.Size = New System.Drawing.Size(332, 40)
		Me.lblFieldDescription.TabIndex = 2
		Me.lblFieldDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'rtxtFieldNotes
		'
		Me.rtxtFieldNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtFieldNotes.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.rtxtFieldNotes.Location = New System.Drawing.Point(3, 290)
		Me.rtxtFieldNotes.Name = "rtxtFieldNotes"
		Me.rtxtFieldNotes.ShowSelectionMargin = True
		Me.rtxtFieldNotes.Size = New System.Drawing.Size(332, 56)
		Me.rtxtFieldNotes.TabIndex = 8
		Me.rtxtFieldNotes.Text = ""
		'
		'lblFieldUnits
		'
		Me.lblFieldUnits.AutoSize = True
		Me.lblFieldUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldUnits.Location = New System.Drawing.Point(279, 239)
		Me.lblFieldUnits.Name = "lblFieldUnits"
		Me.lblFieldUnits.Size = New System.Drawing.Size(0, 14)
		Me.lblFieldUnits.TabIndex = 7
		'
		'txtQty
		'
		Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtQty.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQty.Location = New System.Drawing.Point(126, 215)
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Size = New System.Drawing.Size(151, 48)
		Me.txtQty.TabIndex = 6
		Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblFieldNotes
		'
		Me.lblFieldNotes.AutoSize = True
		Me.lblFieldNotes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldNotes.Location = New System.Drawing.Point(0, 273)
		Me.lblFieldNotes.Name = "lblFieldNotes"
		Me.lblFieldNotes.Size = New System.Drawing.Size(38, 14)
		Me.lblFieldNotes.TabIndex = 5
		Me.lblFieldNotes.Text = "Notes:"
		'
		'lblFieldQty
		'
		Me.lblFieldQty.AutoSize = True
		Me.lblFieldQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldQty.Location = New System.Drawing.Point(43, 239)
		Me.lblFieldQty.Name = "lblFieldQty"
		Me.lblFieldQty.Size = New System.Drawing.Size(77, 14)
		Me.lblFieldQty.TabIndex = 4
		Me.lblFieldQty.Text = "Submitted Qty:"
		'
		'lblFieldDate
		'
		Me.lblFieldDate.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblFieldDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblFieldDate.Location = New System.Drawing.Point(3, 72)
		Me.lblFieldDate.Name = "lblFieldDate"
		Me.lblFieldDate.Size = New System.Drawing.Size(332, 25)
		Me.lblFieldDate.TabIndex = 1
		Me.lblFieldDate.Text = "--.--.----"
		Me.lblFieldDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblFieldName
		'
		Me.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblFieldName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldName.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.lblFieldName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblFieldName.Location = New System.Drawing.Point(3, 22)
		Me.lblFieldName.Name = "lblFieldName"
		Me.lblFieldName.Size = New System.Drawing.Size(332, 50)
		Me.lblFieldName.TabIndex = 0
		Me.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblFieldId
		'
		Me.lblFieldId.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFieldId.Location = New System.Drawing.Point(344, 385)
		Me.lblFieldId.Name = "lblFieldId"
		Me.lblFieldId.Size = New System.Drawing.Size(81, 22)
		Me.lblFieldId.TabIndex = 17
		'
		'grbConfirmedWork
		'
		Me.grbConfirmedWork.Controls.Add(Me.lblConfSite)
		Me.grbConfirmedWork.Controls.Add(Me.lblStatus)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfContQtyUnits)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfContractQty)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfQty)
		Me.grbConfirmedWork.Controls.Add(Me.lblCapContractQty)
		Me.grbConfirmedWork.Controls.Add(Me.rtxtConfNotes)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfQtyUnits)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfNotes)
		Me.grbConfirmedWork.Controls.Add(Me.lblCapConfQty)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfDescription)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfDate)
		Me.grbConfirmedWork.Controls.Add(Me.lblConfName)
		Me.grbConfirmedWork.Controls.Add(Me.ShapeContainer1)
		Me.grbConfirmedWork.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grbConfirmedWork.Location = New System.Drawing.Point(512, 65)
		Me.grbConfirmedWork.Name = "grbConfirmedWork"
		Me.grbConfirmedWork.Size = New System.Drawing.Size(338, 349)
		Me.grbConfirmedWork.TabIndex = 9
		Me.grbConfirmedWork.TabStop = False
		Me.grbConfirmedWork.Text = "Confirmed Work:"
		'
		'lblConfSite
		'
		Me.lblConfSite.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblConfSite.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblConfSite.Location = New System.Drawing.Point(3, 187)
		Me.lblConfSite.Name = "lblConfSite"
		Me.lblConfSite.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
		Me.lblConfSite.Size = New System.Drawing.Size(332, 24)
		Me.lblConfSite.TabIndex = 17
		Me.lblConfSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblStatus
		'
		Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblStatus.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Location = New System.Drawing.Point(3, 137)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(332, 50)
		Me.lblStatus.TabIndex = 13
		Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblConfContQtyUnits
		'
		Me.lblConfContQtyUnits.AutoSize = True
		Me.lblConfContQtyUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfContQtyUnits.Location = New System.Drawing.Point(232, 217)
		Me.lblConfContQtyUnits.Name = "lblConfContQtyUnits"
		Me.lblConfContQtyUnits.Size = New System.Drawing.Size(0, 14)
		Me.lblConfContQtyUnits.TabIndex = 12
		'
		'lblConfContractQty
		'
		Me.lblConfContractQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblConfContractQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfContractQty.Location = New System.Drawing.Point(164, 213)
		Me.lblConfContractQty.Name = "lblConfContractQty"
		Me.lblConfContractQty.Size = New System.Drawing.Size(65, 22)
		Me.lblConfContractQty.TabIndex = 11
		Me.lblConfContractQty.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblConfQty
		'
		Me.lblConfQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblConfQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfQty.Location = New System.Drawing.Point(164, 244)
		Me.lblConfQty.Name = "lblConfQty"
		Me.lblConfQty.Size = New System.Drawing.Size(65, 22)
		Me.lblConfQty.TabIndex = 10
		Me.lblConfQty.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblCapContractQty
		'
		Me.lblCapContractQty.AutoSize = True
		Me.lblCapContractQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCapContractQty.Location = New System.Drawing.Point(93, 217)
		Me.lblCapContractQty.Name = "lblCapContractQty"
		Me.lblCapContractQty.Size = New System.Drawing.Size(71, 14)
		Me.lblCapContractQty.TabIndex = 9
		Me.lblCapContractQty.Text = "Contract Qty:"
		Me.lblCapContractQty.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'rtxtConfNotes
		'
		Me.rtxtConfNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtConfNotes.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.rtxtConfNotes.Location = New System.Drawing.Point(3, 290)
		Me.rtxtConfNotes.Name = "rtxtConfNotes"
		Me.rtxtConfNotes.Size = New System.Drawing.Size(332, 56)
		Me.rtxtConfNotes.TabIndex = 8
		Me.rtxtConfNotes.Text = ""
		'
		'lblConfQtyUnits
		'
		Me.lblConfQtyUnits.AutoSize = True
		Me.lblConfQtyUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfQtyUnits.Location = New System.Drawing.Point(234, 248)
		Me.lblConfQtyUnits.Name = "lblConfQtyUnits"
		Me.lblConfQtyUnits.Size = New System.Drawing.Size(0, 14)
		Me.lblConfQtyUnits.TabIndex = 7
		'
		'lblConfNotes
		'
		Me.lblConfNotes.AutoSize = True
		Me.lblConfNotes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfNotes.Location = New System.Drawing.Point(0, 273)
		Me.lblConfNotes.Name = "lblConfNotes"
		Me.lblConfNotes.Size = New System.Drawing.Size(38, 14)
		Me.lblConfNotes.TabIndex = 5
		Me.lblConfNotes.Text = "Notes:"
		'
		'lblCapConfQty
		'
		Me.lblCapConfQty.AutoSize = True
		Me.lblCapConfQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCapConfQty.Location = New System.Drawing.Point(87, 248)
		Me.lblCapConfQty.Name = "lblCapConfQty"
		Me.lblCapConfQty.Size = New System.Drawing.Size(77, 14)
		Me.lblCapConfQty.TabIndex = 4
		Me.lblCapConfQty.Text = "Submitted Qty:"
		Me.lblCapConfQty.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblConfDescription
		'
		Me.lblConfDescription.BackColor = System.Drawing.Color.Snow
		Me.lblConfDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblConfDescription.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblConfDescription.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfDescription.ForeColor = System.Drawing.Color.DarkOliveGreen
		Me.lblConfDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblConfDescription.Location = New System.Drawing.Point(3, 97)
		Me.lblConfDescription.Name = "lblConfDescription"
		Me.lblConfDescription.Size = New System.Drawing.Size(332, 40)
		Me.lblConfDescription.TabIndex = 18
		Me.lblConfDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblConfDate
		'
		Me.lblConfDate.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblConfDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblConfDate.Location = New System.Drawing.Point(3, 72)
		Me.lblConfDate.Name = "lblConfDate"
		Me.lblConfDate.Size = New System.Drawing.Size(332, 25)
		Me.lblConfDate.TabIndex = 20
		Me.lblConfDate.Text = "--.--.----"
		Me.lblConfDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblConfName
		'
		Me.lblConfName.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblConfName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfName.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.lblConfName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblConfName.Location = New System.Drawing.Point(3, 22)
		Me.lblConfName.Name = "lblConfName"
		Me.lblConfName.Size = New System.Drawing.Size(332, 50)
		Me.lblConfName.TabIndex = 19
		Me.lblConfName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(3, 22)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
		Me.ShapeContainer1.Size = New System.Drawing.Size(332, 324)
		Me.ShapeContainer1.TabIndex = 21
		Me.ShapeContainer1.TabStop = False
		'
		'LineShape1
		'
		Me.LineShape1.BorderColor = System.Drawing.Color.Black
		Me.LineShape1.Name = "LineShape1"
		Me.LineShape1.X1 = 257
		Me.LineShape1.X2 = 70
		Me.LineShape1.Y1 = 217
		Me.LineShape1.Y2 = 217
		'
		'lblConfId
		'
		Me.lblConfId.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConfId.Location = New System.Drawing.Point(431, 385)
		Me.lblConfId.Name = "lblConfId"
		Me.lblConfId.Size = New System.Drawing.Size(80, 22)
		Me.lblConfId.TabIndex = 18
		Me.lblConfId.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'btnPrev
		'
		Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrev.Location = New System.Drawing.Point(344, 353)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(29, 29)
		Me.btnPrev.TabIndex = 10
		Me.btnPrev.Text = "<"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'btnNext
		'
		Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNext.Location = New System.Drawing.Point(480, 353)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(29, 29)
		Me.btnNext.TabIndex = 11
		Me.btnNext.Text = ">>"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'lblRecordCount
		'
		Me.lblRecordCount.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblRecordCount.Location = New System.Drawing.Point(379, 362)
		Me.lblRecordCount.Name = "lblRecordCount"
		Me.lblRecordCount.Size = New System.Drawing.Size(95, 13)
		Me.lblRecordCount.TabIndex = 12
		Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSignCode
		'
		Me.lblSignCode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSignCode.ForeColor = System.Drawing.Color.DimGray
		Me.lblSignCode.Location = New System.Drawing.Point(347, 272)
		Me.lblSignCode.Name = "lblSignCode"
		Me.lblSignCode.Size = New System.Drawing.Size(164, 22)
		Me.lblSignCode.TabIndex = 13
		Me.lblSignCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.White
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Location = New System.Drawing.Point(344, 162)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(165, 108)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBox1.TabIndex = 14
		Me.PictureBox1.TabStop = False
		'
		'btnUpdate
		'
		Me.btnUpdate.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUpdate.Location = New System.Drawing.Point(344, 298)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(165, 47)
		Me.btnUpdate.TabIndex = 15
		Me.btnUpdate.Text = "-->"
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'dgvNPI
		'
		Me.dgvNPI.AllowUserToAddRows = False
		Me.dgvNPI.AllowUserToDeleteRows = False
		Me.dgvNPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvNPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvNPI.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.dgvNPI.Location = New System.Drawing.Point(0, 420)
		Me.dgvNPI.Name = "dgvNPI"
		Me.dgvNPI.ReadOnly = True
		Me.dgvNPI.RowHeadersVisible = False
		Me.dgvNPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvNPI.Size = New System.Drawing.Size(853, 116)
		Me.dgvNPI.TabIndex = 16
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnRefresh)
		Me.SplitContainer1.Panel1.Controls.Add(Me.rbtnWarehouse)
		Me.SplitContainer1.Panel1.Controls.Add(Me.rbtnUnconfirmed)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnMove)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnViewNPiDGV)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnViewDGV)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnLoadDataSync)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnDownloadDP)
		Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDPlist)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblConfId)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblFieldId)
		Me.SplitContainer1.Panel2.Controls.Add(Me.grbFieldWork)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpdate)
		Me.SplitContainer1.Panel2.Controls.Add(Me.dgvNPI)
		Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblJobNum)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblSignCode)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblStationNum)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lblRecordCount)
		Me.SplitContainer1.Panel2.Controls.Add(Me.grbConfirmedWork)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnNext)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnPrev)
		Me.SplitContainer1.Size = New System.Drawing.Size(1058, 536)
		Me.SplitContainer1.SplitterDistance = 201
		Me.SplitContainer1.TabIndex = 17
		'
		'rbtnWarehouse
		'
		Me.rbtnWarehouse.AutoSize = True
		Me.rbtnWarehouse.Location = New System.Drawing.Point(102, 420)
		Me.rbtnWarehouse.Name = "rbtnWarehouse"
		Me.rbtnWarehouse.Size = New System.Drawing.Size(80, 17)
		Me.rbtnWarehouse.TabIndex = 24
		Me.rbtnWarehouse.Text = "Warehouse"
		Me.rbtnWarehouse.UseVisualStyleBackColor = True
		'
		'rbtnUnconfirmed
		'
		Me.rbtnUnconfirmed.AutoSize = True
		Me.rbtnUnconfirmed.Location = New System.Drawing.Point(12, 420)
		Me.rbtnUnconfirmed.Name = "rbtnUnconfirmed"
		Me.rbtnUnconfirmed.Size = New System.Drawing.Size(85, 17)
		Me.rbtnUnconfirmed.TabIndex = 23
		Me.rbtnUnconfirmed.Text = "Unconfirmed"
		Me.rbtnUnconfirmed.UseVisualStyleBackColor = True
		'
		'btnMove
		'
		Me.btnMove.Location = New System.Drawing.Point(3, 507)
		Me.btnMove.Name = "btnMove"
		Me.btnMove.Size = New System.Drawing.Size(94, 23)
		Me.btnMove.TabIndex = 22
		Me.btnMove.Text = "&Move"
		Me.btnMove.UseVisualStyleBackColor = True
		'
		'btnViewNPiDGV
		'
		Me.btnViewNPiDGV.Location = New System.Drawing.Point(103, 478)
		Me.btnViewNPiDGV.Name = "btnViewNPiDGV"
		Me.btnViewNPiDGV.Size = New System.Drawing.Size(89, 23)
		Me.btnViewNPiDGV.TabIndex = 21
		Me.btnViewNPiDGV.Text = "NPiTableView"
		Me.btnViewNPiDGV.UseVisualStyleBackColor = True
		'
		'btnViewDGV
		'
		Me.btnViewDGV.Location = New System.Drawing.Point(103, 449)
		Me.btnViewDGV.Name = "btnViewDGV"
		Me.btnViewDGV.Size = New System.Drawing.Size(89, 23)
		Me.btnViewDGV.TabIndex = 20
		Me.btnViewDGV.Text = "TableView"
		Me.btnViewDGV.UseVisualStyleBackColor = True
		'
		'btnLoadDataSync
		'
		Me.btnLoadDataSync.Location = New System.Drawing.Point(3, 449)
		Me.btnLoadDataSync.Name = "btnLoadDataSync"
		Me.btnLoadDataSync.Size = New System.Drawing.Size(94, 23)
		Me.btnLoadDataSync.TabIndex = 19
		Me.btnLoadDataSync.Text = "Load Selected"
		Me.btnLoadDataSync.UseVisualStyleBackColor = True
		'
		'btnDownloadDP
		'
		Me.btnDownloadDP.Location = New System.Drawing.Point(3, 478)
		Me.btnDownloadDP.Name = "btnDownloadDP"
		Me.btnDownloadDP.Size = New System.Drawing.Size(94, 23)
		Me.btnDownloadDP.TabIndex = 17
		Me.btnDownloadDP.Text = "Download"
		Me.btnDownloadDP.UseVisualStyleBackColor = True
		'
		'dgvDPlist
		'
		Me.dgvDPlist.AllowUserToAddRows = False
		Me.dgvDPlist.AllowUserToDeleteRows = False
		Me.dgvDPlist.AllowUserToResizeColumns = False
		Me.dgvDPlist.AllowUserToResizeRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
		Me.dgvDPlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvDPlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDPlist.BackgroundColor = System.Drawing.Color.White
		Me.dgvDPlist.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvDPlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvDPlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDPlist.Dock = System.Windows.Forms.DockStyle.Top
		Me.dgvDPlist.GridColor = System.Drawing.Color.White
		Me.dgvDPlist.Location = New System.Drawing.Point(0, 0)
		Me.dgvDPlist.Name = "dgvDPlist"
		Me.dgvDPlist.ReadOnly = True
		Me.dgvDPlist.RowHeadersVisible = False
		Me.dgvDPlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDPlist.Size = New System.Drawing.Size(201, 414)
		Me.dgvDPlist.TabIndex = 18
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
		'btnRefresh
		'
		Me.btnRefresh.Location = New System.Drawing.Point(103, 507)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(89, 23)
		Me.btnRefresh.TabIndex = 25
		Me.btnRefresh.Text = "Refresh"
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'frmMergeDP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1058, 536)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmMergeDP"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Confirm Submitted Productions"
		Me.grbFieldWork.ResumeLayout(False)
		Me.grbFieldWork.PerformLayout()
		Me.grbConfirmedWork.ResumeLayout(False)
		Me.grbConfirmedWork.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvNPI, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.PerformLayout()
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.dgvDPlist, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblJobNum As System.Windows.Forms.Label
	Friend WithEvents lblStationNum As System.Windows.Forms.Label
	Friend WithEvents grbFieldWork As System.Windows.Forms.GroupBox
	Friend WithEvents lblFieldName As System.Windows.Forms.Label
	Friend WithEvents lblFieldDate As System.Windows.Forms.Label
	Friend WithEvents lblFieldNotes As System.Windows.Forms.Label
	Friend WithEvents lblFieldQty As System.Windows.Forms.Label
	Friend WithEvents cmbPayItem As System.Windows.Forms.ComboBox
	Friend WithEvents lblFieldDescription As System.Windows.Forms.Label
	Friend WithEvents rtxtFieldNotes As System.Windows.Forms.RichTextBox
	Friend WithEvents lblFieldUnits As System.Windows.Forms.Label
	Friend WithEvents txtQty As System.Windows.Forms.TextBox
	Friend WithEvents grbConfirmedWork As System.Windows.Forms.GroupBox
	Friend WithEvents rtxtConfNotes As System.Windows.Forms.RichTextBox
	Friend WithEvents lblConfQtyUnits As System.Windows.Forms.Label
	Friend WithEvents lblConfNotes As System.Windows.Forms.Label
	Friend WithEvents lblCapConfQty As System.Windows.Forms.Label
	Friend WithEvents lblCapContractQty As System.Windows.Forms.Label
	Friend WithEvents lblConfQty As System.Windows.Forms.Label
	Friend WithEvents lblConfContractQty As System.Windows.Forms.Label
	Friend WithEvents lblConfContQtyUnits As System.Windows.Forms.Label
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents lblRecordCount As System.Windows.Forms.Label
	Friend WithEvents lblSignCode As System.Windows.Forms.Label
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents btnUpdate As System.Windows.Forms.Button
	Friend WithEvents dgvNPI As System.Windows.Forms.DataGridView
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents lblStatus As System.Windows.Forms.Label
	Friend WithEvents dgvDPlist As System.Windows.Forms.DataGridView
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryUsersDisplayNamesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryUsersDisplayNamesTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
	Friend WithEvents btnDownloadDP As System.Windows.Forms.Button
	Friend WithEvents btnLoadDataSync As System.Windows.Forms.Button
	Friend WithEvents lblFieldId As System.Windows.Forms.Label
	Friend WithEvents lblConfId As System.Windows.Forms.Label
	Friend WithEvents lblFieldPayItemCode As System.Windows.Forms.Label
	Friend WithEvents lblConfDescription As System.Windows.Forms.Label
	Friend WithEvents lblConfName As System.Windows.Forms.Label
	Friend WithEvents lblConfDate As System.Windows.Forms.Label
	Friend WithEvents lblConfSite As System.Windows.Forms.Label
	Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents btnViewDGV As System.Windows.Forms.Button
	Friend WithEvents btnViewNPiDGV As System.Windows.Forms.Button
	Friend WithEvents btnMove As System.Windows.Forms.Button
	Friend WithEvents rbtnWarehouse As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnUnconfirmed As System.Windows.Forms.RadioButton
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
