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
		Me.chklstCrew = New System.Windows.Forms.CheckedListBox
		Me.dtpStart = New System.Windows.Forms.DateTimePicker
		Me.dtpEnd = New System.Windows.Forms.DateTimePicker
		Me.lblStart = New System.Windows.Forms.Label
		Me.lblEnd = New System.Windows.Forms.Label
		Me.grpBoxTime = New System.Windows.Forms.GroupBox
		Me.dtpDate = New System.Windows.Forms.DateTimePicker
		Me.btnEnterTime = New System.Windows.Forms.Button
		Me.dgvTime = New System.Windows.Forms.DataGridView
		Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TotalTime = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Foreman = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.lblJobNumber = New System.Windows.Forms.Label
		Me.btnSave = New System.Windows.Forms.Button
		Me.btnDelete = New System.Windows.Forms.Button
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryUsersDisplayNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryUsersDisplayNamesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryUsersDisplayNamesTableAdapter
		Me.lblCaption = New System.Windows.Forms.Label
		Me.lblJobNumberCaption = New System.Windows.Forms.Label
		Me.cmbJobNumber = New System.Windows.Forms.ComboBox
		Me.QryActiveJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblJobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblJobsTableAdapter
		Me.QryActiveJobsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryActiveJobsTableAdapter
		Me.pnlTitleBar = New System.Windows.Forms.Panel
		Me.lblClose = New System.Windows.Forms.Label
		Me.btnOK = New System.Windows.Forms.Button
		Me.Panel1 = New System.Windows.Forms.Panel
		Me.TimeReporting = New AE_Ground.TimeReporting
		Me.AtmTimeDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.grpBoxTime.SuspendLayout()
		CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlTitleBar.SuspendLayout()
		Me.Panel1.SuspendLayout()
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
		Me.chklstCrew.Location = New System.Drawing.Point(10, 74)
		Me.chklstCrew.Name = "chklstCrew"
		Me.chklstCrew.Size = New System.Drawing.Size(174, 268)
		Me.chklstCrew.TabIndex = 0
		'
		'dtpStart
		'
		Me.dtpStart.CustomFormat = "hh:mm tt"
		Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpStart.Location = New System.Drawing.Point(134, 96)
		Me.dtpStart.Name = "dtpStart"
		Me.dtpStart.ShowUpDown = True
		Me.dtpStart.Size = New System.Drawing.Size(120, 29)
		Me.dtpStart.TabIndex = 1
		'
		'dtpEnd
		'
		Me.dtpEnd.CustomFormat = "hh:mm tt"
		Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEnd.Location = New System.Drawing.Point(133, 156)
		Me.dtpEnd.Name = "dtpEnd"
		Me.dtpEnd.ShowUpDown = True
		Me.dtpEnd.Size = New System.Drawing.Size(120, 29)
		Me.dtpEnd.TabIndex = 2
		'
		'lblStart
		'
		Me.lblStart.AutoSize = True
		Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStart.Location = New System.Drawing.Point(29, 98)
		Me.lblStart.Name = "lblStart"
		Me.lblStart.Size = New System.Drawing.Size(99, 24)
		Me.lblStart.TabIndex = 3
		Me.lblStart.Text = "Start Time:"
		'
		'lblEnd
		'
		Me.lblEnd.AutoSize = True
		Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEnd.Location = New System.Drawing.Point(29, 158)
		Me.lblEnd.Name = "lblEnd"
		Me.lblEnd.Size = New System.Drawing.Size(98, 24)
		Me.lblEnd.TabIndex = 4
		Me.lblEnd.Text = "End Time:"
		'
		'grpBoxTime
		'
		Me.grpBoxTime.BackColor = System.Drawing.Color.Transparent
		Me.grpBoxTime.Controls.Add(Me.dtpDate)
		Me.grpBoxTime.Controls.Add(Me.btnEnterTime)
		Me.grpBoxTime.Controls.Add(Me.dtpStart)
		Me.grpBoxTime.Controls.Add(Me.lblEnd)
		Me.grpBoxTime.Controls.Add(Me.dtpEnd)
		Me.grpBoxTime.Controls.Add(Me.lblStart)
		Me.grpBoxTime.Location = New System.Drawing.Point(195, 67)
		Me.grpBoxTime.Name = "grpBoxTime"
		Me.grpBoxTime.Size = New System.Drawing.Size(282, 277)
		Me.grpBoxTime.TabIndex = 5
		Me.grpBoxTime.TabStop = False
		Me.grpBoxTime.Text = "Time"
		'
		'dtpDate
		'
		Me.dtpDate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Location = New System.Drawing.Point(6, 28)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(270, 26)
		Me.dtpDate.TabIndex = 6
		'
		'btnEnterTime
		'
		Me.btnEnterTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEnterTime.Location = New System.Drawing.Point(88, 215)
		Me.btnEnterTime.Name = "btnEnterTime"
		Me.btnEnterTime.Size = New System.Drawing.Size(124, 39)
		Me.btnEnterTime.TabIndex = 5
		Me.btnEnterTime.Text = "Enter Time:"
		Me.btnEnterTime.UseVisualStyleBackColor = True
		'
		'dgvTime
		'
		Me.dgvTime.AllowUserToAddRows = False
		Me.dgvTime.AllowUserToDeleteRows = False
		Me.dgvTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvTime.BackgroundColor = System.Drawing.Color.White
		Me.dgvTime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
		Me.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvTime.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeName, Me.Job, Me.Day, Me.StartTime, Me.EndTime, Me.TotalTime, Me.Notes, Me.Foreman})
		Me.dgvTime.Location = New System.Drawing.Point(485, 74)
		Me.dgvTime.Name = "dgvTime"
		Me.dgvTime.RowHeadersVisible = False
		Me.dgvTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvTime.ShowEditingIcon = False
		Me.dgvTime.Size = New System.Drawing.Size(473, 270)
		Me.dgvTime.TabIndex = 6
		'
		'EmployeeName
		'
		Me.EmployeeName.HeaderText = "Name"
		Me.EmployeeName.Name = "EmployeeName"
		Me.EmployeeName.ReadOnly = True
		'
		'Job
		'
		Me.Job.HeaderText = "JobNum"
		Me.Job.Name = "Job"
		Me.Job.ReadOnly = True
		'
		'Day
		'
		Me.Day.HeaderText = "Date"
		Me.Day.Name = "Day"
		Me.Day.ReadOnly = True
		'
		'StartTime
		'
		Me.StartTime.HeaderText = "Start"
		Me.StartTime.Name = "StartTime"
		Me.StartTime.ReadOnly = True
		'
		'EndTime
		'
		Me.EndTime.HeaderText = "End"
		Me.EndTime.Name = "EndTime"
		Me.EndTime.ReadOnly = True
		'
		'TotalTime
		'
		Me.TotalTime.HeaderText = "Total"
		Me.TotalTime.Name = "TotalTime"
		Me.TotalTime.ReadOnly = True
		'
		'Notes
		'
		Me.Notes.HeaderText = "Notes"
		Me.Notes.Name = "Notes"
		'
		'Foreman
		'
		Me.Foreman.HeaderText = "Foreman"
		Me.Foreman.Name = "Foreman"
		Me.Foreman.ReadOnly = True
		Me.Foreman.Visible = False
		'
		'lblJobNumber
		'
		Me.lblJobNumber.AutoSize = True
		Me.lblJobNumber.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumber.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumber.Location = New System.Drawing.Point(436, 6)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(98, 46)
		Me.lblJobNumber.TabIndex = 6
		Me.lblJobNumber.Text = "Job#"
		'
		'btnSave
		'
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(843, 355)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(116, 29)
		Me.btnSave.TabIndex = 6
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.Location = New System.Drawing.Point(720, 355)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(116, 29)
		Me.btnDelete.TabIndex = 7
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
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
		'lblCaption
		'
		Me.lblCaption.AutoSize = True
		Me.lblCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCaption.ForeColor = System.Drawing.Color.Red
		Me.lblCaption.Location = New System.Drawing.Point(225, 355)
		Me.lblCaption.Name = "lblCaption"
		Me.lblCaption.Size = New System.Drawing.Size(236, 16)
		Me.lblCaption.TabIndex = 8
		Me.lblCaption.Text = "Please Round to the nearest half hour. "
		'
		'lblJobNumberCaption
		'
		Me.lblJobNumberCaption.AutoSize = True
		Me.lblJobNumberCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumberCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumberCaption.ForeColor = System.Drawing.Color.Red
		Me.lblJobNumberCaption.Location = New System.Drawing.Point(386, 52)
		Me.lblJobNumberCaption.Name = "lblJobNumberCaption"
		Me.lblJobNumberCaption.Size = New System.Drawing.Size(199, 16)
		Me.lblJobNumberCaption.TabIndex = 9
		Me.lblJobNumberCaption.Text = "Click on Job Number to Change."
		'
		'cmbJobNumber
		'
		Me.cmbJobNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.cmbJobNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbJobNumber.DataSource = Me.QryActiveJobsBindingSource
		Me.cmbJobNumber.DisplayMember = "jobNum"
		Me.cmbJobNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbJobNumber.FormattingEnabled = True
		Me.cmbJobNumber.Location = New System.Drawing.Point(594, 23)
		Me.cmbJobNumber.Name = "cmbJobNumber"
		Me.cmbJobNumber.Size = New System.Drawing.Size(121, 28)
		Me.cmbJobNumber.TabIndex = 10
		Me.cmbJobNumber.ValueMember = "jobNum"
		Me.cmbJobNumber.Visible = False
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
		'pnlTitleBar
		'
		Me.pnlTitleBar.BackgroundImage = Global.AE_Ground.My.Resources.Resources.progressTitleBar2
		Me.pnlTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTitleBar.Controls.Add(Me.lblClose)
		Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleBar.Name = "pnlTitleBar"
		Me.pnlTitleBar.Size = New System.Drawing.Size(973, 24)
		Me.pnlTitleBar.TabIndex = 11
		'
		'lblClose
		'
		Me.lblClose.AutoSize = True
		Me.lblClose.BackColor = System.Drawing.Color.Transparent
		Me.lblClose.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClose.ForeColor = System.Drawing.Color.White
		Me.lblClose.Location = New System.Drawing.Point(950, 0)
		Me.lblClose.Margin = New System.Windows.Forms.Padding(0)
		Me.lblClose.Name = "lblClose"
		Me.lblClose.Size = New System.Drawing.Size(20, 19)
		Me.lblClose.TabIndex = 0
		Me.lblClose.Text = "X"
		'
		'btnOK
		'
		Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.Location = New System.Drawing.Point(721, 22)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(67, 29)
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
		Me.Panel1.Controls.Add(Me.chklstCrew)
		Me.Panel1.Controls.Add(Me.btnOK)
		Me.Panel1.Controls.Add(Me.grpBoxTime)
		Me.Panel1.Controls.Add(Me.cmbJobNumber)
		Me.Panel1.Controls.Add(Me.dgvTime)
		Me.Panel1.Controls.Add(Me.lblJobNumberCaption)
		Me.Panel1.Controls.Add(Me.lblJobNumber)
		Me.Panel1.Controls.Add(Me.lblCaption)
		Me.Panel1.Controls.Add(Me.btnSave)
		Me.Panel1.Controls.Add(Me.btnDelete)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 24)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(973, 397)
		Me.Panel1.TabIndex = 13
		'
		'TimeReporting
		'
		Me.TimeReporting.DataSetName = "TimeReporting"
		Me.TimeReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'AtmTimeDSBindingSource
		'
		Me.AtmTimeDSBindingSource.DataMember = "atmTimeDS"
		Me.AtmTimeDSBindingSource.DataSource = Me.TimeReporting
		'
		'frmTimeReporting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(973, 421)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.pnlTitleBar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmTimeReporting"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Time Reporting"
		Me.grpBoxTime.ResumeLayout(False)
		Me.grpBoxTime.PerformLayout()
		CType(Me.dgvTime, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryUsersDisplayNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryActiveJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblJobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlTitleBar.ResumeLayout(False)
		Me.pnlTitleBar.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
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
	Friend WithEvents lblCaption As System.Windows.Forms.Label
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
	Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Job As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Day As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents StartTime As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EndTime As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TotalTime As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Notes As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Foreman As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TimeReporting As AE_Ground.TimeReporting
	Friend WithEvents AtmTimeDSBindingSource As System.Windows.Forms.BindingSource
End Class
