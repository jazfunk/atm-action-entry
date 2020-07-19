<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataSyncProgress
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataSyncProgress))
		Me.pnlMain = New System.Windows.Forms.Panel
		Me.pnlTitleBar = New System.Windows.Forms.Panel
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblStatus = New System.Windows.Forms.Label
		Me.picAvatar = New System.Windows.Forms.PictureBox
		Me.lstTransferList = New System.Windows.Forms.ListBox
		Me.btnAction = New System.Windows.Forms.Button
		Me.btnCloseProgress = New System.Windows.Forms.Button
		Me.lblDisplayPercentage = New System.Windows.Forms.Label
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
		Me.pnlMain.SuspendLayout()
		Me.pnlTitleBar.SuspendLayout()
		CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlMain
		'
		Me.pnlMain.BackColor = System.Drawing.Color.Transparent
		Me.pnlMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlMain.Controls.Add(Me.pnlTitleBar)
		Me.pnlMain.Controls.Add(Me.lblStatus)
		Me.pnlMain.Controls.Add(Me.picAvatar)
		Me.pnlMain.Controls.Add(Me.lstTransferList)
		Me.pnlMain.Controls.Add(Me.btnAction)
		Me.pnlMain.Controls.Add(Me.btnCloseProgress)
		Me.pnlMain.Controls.Add(Me.lblDisplayPercentage)
		Me.pnlMain.Controls.Add(Me.ProgressBar1)
		Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlMain.Margin = New System.Windows.Forms.Padding(1)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(484, 207)
		Me.pnlMain.TabIndex = 0
		'
		'pnlTitleBar
		'
		Me.pnlTitleBar.BackgroundImage = Global.AE_Ground.My.Resources.Resources.progressTitleBar2
		Me.pnlTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pnlTitleBar.Controls.Add(Me.Label1)
		Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.pnlTitleBar.Name = "pnlTitleBar"
		Me.pnlTitleBar.Size = New System.Drawing.Size(482, 24)
		Me.pnlTitleBar.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(458, 0)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(20, 19)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "X"
		'
		'lblStatus
		'
		Me.lblStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblStatus.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.ForeColor = System.Drawing.Color.Black
		Me.lblStatus.Location = New System.Drawing.Point(11, 31)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
		Me.lblStatus.Size = New System.Drawing.Size(396, 28)
		Me.lblStatus.TabIndex = 1
		Me.lblStatus.Text = "Downloading File: 1 of 222"
		Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'picAvatar
		'
		Me.picAvatar.BackColor = System.Drawing.Color.Transparent
		Me.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.picAvatar.Image = Global.AE_Ground.My.Resources.Resources.Upload
		Me.picAvatar.Location = New System.Drawing.Point(11, 65)
		Me.picAvatar.Name = "picAvatar"
		Me.picAvatar.Size = New System.Drawing.Size(80, 80)
		Me.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picAvatar.TabIndex = 6
		Me.picAvatar.TabStop = False
		'
		'lstTransferList
		'
		Me.lstTransferList.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstTransferList.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.lstTransferList.FormattingEnabled = True
		Me.lstTransferList.ItemHeight = 15
		Me.lstTransferList.Location = New System.Drawing.Point(101, 65)
		Me.lstTransferList.Name = "lstTransferList"
		Me.lstTransferList.Size = New System.Drawing.Size(370, 94)
		Me.lstTransferList.TabIndex = 5
		'
		'btnAction
		'
		Me.btnAction.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAction.Location = New System.Drawing.Point(370, 164)
		Me.btnAction.Name = "btnAction"
		Me.btnAction.Size = New System.Drawing.Size(101, 26)
		Me.btnAction.TabIndex = 2
		Me.btnAction.Text = "START"
		Me.btnAction.UseVisualStyleBackColor = True
		'
		'btnCloseProgress
		'
		Me.btnCloseProgress.BackColor = System.Drawing.Color.Transparent
		Me.btnCloseProgress.Enabled = False
		Me.btnCloseProgress.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCloseProgress.ForeColor = System.Drawing.Color.Red
		Me.btnCloseProgress.Location = New System.Drawing.Point(410, 32)
		Me.btnCloseProgress.Margin = New System.Windows.Forms.Padding(0)
		Me.btnCloseProgress.Name = "btnCloseProgress"
		Me.btnCloseProgress.Size = New System.Drawing.Size(61, 26)
		Me.btnCloseProgress.TabIndex = 3
		Me.btnCloseProgress.Text = "STOP"
		Me.btnCloseProgress.UseVisualStyleBackColor = False
		'
		'lblDisplayPercentage
		'
		Me.lblDisplayPercentage.BackColor = System.Drawing.Color.Transparent
		Me.lblDisplayPercentage.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisplayPercentage.ForeColor = System.Drawing.Color.DimGray
		Me.lblDisplayPercentage.Location = New System.Drawing.Point(11, 151)
		Me.lblDisplayPercentage.Margin = New System.Windows.Forms.Padding(0)
		Me.lblDisplayPercentage.Name = "lblDisplayPercentage"
		Me.lblDisplayPercentage.Size = New System.Drawing.Size(80, 39)
		Me.lblDisplayPercentage.TabIndex = 4
		Me.lblDisplayPercentage.Text = "0%"
		Me.lblDisplayPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(101, 164)
		Me.ProgressBar1.MarqueeAnimationSpeed = 2
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(263, 26)
		Me.ProgressBar1.TabIndex = 0
		'
		'Timer1
		'
		'
		'BackgroundWorker1
		'
		Me.BackgroundWorker1.WorkerReportsProgress = True
		Me.BackgroundWorker1.WorkerSupportsCancellation = True
		'
		'frmDataSyncProgress
		'
		Me.AcceptButton = Me.btnAction
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(484, 207)
		Me.Controls.Add(Me.pnlMain)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmDataSyncProgress"
		Me.Opacity = 0.95
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "File Transfer (DataSync) Progress"
		Me.pnlMain.ResumeLayout(False)
		Me.pnlTitleBar.ResumeLayout(False)
		Me.pnlTitleBar.PerformLayout()
		CType(Me.picAvatar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlMain As System.Windows.Forms.Panel
	Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend WithEvents lblStatus As System.Windows.Forms.Label
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents btnAction As System.Windows.Forms.Button
	Friend WithEvents btnCloseProgress As System.Windows.Forms.Button
	Friend WithEvents lblDisplayPercentage As System.Windows.Forms.Label
	Friend WithEvents lstTransferList As System.Windows.Forms.ListBox
	Friend WithEvents picAvatar As System.Windows.Forms.PictureBox
	Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
