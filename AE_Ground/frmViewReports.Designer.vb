<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReports
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
		Me.pnlMainBody = New System.Windows.Forms.Panel
		Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.pnlTitleBar = New System.Windows.Forms.Panel
		Me.rbtnUH = New System.Windows.Forms.RadioButton
		Me.rbtnGR = New System.Windows.Forms.RadioButton
		Me.rbtnNPI = New System.Windows.Forms.RadioButton
		Me.rbtnDP = New System.Windows.Forms.RadioButton
		Me.lblClose = New System.Windows.Forms.Label
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryMyDPTodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryMyDPTodayTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
		Me.pnlMainBody.SuspendLayout()
		Me.pnlTitleBar.SuspendLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlMainBody
		'
		Me.pnlMainBody.BackColor = System.Drawing.Color.White
		Me.pnlMainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlMainBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlMainBody.Controls.Add(Me.CrystalReportViewer1)
		Me.pnlMainBody.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlMainBody.Location = New System.Drawing.Point(0, 24)
		Me.pnlMainBody.Name = "pnlMainBody"
		Me.pnlMainBody.Size = New System.Drawing.Size(973, 397)
		Me.pnlMainBody.TabIndex = 15
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
		Me.CrystalReportViewer1.Size = New System.Drawing.Size(971, 395)
		Me.CrystalReportViewer1.TabIndex = 0
		Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
		'
		'pnlTitleBar
		'
		Me.pnlTitleBar.BackgroundImage = Global.AE_Ground.My.Resources.Resources.progressTitleBar2
		Me.pnlTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTitleBar.Controls.Add(Me.rbtnUH)
		Me.pnlTitleBar.Controls.Add(Me.rbtnGR)
		Me.pnlTitleBar.Controls.Add(Me.rbtnNPI)
		Me.pnlTitleBar.Controls.Add(Me.rbtnDP)
		Me.pnlTitleBar.Controls.Add(Me.lblClose)
		Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleBar.Name = "pnlTitleBar"
		Me.pnlTitleBar.Size = New System.Drawing.Size(973, 24)
		Me.pnlTitleBar.TabIndex = 14
		'
		'rbtnUH
		'
		Me.rbtnUH.AutoSize = True
		Me.rbtnUH.BackColor = System.Drawing.Color.Transparent
		Me.rbtnUH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnUH.ForeColor = System.Drawing.Color.Yellow
		Me.rbtnUH.Location = New System.Drawing.Point(412, 4)
		Me.rbtnUH.Name = "rbtnUH"
		Me.rbtnUH.Size = New System.Drawing.Size(77, 17)
		Me.rbtnUH.TabIndex = 4
		Me.rbtnUH.TabStop = True
		Me.rbtnUH.Text = "Utility Hit"
		Me.rbtnUH.UseVisualStyleBackColor = False
		'
		'rbtnGR
		'
		Me.rbtnGR.AutoSize = True
		Me.rbtnGR.BackColor = System.Drawing.Color.Transparent
		Me.rbtnGR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnGR.ForeColor = System.Drawing.Color.Yellow
		Me.rbtnGR.Location = New System.Drawing.Point(297, 4)
		Me.rbtnGR.Name = "rbtnGR"
		Me.rbtnGR.Size = New System.Drawing.Size(85, 17)
		Me.rbtnGR.TabIndex = 3
		Me.rbtnGR.TabStop = True
		Me.rbtnGR.Text = "Guard Rail"
		Me.rbtnGR.UseVisualStyleBackColor = False
		'
		'rbtnNPI
		'
		Me.rbtnNPI.AutoSize = True
		Me.rbtnNPI.BackColor = System.Drawing.Color.Transparent
		Me.rbtnNPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnNPI.ForeColor = System.Drawing.Color.Yellow
		Me.rbtnNPI.Location = New System.Drawing.Point(160, 4)
		Me.rbtnNPI.Name = "rbtnNPI"
		Me.rbtnNPI.Size = New System.Drawing.Size(107, 17)
		Me.rbtnNPI.TabIndex = 2
		Me.rbtnNPI.TabStop = True
		Me.rbtnNPI.Text = "Non Pay Items"
		Me.rbtnNPI.UseVisualStyleBackColor = False
		'
		'rbtnDP
		'
		Me.rbtnDP.AutoSize = True
		Me.rbtnDP.BackColor = System.Drawing.Color.Transparent
		Me.rbtnDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbtnDP.ForeColor = System.Drawing.Color.Yellow
		Me.rbtnDP.Location = New System.Drawing.Point(12, 4)
		Me.rbtnDP.Name = "rbtnDP"
		Me.rbtnDP.Size = New System.Drawing.Size(118, 17)
		Me.rbtnDP.TabIndex = 1
		Me.rbtnDP.TabStop = True
		Me.rbtnDP.Text = "Daily Production"
		Me.rbtnDP.UseVisualStyleBackColor = False
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
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'QryMyDPTodayBindingSource
		'
		Me.QryMyDPTodayBindingSource.DataMember = "qryMyDPToday"
		Me.QryMyDPTodayBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryMyDPTodayTableAdapter
		'
		Me.QryMyDPTodayTableAdapter.ClearBeforeFill = True
		'
		'frmViewReports
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(973, 421)
		Me.Controls.Add(Me.pnlMainBody)
		Me.Controls.Add(Me.pnlTitleBar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmViewReports"
		Me.Text = "frmViewReports"
		Me.pnlMainBody.ResumeLayout(False)
		Me.pnlTitleBar.ResumeLayout(False)
		Me.pnlTitleBar.PerformLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryMyDPTodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlMainBody As System.Windows.Forms.Panel
	Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
	Friend WithEvents lblClose As System.Windows.Forms.Label
	Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents rbtnDP As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnNPI As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnUH As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnGR As System.Windows.Forms.RadioButton
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryMyDPTodayBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryMyDPTodayTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryMyDPTodayTableAdapter
End Class
