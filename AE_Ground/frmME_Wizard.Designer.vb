<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmME_Wizard
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
		Dim WindowsClassicWizardRenderer1 As ActiproSoftware.Wizard.WindowsClassicWizardRenderer = New ActiproSoftware.Wizard.WindowsClassicWizardRenderer
		Dim ImageBackgroundFill2 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim ImageBackgroundFill3 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim ImageBackgroundFill1 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmME_Wizard))
		Me.wzdManualEntry = New ActiproSoftware.Wizard.Wizard
		Me.wzdME_Welcome = New ActiproSoftware.Wizard.WizardWelcomePage
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblWelcome = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.wzdME_JobNumber = New ActiproSoftware.Wizard.WizardPage
		Me.lblJobPageCaption = New System.Windows.Forms.Label
		Me.lblJobDescription = New System.Windows.Forms.Label
		Me.btnChangeJob = New System.Windows.Forms.Button
		Me.lblJobNum = New System.Windows.Forms.Label
		Me.wzdME_Site = New ActiproSoftware.Wizard.WizardPage
		Me.lblInventory1 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.QryPayItemsByJobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.lblSetSite = New System.Windows.Forms.Label
		Me.lblTextToDisplay = New System.Windows.Forms.Label
		Me.txtSetSite = New System.Windows.Forms.TextBox
		Me.wzdME_Items = New ActiproSoftware.Wizard.WizardPage
		Me.lblInventory2 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.lblStation1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.lblUnitOfMeasure = New System.Windows.Forms.Label
		Me.lblDescription = New System.Windows.Forms.Label
		Me.lblCode = New System.Windows.Forms.Label
		Me.cmbJobPayItems = New System.Windows.Forms.ComboBox
		Me.lblSetItems = New System.Windows.Forms.Label
		Me.wzdME_Quantity = New ActiproSoftware.Wizard.WizardPage
		Me.lblInventory3 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.lblPIDesc1 = New System.Windows.Forms.Label
		Me.lblStation2 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.lblSetQuantity = New System.Windows.Forms.Label
		Me.txtME_PQty = New System.Windows.Forms.TextBox
		Me.lblUnitOfMeasure2 = New System.Windows.Forms.Label
		Me.wzdME_Notes = New ActiproSoftware.Wizard.WizardPage
		Me.btnSubmit = New System.Windows.Forms.Button
		Me.lblInventory4 = New System.Windows.Forms.Label
		Me.rtxtNotes = New System.Windows.Forms.RichTextBox
		Me.lblNotesCaption = New System.Windows.Forms.Label
		Me.wzdME_Finish = New ActiproSoftware.Wizard.WizardPage
		Me.lblFinish = New System.Windows.Forms.Label
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.pnlWizardParent = New System.Windows.Forms.Panel
		Me.QryPayItemsByJobTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryPayItemsByJobTableAdapter
		Me.TblDailyProductionsTableAdapter1 = New AE_Ground.ActionEntryDataSetTableAdapters.tblDailyProductionsTableAdapter
		CType(Me.wzdManualEntry, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.wzdME_Welcome.SuspendLayout()
		Me.wzdME_JobNumber.SuspendLayout()
		Me.wzdME_Site.SuspendLayout()
		CType(Me.QryPayItemsByJobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.wzdME_Items.SuspendLayout()
		Me.wzdME_Quantity.SuspendLayout()
		Me.wzdME_Notes.SuspendLayout()
		Me.wzdME_Finish.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlWizardParent.SuspendLayout()
		Me.SuspendLayout()
		'
		'wzdManualEntry
		'
		Me.wzdManualEntry.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wzdManualEntry.InteriorPageGuideLineCount = 0
		Me.wzdManualEntry.Location = New System.Drawing.Point(0, 0)
		Me.wzdManualEntry.Name = "wzdManualEntry"
		Me.wzdManualEntry.Pages.AddRange(New ActiproSoftware.Wizard.WizardPage() {Me.wzdME_Welcome, Me.wzdME_JobNumber, Me.wzdME_Site, Me.wzdME_Items, Me.wzdME_Quantity, Me.wzdME_Notes, Me.wzdME_Finish})
		WindowsClassicWizardRenderer1.WizardExteriorPageDefaultBackgroundFill = New ActiproSoftware.Drawing.SolidColorBackgroundFill(System.Drawing.Color.Transparent)
		ImageBackgroundFill2.Image = CType(resources.GetObject("ImageBackgroundFill2.Image"), System.Drawing.Image)
		ImageBackgroundFill2.Style = ActiproSoftware.Drawing.ImageBackgroundFillStyle.Stretch
		WindowsClassicWizardRenderer1.WizardInteriorPageDefaultBackgroundFill = ImageBackgroundFill2
		ImageBackgroundFill3.Image = CType(resources.GetObject("ImageBackgroundFill3.Image"), System.Drawing.Image)
		ImageBackgroundFill3.Style = ActiproSoftware.Drawing.ImageBackgroundFillStyle.Stretch
		WindowsClassicWizardRenderer1.WizardInteriorPageHeaderDefaultBackgroundFill = ImageBackgroundFill3
		WindowsClassicWizardRenderer1.WizardInteriorPageHeaderDefaultImage = Global.AE_Ground.My.Resources.Resources.AE_LT_2_48x48
		WindowsClassicWizardRenderer1.WizardPageCaptionForeColor = System.Drawing.Color.White
		WindowsClassicWizardRenderer1.WizardPageDescriptionForeColor = System.Drawing.Color.WhiteSmoke
		WindowsClassicWizardRenderer1.WizardWelcomePageWatermarkDefaultBackgroundFill = New ActiproSoftware.Drawing.SolidColorBackgroundFill(System.Drawing.Color.Transparent)
		Me.wzdManualEntry.Renderer = WindowsClassicWizardRenderer1
		Me.wzdManualEntry.Size = New System.Drawing.Size(578, 364)
		Me.wzdManualEntry.TabIndex = 0
		Me.wzdManualEntry.Text = "Wizard1"
		'
		'wzdME_Welcome
		'
		Me.wzdME_Welcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Welcome.BackColor = System.Drawing.SystemColors.Window
		Me.wzdME_Welcome.Controls.Add(Me.Label3)
		Me.wzdME_Welcome.Controls.Add(Me.lblWelcome)
		Me.wzdME_Welcome.Controls.Add(Me.Label1)
		Me.wzdME_Welcome.IsInteriorPage = False
		Me.wzdME_Welcome.Location = New System.Drawing.Point(0, 0)
		Me.wzdME_Welcome.Name = "wzdME_Welcome"
		Me.wzdME_Welcome.PageCaption = ""
		Me.wzdME_Welcome.PageDescription = ""
		Me.wzdME_Welcome.PageTitleBarText = "Manual Entry  - Welcome"
		Me.wzdME_Welcome.Size = New System.Drawing.Size(578, 325)
		Me.wzdME_Welcome.TabIndex = 0
		ImageBackgroundFill1.Image = CType(resources.GetObject("ImageBackgroundFill1.Image"), System.Drawing.Image)
		ImageBackgroundFill1.Style = ActiproSoftware.Drawing.ImageBackgroundFillStyle.TileFlipXY
		Me.wzdME_Welcome.WatermarkBackgroundFill = ImageBackgroundFill1
		Me.wzdME_Welcome.WatermarkImage = Global.AE_Ground.My.Resources.Resources.AE_LT
		Me.wzdME_Welcome.WatermarkImageLocation = New System.Drawing.Point(48, 24)
		Me.wzdME_Welcome.WatermarkImageSize = New System.Drawing.Size(110, 130)
		Me.wzdME_Welcome.WatermarkWidth = 104
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(319, 304)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(120, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "To continue, click Next."
		'
		'lblWelcome
		'
		Me.lblWelcome.Location = New System.Drawing.Point(178, 106)
		Me.lblWelcome.Name = "lblWelcome"
		Me.lblWelcome.Size = New System.Drawing.Size(312, 161)
		Me.lblWelcome.TabIndex = 1
		Me.lblWelcome.Text = resources.GetString("lblWelcome.Text")
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(178, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(312, 84)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Welcome to the Daily Productions Manual Entry Wizard"
		'
		'wzdME_JobNumber
		'
		Me.wzdME_JobNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_JobNumber.Controls.Add(Me.lblJobPageCaption)
		Me.wzdME_JobNumber.Controls.Add(Me.lblJobDescription)
		Me.wzdME_JobNumber.Controls.Add(Me.btnChangeJob)
		Me.wzdME_JobNumber.Controls.Add(Me.lblJobNum)
		Me.wzdME_JobNumber.Location = New System.Drawing.Point(16, 76)
		Me.wzdME_JobNumber.Name = "wzdME_JobNumber"
		Me.wzdME_JobNumber.PageCaption = "Job Information"
		Me.wzdME_JobNumber.PageDescription = "The Job/Project this Item will be applied to."
		Me.wzdME_JobNumber.PageTitleBarText = "Job Number"
		Me.wzdME_JobNumber.Size = New System.Drawing.Size(546, 233)
		Me.wzdME_JobNumber.TabIndex = 1
		'
		'lblJobPageCaption
		'
		Me.lblJobPageCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblJobPageCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobPageCaption.ForeColor = System.Drawing.Color.Black
		Me.lblJobPageCaption.Location = New System.Drawing.Point(47, 30)
		Me.lblJobPageCaption.Name = "lblJobPageCaption"
		Me.lblJobPageCaption.Size = New System.Drawing.Size(495, 22)
		Me.lblJobPageCaption.TabIndex = 3
		Me.lblJobPageCaption.Text = "This item will be added to Job:"
		'
		'lblJobDescription
		'
		Me.lblJobDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblJobDescription.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobDescription.ForeColor = System.Drawing.Color.Black
		Me.lblJobDescription.Location = New System.Drawing.Point(47, 134)
		Me.lblJobDescription.Name = "lblJobDescription"
		Me.lblJobDescription.Size = New System.Drawing.Size(495, 33)
		Me.lblJobDescription.TabIndex = 1
		Me.lblJobDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'btnChangeJob
		'
		Me.btnChangeJob.Location = New System.Drawing.Point(409, 207)
		Me.btnChangeJob.Name = "btnChangeJob"
		Me.btnChangeJob.Size = New System.Drawing.Size(133, 23)
		Me.btnChangeJob.TabIndex = 2
		Me.btnChangeJob.Text = "Select Different Job"
		Me.btnChangeJob.UseVisualStyleBackColor = True
		'
		'lblJobNum
		'
		Me.lblJobNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblJobNum.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNum.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNum.ForeColor = System.Drawing.Color.Black
		Me.lblJobNum.Location = New System.Drawing.Point(47, 71)
		Me.lblJobNum.Name = "lblJobNum"
		Me.lblJobNum.Size = New System.Drawing.Size(495, 55)
		Me.lblJobNum.TabIndex = 0
		Me.lblJobNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'wzdME_Site
		'
		Me.wzdME_Site.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Site.Controls.Add(Me.lblInventory1)
		Me.wzdME_Site.Controls.Add(Me.Label5)
		Me.wzdME_Site.Controls.Add(Me.lblSetSite)
		Me.wzdME_Site.Controls.Add(Me.lblTextToDisplay)
		Me.wzdME_Site.Controls.Add(Me.txtSetSite)
		Me.wzdME_Site.Location = New System.Drawing.Point(16, 76)
		Me.wzdME_Site.Name = "wzdME_Site"
		Me.wzdME_Site.PageCaption = "Assign Station Number"
		Me.wzdME_Site.PageDescription = "This Section will be automatically loaded with the next available Station Number." & _
			"  "
		Me.wzdME_Site.PageTitleBarText = "Job Site"
		Me.wzdME_Site.Size = New System.Drawing.Size(546, 233)
		Me.wzdME_Site.TabIndex = 2
		'
		'lblInventory1
		'
		Me.lblInventory1.AutoSize = True
		Me.lblInventory1.BackColor = System.Drawing.Color.Transparent
		Me.lblInventory1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInventory1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblInventory1.Location = New System.Drawing.Point(95, 180)
		Me.lblInventory1.Name = "lblInventory1"
		Me.lblInventory1.Size = New System.Drawing.Size(34, 15)
		Me.lblInventory1.TabIndex = 12
		Me.lblInventory1.Text = "Job#"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "jobNum", True))
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label5.Location = New System.Drawing.Point(3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(34, 15)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "Job#"
		'
		'QryPayItemsByJobBindingSource
		'
		Me.QryPayItemsByJobBindingSource.DataMember = "qryPayItemsByJob"
		Me.QryPayItemsByJobBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'lblSetSite
		'
		Me.lblSetSite.BackColor = System.Drawing.Color.Transparent
		Me.lblSetSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSetSite.ForeColor = System.Drawing.Color.Black
		Me.lblSetSite.Location = New System.Drawing.Point(47, 30)
		Me.lblSetSite.Name = "lblSetSite"
		Me.lblSetSite.Size = New System.Drawing.Size(495, 22)
		Me.lblSetSite.TabIndex = 4
		Me.lblSetSite.Text = "The following will be used as the Station Number for this Location:"
		'
		'lblTextToDisplay
		'
		Me.lblTextToDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblTextToDisplay.BackColor = System.Drawing.Color.Transparent
		Me.lblTextToDisplay.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTextToDisplay.ForeColor = System.Drawing.Color.Red
		Me.lblTextToDisplay.Location = New System.Drawing.Point(95, 133)
		Me.lblTextToDisplay.Name = "lblTextToDisplay"
		Me.lblTextToDisplay.Size = New System.Drawing.Size(353, 47)
		Me.lblTextToDisplay.TabIndex = 3
		Me.lblTextToDisplay.Text = "TODO:  Must determine whether to pre-populate this field, with yet-to-be-develope" & _
			"d logic, or allow user to set this value."
		Me.lblTextToDisplay.Visible = False
		'
		'txtSetSite
		'
		Me.txtSetSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSetSite.Location = New System.Drawing.Point(98, 71)
		Me.txtSetSite.Name = "txtSetSite"
		Me.txtSetSite.Size = New System.Drawing.Size(350, 47)
		Me.txtSetSite.TabIndex = 1
		Me.txtSetSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'wzdME_Items
		'
		Me.wzdME_Items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Items.Controls.Add(Me.lblInventory2)
		Me.wzdME_Items.Controls.Add(Me.Label6)
		Me.wzdME_Items.Controls.Add(Me.lblStation1)
		Me.wzdME_Items.Controls.Add(Me.Label2)
		Me.wzdME_Items.Controls.Add(Me.lblUnitOfMeasure)
		Me.wzdME_Items.Controls.Add(Me.lblDescription)
		Me.wzdME_Items.Controls.Add(Me.lblCode)
		Me.wzdME_Items.Controls.Add(Me.cmbJobPayItems)
		Me.wzdME_Items.Controls.Add(Me.lblSetItems)
		Me.wzdME_Items.Location = New System.Drawing.Point(16, 76)
		Me.wzdME_Items.Name = "wzdME_Items"
		Me.wzdME_Items.PageCaption = "Select Pay Item(s)"
		Me.wzdME_Items.PageDescription = "The item representing the work completed."
		Me.wzdME_Items.PageTitleBarText = "Items"
		Me.wzdME_Items.Size = New System.Drawing.Size(546, 233)
		Me.wzdME_Items.TabIndex = 3
		'
		'lblInventory2
		'
		Me.lblInventory2.AutoSize = True
		Me.lblInventory2.BackColor = System.Drawing.Color.Transparent
		Me.lblInventory2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInventory2.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblInventory2.Location = New System.Drawing.Point(3, 185)
		Me.lblInventory2.Name = "lblInventory2"
		Me.lblInventory2.Size = New System.Drawing.Size(34, 15)
		Me.lblInventory2.TabIndex = 13
		Me.lblInventory2.Text = "Job#"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label6.Location = New System.Drawing.Point(43, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(11, 15)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "/"
		'
		'lblStation1
		'
		Me.lblStation1.AutoSize = True
		Me.lblStation1.BackColor = System.Drawing.Color.Transparent
		Me.lblStation1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStation1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblStation1.Location = New System.Drawing.Point(59, 0)
		Me.lblStation1.Name = "lblStation1"
		Me.lblStation1.Size = New System.Drawing.Size(52, 15)
		Me.lblStation1.TabIndex = 11
		Me.lblStation1.Text = "Station#"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "jobNum", True))
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label2.Location = New System.Drawing.Point(3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(34, 15)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "Job#"
		'
		'lblUnitOfMeasure
		'
		Me.lblUnitOfMeasure.BackColor = System.Drawing.Color.Transparent
		Me.lblUnitOfMeasure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "unit", True))
		Me.lblUnitOfMeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUnitOfMeasure.ForeColor = System.Drawing.Color.Black
		Me.lblUnitOfMeasure.Location = New System.Drawing.Point(3, 151)
		Me.lblUnitOfMeasure.Name = "lblUnitOfMeasure"
		Me.lblUnitOfMeasure.Size = New System.Drawing.Size(353, 22)
		Me.lblUnitOfMeasure.TabIndex = 9
		Me.lblUnitOfMeasure.Text = "ft"
		'
		'lblDescription
		'
		Me.lblDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "description", True))
		Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Location = New System.Drawing.Point(3, 129)
		Me.lblDescription.Name = "lblDescription"
		Me.lblDescription.Size = New System.Drawing.Size(353, 22)
		Me.lblDescription.TabIndex = 8
		Me.lblDescription.Text = "3# Post"
		'
		'lblCode
		'
		Me.lblCode.BackColor = System.Drawing.Color.Transparent
		Me.lblCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "code", True))
		Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCode.ForeColor = System.Drawing.Color.Black
		Me.lblCode.Location = New System.Drawing.Point(3, 107)
		Me.lblCode.Name = "lblCode"
		Me.lblCode.Size = New System.Drawing.Size(353, 22)
		Me.lblCode.TabIndex = 7
		Me.lblCode.Text = "8100156"
		'
		'cmbJobPayItems
		'
		Me.cmbJobPayItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbJobPayItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbJobPayItems.DataSource = Me.QryPayItemsByJobBindingSource
		Me.cmbJobPayItems.DisplayMember = "description"
		Me.cmbJobPayItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbJobPayItems.FormattingEnabled = True
		Me.cmbJobPayItems.Location = New System.Drawing.Point(6, 76)
		Me.cmbJobPayItems.Name = "cmbJobPayItems"
		Me.cmbJobPayItems.Size = New System.Drawing.Size(536, 28)
		Me.cmbJobPayItems.TabIndex = 6
		Me.cmbJobPayItems.ValueMember = "payItemID"
		'
		'lblSetItems
		'
		Me.lblSetItems.BackColor = System.Drawing.Color.Transparent
		Me.lblSetItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSetItems.ForeColor = System.Drawing.Color.Black
		Me.lblSetItems.Location = New System.Drawing.Point(47, 30)
		Me.lblSetItems.Name = "lblSetItems"
		Me.lblSetItems.Size = New System.Drawing.Size(495, 22)
		Me.lblSetItems.TabIndex = 5
		Me.lblSetItems.Text = "Select item from the list:"
		'
		'wzdME_Quantity
		'
		Me.wzdME_Quantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Quantity.Controls.Add(Me.lblInventory3)
		Me.wzdME_Quantity.Controls.Add(Me.Label8)
		Me.wzdME_Quantity.Controls.Add(Me.Label7)
		Me.wzdME_Quantity.Controls.Add(Me.lblPIDesc1)
		Me.wzdME_Quantity.Controls.Add(Me.lblStation2)
		Me.wzdME_Quantity.Controls.Add(Me.Label4)
		Me.wzdME_Quantity.Controls.Add(Me.lblSetQuantity)
		Me.wzdME_Quantity.Controls.Add(Me.txtME_PQty)
		Me.wzdME_Quantity.Controls.Add(Me.lblUnitOfMeasure2)
		Me.wzdME_Quantity.Location = New System.Drawing.Point(16, 76)
		Me.wzdME_Quantity.Name = "wzdME_Quantity"
		Me.wzdME_Quantity.PageCaption = "Item Quantity"
		Me.wzdME_Quantity.PageDescription = "Enter the installed quantity for given Pay Item."
		Me.wzdME_Quantity.PageTitleBarText = "Item Quantity"
		Me.wzdME_Quantity.Size = New System.Drawing.Size(5272, 1321)
		Me.wzdME_Quantity.TabIndex = 4
		'
		'lblInventory3
		'
		Me.lblInventory3.AutoSize = True
		Me.lblInventory3.BackColor = System.Drawing.Color.Transparent
		Me.lblInventory3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInventory3.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblInventory3.Location = New System.Drawing.Point(95, 180)
		Me.lblInventory3.Name = "lblInventory3"
		Me.lblInventory3.Size = New System.Drawing.Size(34, 15)
		Me.lblInventory3.TabIndex = 16
		Me.lblInventory3.Text = "Job#"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label8.Location = New System.Drawing.Point(43, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(11, 15)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "/"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label7.Location = New System.Drawing.Point(117, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(11, 15)
		Me.Label7.TabIndex = 14
		Me.Label7.Text = "/"
		'
		'lblPIDesc1
		'
		Me.lblPIDesc1.AutoSize = True
		Me.lblPIDesc1.BackColor = System.Drawing.Color.Transparent
		Me.lblPIDesc1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "description", True))
		Me.lblPIDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPIDesc1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblPIDesc1.Location = New System.Drawing.Point(133, 0)
		Me.lblPIDesc1.Name = "lblPIDesc1"
		Me.lblPIDesc1.Size = New System.Drawing.Size(119, 15)
		Me.lblPIDesc1.TabIndex = 13
		Me.lblPIDesc1.Text = "Pay Item Description"
		'
		'lblStation2
		'
		Me.lblStation2.AutoSize = True
		Me.lblStation2.BackColor = System.Drawing.Color.Transparent
		Me.lblStation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStation2.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblStation2.Location = New System.Drawing.Point(59, 0)
		Me.lblStation2.Name = "lblStation2"
		Me.lblStation2.Size = New System.Drawing.Size(52, 15)
		Me.lblStation2.TabIndex = 12
		Me.lblStation2.Text = "Station#"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "jobNum", True))
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
		Me.Label4.Location = New System.Drawing.Point(3, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(34, 15)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Job#"
		'
		'lblSetQuantity
		'
		Me.lblSetQuantity.BackColor = System.Drawing.Color.Transparent
		Me.lblSetQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSetQuantity.ForeColor = System.Drawing.Color.Black
		Me.lblSetQuantity.Location = New System.Drawing.Point(47, 30)
		Me.lblSetQuantity.Name = "lblSetQuantity"
		Me.lblSetQuantity.Size = New System.Drawing.Size(495, 22)
		Me.lblSetQuantity.TabIndex = 6
		Me.lblSetQuantity.Text = "Enter the quantity installed"
		'
		'txtME_PQty
		'
		Me.txtME_PQty.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtME_PQty.Location = New System.Drawing.Point(98, 71)
		Me.txtME_PQty.Name = "txtME_PQty"
		Me.txtME_PQty.Size = New System.Drawing.Size(315, 63)
		Me.txtME_PQty.TabIndex = 1
		Me.txtME_PQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblUnitOfMeasure2
		'
		Me.lblUnitOfMeasure2.AutoSize = True
		Me.lblUnitOfMeasure2.BackColor = System.Drawing.Color.Transparent
		Me.lblUnitOfMeasure2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QryPayItemsByJobBindingSource, "unit", True))
		Me.lblUnitOfMeasure2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUnitOfMeasure2.Location = New System.Drawing.Point(419, 88)
		Me.lblUnitOfMeasure2.Name = "lblUnitOfMeasure2"
		Me.lblUnitOfMeasure2.Size = New System.Drawing.Size(58, 43)
		Me.lblUnitOfMeasure2.TabIndex = 0
		Me.lblUnitOfMeasure2.Text = "ea"
		'
		'wzdME_Notes
		'
		Me.wzdME_Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Notes.Controls.Add(Me.btnSubmit)
		Me.wzdME_Notes.Controls.Add(Me.lblInventory4)
		Me.wzdME_Notes.Controls.Add(Me.rtxtNotes)
		Me.wzdME_Notes.Controls.Add(Me.lblNotesCaption)
		Me.wzdME_Notes.Location = New System.Drawing.Point(16, 76)
		Me.wzdME_Notes.Name = "wzdME_Notes"
		Me.wzdME_Notes.PageCaption = "Notes"
		Me.wzdME_Notes.PageDescription = "Description for need of manual entry."
		Me.wzdME_Notes.Size = New System.Drawing.Size(5550, 1385)
		Me.wzdME_Notes.TabIndex = 5
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(12, 207)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
		Me.btnSubmit.TabIndex = 3
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		Me.btnSubmit.Visible = False
		'
		'lblInventory4
		'
		Me.lblInventory4.AutoSize = True
		Me.lblInventory4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInventory4.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblInventory4.Location = New System.Drawing.Point(95, 180)
		Me.lblInventory4.Name = "lblInventory4"
		Me.lblInventory4.Size = New System.Drawing.Size(34, 15)
		Me.lblInventory4.TabIndex = 2
		Me.lblInventory4.Text = "Job#"
		'
		'rtxtNotes
		'
		Me.rtxtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtNotes.Location = New System.Drawing.Point(51, 63)
		Me.rtxtNotes.Name = "rtxtNotes"
		Me.rtxtNotes.Size = New System.Drawing.Size(438, 114)
		Me.rtxtNotes.TabIndex = 1
		Me.rtxtNotes.Text = ""
		'
		'lblNotesCaption
		'
		Me.lblNotesCaption.AutoSize = True
		Me.lblNotesCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblNotesCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNotesCaption.Location = New System.Drawing.Point(47, 30)
		Me.lblNotesCaption.Name = "lblNotesCaption"
		Me.lblNotesCaption.Size = New System.Drawing.Size(232, 20)
		Me.lblNotesCaption.TabIndex = 0
		Me.lblNotesCaption.Text = "Notes - Reason for Manual Entry:"
		'
		'wzdME_Finish
		'
		Me.wzdME_Finish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdME_Finish.BackColor = System.Drawing.SystemColors.Window
		Me.wzdME_Finish.Controls.Add(Me.lblFinish)
		Me.wzdME_Finish.Controls.Add(Me.PictureBox1)
		Me.wzdME_Finish.IsInteriorPage = False
		Me.wzdME_Finish.Location = New System.Drawing.Point(0, 0)
		Me.wzdME_Finish.Name = "wzdME_Finish"
		Me.wzdME_Finish.Size = New System.Drawing.Size(5860, 1541)
		Me.wzdME_Finish.TabIndex = 6
		'
		'lblFinish
		'
		Me.lblFinish.AutoSize = True
		Me.lblFinish.Location = New System.Drawing.Point(312, 299)
		Me.lblFinish.Name = "lblFinish"
		Me.lblFinish.Size = New System.Drawing.Size(222, 13)
		Me.lblFinish.TabIndex = 1
		Me.lblFinish.Text = "Click Finsih to complete Manual Entry Wizard."
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(45, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(489, 293)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'pnlWizardParent
		'
		Me.pnlWizardParent.BackColor = System.Drawing.Color.Transparent
		Me.pnlWizardParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlWizardParent.Controls.Add(Me.wzdManualEntry)
		Me.pnlWizardParent.Location = New System.Drawing.Point(10, 9)
		Me.pnlWizardParent.Margin = New System.Windows.Forms.Padding(20)
		Me.pnlWizardParent.Name = "pnlWizardParent"
		Me.pnlWizardParent.Size = New System.Drawing.Size(580, 366)
		Me.pnlWizardParent.TabIndex = 1
		'
		'QryPayItemsByJobTableAdapter
		'
		Me.QryPayItemsByJobTableAdapter.ClearBeforeFill = True
		'
		'TblDailyProductionsTableAdapter1
		'
		Me.TblDailyProductionsTableAdapter1.ClearBeforeFill = True
		'
		'frmME_Wizard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.AE_LT
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(600, 385)
		Me.Controls.Add(Me.pnlWizardParent)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmME_Wizard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Daily Productions - Manual Entry Wizard"
		CType(Me.wzdManualEntry, System.ComponentModel.ISupportInitialize).EndInit()
		Me.wzdME_Welcome.ResumeLayout(False)
		Me.wzdME_Welcome.PerformLayout()
		Me.wzdME_JobNumber.ResumeLayout(False)
		Me.wzdME_Site.ResumeLayout(False)
		Me.wzdME_Site.PerformLayout()
		CType(Me.QryPayItemsByJobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.wzdME_Items.ResumeLayout(False)
		Me.wzdME_Items.PerformLayout()
		Me.wzdME_Quantity.ResumeLayout(False)
		Me.wzdME_Quantity.PerformLayout()
		Me.wzdME_Notes.ResumeLayout(False)
		Me.wzdME_Notes.PerformLayout()
		Me.wzdME_Finish.ResumeLayout(False)
		Me.wzdME_Finish.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlWizardParent.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents wzdManualEntry As ActiproSoftware.Wizard.Wizard
	Friend WithEvents wzdME_Welcome As ActiproSoftware.Wizard.WizardWelcomePage
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblWelcome As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents wzdME_JobNumber As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblJobDescription As System.Windows.Forms.Label
	Friend WithEvents lblJobNum As System.Windows.Forms.Label
	Friend WithEvents wzdME_Site As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents wzdME_Items As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents txtSetSite As System.Windows.Forms.TextBox
	Friend WithEvents lblTextToDisplay As System.Windows.Forms.Label
	Friend WithEvents btnChangeJob As System.Windows.Forms.Button
	Friend WithEvents lblJobPageCaption As System.Windows.Forms.Label
	Friend WithEvents lblSetSite As System.Windows.Forms.Label
	Friend WithEvents lblSetItems As System.Windows.Forms.Label
	Friend WithEvents pnlWizardParent As System.Windows.Forms.Panel
	Friend WithEvents cmbJobPayItems As System.Windows.Forms.ComboBox
	Friend WithEvents QryPayItemsByJobBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents QryPayItemsByJobTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryPayItemsByJobTableAdapter
	Friend WithEvents lblUnitOfMeasure As System.Windows.Forms.Label
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents lblCode As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents wzdME_Quantity As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblSetQuantity As System.Windows.Forms.Label
	Friend WithEvents txtME_PQty As System.Windows.Forms.TextBox
	Friend WithEvents lblUnitOfMeasure2 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents lblStation1 As System.Windows.Forms.Label
	Friend WithEvents lblPIDesc1 As System.Windows.Forms.Label
	Friend WithEvents lblStation2 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents lblInventory1 As System.Windows.Forms.Label
	Friend WithEvents lblInventory2 As System.Windows.Forms.Label
	Friend WithEvents lblInventory3 As System.Windows.Forms.Label
	Friend WithEvents wzdME_Notes As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblNotesCaption As System.Windows.Forms.Label
	Friend WithEvents lblInventory4 As System.Windows.Forms.Label
	Friend WithEvents rtxtNotes As System.Windows.Forms.RichTextBox
	Friend WithEvents wzdME_Finish As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblFinish As System.Windows.Forms.Label
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents btnSubmit As System.Windows.Forms.Button
	Friend WithEvents TblDailyProductionsTableAdapter1 As AE_Ground.ActionEntryDataSetTableAdapters.tblDailyProductionsTableAdapter
End Class
