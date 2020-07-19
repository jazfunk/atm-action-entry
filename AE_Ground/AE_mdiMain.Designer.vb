<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AE_mdiMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AE_mdiMain))
		Me.MenuStrip = New System.Windows.Forms.MenuStrip
		Me.ToolStrip = New System.Windows.Forms.ToolStrip
		Me.btnCloseApp = New System.Windows.Forms.ToolStripButton
		Me.ToolStripButtonHome = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripSplitButtonProduction = New System.Windows.Forms.ToolStripSplitButton
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripSplitButtonDataSync = New System.Windows.Forms.ToolStripSplitButton
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripSplitButtonTime = New System.Windows.Forms.ToolStripSplitButton
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripDropDownButtonTesting = New System.Windows.Forms.ToolStripSplitButton
		Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.DailyProductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.NonPayItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.GuardRailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.UtilityHitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripDropDownButtonTools = New System.Windows.Forms.ToolStripDropDownButton
		Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.ActionMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.StatusStrip = New System.Windows.Forms.StatusStrip
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.ToolStripDateTimeStatusLabel1 = New AE_Ground.Wunnell.Windows.Forms.ToolStripDateTimeStatusLabel
		Me.ToolStrip.SuspendLayout()
		Me.StatusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
		Me.MenuStrip.TabIndex = 5
		Me.MenuStrip.Text = "MenuStrip"
		Me.MenuStrip.Visible = False
		'
		'ToolStrip
		'
		Me.ToolStrip.AutoSize = False
		Me.ToolStrip.Enabled = False
		Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
		Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCloseApp, Me.ToolStripButtonHome, Me.ToolStripSeparator1, Me.ToolStripSplitButtonProduction, Me.ToolStripSeparator2, Me.ToolStripSplitButtonDataSync, Me.ToolStripSeparator3, Me.ToolStripSplitButtonTime, Me.ToolStripSeparator4, Me.ToolStripDropDownButtonTesting, Me.ToolStripSeparator5, Me.ToolStripDropDownButtonTools})
		Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip.Name = "ToolStrip"
		Me.ToolStrip.Size = New System.Drawing.Size(720, 28)
		Me.ToolStrip.TabIndex = 6
		Me.ToolStrip.Text = "ToolStrip"
		'
		'btnCloseApp
		'
		Me.btnCloseApp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.btnCloseApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnCloseApp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCloseApp.ForeColor = System.Drawing.Color.Red
		Me.btnCloseApp.Image = Global.AE_Ground.My.Resources.Resources.onOffRedSmall
		Me.btnCloseApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.btnCloseApp.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnCloseApp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.btnCloseApp.Name = "btnCloseApp"
		Me.btnCloseApp.Size = New System.Drawing.Size(28, 28)
		Me.btnCloseApp.Text = "EXIT"
		Me.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnCloseApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		Me.btnCloseApp.ToolTipText = "EXIT ActionEntry"
		'
		'ToolStripButtonHome
		'
		Me.ToolStripButtonHome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStripButtonHome.Image = Global.AE_Ground.My.Resources.Resources.homeGreenSmall
		Me.ToolStripButtonHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.ToolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButtonHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripButtonHome.Name = "ToolStripButtonHome"
		Me.ToolStripButtonHome.Size = New System.Drawing.Size(75, 28)
		Me.ToolStripButtonHome.Text = "HOME"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.AutoSize = False
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(8, 31)
		'
		'ToolStripSplitButtonProduction
		'
		Me.ToolStripSplitButtonProduction.Image = Global.AE_Ground.My.Resources.Resources.gearsLightBlueSmall
		Me.ToolStripSplitButtonProduction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolStripSplitButtonProduction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.ToolStripSplitButtonProduction.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButtonProduction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripSplitButtonProduction.Name = "ToolStripSplitButtonProduction"
		Me.ToolStripSplitButtonProduction.Size = New System.Drawing.Size(111, 28)
		Me.ToolStripSplitButtonProduction.Text = "Production"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
		'
		'ToolStripSplitButtonDataSync
		'
		Me.ToolStripSplitButtonDataSync.Image = Global.AE_Ground.My.Resources.Resources.sateliteDish
		Me.ToolStripSplitButtonDataSync.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolStripSplitButtonDataSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.ToolStripSplitButtonDataSync.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButtonDataSync.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripSplitButtonDataSync.Name = "ToolStripSplitButtonDataSync"
		Me.ToolStripSplitButtonDataSync.Size = New System.Drawing.Size(101, 28)
		Me.ToolStripSplitButtonDataSync.Text = "DataSync"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
		'
		'ToolStripSplitButtonTime
		'
		Me.ToolStripSplitButtonTime.Image = Global.AE_Ground.My.Resources.Resources.clockLightBlueSmall
		Me.ToolStripSplitButtonTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolStripSplitButtonTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.ToolStripSplitButtonTime.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripSplitButtonTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripSplitButtonTime.Name = "ToolStripSplitButtonTime"
		Me.ToolStripSplitButtonTime.Size = New System.Drawing.Size(76, 28)
		Me.ToolStripSplitButtonTime.Text = "Time"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
		'
		'ToolStripDropDownButtonTesting
		'
		Me.ToolStripDropDownButtonTesting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
		Me.ToolStripDropDownButtonTesting.Enabled = False
		Me.ToolStripDropDownButtonTesting.Image = Global.AE_Ground.My.Resources.Resources.barGraphSmall
		Me.ToolStripDropDownButtonTesting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.ToolStripDropDownButtonTesting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.ToolStripDropDownButtonTesting.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripDropDownButtonTesting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripDropDownButtonTesting.Name = "ToolStripDropDownButtonTesting"
		Me.ToolStripDropDownButtonTesting.Size = New System.Drawing.Size(88, 28)
		Me.ToolStripDropDownButtonTesting.Text = "Review"
		'
		'ReportsToolStripMenuItem
		'
		Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyProductionToolStripMenuItem, Me.NonPayItemsToolStripMenuItem, Me.GuardRailToolStripMenuItem, Me.UtilityHitsToolStripMenuItem})
		Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
		Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
		Me.ReportsToolStripMenuItem.Text = "Reports"
		'
		'DailyProductionToolStripMenuItem
		'
		Me.DailyProductionToolStripMenuItem.Name = "DailyProductionToolStripMenuItem"
		Me.DailyProductionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.DailyProductionToolStripMenuItem.Text = "Daily Production"
		'
		'NonPayItemsToolStripMenuItem
		'
		Me.NonPayItemsToolStripMenuItem.Enabled = False
		Me.NonPayItemsToolStripMenuItem.Name = "NonPayItemsToolStripMenuItem"
		Me.NonPayItemsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.NonPayItemsToolStripMenuItem.Text = "Non Pay Items"
		'
		'GuardRailToolStripMenuItem
		'
		Me.GuardRailToolStripMenuItem.Enabled = False
		Me.GuardRailToolStripMenuItem.Name = "GuardRailToolStripMenuItem"
		Me.GuardRailToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.GuardRailToolStripMenuItem.Text = "Guard Rail"
		'
		'UtilityHitsToolStripMenuItem
		'
		Me.UtilityHitsToolStripMenuItem.Enabled = False
		Me.UtilityHitsToolStripMenuItem.Name = "UtilityHitsToolStripMenuItem"
		Me.UtilityHitsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
		Me.UtilityHitsToolStripMenuItem.Text = "Utility Hits"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
		'
		'ToolStripDropDownButtonTools
		'
		Me.ToolStripDropDownButtonTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ActionMailToolStripMenuItem, Me.OptionsToolStripMenuItem})
		Me.ToolStripDropDownButtonTools.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripDropDownButtonTools.Name = "ToolStripDropDownButtonTools"
		Me.ToolStripDropDownButtonTools.Size = New System.Drawing.Size(53, 25)
		Me.ToolStripDropDownButtonTools.Text = "Tools"
		'
		'SettingsToolStripMenuItem
		'
		Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
		Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
		Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
		Me.SettingsToolStripMenuItem.Text = "Settings"
		'
		'ChangePasswordToolStripMenuItem
		'
		Me.ChangePasswordToolStripMenuItem.Enabled = False
		Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
		Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
		'
		'ActionMailToolStripMenuItem
		'
		Me.ActionMailToolStripMenuItem.Name = "ActionMailToolStripMenuItem"
		Me.ActionMailToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
		Me.ActionMailToolStripMenuItem.Text = "ActionMail"
		'
		'OptionsToolStripMenuItem
		'
		Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
		Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
		Me.OptionsToolStripMenuItem.Text = "Options"
		'
		'StatusStrip
		'
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripDateTimeStatusLabel1, Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Size = New System.Drawing.Size(720, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.AutoSize = False
		Me.ToolStripStatusLabel.Margin = New System.Windows.Forms.Padding(0)
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(182, 22)
		Me.ToolStripStatusLabel.Text = "Status"
		Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.AutoSize = False
		Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(122, 22)
		Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ToolStripProgressBar1
		'
		Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.ToolStripProgressBar1.AutoSize = False
		Me.ToolStripProgressBar1.Margin = New System.Windows.Forms.Padding(4)
		Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
		Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 14)
		Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		'
		'ToolStripDateTimeStatusLabel1
		'
		Me.ToolStripDateTimeStatusLabel1.CustomFormat = "dddd, MMMM dd yyyy  h:mm:ss tt"
		Me.ToolStripDateTimeStatusLabel1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.ToolStripDateTimeStatusLabel1.Image = Global.AE_Ground.My.Resources.Resources.clock_1
		Me.ToolStripDateTimeStatusLabel1.Name = "ToolStripDateTimeStatusLabel1"
		Me.ToolStripDateTimeStatusLabel1.Size = New System.Drawing.Size(208, 16)
		Me.ToolStripDateTimeStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		'
		'AE_mdiMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(720, 453)
		Me.Controls.Add(Me.ToolStrip)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.StatusStrip)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.KeyPreview = True
		Me.MainMenuStrip = Me.MenuStrip
		Me.Name = "AE_mdiMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "ActionEntry"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ToolStrip.ResumeLayout(False)
		Me.ToolStrip.PerformLayout()
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
	Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
	Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
	Friend WithEvents btnCloseApp As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
	Friend WithEvents ToolStripDateTimeStatusLabel1 As AE_Ground.Wunnell.Windows.Forms.ToolStripDateTimeStatusLabel
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripButtonHome As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSplitButtonProduction As System.Windows.Forms.ToolStripSplitButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripSplitButtonDataSync As System.Windows.Forms.ToolStripSplitButton
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripSplitButtonTime As System.Windows.Forms.ToolStripSplitButton
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripDropDownButtonTools As System.Windows.Forms.ToolStripDropDownButton
	Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripDropDownButtonTesting As System.Windows.Forms.ToolStripSplitButton
	Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents DailyProductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents NonPayItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents GuardRailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents UtilityHitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ActionMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
