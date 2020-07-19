<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		Me.QryForReportingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryForReportingTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.QryForReportingTableAdapter
		Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.rptDP31 = New AE_Ground.rptDP3
		Me.rptDP_BETA1 = New AE_Ground.rptDP_BETA
		Me.rptDP11 = New AE_Ground.rptDP1
		Me.DPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DPTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.DPTableAdapter
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.grpCustom = New System.Windows.Forms.GroupBox
		Me.btnPopRange = New System.Windows.Forms.Button
		Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
		Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
		Me.btnRange = New System.Windows.Forms.Button
		Me.lblStart = New System.Windows.Forms.Label
		Me.lblEnd = New System.Windows.Forms.Label
		Me.cmbJob = New System.Windows.Forms.ComboBox
		CType(Me.QryForReportingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.grpCustom.SuspendLayout()
		Me.SuspendLayout()
		'
		'QryForReportingBindingSource
		'
		Me.QryForReportingBindingSource.DataMember = "QryForReporting"
		Me.QryForReportingBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'QryForReportingTableAdapter
		'
		Me.QryForReportingTableAdapter.ClearBeforeFill = True
		'
		'CrystalReportViewer1
		'
		Me.CrystalReportViewer1.ActiveViewIndex = 0
		Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CrystalReportViewer1.DisplayGroupTree = False
		Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
		Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
		Me.CrystalReportViewer1.ReportSource = Me.rptDP31
		Me.CrystalReportViewer1.Size = New System.Drawing.Size(874, 378)
		Me.CrystalReportViewer1.TabIndex = 0
		'
		'DPBindingSource
		'
		Me.DPBindingSource.DataMember = "DP"
		Me.DPBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'DPTableAdapter
		'
		Me.DPTableAdapter.ClearBeforeFill = True
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
		Me.SplitContainer1.Panel1.Controls.Add(Me.grpCustom)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
		Me.SplitContainer1.Size = New System.Drawing.Size(874, 462)
		Me.SplitContainer1.SplitterDistance = 80
		Me.SplitContainer1.TabIndex = 1
		'
		'grpCustom
		'
		Me.grpCustom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grpCustom.BackColor = System.Drawing.Color.Transparent
		Me.grpCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.grpCustom.Controls.Add(Me.cmbJob)
		Me.grpCustom.Controls.Add(Me.btnPopRange)
		Me.grpCustom.Controls.Add(Me.dtpStartDate)
		Me.grpCustom.Controls.Add(Me.dtpEndDate)
		Me.grpCustom.Controls.Add(Me.btnRange)
		Me.grpCustom.Controls.Add(Me.lblStart)
		Me.grpCustom.Controls.Add(Me.lblEnd)
		Me.grpCustom.Location = New System.Drawing.Point(12, 9)
		Me.grpCustom.Name = "grpCustom"
		Me.grpCustom.Size = New System.Drawing.Size(850, 68)
		Me.grpCustom.TabIndex = 15
		Me.grpCustom.TabStop = False
		Me.grpCustom.Text = "Custom Range"
		'
		'btnPopRange
		'
		Me.btnPopRange.Font = New System.Drawing.Font("Wingdings 2", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.btnPopRange.Location = New System.Drawing.Point(443, 23)
		Me.btnPopRange.Name = "btnPopRange"
		Me.btnPopRange.Size = New System.Drawing.Size(43, 30)
		Me.btnPopRange.TabIndex = 13
		Me.btnPopRange.Text = "1"
		Me.btnPopRange.UseVisualStyleBackColor = True
		'
		'dtpStartDate
		'
		Me.dtpStartDate.CustomFormat = "MM/dd/yyyy"
		Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpStartDate.Location = New System.Drawing.Point(88, 29)
		Me.dtpStartDate.Name = "dtpStartDate"
		Me.dtpStartDate.Size = New System.Drawing.Size(109, 22)
		Me.dtpStartDate.TabIndex = 0
		'
		'dtpEndDate
		'
		Me.dtpEndDate.CustomFormat = "MM/dd/yyyy"
		Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEndDate.Location = New System.Drawing.Point(242, 29)
		Me.dtpEndDate.Name = "dtpEndDate"
		Me.dtpEndDate.Size = New System.Drawing.Size(109, 22)
		Me.dtpEndDate.TabIndex = 1
		'
		'btnRange
		'
		Me.btnRange.Location = New System.Drawing.Point(357, 23)
		Me.btnRange.Name = "btnRange"
		Me.btnRange.Size = New System.Drawing.Size(85, 30)
		Me.btnRange.TabIndex = 12
		Me.btnRange.Text = "View Range"
		Me.btnRange.UseVisualStyleBackColor = True
		'
		'lblStart
		'
		Me.lblStart.AutoSize = True
		Me.lblStart.Location = New System.Drawing.Point(50, 34)
		Me.lblStart.Name = "lblStart"
		Me.lblStart.Size = New System.Drawing.Size(32, 13)
		Me.lblStart.TabIndex = 8
		Me.lblStart.Text = "Start:"
		'
		'lblEnd
		'
		Me.lblEnd.AutoSize = True
		Me.lblEnd.Location = New System.Drawing.Point(207, 34)
		Me.lblEnd.Name = "lblEnd"
		Me.lblEnd.Size = New System.Drawing.Size(29, 13)
		Me.lblEnd.TabIndex = 9
		Me.lblEnd.Text = "End:"
		'
		'cmbJob
		'
		Me.cmbJob.FormattingEnabled = True
		Me.cmbJob.Location = New System.Drawing.Point(492, 26)
		Me.cmbJob.Name = "cmbJob"
		Me.cmbJob.Size = New System.Drawing.Size(121, 21)
		Me.cmbJob.TabIndex = 14
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(874, 462)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Form2"
		Me.Text = "Form2"
		CType(Me.QryForReportingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.grpCustom.ResumeLayout(False)
		Me.grpCustom.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryForReportingBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryForReportingTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.QryForReportingTableAdapter
	Friend WithEvents rptDP_BETA1 As AE_Ground.rptDP_BETA
	Friend WithEvents rptDP11 As AE_Ground.rptDP1
	Friend WithEvents DPBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents DPTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.DPTableAdapter
	Friend WithEvents rptDP31 As AE_Ground.rptDP3
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents grpCustom As System.Windows.Forms.GroupBox
	Friend WithEvents btnPopRange As System.Windows.Forms.Button
	Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents btnRange As System.Windows.Forms.Button
	Friend WithEvents lblStart As System.Windows.Forms.Label
	Friend WithEvents lblEnd As System.Windows.Forms.Label
	Friend WithEvents cmbJob As System.Windows.Forms.ComboBox
End Class
