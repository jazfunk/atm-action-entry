<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSafetyInspection
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
		Dim ForemanLabel As System.Windows.Forms.Label
		Dim EquipIDLabel As System.Windows.Forms.Label
		Dim LocationLabel As System.Windows.Forms.Label
		Dim OverviewLabel As System.Windows.Forms.Label
		Dim TruckInspectionLabel As System.Windows.Forms.Label
		Dim NoIncidentLabel As System.Windows.Forms.Label
		Dim ItemsMissingLabel As System.Windows.Forms.Label
		Me.ClsAE_EquipmentInspection = New AE_Ground.clsAE_EquipmentInspection
		Me.DtEquipInspectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ForemanComboBox = New System.Windows.Forms.ComboBox
		Me.EquipIDTextBox = New System.Windows.Forms.TextBox
		Me.LocationTextBox = New System.Windows.Forms.TextBox
		Me.OverviewTextBox = New System.Windows.Forms.TextBox
		Me.InfractionCheckBox = New System.Windows.Forms.CheckBox
		Me.TruckInspectionTextBox = New System.Windows.Forms.TextBox
		Me.MajorRepairCheckBox = New System.Windows.Forms.CheckBox
		Me.MinorRepairCheckBox = New System.Windows.Forms.CheckBox
		Me.NoIncidentTextBox = New System.Windows.Forms.TextBox
		Me.AllItemsPresentCheckBox = New System.Windows.Forms.CheckBox
		Me.ItemsMissingTextBox = New System.Windows.Forms.TextBox
		Me.ReplacedCheckBox = New System.Windows.Forms.CheckBox
		Me.btnSave = New System.Windows.Forms.Button
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		ForemanLabel = New System.Windows.Forms.Label
		EquipIDLabel = New System.Windows.Forms.Label
		LocationLabel = New System.Windows.Forms.Label
		OverviewLabel = New System.Windows.Forms.Label
		TruckInspectionLabel = New System.Windows.Forms.Label
		NoIncidentLabel = New System.Windows.Forms.Label
		ItemsMissingLabel = New System.Windows.Forms.Label
		CType(Me.ClsAE_EquipmentInspection, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtEquipInspectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ForemanLabel
		'
		ForemanLabel.AutoSize = True
		ForemanLabel.Location = New System.Drawing.Point(68, 22)
		ForemanLabel.Name = "ForemanLabel"
		ForemanLabel.Size = New System.Drawing.Size(51, 13)
		ForemanLabel.TabIndex = 1
		ForemanLabel.Text = "Foreman:"
		'
		'EquipIDLabel
		'
		EquipIDLabel.AutoSize = True
		EquipIDLabel.Location = New System.Drawing.Point(39, 49)
		EquipIDLabel.Name = "EquipIDLabel"
		EquipIDLabel.Size = New System.Drawing.Size(80, 13)
		EquipIDLabel.TabIndex = 3
		EquipIDLabel.Text = "Truck/Equip #:"
		'
		'LocationLabel
		'
		LocationLabel.AutoSize = True
		LocationLabel.Location = New System.Drawing.Point(276, 49)
		LocationLabel.Name = "LocationLabel"
		LocationLabel.Size = New System.Drawing.Size(73, 13)
		LocationLabel.TabIndex = 5
		LocationLabel.Text = "Location/Job:"
		'
		'OverviewLabel
		'
		OverviewLabel.AutoSize = True
		OverviewLabel.Location = New System.Drawing.Point(64, 72)
		OverviewLabel.Name = "OverviewLabel"
		OverviewLabel.Size = New System.Drawing.Size(55, 13)
		OverviewLabel.TabIndex = 7
		OverviewLabel.Text = "Overview:"
		'
		'TruckInspectionLabel
		'
		TruckInspectionLabel.AutoSize = True
		TruckInspectionLabel.Location = New System.Drawing.Point(27, 214)
		TruckInspectionLabel.Name = "TruckInspectionLabel"
		TruckInspectionLabel.Size = New System.Drawing.Size(92, 13)
		TruckInspectionLabel.TabIndex = 11
		TruckInspectionLabel.Text = "Equip. Inspection:"
		'
		'NoIncidentLabel
		'
		NoIncidentLabel.AutoSize = True
		NoIncidentLabel.Location = New System.Drawing.Point(71, 356)
		NoIncidentLabel.Name = "NoIncidentLabel"
		NoIncidentLabel.Size = New System.Drawing.Size(48, 13)
		NoIncidentLabel.TabIndex = 17
		NoIncidentLabel.Text = "Incident:"
		'
		'ItemsMissingLabel
		'
		ItemsMissingLabel.AutoSize = True
		ItemsMissingLabel.Location = New System.Drawing.Point(40, 440)
		ItemsMissingLabel.Name = "ItemsMissingLabel"
		ItemsMissingLabel.Size = New System.Drawing.Size(79, 13)
		ItemsMissingLabel.TabIndex = 21
		ItemsMissingLabel.Text = "Missing Item(s):"
		'
		'ClsAE_EquipmentInspection
		'
		Me.ClsAE_EquipmentInspection.DataSetName = "clsAE_EquipmentInspection"
		Me.ClsAE_EquipmentInspection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DtEquipInspectionBindingSource
		'
		Me.DtEquipInspectionBindingSource.DataMember = "dtEquipInspection"
		Me.DtEquipInspectionBindingSource.DataSource = Me.ClsAE_EquipmentInspection
		'
		'ForemanComboBox
		'
		Me.ForemanComboBox.FormattingEnabled = True
		Me.ForemanComboBox.Location = New System.Drawing.Point(125, 19)
		Me.ForemanComboBox.Name = "ForemanComboBox"
		Me.ForemanComboBox.Size = New System.Drawing.Size(121, 21)
		Me.ForemanComboBox.TabIndex = 2
		'
		'EquipIDTextBox
		'
		Me.EquipIDTextBox.Location = New System.Drawing.Point(125, 46)
		Me.EquipIDTextBox.Name = "EquipIDTextBox"
		Me.EquipIDTextBox.Size = New System.Drawing.Size(121, 20)
		Me.EquipIDTextBox.TabIndex = 4
		'
		'LocationTextBox
		'
		Me.LocationTextBox.Location = New System.Drawing.Point(355, 46)
		Me.LocationTextBox.Name = "LocationTextBox"
		Me.LocationTextBox.Size = New System.Drawing.Size(121, 20)
		Me.LocationTextBox.TabIndex = 6
		'
		'OverviewTextBox
		'
		Me.OverviewTextBox.Location = New System.Drawing.Point(125, 72)
		Me.OverviewTextBox.Multiline = True
		Me.OverviewTextBox.Name = "OverviewTextBox"
		Me.OverviewTextBox.Size = New System.Drawing.Size(351, 106)
		Me.OverviewTextBox.TabIndex = 8
		'
		'InfractionCheckBox
		'
		Me.InfractionCheckBox.Location = New System.Drawing.Point(125, 184)
		Me.InfractionCheckBox.Name = "InfractionCheckBox"
		Me.InfractionCheckBox.Size = New System.Drawing.Size(121, 24)
		Me.InfractionCheckBox.TabIndex = 10
		Me.InfractionCheckBox.Text = "Infraction?"
		Me.InfractionCheckBox.UseVisualStyleBackColor = True
		'
		'TruckInspectionTextBox
		'
		Me.TruckInspectionTextBox.Location = New System.Drawing.Point(125, 214)
		Me.TruckInspectionTextBox.Multiline = True
		Me.TruckInspectionTextBox.Name = "TruckInspectionTextBox"
		Me.TruckInspectionTextBox.Size = New System.Drawing.Size(351, 106)
		Me.TruckInspectionTextBox.TabIndex = 12
		'
		'MajorRepairCheckBox
		'
		Me.MajorRepairCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DtEquipInspectionBindingSource, "majorRepair", True))
		Me.MajorRepairCheckBox.Location = New System.Drawing.Point(125, 326)
		Me.MajorRepairCheckBox.Name = "MajorRepairCheckBox"
		Me.MajorRepairCheckBox.Size = New System.Drawing.Size(121, 24)
		Me.MajorRepairCheckBox.TabIndex = 14
		Me.MajorRepairCheckBox.Text = "Major Repair?"
		Me.MajorRepairCheckBox.UseVisualStyleBackColor = True
		'
		'MinorRepairCheckBox
		'
		Me.MinorRepairCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DtEquipInspectionBindingSource, "minorRepair", True))
		Me.MinorRepairCheckBox.Location = New System.Drawing.Point(252, 326)
		Me.MinorRepairCheckBox.Name = "MinorRepairCheckBox"
		Me.MinorRepairCheckBox.Size = New System.Drawing.Size(121, 24)
		Me.MinorRepairCheckBox.TabIndex = 16
		Me.MinorRepairCheckBox.Text = "Minor Repair?"
		Me.MinorRepairCheckBox.UseVisualStyleBackColor = True
		'
		'NoIncidentTextBox
		'
		Me.NoIncidentTextBox.Location = New System.Drawing.Point(125, 356)
		Me.NoIncidentTextBox.Multiline = True
		Me.NoIncidentTextBox.Name = "NoIncidentTextBox"
		Me.NoIncidentTextBox.Size = New System.Drawing.Size(351, 48)
		Me.NoIncidentTextBox.TabIndex = 18
		'
		'AllItemsPresentCheckBox
		'
		Me.AllItemsPresentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DtEquipInspectionBindingSource, "allItemsPresent", True))
		Me.AllItemsPresentCheckBox.Location = New System.Drawing.Point(125, 410)
		Me.AllItemsPresentCheckBox.Name = "AllItemsPresentCheckBox"
		Me.AllItemsPresentCheckBox.Size = New System.Drawing.Size(121, 24)
		Me.AllItemsPresentCheckBox.TabIndex = 20
		Me.AllItemsPresentCheckBox.Text = "All Items Present?"
		Me.AllItemsPresentCheckBox.UseVisualStyleBackColor = True
		'
		'ItemsMissingTextBox
		'
		Me.ItemsMissingTextBox.Location = New System.Drawing.Point(125, 440)
		Me.ItemsMissingTextBox.Multiline = True
		Me.ItemsMissingTextBox.Name = "ItemsMissingTextBox"
		Me.ItemsMissingTextBox.Size = New System.Drawing.Size(351, 48)
		Me.ItemsMissingTextBox.TabIndex = 22
		'
		'ReplacedCheckBox
		'
		Me.ReplacedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DtEquipInspectionBindingSource, "replaced", True))
		Me.ReplacedCheckBox.Location = New System.Drawing.Point(252, 410)
		Me.ReplacedCheckBox.Name = "ReplacedCheckBox"
		Me.ReplacedCheckBox.Size = New System.Drawing.Size(121, 24)
		Me.ReplacedCheckBox.TabIndex = 24
		Me.ReplacedCheckBox.Text = "Replaced?"
		Me.ReplacedCheckBox.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(401, 494)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 25
		Me.btnSave.Text = "Save Report"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(355, 20)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
		Me.DateTimePicker1.TabIndex = 26
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ForemanComboBox)
		Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
		Me.GroupBox1.Controls.Add(Me.ReplacedCheckBox)
		Me.GroupBox1.Controls.Add(Me.btnSave)
		Me.GroupBox1.Controls.Add(Me.ItemsMissingTextBox)
		Me.GroupBox1.Controls.Add(ForemanLabel)
		Me.GroupBox1.Controls.Add(ItemsMissingLabel)
		Me.GroupBox1.Controls.Add(Me.AllItemsPresentCheckBox)
		Me.GroupBox1.Controls.Add(EquipIDLabel)
		Me.GroupBox1.Controls.Add(Me.NoIncidentTextBox)
		Me.GroupBox1.Controls.Add(Me.EquipIDTextBox)
		Me.GroupBox1.Controls.Add(NoIncidentLabel)
		Me.GroupBox1.Controls.Add(LocationLabel)
		Me.GroupBox1.Controls.Add(Me.MinorRepairCheckBox)
		Me.GroupBox1.Controls.Add(Me.LocationTextBox)
		Me.GroupBox1.Controls.Add(Me.MajorRepairCheckBox)
		Me.GroupBox1.Controls.Add(OverviewLabel)
		Me.GroupBox1.Controls.Add(Me.TruckInspectionTextBox)
		Me.GroupBox1.Controls.Add(Me.OverviewTextBox)
		Me.GroupBox1.Controls.Add(TruckInspectionLabel)
		Me.GroupBox1.Controls.Add(Me.InfractionCheckBox)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(503, 529)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GroupBox1"
		'
		'frmSafetyInspection
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(538, 553)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "frmSafetyInspection"
		Me.Text = "Safety Inspection Report"
		CType(Me.ClsAE_EquipmentInspection, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtEquipInspectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ClsAE_EquipmentInspection As AE_Ground.clsAE_EquipmentInspection
	Friend WithEvents DtEquipInspectionBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ForemanComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents EquipIDTextBox As System.Windows.Forms.TextBox
	Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
	Friend WithEvents OverviewTextBox As System.Windows.Forms.TextBox
	Friend WithEvents InfractionCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents TruckInspectionTextBox As System.Windows.Forms.TextBox
	Friend WithEvents MajorRepairCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents MinorRepairCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents NoIncidentTextBox As System.Windows.Forms.TextBox
	Friend WithEvents AllItemsPresentCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents ItemsMissingTextBox As System.Windows.Forms.TextBox
	Friend WithEvents ReplacedCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
