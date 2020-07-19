<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.tb_Latitude = New System.Windows.Forms.TextBox
		Me.tb_Longitude = New System.Windows.Forms.TextBox
		Me.btn_ShowMap = New System.Windows.Forms.Button
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.txtURL = New System.Windows.Forms.TextBox
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.btnRefresh = New System.Windows.Forms.Button
		Me.btnStop = New System.Windows.Forms.Button
		Me.btnGo = New System.Windows.Forms.Button
		Me.btnForward = New System.Windows.Forms.Button
		Me.btnBack = New System.Windows.Forms.Button
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
		Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
		Me.StatusText = New System.Windows.Forms.ToolStripStatusLabel
		Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'tb_Latitude
		'
		Me.tb_Latitude.Location = New System.Drawing.Point(822, 15)
		Me.tb_Latitude.Name = "tb_Latitude"
		Me.tb_Latitude.Size = New System.Drawing.Size(149, 20)
		Me.tb_Latitude.TabIndex = 1
		'
		'tb_Longitude
		'
		Me.tb_Longitude.Location = New System.Drawing.Point(977, 15)
		Me.tb_Longitude.Name = "tb_Longitude"
		Me.tb_Longitude.Size = New System.Drawing.Size(149, 20)
		Me.tb_Longitude.TabIndex = 2
		'
		'btn_ShowMap
		'
		Me.btn_ShowMap.Location = New System.Drawing.Point(1132, 13)
		Me.btn_ShowMap.Name = "btn_ShowMap"
		Me.btn_ShowMap.Size = New System.Drawing.Size(75, 23)
		Me.btn_ShowMap.TabIndex = 3
		Me.btn_ShowMap.Text = "Show Link"
		Me.btn_ShowMap.UseVisualStyleBackColor = True
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(1255, 514)
		Me.WebBrowser1.TabIndex = 4
		'
		'txtURL
		'
		Me.txtURL.Location = New System.Drawing.Point(20, 13)
		Me.txtURL.Name = "txtURL"
		Me.txtURL.Size = New System.Drawing.Size(437, 20)
		Me.txtURL.TabIndex = 5
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.IsSplitterFixed = True
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnRefresh)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnStop)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btn_ShowMap)
		Me.SplitContainer1.Panel1.Controls.Add(Me.tb_Longitude)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnGo)
		Me.SplitContainer1.Panel1.Controls.Add(Me.tb_Latitude)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnForward)
		Me.SplitContainer1.Panel1.Controls.Add(Me.btnBack)
		Me.SplitContainer1.Panel1.Controls.Add(Me.txtURL)
		Me.SplitContainer1.Panel1MinSize = 55
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1255, 620)
		Me.SplitContainer1.SplitterDistance = 104
		Me.SplitContainer1.SplitterWidth = 2
		Me.SplitContainer1.TabIndex = 6
		'
		'btnRefresh
		'
		Me.btnRefresh.Location = New System.Drawing.Point(521, 12)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
		Me.btnRefresh.TabIndex = 10
		Me.btnRefresh.Text = "Refresh"
		Me.btnRefresh.UseVisualStyleBackColor = True
		'
		'btnStop
		'
		Me.btnStop.Location = New System.Drawing.Point(579, 12)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(52, 23)
		Me.btnStop.TabIndex = 9
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = True
		'
		'btnGo
		'
		Me.btnGo.Location = New System.Drawing.Point(463, 12)
		Me.btnGo.Name = "btnGo"
		Me.btnGo.Size = New System.Drawing.Size(52, 23)
		Me.btnGo.TabIndex = 8
		Me.btnGo.Text = "Go"
		Me.btnGo.UseVisualStyleBackColor = True
		'
		'btnForward
		'
		Me.btnForward.Location = New System.Drawing.Point(695, 12)
		Me.btnForward.Name = "btnForward"
		Me.btnForward.Size = New System.Drawing.Size(52, 23)
		Me.btnForward.TabIndex = 7
		Me.btnForward.Text = ">>"
		Me.btnForward.UseVisualStyleBackColor = True
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(637, 12)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(52, 23)
		Me.btnBack.TabIndex = 6
		Me.btnBack.Text = "<<"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.StatusText})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 598)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1255, 22)
		Me.StatusStrip1.TabIndex = 7
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
		'
		'StatusText
		'
		Me.StatusText.Name = "StatusText"
		Me.StatusText.Size = New System.Drawing.Size(35, 17)
		Me.StatusText.Text = "Done"
		'
		'LinkLabel1
		'
		Me.LinkLabel1.AutoSize = True
		Me.LinkLabel1.Location = New System.Drawing.Point(819, 38)
		Me.LinkLabel1.Name = "LinkLabel1"
		Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
		Me.LinkLabel1.TabIndex = 11
		Me.LinkLabel1.TabStop = True
		Me.LinkLabel1.Text = "LinkLabel1"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1255, 620)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.PerformLayout()
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tb_Latitude As System.Windows.Forms.TextBox
	Friend WithEvents tb_Longitude As System.Windows.Forms.TextBox
	Friend WithEvents btn_ShowMap As System.Windows.Forms.Button
	Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	Friend WithEvents txtURL As System.Windows.Forms.TextBox
	Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
	Friend WithEvents btnStop As System.Windows.Forms.Button
	Friend WithEvents btnGo As System.Windows.Forms.Button
	Friend WithEvents btnForward As System.Windows.Forms.Button
	Friend WithEvents btnBack As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Friend WithEvents StatusText As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
