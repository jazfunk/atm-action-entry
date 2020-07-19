<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceRequest
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
		Me.txtUnitNumber = New System.Windows.Forms.TextBox
		Me.ckbDomiciled = New System.Windows.Forms.CheckBox
		Me.dtpRequestDate = New System.Windows.Forms.DateTimePicker
		Me.txtMake = New System.Windows.Forms.TextBox
		Me.txtModel = New System.Windows.Forms.TextBox
		Me.txtYear = New System.Windows.Forms.TextBox
		Me.txtMileage = New System.Windows.Forms.TextBox
		Me.txtEngineMake = New System.Windows.Forms.TextBox
		Me.txtProblem = New System.Windows.Forms.TextBox
		Me.txtRecentRelatedProblems = New System.Windows.Forms.TextBox
		Me.ckbASAP = New System.Windows.Forms.CheckBox
		Me.dtpDateRepairNeeded = New System.Windows.Forms.DateTimePicker
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Button1 = New System.Windows.Forms.Button
		Me.ComboBox1 = New System.Windows.Forms.ComboBox
		Me.btnSave = New System.Windows.Forms.Button
		Me.btnClearFields = New System.Windows.Forms.Button
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtUnitNumber
		'
		Me.txtUnitNumber.Location = New System.Drawing.Point(46, 57)
		Me.txtUnitNumber.Name = "txtUnitNumber"
		Me.txtUnitNumber.Size = New System.Drawing.Size(100, 20)
		Me.txtUnitNumber.TabIndex = 0
		Me.txtUnitNumber.Text = "Unit Number"
		'
		'ckbDomiciled
		'
		Me.ckbDomiciled.AutoSize = True
		Me.ckbDomiciled.Location = New System.Drawing.Point(252, 57)
		Me.ckbDomiciled.Name = "ckbDomiciled"
		Me.ckbDomiciled.Size = New System.Drawing.Size(72, 17)
		Me.ckbDomiciled.TabIndex = 1
		Me.ckbDomiciled.Text = "Domiciled"
		Me.ckbDomiciled.UseVisualStyleBackColor = True
		'
		'dtpRequestDate
		'
		Me.dtpRequestDate.CustomFormat = "MM/dd/yyyy"
		Me.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpRequestDate.Location = New System.Drawing.Point(278, 12)
		Me.dtpRequestDate.Name = "dtpRequestDate"
		Me.dtpRequestDate.Size = New System.Drawing.Size(110, 20)
		Me.dtpRequestDate.TabIndex = 2
		'
		'txtMake
		'
		Me.txtMake.Location = New System.Drawing.Point(46, 83)
		Me.txtMake.Name = "txtMake"
		Me.txtMake.Size = New System.Drawing.Size(100, 20)
		Me.txtMake.TabIndex = 3
		Me.txtMake.Text = "Make"
		'
		'txtModel
		'
		Me.txtModel.Location = New System.Drawing.Point(152, 83)
		Me.txtModel.Name = "txtModel"
		Me.txtModel.Size = New System.Drawing.Size(100, 20)
		Me.txtModel.TabIndex = 4
		Me.txtModel.Text = "Model"
		'
		'txtYear
		'
		Me.txtYear.Location = New System.Drawing.Point(258, 83)
		Me.txtYear.Name = "txtYear"
		Me.txtYear.Size = New System.Drawing.Size(100, 20)
		Me.txtYear.TabIndex = 5
		Me.txtYear.Text = "Year"
		'
		'txtMileage
		'
		Me.txtMileage.Location = New System.Drawing.Point(46, 109)
		Me.txtMileage.Name = "txtMileage"
		Me.txtMileage.Size = New System.Drawing.Size(100, 20)
		Me.txtMileage.TabIndex = 6
		Me.txtMileage.Text = "Mileage"
		'
		'txtEngineMake
		'
		Me.txtEngineMake.Location = New System.Drawing.Point(46, 135)
		Me.txtEngineMake.Name = "txtEngineMake"
		Me.txtEngineMake.Size = New System.Drawing.Size(100, 20)
		Me.txtEngineMake.TabIndex = 7
		Me.txtEngineMake.Text = "Engine Make"
		'
		'txtProblem
		'
		Me.txtProblem.Location = New System.Drawing.Point(46, 161)
		Me.txtProblem.Multiline = True
		Me.txtProblem.Name = "txtProblem"
		Me.txtProblem.Size = New System.Drawing.Size(399, 124)
		Me.txtProblem.TabIndex = 8
		Me.txtProblem.Text = "Complaint/Problem"
		'
		'txtRecentRelatedProblems
		'
		Me.txtRecentRelatedProblems.Location = New System.Drawing.Point(46, 291)
		Me.txtRecentRelatedProblems.Multiline = True
		Me.txtRecentRelatedProblems.Name = "txtRecentRelatedProblems"
		Me.txtRecentRelatedProblems.Size = New System.Drawing.Size(399, 124)
		Me.txtRecentRelatedProblems.TabIndex = 9
		Me.txtRecentRelatedProblems.Text = "Recent Repairs Relevant to Problem"
		'
		'ckbASAP
		'
		Me.ckbASAP.AutoSize = True
		Me.ckbASAP.Location = New System.Drawing.Point(46, 446)
		Me.ckbASAP.Name = "ckbASAP"
		Me.ckbASAP.Size = New System.Drawing.Size(54, 17)
		Me.ckbASAP.TabIndex = 10
		Me.ckbASAP.Text = "ASAP"
		Me.ckbASAP.UseVisualStyleBackColor = True
		'
		'dtpDateRepairNeeded
		'
		Me.dtpDateRepairNeeded.CustomFormat = "MM/dd/yyyy"
		Me.dtpDateRepairNeeded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateRepairNeeded.Location = New System.Drawing.Point(133, 443)
		Me.dtpDateRepairNeeded.Name = "dtpDateRepairNeeded"
		Me.dtpDateRepairNeeded.Size = New System.Drawing.Size(119, 20)
		Me.dtpDateRepairNeeded.TabIndex = 11
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Location = New System.Drawing.Point(713, 83)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Size = New System.Drawing.Size(150, 100)
		Me.SplitContainer1.TabIndex = 16
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(586, 139)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(121, 20)
		Me.TextBox1.TabIndex = 15
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(583, 162)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "Label1"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(586, 110)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(121, 23)
		Me.Button1.TabIndex = 13
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(586, 83)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 12
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(152, 527)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(121, 23)
		Me.btnSave.TabIndex = 17
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnClearFields
		'
		Me.btnClearFields.Location = New System.Drawing.Point(279, 527)
		Me.btnClearFields.Name = "btnClearFields"
		Me.btnClearFields.Size = New System.Drawing.Size(121, 23)
		Me.btnClearFields.TabIndex = 18
		Me.btnClearFields.Text = "Clear Form"
		Me.btnClearFields.UseVisualStyleBackColor = True
		'
		'frmServiceRequest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(937, 617)
		Me.Controls.Add(Me.btnClearFields)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.dtpDateRepairNeeded)
		Me.Controls.Add(Me.ckbASAP)
		Me.Controls.Add(Me.txtRecentRelatedProblems)
		Me.Controls.Add(Me.txtProblem)
		Me.Controls.Add(Me.txtEngineMake)
		Me.Controls.Add(Me.txtMileage)
		Me.Controls.Add(Me.txtYear)
		Me.Controls.Add(Me.txtModel)
		Me.Controls.Add(Me.txtMake)
		Me.Controls.Add(Me.dtpRequestDate)
		Me.Controls.Add(Me.ckbDomiciled)
		Me.Controls.Add(Me.txtUnitNumber)
		Me.Name = "frmServiceRequest"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Service Request Form"
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtUnitNumber As System.Windows.Forms.TextBox
	Friend WithEvents ckbDomiciled As System.Windows.Forms.CheckBox
	Friend WithEvents dtpRequestDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents txtMake As System.Windows.Forms.TextBox
	Friend WithEvents txtModel As System.Windows.Forms.TextBox
	Friend WithEvents txtYear As System.Windows.Forms.TextBox
	Friend WithEvents txtMileage As System.Windows.Forms.TextBox
	Friend WithEvents txtEngineMake As System.Windows.Forms.TextBox
	Friend WithEvents txtProblem As System.Windows.Forms.TextBox
	Friend WithEvents txtRecentRelatedProblems As System.Windows.Forms.TextBox
	Friend WithEvents ckbASAP As System.Windows.Forms.CheckBox
	Friend WithEvents dtpDateRepairNeeded As System.Windows.Forms.DateTimePicker
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnClearFields As System.Windows.Forms.Button
End Class
