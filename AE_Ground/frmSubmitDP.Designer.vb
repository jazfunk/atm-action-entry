<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubmitDP
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubmitDP))
		Me.cmbJobs = New System.Windows.Forms.ComboBox
		Me.QryActiveJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.dtpDpDate = New System.Windows.Forms.DateTimePicker
		Me.lblUserDisplayName = New System.Windows.Forms.Label
		Me.lblJobDescription = New System.Windows.Forms.Label
		Me.btnSubmitDataSync = New System.Windows.Forms.Button
		Me.DataGridView1 = New System.Windows.Forms.DataGridView
		Me.ForemanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.EntryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DisplayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JobNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.PayItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DpQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.SiteNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.QryMyDPTodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnWriteXML = New System.Windows.Forms.Button
		Me.QryActiveJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
		Me.QryMyDPTodayTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cmbJobs
		'
		Me.cmbJobs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbJobs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbJobs.DataSource = Me.QryActiveJobsBindingSource
		Me.cmbJobs.DisplayMember = "jobNum"
		Me.cmbJobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbJobs.FormattingEnabled = True
		Me.cmbJobs.Location = New System.Drawing.Point(12, 13)
		Me.cmbJobs.Name = "cmbJobs"
		Me.cmbJobs.Size = New System.Drawing.Size(132, 32)
		Me.cmbJobs.TabIndex = 0
		Me.cmbJobs.ValueMember = "jobNum"
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
		'dtpDpDate
		'
		Me.dtpDpDate.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDpDate.CustomFormat = "MM/dd/yyyy"
		Me.dtpDpDate.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDpDate.Location = New System.Drawing.Point(529, 12)
		Me.dtpDpDate.MaxDate = New Date(2153, 1, 1, 0, 0, 0, 0)
		Me.dtpDpDate.Name = "dtpDpDate"
		Me.dtpDpDate.ShowCheckBox = True
		Me.dtpDpDate.Size = New System.Drawing.Size(232, 35)
		Me.dtpDpDate.TabIndex = 45
		Me.dtpDpDate.Value = New Date(2011, 6, 7, 0, 0, 0, 0)
		'
		'lblUserDisplayName
		'
		Me.lblUserDisplayName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.AE_Ground.My.MySettings.Default, "ae_DisplayName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.lblUserDisplayName.Location = New System.Drawing.Point(237, 386)
		Me.lblUserDisplayName.Name = "lblUserDisplayName"
		Me.lblUserDisplayName.Size = New System.Drawing.Size(155, 35)
		Me.lblUserDisplayName.TabIndex = 47
		Me.lblUserDisplayName.Text = Global.AE_Ground.My.MySettings.Default.ae_DisplayName
		'
		'lblJobDescription
		'
		Me.lblJobDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblJobDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblJobDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryActiveJobsBindingSource, "location", True))
		Me.lblJobDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobDescription.Location = New System.Drawing.Point(150, 13)
		Me.lblJobDescription.Name = "lblJobDescription"
		Me.lblJobDescription.Size = New System.Drawing.Size(373, 32)
		Me.lblJobDescription.TabIndex = 48
		'
		'btnSubmitDataSync
		'
		Me.btnSubmitDataSync.Location = New System.Drawing.Point(398, 386)
		Me.btnSubmitDataSync.Name = "btnSubmitDataSync"
		Me.btnSubmitDataSync.Size = New System.Drawing.Size(363, 35)
		Me.btnSubmitDataSync.TabIndex = 49
		Me.btnSubmitDataSync.Text = "Submit Data Sync"
		Me.btnSubmitDataSync.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToOrderColumns = True
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ForemanDataGridViewTextBoxColumn, Me.EntryDateDataGridViewTextBoxColumn, Me.DisplayNameDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.DpIDDataGridViewTextBoxColumn, Me.JobNumDataGridViewTextBoxColumn, Me.SiteDataGridViewTextBoxColumn, Me.PayItemIDDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DpQtyDataGridViewTextBoxColumn, Me.SiteNotesDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.QryMyDPTodayBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(12, 52)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.Size = New System.Drawing.Size(749, 328)
		Me.DataGridView1.TabIndex = 50
		'
		'ForemanDataGridViewTextBoxColumn
		'
		Me.ForemanDataGridViewTextBoxColumn.DataPropertyName = "foreman"
		Me.ForemanDataGridViewTextBoxColumn.HeaderText = "foreman"
		Me.ForemanDataGridViewTextBoxColumn.Name = "ForemanDataGridViewTextBoxColumn"
		Me.ForemanDataGridViewTextBoxColumn.ReadOnly = True
		Me.ForemanDataGridViewTextBoxColumn.Visible = False
		'
		'EntryDateDataGridViewTextBoxColumn
		'
		Me.EntryDateDataGridViewTextBoxColumn.DataPropertyName = "entryDate"
		Me.EntryDateDataGridViewTextBoxColumn.HeaderText = "entryDate"
		Me.EntryDateDataGridViewTextBoxColumn.Name = "EntryDateDataGridViewTextBoxColumn"
		Me.EntryDateDataGridViewTextBoxColumn.ReadOnly = True
		Me.EntryDateDataGridViewTextBoxColumn.Visible = False
		'
		'DisplayNameDataGridViewTextBoxColumn
		'
		Me.DisplayNameDataGridViewTextBoxColumn.DataPropertyName = "displayName"
		Me.DisplayNameDataGridViewTextBoxColumn.HeaderText = "displayName"
		Me.DisplayNameDataGridViewTextBoxColumn.Name = "DisplayNameDataGridViewTextBoxColumn"
		Me.DisplayNameDataGridViewTextBoxColumn.ReadOnly = True
		Me.DisplayNameDataGridViewTextBoxColumn.Visible = False
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		Me.IDDataGridViewTextBoxColumn.ReadOnly = True
		Me.IDDataGridViewTextBoxColumn.Visible = False
		'
		'DpIDDataGridViewTextBoxColumn
		'
		Me.DpIDDataGridViewTextBoxColumn.DataPropertyName = "dpID"
		Me.DpIDDataGridViewTextBoxColumn.HeaderText = "dpID"
		Me.DpIDDataGridViewTextBoxColumn.Name = "DpIDDataGridViewTextBoxColumn"
		Me.DpIDDataGridViewTextBoxColumn.ReadOnly = True
		Me.DpIDDataGridViewTextBoxColumn.Visible = False
		'
		'JobNumDataGridViewTextBoxColumn
		'
		Me.JobNumDataGridViewTextBoxColumn.DataPropertyName = "jobNum"
		Me.JobNumDataGridViewTextBoxColumn.HeaderText = "Job #"
		Me.JobNumDataGridViewTextBoxColumn.Name = "JobNumDataGridViewTextBoxColumn"
		Me.JobNumDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SiteDataGridViewTextBoxColumn
		'
		Me.SiteDataGridViewTextBoxColumn.DataPropertyName = "site"
		Me.SiteDataGridViewTextBoxColumn.HeaderText = "Station #"
		Me.SiteDataGridViewTextBoxColumn.Name = "SiteDataGridViewTextBoxColumn"
		Me.SiteDataGridViewTextBoxColumn.ReadOnly = True
		'
		'PayItemIDDataGridViewTextBoxColumn
		'
		Me.PayItemIDDataGridViewTextBoxColumn.DataPropertyName = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn.HeaderText = "payItemID"
		Me.PayItemIDDataGridViewTextBoxColumn.Name = "PayItemIDDataGridViewTextBoxColumn"
		Me.PayItemIDDataGridViewTextBoxColumn.ReadOnly = True
		Me.PayItemIDDataGridViewTextBoxColumn.Visible = False
		'
		'CodeDataGridViewTextBoxColumn
		'
		Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
		Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
		Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
		Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
		Me.CodeDataGridViewTextBoxColumn.Visible = False
		'
		'DescriptionDataGridViewTextBoxColumn
		'
		Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
		Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Pay item Description"
		Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
		Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DpQtyDataGridViewTextBoxColumn
		'
		Me.DpQtyDataGridViewTextBoxColumn.DataPropertyName = "dpQty"
		Me.DpQtyDataGridViewTextBoxColumn.HeaderText = "Installed Qty"
		Me.DpQtyDataGridViewTextBoxColumn.Name = "DpQtyDataGridViewTextBoxColumn"
		Me.DpQtyDataGridViewTextBoxColumn.ReadOnly = True
		'
		'SiteNotesDataGridViewTextBoxColumn
		'
		Me.SiteNotesDataGridViewTextBoxColumn.DataPropertyName = "siteNotes"
		Me.SiteNotesDataGridViewTextBoxColumn.HeaderText = "Location Notes"
		Me.SiteNotesDataGridViewTextBoxColumn.Name = "SiteNotesDataGridViewTextBoxColumn"
		Me.SiteNotesDataGridViewTextBoxColumn.ReadOnly = True
		'
		'QryMyDPTodayBindingSource
		'
		Me.QryMyDPTodayBindingSource.DataMember = "qryMyDPToday"
		Me.QryMyDPTodayBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'btnWriteXML
		'
		Me.btnWriteXML.Location = New System.Drawing.Point(8, 386)
		Me.btnWriteXML.Name = "btnWriteXML"
		Me.btnWriteXML.Size = New System.Drawing.Size(223, 35)
		Me.btnWriteXML.TabIndex = 51
		Me.btnWriteXML.Text = "Write/Update DataSync"
		Me.btnWriteXML.UseVisualStyleBackColor = True
		'
		'QryActiveJobsTableAdapter
		'
		Me.QryActiveJobsTableAdapter.ClearBeforeFill = True
		'
		'QryMyDPTodayTableAdapter
		'
		Me.QryMyDPTodayTableAdapter.ClearBeforeFill = True
		'
		'frmSubmitDP
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(810, 427)
		Me.Controls.Add(Me.btnWriteXML)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.btnSubmitDataSync)
		Me.Controls.Add(Me.lblJobDescription)
		Me.Controls.Add(Me.lblUserDisplayName)
		Me.Controls.Add(Me.dtpDpDate)
		Me.Controls.Add(Me.cmbJobs)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmSubmitDP"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Submit Daily Productions"
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents cmbJobs As System.Windows.Forms.ComboBox
	Friend WithEvents dtpDpDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblUserDisplayName As System.Windows.Forms.Label
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryActiveJobsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryActiveJobsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
	Friend WithEvents lblJobDescription As System.Windows.Forms.Label
	Friend WithEvents btnSubmitDataSync As System.Windows.Forms.Button
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents btnWriteXML As System.Windows.Forms.Button
	Friend WithEvents QryMyDPTodayBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryMyDPTodayTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
	Friend WithEvents ForemanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EntryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DisplayNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents JobNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PayItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DpQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SiteNotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
