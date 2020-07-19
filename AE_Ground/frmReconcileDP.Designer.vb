<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReconcileDP
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.pnlReviewMain = New System.Windows.Forms.Panel
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.lblCloudDisplayName = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.lblCQty = New System.Windows.Forms.Label
		Me.lblDescription = New System.Windows.Forms.Label
		Me.lblSite = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.cmbPayItems = New System.Windows.Forms.ComboBox
		Me.txtSiteNotes = New System.Windows.Forms.TextBox
		Me.txtQty = New System.Windows.Forms.TextBox
		Me.txtCloudStation = New System.Windows.Forms.TextBox
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
		Me.ListBox1 = New System.Windows.Forms.ListBox
		Me.btnGetDataSync = New System.Windows.Forms.Button
		Me.btnLoadCloudDP = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.cmbJobs = New System.Windows.Forms.ComboBox
		Me.pnlAE = New System.Windows.Forms.Panel
		Me.dgvCloudDP = New System.Windows.Forms.DataGridView
		Me.pnlATM = New System.Windows.Forms.Panel
		Me.dgvDailyProductions = New System.Windows.Forms.DataGridView
		Me.pnlReviewMain.SuspendLayout()
		Me.pnlAE.SuspendLayout()
		CType(Me.dgvCloudDP, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlATM.SuspendLayout()
		CType(Me.dgvDailyProductions, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlReviewMain
		'
		Me.pnlReviewMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.pnlReviewMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlReviewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlReviewMain.Controls.Add(Me.Label8)
		Me.pnlReviewMain.Controls.Add(Me.Label7)
		Me.pnlReviewMain.Controls.Add(Me.lblCloudDisplayName)
		Me.pnlReviewMain.Controls.Add(Me.Label6)
		Me.pnlReviewMain.Controls.Add(Me.lblCQty)
		Me.pnlReviewMain.Controls.Add(Me.lblDescription)
		Me.pnlReviewMain.Controls.Add(Me.lblSite)
		Me.pnlReviewMain.Controls.Add(Me.Label2)
		Me.pnlReviewMain.Controls.Add(Me.cmbPayItems)
		Me.pnlReviewMain.Controls.Add(Me.txtSiteNotes)
		Me.pnlReviewMain.Controls.Add(Me.txtQty)
		Me.pnlReviewMain.Controls.Add(Me.txtCloudStation)
		Me.pnlReviewMain.Controls.Add(Me.DateTimePicker1)
		Me.pnlReviewMain.Controls.Add(Me.ListBox1)
		Me.pnlReviewMain.Controls.Add(Me.btnGetDataSync)
		Me.pnlReviewMain.Controls.Add(Me.btnLoadCloudDP)
		Me.pnlReviewMain.Controls.Add(Me.Label1)
		Me.pnlReviewMain.Controls.Add(Me.cmbJobs)
		Me.pnlReviewMain.Controls.Add(Me.pnlAE)
		Me.pnlReviewMain.Controls.Add(Me.pnlATM)
		Me.pnlReviewMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlReviewMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlReviewMain.Name = "pnlReviewMain"
		Me.pnlReviewMain.Size = New System.Drawing.Size(1008, 492)
		Me.pnlReviewMain.TabIndex = 0
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(730, 455)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(29, 16)
		Me.Label8.TabIndex = 60
		Me.Label8.Text = "pID"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(684, 455)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(29, 16)
		Me.Label7.TabIndex = 59
		Me.Label7.Text = "pID"
		'
		'lblCloudDisplayName
		'
		Me.lblCloudDisplayName.AutoSize = True
		Me.lblCloudDisplayName.BackColor = System.Drawing.Color.Transparent
		Me.lblCloudDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCloudDisplayName.Location = New System.Drawing.Point(825, 10)
		Me.lblCloudDisplayName.Name = "lblCloudDisplayName"
		Me.lblCloudDisplayName.Size = New System.Drawing.Size(136, 16)
		Me.lblCloudDisplayName.TabIndex = 58
		Me.lblCloudDisplayName.Text = "Cloud - DisplayName"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(615, 420)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(144, 16)
		Me.Label6.TabIndex = 57
		Me.Label6.Text = "Production - Site Notes"
		'
		'lblCQty
		'
		Me.lblCQty.AutoSize = True
		Me.lblCQty.BackColor = System.Drawing.Color.Transparent
		Me.lblCQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCQty.Location = New System.Drawing.Point(505, 296)
		Me.lblCQty.Name = "lblCQty"
		Me.lblCQty.Size = New System.Drawing.Size(154, 16)
		Me.lblCQty.TabIndex = 56
		Me.lblCQty.Text = "Production - Contract Qty"
		'
		'lblDescription
		'
		Me.lblDescription.AutoSize = True
		Me.lblDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.Location = New System.Drawing.Point(505, 325)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(131, 16)
		Me.lblDescription.TabIndex = 55
		Me.lblDescription.Text = "Production - PayItem"
		'
		'lblSite
		'
		Me.lblSite.AutoSize = True
		Me.lblSite.BackColor = System.Drawing.Color.Transparent
		Me.lblSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSite.Location = New System.Drawing.Point(505, 235)
		Me.lblSite.Name = "lblSite"
		Me.lblSite.Size = New System.Drawing.Size(158, 16)
		Me.lblSite.TabIndex = 54
		Me.lblSite.Text = "Production Station # (site)"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(44, 465)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(479, 17)
		Me.Label2.TabIndex = 53
		Me.Label2.Text = "TODO:  Create Station#/ID Dictionary to give option of changing to different stat" & _
			"ion number."
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'cmbPayItems
		'
		Me.cmbPayItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbPayItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbPayItems.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPayItems.FormattingEnabled = True
		Me.cmbPayItems.Location = New System.Drawing.Point(253, 324)
		Me.cmbPayItems.Name = "cmbPayItems"
		Me.cmbPayItems.Size = New System.Drawing.Size(246, 32)
		Me.cmbPayItems.TabIndex = 52
		Me.cmbPayItems.Text = "PayItem"
		'
		'txtSiteNotes
		'
		Me.txtSiteNotes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSiteNotes.Location = New System.Drawing.Point(253, 362)
		Me.txtSiteNotes.Multiline = True
		Me.txtSiteNotes.Name = "txtSiteNotes"
		Me.txtSiteNotes.Size = New System.Drawing.Size(246, 53)
		Me.txtSiteNotes.TabIndex = 48
		Me.txtSiteNotes.Text = "textklhlkjhlkjh"
		'
		'txtQty
		'
		Me.txtQty.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQty.Location = New System.Drawing.Point(253, 268)
		Me.txtQty.Name = "txtQty"
		Me.txtQty.Size = New System.Drawing.Size(246, 41)
		Me.txtQty.TabIndex = 47
		Me.txtQty.Text = "Qty"
		Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtCloudStation
		'
		Me.txtCloudStation.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCloudStation.Location = New System.Drawing.Point(253, 230)
		Me.txtCloudStation.Name = "txtCloudStation"
		Me.txtCloudStation.Size = New System.Drawing.Size(246, 32)
		Me.txtCloudStation.TabIndex = 46
		Me.txtCloudStation.Text = "17023 12.000+BR"
		Me.txtCloudStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker1.CustomFormat = "MM.dd.yyyy"
		Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.DateTimePicker1.Location = New System.Drawing.Point(20, 9)
		Me.DateTimePicker1.MaxDate = New Date(2012, 7, 5, 0, 0, 0, 0)
		Me.DateTimePicker1.MinDate = New Date(2011, 6, 5, 0, 0, 0, 0)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.ShowCheckBox = True
		Me.DateTimePicker1.Size = New System.Drawing.Size(159, 35)
		Me.DateTimePicker1.TabIndex = 45
		Me.DateTimePicker1.Value = New Date(2011, 6, 5, 0, 0, 0, 0)
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(782, 397)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(194, 56)
		Me.ListBox1.TabIndex = 14
		'
		'btnGetDataSync
		'
		Me.btnGetDataSync.Location = New System.Drawing.Point(845, 201)
		Me.btnGetDataSync.Name = "btnGetDataSync"
		Me.btnGetDataSync.Size = New System.Drawing.Size(140, 23)
		Me.btnGetDataSync.TabIndex = 3
		Me.btnGetDataSync.Text = "Get DataSync"
		Me.btnGetDataSync.UseVisualStyleBackColor = True
		'
		'btnLoadCloudDP
		'
		Me.btnLoadCloudDP.Location = New System.Drawing.Point(845, 230)
		Me.btnLoadCloudDP.Name = "btnLoadCloudDP"
		Me.btnLoadCloudDP.Size = New System.Drawing.Size(140, 23)
		Me.btnLoadCloudDP.TabIndex = 6
		Me.btnLoadCloudDP.Text = "Load Cloud DP"
		Me.btnLoadCloudDP.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(185, 33)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(77, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "JobDescription"
		'
		'cmbJobs
		'
		Me.cmbJobs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbJobs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbJobs.FormattingEnabled = True
		Me.cmbJobs.Location = New System.Drawing.Point(185, 9)
		Me.cmbJobs.Name = "cmbJobs"
		Me.cmbJobs.Size = New System.Drawing.Size(190, 21)
		Me.cmbJobs.TabIndex = 2
		Me.cmbJobs.Text = "JobNumber"
		'
		'pnlAE
		'
		Me.pnlAE.Controls.Add(Me.dgvCloudDP)
		Me.pnlAE.Location = New System.Drawing.Point(19, 49)
		Me.pnlAE.Name = "pnlAE"
		Me.pnlAE.Size = New System.Drawing.Size(480, 148)
		Me.pnlAE.TabIndex = 1
		'
		'dgvCloudDP
		'
		Me.dgvCloudDP.AllowUserToAddRows = False
		Me.dgvCloudDP.AllowUserToDeleteRows = False
		Me.dgvCloudDP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvCloudDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCloudDP.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvCloudDP.Location = New System.Drawing.Point(0, 0)
		Me.dgvCloudDP.Name = "dgvCloudDP"
		Me.dgvCloudDP.ReadOnly = True
		Me.dgvCloudDP.RowHeadersVisible = False
		Me.dgvCloudDP.Size = New System.Drawing.Size(480, 148)
		Me.dgvCloudDP.TabIndex = 34
		'
		'pnlATM
		'
		Me.pnlATM.Controls.Add(Me.dgvDailyProductions)
		Me.pnlATM.Location = New System.Drawing.Point(505, 49)
		Me.pnlATM.Name = "pnlATM"
		Me.pnlATM.Size = New System.Drawing.Size(480, 148)
		Me.pnlATM.TabIndex = 0
		'
		'dgvDailyProductions
		'
		Me.dgvDailyProductions.AllowUserToAddRows = False
		Me.dgvDailyProductions.AllowUserToDeleteRows = False
		Me.dgvDailyProductions.AllowUserToResizeRows = False
		Me.dgvDailyProductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvDailyProductions.BackgroundColor = System.Drawing.Color.White
		Me.dgvDailyProductions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDailyProductions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvDailyProductions.ColumnHeadersHeight = 18
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(1)
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDailyProductions.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvDailyProductions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvDailyProductions.EnableHeadersVisualStyles = False
		Me.dgvDailyProductions.GridColor = System.Drawing.Color.White
		Me.dgvDailyProductions.Location = New System.Drawing.Point(0, 0)
		Me.dgvDailyProductions.Margin = New System.Windows.Forms.Padding(2)
		Me.dgvDailyProductions.Name = "dgvDailyProductions"
		Me.dgvDailyProductions.ReadOnly = True
		Me.dgvDailyProductions.RowHeadersVisible = False
		Me.dgvDailyProductions.RowTemplate.Height = 26
		Me.dgvDailyProductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDailyProductions.Size = New System.Drawing.Size(480, 148)
		Me.dgvDailyProductions.TabIndex = 1
		Me.dgvDailyProductions.TabStop = False
		'
		'frmReconcileDP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1008, 492)
		Me.Controls.Add(Me.pnlReviewMain)
		Me.Name = "frmReconcileDP"
		Me.Text = "Review Submitted Productions"
		Me.pnlReviewMain.ResumeLayout(False)
		Me.pnlReviewMain.PerformLayout()
		Me.pnlAE.ResumeLayout(False)
		CType(Me.dgvCloudDP, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlATM.ResumeLayout(False)
		CType(Me.dgvDailyProductions, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlReviewMain As System.Windows.Forms.Panel
	Friend WithEvents pnlAE As System.Windows.Forms.Panel
	Friend WithEvents pnlATM As System.Windows.Forms.Panel
	Friend WithEvents cmbJobs As System.Windows.Forms.ComboBox
	Friend WithEvents dgvDailyProductions As System.Windows.Forms.DataGridView
	Friend WithEvents btnGetDataSync As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnLoadCloudDP As System.Windows.Forms.Button
	Friend WithEvents dgvCloudDP As System.Windows.Forms.DataGridView
	Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
	Friend WithEvents txtSiteNotes As System.Windows.Forms.TextBox
	Friend WithEvents txtQty As System.Windows.Forms.TextBox
	Friend WithEvents txtCloudStation As System.Windows.Forms.TextBox
	Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cmbPayItems As System.Windows.Forms.ComboBox
	Friend WithEvents lblSite As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents lblCQty As System.Windows.Forms.Label
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents lblCloudDisplayName As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
