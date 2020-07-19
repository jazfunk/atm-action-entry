<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAE_HomeExpress
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
		Me.SplitContainerMain = New System.Windows.Forms.SplitContainer
		Me.pnlTitleMain = New System.Windows.Forms.Panel
		Me.lblTodayDate = New System.Windows.Forms.Label
		Me.lblUserName = New System.Windows.Forms.Label
		Me.SplitContainerContentMain = New System.Windows.Forms.SplitContainer
		Me.pnlHomeSummary = New System.Windows.Forms.Panel
		Me.pnlMainBack = New System.Windows.Forms.Panel
		Me.ComboBox1 = New System.Windows.Forms.ComboBox
		Me.pnlTime = New System.Windows.Forms.Panel
		Me.btnTime = New System.Windows.Forms.Button
		Me.Label20 = New System.Windows.Forms.Label
		Me.Label19 = New System.Windows.Forms.Label
		Me.lblSubmitCaption = New System.Windows.Forms.Label
		Me.btnSubmitTime = New System.Windows.Forms.Button
		Me.lblSubmitTime = New System.Windows.Forms.Label
		Me.pnlProductions = New System.Windows.Forms.Panel
		Me.Label9 = New System.Windows.Forms.Label
		Me.btnDP = New System.Windows.Forms.Button
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.btnUpload = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.bgWorker2 = New System.ComponentModel.BackgroundWorker
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.QryJobDescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.QryJobDescriptionTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.QryJobDescriptionTableAdapter
		Me.SplitContainerMain.Panel1.SuspendLayout()
		Me.SplitContainerMain.Panel2.SuspendLayout()
		Me.SplitContainerMain.SuspendLayout()
		Me.pnlTitleMain.SuspendLayout()
		Me.SplitContainerContentMain.Panel1.SuspendLayout()
		Me.SplitContainerContentMain.Panel2.SuspendLayout()
		Me.SplitContainerContentMain.SuspendLayout()
		Me.pnlMainBack.SuspendLayout()
		Me.pnlTime.SuspendLayout()
		Me.pnlProductions.SuspendLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitContainerMain
		'
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
		Me.SplitContainerMain.Panel1.BackColor = System.Drawing.Color.White
		Me.SplitContainerMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainerMain.Panel1.Controls.Add(Me.pnlTitleMain)
		Me.SplitContainerMain.Panel1MinSize = 50
		'
		'SplitContainerMain.Panel2
		'
		Me.SplitContainerMain.Panel2.Controls.Add(Me.SplitContainerContentMain)
		Me.SplitContainerMain.Size = New System.Drawing.Size(1000, 530)
		Me.SplitContainerMain.SplitterWidth = 1
		Me.SplitContainerMain.TabIndex = 10
		'
		'pnlTitleMain
		'
		Me.pnlTitleMain.BackColor = System.Drawing.Color.Transparent
		Me.pnlTitleMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.homeTitleBar2
		Me.pnlTitleMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.pnlTitleMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTitleMain.Controls.Add(Me.lblTodayDate)
		Me.pnlTitleMain.Controls.Add(Me.lblUserName)
		Me.pnlTitleMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlTitleMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleMain.Name = "pnlTitleMain"
		Me.pnlTitleMain.Size = New System.Drawing.Size(998, 48)
		Me.pnlTitleMain.TabIndex = 1
		'
		'lblTodayDate
		'
		Me.lblTodayDate.BackColor = System.Drawing.Color.Transparent
		Me.lblTodayDate.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTodayDate.ForeColor = System.Drawing.Color.Snow
		Me.lblTodayDate.Location = New System.Drawing.Point(58, 19)
		Me.lblTodayDate.Name = "lblTodayDate"
		Me.lblTodayDate.Size = New System.Drawing.Size(384, 24)
		Me.lblTodayDate.TabIndex = 0
		Me.lblTodayDate.Text = "Friday, July 29, 2011"
		Me.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblUserName
		'
		Me.lblUserName.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUserName.ForeColor = System.Drawing.Color.Gainsboro
		Me.lblUserName.Location = New System.Drawing.Point(760, 27)
		Me.lblUserName.Name = "lblUserName"
		Me.lblUserName.Size = New System.Drawing.Size(226, 16)
		Me.lblUserName.TabIndex = 2
		Me.lblUserName.Text = "Welcome, Jeff King"
		Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'SplitContainerContentMain
		'
		Me.SplitContainerContentMain.BackColor = System.Drawing.Color.White
		Me.SplitContainerContentMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerContentMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainerContentMain.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainerContentMain.Margin = New System.Windows.Forms.Padding(0)
		Me.SplitContainerContentMain.Name = "SplitContainerContentMain"
		'
		'SplitContainerContentMain.Panel1
		'
		Me.SplitContainerContentMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainerContentMain.Panel1.Controls.Add(Me.pnlHomeSummary)
		Me.SplitContainerContentMain.Panel1MinSize = 0
		'
		'SplitContainerContentMain.Panel2
		'
		Me.SplitContainerContentMain.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.SplitContainerContentMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.SplitContainerContentMain.Panel2.Controls.Add(Me.pnlMainBack)
		Me.SplitContainerContentMain.Panel2MinSize = 0
		Me.SplitContainerContentMain.Size = New System.Drawing.Size(998, 477)
		Me.SplitContainerContentMain.SplitterDistance = 122
		Me.SplitContainerContentMain.SplitterWidth = 1
		Me.SplitContainerContentMain.TabIndex = 0
		'
		'pnlHomeSummary
		'
		Me.pnlHomeSummary.BackColor = System.Drawing.Color.Transparent
		Me.pnlHomeSummary.BackgroundImage = Global.AE_Ground.My.Resources.Resources.GrayFade_UPRIGHT
		Me.pnlHomeSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlHomeSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlHomeSummary.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlHomeSummary.Location = New System.Drawing.Point(0, 0)
		Me.pnlHomeSummary.Margin = New System.Windows.Forms.Padding(0)
		Me.pnlHomeSummary.Name = "pnlHomeSummary"
		Me.pnlHomeSummary.Size = New System.Drawing.Size(122, 477)
		Me.pnlHomeSummary.TabIndex = 1
		'
		'pnlMainBack
		'
		Me.pnlMainBack.BackColor = System.Drawing.Color.Transparent
		Me.pnlMainBack.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.pnlMainBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlMainBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlMainBack.Controls.Add(Me.ComboBox1)
		Me.pnlMainBack.Controls.Add(Me.pnlTime)
		Me.pnlMainBack.Controls.Add(Me.pnlProductions)
		Me.pnlMainBack.Controls.Add(Me.ShapeContainer1)
		Me.pnlMainBack.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlMainBack.Location = New System.Drawing.Point(0, 0)
		Me.pnlMainBack.Margin = New System.Windows.Forms.Padding(0)
		Me.pnlMainBack.Name = "pnlMainBack"
		Me.pnlMainBack.Size = New System.Drawing.Size(875, 477)
		Me.pnlMainBack.TabIndex = 0
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(35, 228)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 35
		'
		'pnlTime
		'
		Me.pnlTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlTime.Controls.Add(Me.btnTime)
		Me.pnlTime.Controls.Add(Me.Label20)
		Me.pnlTime.Controls.Add(Me.Label19)
		Me.pnlTime.Controls.Add(Me.lblSubmitCaption)
		Me.pnlTime.Controls.Add(Me.btnSubmitTime)
		Me.pnlTime.Controls.Add(Me.lblSubmitTime)
		Me.pnlTime.Location = New System.Drawing.Point(20, 265)
		Me.pnlTime.Name = "pnlTime"
		Me.pnlTime.Size = New System.Drawing.Size(710, 181)
		Me.pnlTime.TabIndex = 31
		'
		'btnTime
		'
		Me.btnTime.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTime.ForeColor = System.Drawing.Color.ForestGreen
		Me.btnTime.Image = Global.AE_Ground.My.Resources.Resources.timeCalendar
		Me.btnTime.Location = New System.Drawing.Point(129, 13)
		Me.btnTime.Name = "btnTime"
		Me.btnTime.Size = New System.Drawing.Size(160, 127)
		Me.btnTime.TabIndex = 6
		Me.btnTime.UseVisualStyleBackColor = True
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.ForeColor = System.Drawing.Color.MediumBlue
		Me.Label20.Location = New System.Drawing.Point(126, 143)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(86, 16)
		Me.Label20.TabIndex = 0
		Me.Label20.Text = "Enter Time"
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(159, 159)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(94, 13)
		Me.Label19.TabIndex = 1
		Me.Label19.Text = "Enter time for all personnel"
		'
		'lblSubmitCaption
		'
		Me.lblSubmitCaption.AutoSize = True
		Me.lblSubmitCaption.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubmitCaption.Location = New System.Drawing.Point(462, 159)
		Me.lblSubmitCaption.Name = "lblSubmitCaption"
		Me.lblSubmitCaption.Size = New System.Drawing.Size(100, 13)
		Me.lblSubmitCaption.TabIndex = 15
		Me.lblSubmitCaption.Text = "Submit time for all personnel"
		'
		'btnSubmitTime
		'
		Me.btnSubmitTime.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSubmitTime.ForeColor = System.Drawing.Color.ForestGreen
		Me.btnSubmitTime.Image = Global.AE_Ground.My.Resources.Resources.TimeClock
		Me.btnSubmitTime.Location = New System.Drawing.Point(433, 13)
		Me.btnSubmitTime.Name = "btnSubmitTime"
		Me.btnSubmitTime.Size = New System.Drawing.Size(160, 127)
		Me.btnSubmitTime.TabIndex = 13
		Me.btnSubmitTime.UseVisualStyleBackColor = True
		'
		'lblSubmitTime
		'
		Me.lblSubmitTime.AutoSize = True
		Me.lblSubmitTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubmitTime.ForeColor = System.Drawing.Color.MediumBlue
		Me.lblSubmitTime.Location = New System.Drawing.Point(430, 143)
		Me.lblSubmitTime.Name = "lblSubmitTime"
		Me.lblSubmitTime.Size = New System.Drawing.Size(98, 16)
		Me.lblSubmitTime.TabIndex = 14
		Me.lblSubmitTime.Text = "Submit Time"
		Me.lblSubmitTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'pnlProductions
		'
		Me.pnlProductions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.pnlProductions.Controls.Add(Me.Label9)
		Me.pnlProductions.Controls.Add(Me.btnDP)
		Me.pnlProductions.Controls.Add(Me.Label16)
		Me.pnlProductions.Controls.Add(Me.Label2)
		Me.pnlProductions.Controls.Add(Me.btnUpload)
		Me.pnlProductions.Controls.Add(Me.Label1)
		Me.pnlProductions.Location = New System.Drawing.Point(20, 14)
		Me.pnlProductions.Name = "pnlProductions"
		Me.pnlProductions.Size = New System.Drawing.Size(710, 181)
		Me.pnlProductions.TabIndex = 30
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(460, 164)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(136, 13)
		Me.Label9.TabIndex = 1
		Me.Label9.Text = "Send Daily Production, and Utility Hits. "
		'
		'btnDP
		'
		Me.btnDP.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDP.ForeColor = System.Drawing.Color.Black
		Me.btnDP.Image = Global.AE_Ground.My.Resources.Resources.GearsWindow
		Me.btnDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnDP.Location = New System.Drawing.Point(129, 16)
		Me.btnDP.Name = "btnDP"
		Me.btnDP.Size = New System.Drawing.Size(160, 127)
		Me.btnDP.TabIndex = 2
		Me.btnDP.UseVisualStyleBackColor = True
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.MediumBlue
		Me.Label16.Location = New System.Drawing.Point(430, 146)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(215, 18)
		Me.Label16.TabIndex = 0
		Me.Label16.Text = "Submit Daily Production"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(155, 164)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(118, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Enter your Daily Productions here."
		'
		'btnUpload
		'
		Me.btnUpload.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUpload.Image = Global.AE_Ground.My.Resources.Resources.SatelliteBig
		Me.btnUpload.Location = New System.Drawing.Point(433, 16)
		Me.btnUpload.Name = "btnUpload"
		Me.btnUpload.Size = New System.Drawing.Size(160, 127)
		Me.btnUpload.TabIndex = 5
		Me.btnUpload.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
		Me.Label1.Location = New System.Drawing.Point(126, 146)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(203, 18)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter Daily Production"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ShapeContainer1
		'
		Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
		Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
		Me.ShapeContainer1.Name = "ShapeContainer1"
		Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
		Me.ShapeContainer1.Size = New System.Drawing.Size(873, 475)
		Me.ShapeContainer1.TabIndex = 34
		Me.ShapeContainer1.TabStop = False
		'
		'LineShape1
		'
		Me.LineShape1.BorderColor = System.Drawing.Color.Black
		Me.LineShape1.Name = "LineShape1"
		Me.LineShape1.X1 = 727
		Me.LineShape1.X2 = 20
		Me.LineShape1.Y1 = 211
		Me.LineShape1.Y2 = 211
		'
		'bgWorker2
		'
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'QryJobDescriptionBindingSource
		'
		Me.QryJobDescriptionBindingSource.DataMember = "QryJobDescription"
		Me.QryJobDescriptionBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'QryJobDescriptionTableAdapter
		'
		Me.QryJobDescriptionTableAdapter.ClearBeforeFill = True
		'
		'frmAE_HomeExpress
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1000, 530)
		Me.Controls.Add(Me.SplitContainerMain)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmAE_HomeExpress"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Home - Express"
		Me.SplitContainerMain.Panel1.ResumeLayout(False)
		Me.SplitContainerMain.Panel2.ResumeLayout(False)
		Me.SplitContainerMain.ResumeLayout(False)
		Me.pnlTitleMain.ResumeLayout(False)
		Me.SplitContainerContentMain.Panel1.ResumeLayout(False)
		Me.SplitContainerContentMain.Panel2.ResumeLayout(False)
		Me.SplitContainerContentMain.ResumeLayout(False)
		Me.pnlMainBack.ResumeLayout(False)
		Me.pnlTime.ResumeLayout(False)
		Me.pnlTime.PerformLayout()
		Me.pnlProductions.ResumeLayout(False)
		Me.pnlProductions.PerformLayout()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryJobDescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainerMain As System.Windows.Forms.SplitContainer
	Friend WithEvents pnlTitleMain As System.Windows.Forms.Panel
	Friend WithEvents lblTodayDate As System.Windows.Forms.Label
	Friend WithEvents lblUserName As System.Windows.Forms.Label
	Friend WithEvents SplitContainerContentMain As System.Windows.Forms.SplitContainer
	Friend WithEvents pnlHomeSummary As System.Windows.Forms.Panel
	Friend WithEvents pnlMainBack As System.Windows.Forms.Panel
	Friend WithEvents lblSubmitCaption As System.Windows.Forms.Label
	Friend WithEvents lblSubmitTime As System.Windows.Forms.Label
	Friend WithEvents btnSubmitTime As System.Windows.Forms.Button
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents btnTime As System.Windows.Forms.Button
	Friend WithEvents pnlTime As System.Windows.Forms.Panel
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents btnUpload As System.Windows.Forms.Button
	Friend WithEvents pnlProductions As System.Windows.Forms.Panel
	Friend WithEvents btnDP As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
	Friend WithEvents bgWorker2 As System.ComponentModel.BackgroundWorker
	Friend WithEvents QryJobDescriptionBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryJobDescriptionTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.QryJobDescriptionTableAdapter
End Class
