<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUH_Wizard
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
		Dim ImageBackgroundFill1 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim ImageBackgroundFill2 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim ImageBackgroundFill3 As ActiproSoftware.Drawing.ImageBackgroundFill = New ActiproSoftware.Drawing.ImageBackgroundFill
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUH_Wizard))
		Me.pnlUtilityHitWizard = New System.Windows.Forms.Panel
		Me.wzdUH = New ActiproSoftware.Wizard.Wizard
		Me.wzdUH_Welcome = New ActiproSoftware.Wizard.WizardWelcomePage
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.wzdUH_JobNumber = New ActiproSoftware.Wizard.WizardPage
		Me.lblJobDescription = New System.Windows.Forms.Label
		Me.lblJobNumber = New System.Windows.Forms.Label
		Me.lblJobNumberCaption = New System.Windows.Forms.Label
		Me.wzdUH_StationNumber = New ActiproSoftware.Wizard.WizardPage
		Me.lblString1 = New System.Windows.Forms.Label
		Me.cmbStationNumber = New System.Windows.Forms.ComboBox
		Me.SiteListTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.rtxtPhysicalLocation = New System.Windows.Forms.RichTextBox
		Me.lblPhysicalLocation = New System.Windows.Forms.Label
		Me.lblSite = New System.Windows.Forms.Label
		Me.wzdUH_Time = New ActiproSoftware.Wizard.WizardPage
		Me.lblString2 = New System.Windows.Forms.Label
		Me.lblDate = New System.Windows.Forms.Label
		Me.dtpIncident = New System.Windows.Forms.DateTimePicker
		Me.wzdUH_UtilityType = New ActiproSoftware.Wizard.WizardPage
		Me.lblString3 = New System.Windows.Forms.Label
		Me.gpbUtilityStaked = New System.Windows.Forms.GroupBox
		Me.rbtnStakedNo = New System.Windows.Forms.RadioButton
		Me.rbtnStakedYes = New System.Windows.Forms.RadioButton
		Me.gpbUtilityType = New System.Windows.Forms.GroupBox
		Me.rbtnOther = New System.Windows.Forms.RadioButton
		Me.rbtnFreewayLighting = New System.Windows.Forms.RadioButton
		Me.rbtnMits = New System.Windows.Forms.RadioButton
		Me.rbtnSewer = New System.Windows.Forms.RadioButton
		Me.rbtnWater = New System.Windows.Forms.RadioButton
		Me.rbtnFiber = New System.Windows.Forms.RadioButton
		Me.rbtnPhone = New System.Windows.Forms.RadioButton
		Me.rbtnCable = New System.Windows.Forms.RadioButton
		Me.rbtnGas = New System.Windows.Forms.RadioButton
		Me.rBtnElectric = New System.Windows.Forms.RadioButton
		Me.wzdUH_OtherStaked = New ActiproSoftware.Wizard.WizardPage
		Me.lblString4 = New System.Windows.Forms.Label
		Me.gpbOtherStaked = New System.Windows.Forms.GroupBox
		Me.ckbFreewayLighting = New System.Windows.Forms.CheckBox
		Me.ckbMits = New System.Windows.Forms.CheckBox
		Me.ckbSewer = New System.Windows.Forms.CheckBox
		Me.ckbWater = New System.Windows.Forms.CheckBox
		Me.ckbFiber = New System.Windows.Forms.CheckBox
		Me.ckbPhone = New System.Windows.Forms.CheckBox
		Me.ckbCable = New System.Windows.Forms.CheckBox
		Me.ckbGas = New System.Windows.Forms.CheckBox
		Me.ckbElectric = New System.Windows.Forms.CheckBox
		Me.gpbOtherUtilities = New System.Windows.Forms.GroupBox
		Me.rbtnOtherUtilitiesNo = New System.Windows.Forms.RadioButton
		Me.rbtnOtherUtilitiesYes = New System.Windows.Forms.RadioButton
		Me.wzdUH_Responder = New ActiproSoftware.Wizard.WizardPage
		Me.lblString5 = New System.Windows.Forms.Label
		Me.rtxtResponder = New System.Windows.Forms.RichTextBox
		Me.lblResponder = New System.Windows.Forms.Label
		Me.wzdUH_Inspector = New ActiproSoftware.Wizard.WizardPage
		Me.lblString6 = New System.Windows.Forms.Label
		Me.rtxtInspector = New System.Windows.Forms.RichTextBox
		Me.gpbInspector = New System.Windows.Forms.GroupBox
		Me.rbtnInspectorNo = New System.Windows.Forms.RadioButton
		Me.rbtnInspectorYes = New System.Windows.Forms.RadioButton
		Me.lblInpectorDetails = New System.Windows.Forms.Label
		Me.lblInspectorCaption = New System.Windows.Forms.Label
		Me.wzdUH_Witnesses = New ActiproSoftware.Wizard.WizardPage
		Me.lblString7 = New System.Windows.Forms.Label
		Me.rtxtWitnesses = New System.Windows.Forms.RichTextBox
		Me.lblWitnessCaption = New System.Windows.Forms.Label
		Me.wzdUH_IncidentNotes = New ActiproSoftware.Wizard.WizardPage
		Me.btnAddTimeLineEvent = New System.Windows.Forms.Button
		Me.lstTimeLineEvents = New System.Windows.Forms.ListBox
		Me.lblString8 = New System.Windows.Forms.Label
		Me.rtxtIncidentNotes = New System.Windows.Forms.RichTextBox
		Me.lblIncidentCaption = New System.Windows.Forms.Label
		Me.wzdUH_PicUpload = New ActiproSoftware.Wizard.WizardPage
		Me.lblProcessing = New System.Windows.Forms.Label
		Me.lblNumProcessed = New System.Windows.Forms.Label
		Me.lstDrives = New System.Windows.Forms.ListBox
		Me.btnTransferImages = New System.Windows.Forms.Button
		Me.lblString9 = New System.Windows.Forms.Label
		Me.WizardPage1 = New ActiproSoftware.Wizard.WizardPage
		Me.lblFinish = New System.Windows.Forms.Label
		Me.picFinish = New System.Windows.Forms.PictureBox
		Me.DPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SiteListTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.SiteListTableAdapter
		Me.TimeReporting = New AE_Ground.TimeReporting
		Me.AtmUhDTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.pnlUtilityHitWizard.SuspendLayout()
		CType(Me.wzdUH, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.wzdUH_Welcome.SuspendLayout()
		Me.wzdUH_JobNumber.SuspendLayout()
		Me.wzdUH_StationNumber.SuspendLayout()
		CType(Me.SiteListTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.wzdUH_Time.SuspendLayout()
		Me.wzdUH_UtilityType.SuspendLayout()
		Me.gpbUtilityStaked.SuspendLayout()
		Me.gpbUtilityType.SuspendLayout()
		Me.wzdUH_OtherStaked.SuspendLayout()
		Me.gpbOtherStaked.SuspendLayout()
		Me.gpbOtherUtilities.SuspendLayout()
		Me.wzdUH_Responder.SuspendLayout()
		Me.wzdUH_Inspector.SuspendLayout()
		Me.gpbInspector.SuspendLayout()
		Me.wzdUH_Witnesses.SuspendLayout()
		Me.wzdUH_IncidentNotes.SuspendLayout()
		Me.wzdUH_PicUpload.SuspendLayout()
		Me.WizardPage1.SuspendLayout()
		CType(Me.picFinish, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TimeReporting, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.AtmUhDTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlUtilityHitWizard
		'
		Me.pnlUtilityHitWizard.BackColor = System.Drawing.Color.Transparent
		Me.pnlUtilityHitWizard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlUtilityHitWizard.Controls.Add(Me.wzdUH)
		Me.pnlUtilityHitWizard.Location = New System.Drawing.Point(10, 9)
		Me.pnlUtilityHitWizard.Margin = New System.Windows.Forms.Padding(20)
		Me.pnlUtilityHitWizard.Name = "pnlUtilityHitWizard"
		Me.pnlUtilityHitWizard.Size = New System.Drawing.Size(580, 366)
		Me.pnlUtilityHitWizard.TabIndex = 0
		'
		'wzdUH
		'
		Me.wzdUH.Dock = System.Windows.Forms.DockStyle.Fill
		Me.wzdUH.Location = New System.Drawing.Point(0, 0)
		Me.wzdUH.Name = "wzdUH"
		Me.wzdUH.Pages.AddRange(New ActiproSoftware.Wizard.WizardPage() {Me.wzdUH_Welcome, Me.wzdUH_JobNumber, Me.wzdUH_StationNumber, Me.wzdUH_Time, Me.wzdUH_UtilityType, Me.wzdUH_OtherStaked, Me.wzdUH_Responder, Me.wzdUH_Inspector, Me.wzdUH_Witnesses, Me.wzdUH_IncidentNotes, Me.wzdUH_PicUpload, Me.WizardPage1})
		ImageBackgroundFill1.Image = CType(resources.GetObject("ImageBackgroundFill1.Image"), System.Drawing.Image)
		WindowsClassicWizardRenderer1.WizardInteriorPageDefaultBackgroundFill = ImageBackgroundFill1
		ImageBackgroundFill2.Image = CType(resources.GetObject("ImageBackgroundFill2.Image"), System.Drawing.Image)
		WindowsClassicWizardRenderer1.WizardInteriorPageHeaderDefaultBackgroundFill = ImageBackgroundFill2
		WindowsClassicWizardRenderer1.WizardInteriorPageHeaderDefaultImage = Global.AE_Ground.My.Resources.Resources.CautionBoardInterstate
		WindowsClassicWizardRenderer1.WizardInteriorPageHeaderImageSize = New System.Drawing.Size(90, 45)
		WindowsClassicWizardRenderer1.WizardPageCaptionForeColor = System.Drawing.Color.Yellow
		WindowsClassicWizardRenderer1.WizardPageDescriptionForeColor = System.Drawing.Color.Yellow
		ImageBackgroundFill3.Image = CType(resources.GetObject("ImageBackgroundFill3.Image"), System.Drawing.Image)
		ImageBackgroundFill3.Style = ActiproSoftware.Drawing.ImageBackgroundFillStyle.TileFlipXY
		WindowsClassicWizardRenderer1.WizardWelcomePageWatermarkDefaultBackgroundFill = ImageBackgroundFill3
		Me.wzdUH.Renderer = WindowsClassicWizardRenderer1
		Me.wzdUH.Size = New System.Drawing.Size(578, 364)
		Me.wzdUH.TabIndex = 0
		Me.wzdUH.Text = "Wizard1"
		'
		'wzdUH_Welcome
		'
		Me.wzdUH_Welcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_Welcome.BackColor = System.Drawing.SystemColors.Window
		Me.wzdUH_Welcome.Controls.Add(Me.Label3)
		Me.wzdUH_Welcome.Controls.Add(Me.Label2)
		Me.wzdUH_Welcome.Controls.Add(Me.Label1)
		Me.wzdUH_Welcome.IsInteriorPage = False
		Me.wzdUH_Welcome.Location = New System.Drawing.Point(0, 0)
		Me.wzdUH_Welcome.Name = "wzdUH_Welcome"
		Me.wzdUH_Welcome.PageCaption = ""
		Me.wzdUH_Welcome.PageDescription = ""
		Me.wzdUH_Welcome.Size = New System.Drawing.Size(578, 325)
		Me.wzdUH_Welcome.TabIndex = 0
		Me.wzdUH_Welcome.WatermarkImage = Global.AE_Ground.My.Resources.Resources.CautionBoardInterstate
		Me.wzdUH_Welcome.WatermarkImageLocation = New System.Drawing.Point(94, 20)
		Me.wzdUH_Welcome.WatermarkImageSize = New System.Drawing.Size(140, 80)
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(271, 295)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(120, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "To continue, click Next."
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(271, 100)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(274, 165)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "This Wizard will guide you through steps to report a Utility Hit."
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(271, 21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(274, 55)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Welcome to the Utility Hit Wizard"
		'
		'wzdUH_JobNumber
		'
		Me.wzdUH_JobNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_JobNumber.Controls.Add(Me.lblJobDescription)
		Me.wzdUH_JobNumber.Controls.Add(Me.lblJobNumber)
		Me.wzdUH_JobNumber.Controls.Add(Me.lblJobNumberCaption)
		Me.wzdUH_JobNumber.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_JobNumber.Name = "wzdUH_JobNumber"
		Me.wzdUH_JobNumber.PageCaption = "ActionEntry Utility Hit Wizard"
		Me.wzdUH_JobNumber.PageDescription = "Confirm Job Number"
		Me.wzdUH_JobNumber.Size = New System.Drawing.Size(824, 297)
		Me.wzdUH_JobNumber.TabIndex = 1
		'
		'lblJobDescription
		'
		Me.lblJobDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblJobDescription.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobDescription.Location = New System.Drawing.Point(0, 126)
		Me.lblJobDescription.Name = "lblJobDescription"
		Me.lblJobDescription.Size = New System.Drawing.Size(546, 20)
		Me.lblJobDescription.TabIndex = 2
		Me.lblJobDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblJobNumber
		'
		Me.lblJobNumber.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumber.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumber.Location = New System.Drawing.Point(0, 66)
		Me.lblJobNumber.Name = "lblJobNumber"
		Me.lblJobNumber.Size = New System.Drawing.Size(546, 60)
		Me.lblJobNumber.TabIndex = 1
		Me.lblJobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblJobNumberCaption
		'
		Me.lblJobNumberCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblJobNumberCaption.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblJobNumberCaption.Location = New System.Drawing.Point(47, 20)
		Me.lblJobNumberCaption.Name = "lblJobNumberCaption"
		Me.lblJobNumberCaption.Size = New System.Drawing.Size(453, 46)
		Me.lblJobNumberCaption.TabIndex = 0
		Me.lblJobNumberCaption.Text = "Current Job.  To change, close this Wizard and select your Job # from the 'Enter " & _
			"Daily Productions' form."
		'
		'wzdUH_StationNumber
		'
		Me.wzdUH_StationNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_StationNumber.Controls.Add(Me.lblString1)
		Me.wzdUH_StationNumber.Controls.Add(Me.cmbStationNumber)
		Me.wzdUH_StationNumber.Controls.Add(Me.rtxtPhysicalLocation)
		Me.wzdUH_StationNumber.Controls.Add(Me.lblPhysicalLocation)
		Me.wzdUH_StationNumber.Controls.Add(Me.lblSite)
		Me.wzdUH_StationNumber.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_StationNumber.Name = "wzdUH_StationNumber"
		Me.wzdUH_StationNumber.PageCaption = "Station Number"
		Me.wzdUH_StationNumber.PageDescription = "Enter Station Number where Utility Hit ocurred."
		Me.wzdUH_StationNumber.Size = New System.Drawing.Size(824, 297)
		Me.wzdUH_StationNumber.TabIndex = 2
		'
		'lblString1
		'
		Me.lblString1.AutoSize = True
		Me.lblString1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString1.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString1.Location = New System.Drawing.Point(387, 220)
		Me.lblString1.Name = "lblString1"
		Me.lblString1.Size = New System.Drawing.Size(31, 16)
		Me.lblString1.TabIndex = 6
		Me.lblString1.Text = "Job#"
		'
		'cmbStationNumber
		'
		Me.cmbStationNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbStationNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbStationNumber.DataSource = Me.SiteListTableAdapterBindingSource
		Me.cmbStationNumber.DisplayMember = "site"
		Me.cmbStationNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbStationNumber.FormattingEnabled = True
		Me.cmbStationNumber.Location = New System.Drawing.Point(103, 43)
		Me.cmbStationNumber.Name = "cmbStationNumber"
		Me.cmbStationNumber.Size = New System.Drawing.Size(296, 26)
		Me.cmbStationNumber.TabIndex = 5
		Me.cmbStationNumber.ValueMember = "site"
		'
		'SiteListTableAdapterBindingSource
		'
		Me.SiteListTableAdapterBindingSource.DataMember = "SiteListTableAdapter"
		Me.SiteListTableAdapterBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'rtxtPhysicalLocation
		'
		Me.rtxtPhysicalLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtPhysicalLocation.Location = New System.Drawing.Point(103, 106)
		Me.rtxtPhysicalLocation.Name = "rtxtPhysicalLocation"
		Me.rtxtPhysicalLocation.Size = New System.Drawing.Size(371, 89)
		Me.rtxtPhysicalLocation.TabIndex = 3
		Me.rtxtPhysicalLocation.Text = ""
		'
		'lblPhysicalLocation
		'
		Me.lblPhysicalLocation.AutoSize = True
		Me.lblPhysicalLocation.BackColor = System.Drawing.Color.Transparent
		Me.lblPhysicalLocation.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPhysicalLocation.Location = New System.Drawing.Point(72, 83)
		Me.lblPhysicalLocation.Name = "lblPhysicalLocation"
		Me.lblPhysicalLocation.Size = New System.Drawing.Size(128, 20)
		Me.lblPhysicalLocation.TabIndex = 1
		Me.lblPhysicalLocation.Text = "Physical Location:"
		'
		'lblSite
		'
		Me.lblSite.AutoSize = True
		Me.lblSite.BackColor = System.Drawing.Color.Transparent
		Me.lblSite.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSite.Location = New System.Drawing.Point(72, 20)
		Me.lblSite.Name = "lblSite"
		Me.lblSite.Size = New System.Drawing.Size(120, 20)
		Me.lblSite.TabIndex = 0
		Me.lblSite.Text = "Station Number:"
		'
		'wzdUH_Time
		'
		Me.wzdUH_Time.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_Time.Controls.Add(Me.lblString2)
		Me.wzdUH_Time.Controls.Add(Me.lblDate)
		Me.wzdUH_Time.Controls.Add(Me.dtpIncident)
		Me.wzdUH_Time.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_Time.Name = "wzdUH_Time"
		Me.wzdUH_Time.PageCaption = "Time of Incident"
		Me.wzdUH_Time.PageDescription = "Select the Date and Time of the Incident. "
		Me.wzdUH_Time.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_Time.TabIndex = 3
		'
		'lblString2
		'
		Me.lblString2.AutoSize = True
		Me.lblString2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString2.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString2.Location = New System.Drawing.Point(387, 220)
		Me.lblString2.Name = "lblString2"
		Me.lblString2.Size = New System.Drawing.Size(31, 16)
		Me.lblString2.TabIndex = 7
		Me.lblString2.Text = "Job#"
		'
		'lblDate
		'
		Me.lblDate.AutoSize = True
		Me.lblDate.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDate.Location = New System.Drawing.Point(47, 30)
		Me.lblDate.Name = "lblDate"
		Me.lblDate.Size = New System.Drawing.Size(235, 20)
		Me.lblDate.TabIndex = 1
		Me.lblDate.Text = "Select Date and Time of Incident:"
		'
		'dtpIncident
		'
		Me.dtpIncident.CalendarMonthBackground = System.Drawing.Color.Transparent
		Me.dtpIncident.CustomFormat = "ddd MM/dd/yyy hh:mm tt"
		Me.dtpIncident.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpIncident.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpIncident.Location = New System.Drawing.Point(108, 75)
		Me.dtpIncident.Name = "dtpIncident"
		Me.dtpIncident.ShowUpDown = True
		Me.dtpIncident.Size = New System.Drawing.Size(359, 37)
		Me.dtpIncident.TabIndex = 0
		'
		'wzdUH_UtilityType
		'
		Me.wzdUH_UtilityType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_UtilityType.Controls.Add(Me.lblString3)
		Me.wzdUH_UtilityType.Controls.Add(Me.gpbUtilityStaked)
		Me.wzdUH_UtilityType.Controls.Add(Me.gpbUtilityType)
		Me.wzdUH_UtilityType.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_UtilityType.Name = "wzdUH_UtilityType"
		Me.wzdUH_UtilityType.PageCaption = "Utility Type"
		Me.wzdUH_UtilityType.PageDescription = "What type of Utility was Hit?"
		Me.wzdUH_UtilityType.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_UtilityType.TabIndex = 4
		'
		'lblString3
		'
		Me.lblString3.AutoSize = True
		Me.lblString3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString3.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString3.Location = New System.Drawing.Point(387, 220)
		Me.lblString3.Name = "lblString3"
		Me.lblString3.Size = New System.Drawing.Size(31, 16)
		Me.lblString3.TabIndex = 7
		Me.lblString3.Text = "Job#"
		'
		'gpbUtilityStaked
		'
		Me.gpbUtilityStaked.BackColor = System.Drawing.Color.Transparent
		Me.gpbUtilityStaked.Controls.Add(Me.rbtnStakedNo)
		Me.gpbUtilityStaked.Controls.Add(Me.rbtnStakedYes)
		Me.gpbUtilityStaked.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gpbUtilityStaked.Location = New System.Drawing.Point(35, 142)
		Me.gpbUtilityStaked.Name = "gpbUtilityStaked"
		Me.gpbUtilityStaked.Size = New System.Drawing.Size(235, 79)
		Me.gpbUtilityStaked.TabIndex = 1
		Me.gpbUtilityStaked.TabStop = False
		Me.gpbUtilityStaked.Text = "Was the Utility Staked?"
		'
		'rbtnStakedNo
		'
		Me.rbtnStakedNo.AutoSize = True
		Me.rbtnStakedNo.Location = New System.Drawing.Point(149, 36)
		Me.rbtnStakedNo.Name = "rbtnStakedNo"
		Me.rbtnStakedNo.Size = New System.Drawing.Size(45, 24)
		Me.rbtnStakedNo.TabIndex = 1
		Me.rbtnStakedNo.TabStop = True
		Me.rbtnStakedNo.Text = "No"
		Me.rbtnStakedNo.UseVisualStyleBackColor = True
		'
		'rbtnStakedYes
		'
		Me.rbtnStakedYes.AutoSize = True
		Me.rbtnStakedYes.Location = New System.Drawing.Point(47, 36)
		Me.rbtnStakedYes.Name = "rbtnStakedYes"
		Me.rbtnStakedYes.Size = New System.Drawing.Size(50, 24)
		Me.rbtnStakedYes.TabIndex = 0
		Me.rbtnStakedYes.TabStop = True
		Me.rbtnStakedYes.Text = "Yes"
		Me.rbtnStakedYes.UseVisualStyleBackColor = True
		'
		'gpbUtilityType
		'
		Me.gpbUtilityType.BackColor = System.Drawing.Color.Transparent
		Me.gpbUtilityType.Controls.Add(Me.rbtnOther)
		Me.gpbUtilityType.Controls.Add(Me.rbtnFreewayLighting)
		Me.gpbUtilityType.Controls.Add(Me.rbtnMits)
		Me.gpbUtilityType.Controls.Add(Me.rbtnSewer)
		Me.gpbUtilityType.Controls.Add(Me.rbtnWater)
		Me.gpbUtilityType.Controls.Add(Me.rbtnFiber)
		Me.gpbUtilityType.Controls.Add(Me.rbtnPhone)
		Me.gpbUtilityType.Controls.Add(Me.rbtnCable)
		Me.gpbUtilityType.Controls.Add(Me.rbtnGas)
		Me.gpbUtilityType.Controls.Add(Me.rBtnElectric)
		Me.gpbUtilityType.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gpbUtilityType.Location = New System.Drawing.Point(35, 3)
		Me.gpbUtilityType.Name = "gpbUtilityType"
		Me.gpbUtilityType.Size = New System.Drawing.Size(481, 124)
		Me.gpbUtilityType.TabIndex = 0
		Me.gpbUtilityType.TabStop = False
		Me.gpbUtilityType.Text = "What type of Utility was Hit?"
		'
		'rbtnOther
		'
		Me.rbtnOther.AutoSize = True
		Me.rbtnOther.Location = New System.Drawing.Point(394, 30)
		Me.rbtnOther.Name = "rbtnOther"
		Me.rbtnOther.Size = New System.Drawing.Size(65, 24)
		Me.rbtnOther.TabIndex = 9
		Me.rbtnOther.TabStop = True
		Me.rbtnOther.Text = "Other"
		Me.rbtnOther.UseVisualStyleBackColor = True
		'
		'rbtnFreewayLighting
		'
		Me.rbtnFreewayLighting.AutoSize = True
		Me.rbtnFreewayLighting.Location = New System.Drawing.Point(241, 96)
		Me.rbtnFreewayLighting.Name = "rbtnFreewayLighting"
		Me.rbtnFreewayLighting.Size = New System.Drawing.Size(142, 24)
		Me.rbtnFreewayLighting.TabIndex = 8
		Me.rbtnFreewayLighting.TabStop = True
		Me.rbtnFreewayLighting.Text = "Freeway Lighting"
		Me.rbtnFreewayLighting.UseVisualStyleBackColor = True
		'
		'rbtnMits
		'
		Me.rbtnMits.AutoSize = True
		Me.rbtnMits.Location = New System.Drawing.Point(241, 63)
		Me.rbtnMits.Name = "rbtnMits"
		Me.rbtnMits.Size = New System.Drawing.Size(54, 24)
		Me.rbtnMits.TabIndex = 7
		Me.rbtnMits.TabStop = True
		Me.rbtnMits.Text = "Mits"
		Me.rbtnMits.UseVisualStyleBackColor = True
		'
		'rbtnSewer
		'
		Me.rbtnSewer.AutoSize = True
		Me.rbtnSewer.Location = New System.Drawing.Point(241, 30)
		Me.rbtnSewer.Name = "rbtnSewer"
		Me.rbtnSewer.Size = New System.Drawing.Size(67, 24)
		Me.rbtnSewer.TabIndex = 6
		Me.rbtnSewer.TabStop = True
		Me.rbtnSewer.Text = "Sewer"
		Me.rbtnSewer.UseVisualStyleBackColor = True
		'
		'rbtnWater
		'
		Me.rbtnWater.AutoSize = True
		Me.rbtnWater.Location = New System.Drawing.Point(149, 96)
		Me.rbtnWater.Name = "rbtnWater"
		Me.rbtnWater.Size = New System.Drawing.Size(68, 24)
		Me.rbtnWater.TabIndex = 5
		Me.rbtnWater.TabStop = True
		Me.rbtnWater.Text = "Water"
		Me.rbtnWater.UseVisualStyleBackColor = True
		'
		'rbtnFiber
		'
		Me.rbtnFiber.AutoSize = True
		Me.rbtnFiber.Location = New System.Drawing.Point(149, 63)
		Me.rbtnFiber.Name = "rbtnFiber"
		Me.rbtnFiber.Size = New System.Drawing.Size(61, 24)
		Me.rbtnFiber.TabIndex = 4
		Me.rbtnFiber.TabStop = True
		Me.rbtnFiber.Text = "Fiber"
		Me.rbtnFiber.UseVisualStyleBackColor = True
		'
		'rbtnPhone
		'
		Me.rbtnPhone.AutoSize = True
		Me.rbtnPhone.Location = New System.Drawing.Point(149, 30)
		Me.rbtnPhone.Name = "rbtnPhone"
		Me.rbtnPhone.Size = New System.Drawing.Size(67, 24)
		Me.rbtnPhone.TabIndex = 3
		Me.rbtnPhone.TabStop = True
		Me.rbtnPhone.Text = "Phone"
		Me.rbtnPhone.UseVisualStyleBackColor = True
		'
		'rbtnCable
		'
		Me.rbtnCable.AutoSize = True
		Me.rbtnCable.Location = New System.Drawing.Point(47, 96)
		Me.rbtnCable.Name = "rbtnCable"
		Me.rbtnCable.Size = New System.Drawing.Size(63, 24)
		Me.rbtnCable.TabIndex = 2
		Me.rbtnCable.TabStop = True
		Me.rbtnCable.Text = "Cable"
		Me.rbtnCable.UseVisualStyleBackColor = True
		'
		'rbtnGas
		'
		Me.rbtnGas.AutoSize = True
		Me.rbtnGas.Location = New System.Drawing.Point(47, 63)
		Me.rbtnGas.Name = "rbtnGas"
		Me.rbtnGas.Size = New System.Drawing.Size(51, 24)
		Me.rbtnGas.TabIndex = 1
		Me.rbtnGas.TabStop = True
		Me.rbtnGas.Text = "Gas"
		Me.rbtnGas.UseVisualStyleBackColor = True
		'
		'rBtnElectric
		'
		Me.rBtnElectric.AutoSize = True
		Me.rBtnElectric.Location = New System.Drawing.Point(47, 30)
		Me.rBtnElectric.Name = "rBtnElectric"
		Me.rBtnElectric.Size = New System.Drawing.Size(76, 24)
		Me.rBtnElectric.TabIndex = 0
		Me.rBtnElectric.TabStop = True
		Me.rBtnElectric.Text = "Electric"
		Me.rBtnElectric.UseVisualStyleBackColor = True
		'
		'wzdUH_OtherStaked
		'
		Me.wzdUH_OtherStaked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_OtherStaked.Controls.Add(Me.lblString4)
		Me.wzdUH_OtherStaked.Controls.Add(Me.gpbOtherStaked)
		Me.wzdUH_OtherStaked.Controls.Add(Me.gpbOtherUtilities)
		Me.wzdUH_OtherStaked.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_OtherStaked.Name = "wzdUH_OtherStaked"
		Me.wzdUH_OtherStaked.PageCaption = "Utilites Staked"
		Me.wzdUH_OtherStaked.PageDescription = "Note if Other Utilities were staked."
		Me.wzdUH_OtherStaked.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_OtherStaked.TabIndex = 5
		'
		'lblString4
		'
		Me.lblString4.AutoSize = True
		Me.lblString4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString4.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString4.Location = New System.Drawing.Point(387, 220)
		Me.lblString4.Name = "lblString4"
		Me.lblString4.Size = New System.Drawing.Size(31, 16)
		Me.lblString4.TabIndex = 7
		Me.lblString4.Text = "Job#"
		'
		'gpbOtherStaked
		'
		Me.gpbOtherStaked.BackColor = System.Drawing.Color.Transparent
		Me.gpbOtherStaked.Controls.Add(Me.ckbFreewayLighting)
		Me.gpbOtherStaked.Controls.Add(Me.ckbMits)
		Me.gpbOtherStaked.Controls.Add(Me.ckbSewer)
		Me.gpbOtherStaked.Controls.Add(Me.ckbWater)
		Me.gpbOtherStaked.Controls.Add(Me.ckbFiber)
		Me.gpbOtherStaked.Controls.Add(Me.ckbPhone)
		Me.gpbOtherStaked.Controls.Add(Me.ckbCable)
		Me.gpbOtherStaked.Controls.Add(Me.ckbGas)
		Me.gpbOtherStaked.Controls.Add(Me.ckbElectric)
		Me.gpbOtherStaked.Enabled = False
		Me.gpbOtherStaked.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gpbOtherStaked.Location = New System.Drawing.Point(30, 88)
		Me.gpbOtherStaked.Name = "gpbOtherStaked"
		Me.gpbOtherStaked.Size = New System.Drawing.Size(484, 127)
		Me.gpbOtherStaked.TabIndex = 1
		Me.gpbOtherStaked.TabStop = False
		Me.gpbOtherStaked.Text = "Which Utilities Were Staked?"
		'
		'ckbFreewayLighting
		'
		Me.ckbFreewayLighting.AutoSize = True
		Me.ckbFreewayLighting.Location = New System.Drawing.Point(315, 98)
		Me.ckbFreewayLighting.Name = "ckbFreewayLighting"
		Me.ckbFreewayLighting.Size = New System.Drawing.Size(138, 24)
		Me.ckbFreewayLighting.TabIndex = 8
		Me.ckbFreewayLighting.Text = "FreewayLighting"
		Me.ckbFreewayLighting.UseVisualStyleBackColor = True
		'
		'ckbMits
		'
		Me.ckbMits.AutoSize = True
		Me.ckbMits.Location = New System.Drawing.Point(315, 68)
		Me.ckbMits.Name = "ckbMits"
		Me.ckbMits.Size = New System.Drawing.Size(55, 24)
		Me.ckbMits.TabIndex = 7
		Me.ckbMits.Text = "Mits"
		Me.ckbMits.UseVisualStyleBackColor = True
		'
		'ckbSewer
		'
		Me.ckbSewer.AutoSize = True
		Me.ckbSewer.Location = New System.Drawing.Point(315, 38)
		Me.ckbSewer.Name = "ckbSewer"
		Me.ckbSewer.Size = New System.Drawing.Size(68, 24)
		Me.ckbSewer.TabIndex = 6
		Me.ckbSewer.Text = "Sewer"
		Me.ckbSewer.UseVisualStyleBackColor = True
		'
		'ckbWater
		'
		Me.ckbWater.AutoSize = True
		Me.ckbWater.Location = New System.Drawing.Point(184, 98)
		Me.ckbWater.Name = "ckbWater"
		Me.ckbWater.Size = New System.Drawing.Size(69, 24)
		Me.ckbWater.TabIndex = 5
		Me.ckbWater.Text = "Water"
		Me.ckbWater.UseVisualStyleBackColor = True
		'
		'ckbFiber
		'
		Me.ckbFiber.AutoSize = True
		Me.ckbFiber.Location = New System.Drawing.Point(184, 68)
		Me.ckbFiber.Name = "ckbFiber"
		Me.ckbFiber.Size = New System.Drawing.Size(62, 24)
		Me.ckbFiber.TabIndex = 4
		Me.ckbFiber.Text = "Fiber"
		Me.ckbFiber.UseVisualStyleBackColor = True
		'
		'ckbPhone
		'
		Me.ckbPhone.AutoSize = True
		Me.ckbPhone.Location = New System.Drawing.Point(184, 38)
		Me.ckbPhone.Name = "ckbPhone"
		Me.ckbPhone.Size = New System.Drawing.Size(68, 24)
		Me.ckbPhone.TabIndex = 3
		Me.ckbPhone.Text = "Phone"
		Me.ckbPhone.UseVisualStyleBackColor = True
		'
		'ckbCable
		'
		Me.ckbCable.AutoSize = True
		Me.ckbCable.Location = New System.Drawing.Point(52, 98)
		Me.ckbCable.Name = "ckbCable"
		Me.ckbCable.Size = New System.Drawing.Size(64, 24)
		Me.ckbCable.TabIndex = 2
		Me.ckbCable.Text = "Cable"
		Me.ckbCable.UseVisualStyleBackColor = True
		'
		'ckbGas
		'
		Me.ckbGas.AutoSize = True
		Me.ckbGas.Location = New System.Drawing.Point(52, 68)
		Me.ckbGas.Name = "ckbGas"
		Me.ckbGas.Size = New System.Drawing.Size(52, 24)
		Me.ckbGas.TabIndex = 1
		Me.ckbGas.Text = "Gas"
		Me.ckbGas.UseVisualStyleBackColor = True
		'
		'ckbElectric
		'
		Me.ckbElectric.AutoSize = True
		Me.ckbElectric.Location = New System.Drawing.Point(52, 38)
		Me.ckbElectric.Name = "ckbElectric"
		Me.ckbElectric.Size = New System.Drawing.Size(77, 24)
		Me.ckbElectric.TabIndex = 0
		Me.ckbElectric.Text = "Electric"
		Me.ckbElectric.UseVisualStyleBackColor = True
		'
		'gpbOtherUtilities
		'
		Me.gpbOtherUtilities.BackColor = System.Drawing.Color.Transparent
		Me.gpbOtherUtilities.Controls.Add(Me.rbtnOtherUtilitiesNo)
		Me.gpbOtherUtilities.Controls.Add(Me.rbtnOtherUtilitiesYes)
		Me.gpbOtherUtilities.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gpbOtherUtilities.Location = New System.Drawing.Point(30, 4)
		Me.gpbOtherUtilities.Name = "gpbOtherUtilities"
		Me.gpbOtherUtilities.Size = New System.Drawing.Size(271, 78)
		Me.gpbOtherUtilities.TabIndex = 0
		Me.gpbOtherUtilities.TabStop = False
		Me.gpbOtherUtilities.Text = "Were Other Utilities Staked?"
		'
		'rbtnOtherUtilitiesNo
		'
		Me.rbtnOtherUtilitiesNo.AutoSize = True
		Me.rbtnOtherUtilitiesNo.Checked = True
		Me.rbtnOtherUtilitiesNo.Location = New System.Drawing.Point(184, 37)
		Me.rbtnOtherUtilitiesNo.Name = "rbtnOtherUtilitiesNo"
		Me.rbtnOtherUtilitiesNo.Size = New System.Drawing.Size(45, 24)
		Me.rbtnOtherUtilitiesNo.TabIndex = 1
		Me.rbtnOtherUtilitiesNo.TabStop = True
		Me.rbtnOtherUtilitiesNo.Text = "No"
		Me.rbtnOtherUtilitiesNo.UseVisualStyleBackColor = True
		'
		'rbtnOtherUtilitiesYes
		'
		Me.rbtnOtherUtilitiesYes.AutoSize = True
		Me.rbtnOtherUtilitiesYes.Location = New System.Drawing.Point(52, 37)
		Me.rbtnOtherUtilitiesYes.Name = "rbtnOtherUtilitiesYes"
		Me.rbtnOtherUtilitiesYes.Size = New System.Drawing.Size(50, 24)
		Me.rbtnOtherUtilitiesYes.TabIndex = 0
		Me.rbtnOtherUtilitiesYes.Text = "Yes"
		Me.rbtnOtherUtilitiesYes.UseVisualStyleBackColor = True
		'
		'wzdUH_Responder
		'
		Me.wzdUH_Responder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_Responder.Controls.Add(Me.lblString5)
		Me.wzdUH_Responder.Controls.Add(Me.rtxtResponder)
		Me.wzdUH_Responder.Controls.Add(Me.lblResponder)
		Me.wzdUH_Responder.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_Responder.Name = "wzdUH_Responder"
		Me.wzdUH_Responder.PageCaption = "Utility Responder"
		Me.wzdUH_Responder.PageDescription = "Person who responded to Utility Hit,"
		Me.wzdUH_Responder.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_Responder.TabIndex = 6
		'
		'lblString5
		'
		Me.lblString5.AutoSize = True
		Me.lblString5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString5.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString5.Location = New System.Drawing.Point(387, 220)
		Me.lblString5.Name = "lblString5"
		Me.lblString5.Size = New System.Drawing.Size(31, 16)
		Me.lblString5.TabIndex = 7
		Me.lblString5.Text = "Job#"
		'
		'rtxtResponder
		'
		Me.rtxtResponder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtResponder.Location = New System.Drawing.Point(51, 53)
		Me.rtxtResponder.Name = "rtxtResponder"
		Me.rtxtResponder.Size = New System.Drawing.Size(445, 135)
		Me.rtxtResponder.TabIndex = 1
		Me.rtxtResponder.Text = ""
		'
		'lblResponder
		'
		Me.lblResponder.AutoSize = True
		Me.lblResponder.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblResponder.Location = New System.Drawing.Point(47, 30)
		Me.lblResponder.Name = "lblResponder"
		Me.lblResponder.Size = New System.Drawing.Size(233, 20)
		Me.lblResponder.TabIndex = 0
		Me.lblResponder.Text = "Who responded to the Utility Hit?"
		'
		'wzdUH_Inspector
		'
		Me.wzdUH_Inspector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_Inspector.Controls.Add(Me.lblString6)
		Me.wzdUH_Inspector.Controls.Add(Me.rtxtInspector)
		Me.wzdUH_Inspector.Controls.Add(Me.gpbInspector)
		Me.wzdUH_Inspector.Controls.Add(Me.lblInpectorDetails)
		Me.wzdUH_Inspector.Controls.Add(Me.lblInspectorCaption)
		Me.wzdUH_Inspector.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_Inspector.Name = "wzdUH_Inspector"
		Me.wzdUH_Inspector.PageCaption = "Inspector"
		Me.wzdUH_Inspector.PageDescription = "Details about the inspector."
		Me.wzdUH_Inspector.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_Inspector.TabIndex = 7
		'
		'lblString6
		'
		Me.lblString6.AutoSize = True
		Me.lblString6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString6.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString6.Location = New System.Drawing.Point(387, 220)
		Me.lblString6.Name = "lblString6"
		Me.lblString6.Size = New System.Drawing.Size(31, 16)
		Me.lblString6.TabIndex = 7
		Me.lblString6.Text = "Job#"
		'
		'rtxtInspector
		'
		Me.rtxtInspector.Enabled = False
		Me.rtxtInspector.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtInspector.Location = New System.Drawing.Point(59, 101)
		Me.rtxtInspector.Name = "rtxtInspector"
		Me.rtxtInspector.Size = New System.Drawing.Size(450, 96)
		Me.rtxtInspector.TabIndex = 4
		Me.rtxtInspector.Text = ""
		'
		'gpbInspector
		'
		Me.gpbInspector.BackColor = System.Drawing.Color.Transparent
		Me.gpbInspector.Controls.Add(Me.rbtnInspectorNo)
		Me.gpbInspector.Controls.Add(Me.rbtnInspectorYes)
		Me.gpbInspector.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gpbInspector.Location = New System.Drawing.Point(59, 3)
		Me.gpbInspector.Name = "gpbInspector"
		Me.gpbInspector.Size = New System.Drawing.Size(227, 72)
		Me.gpbInspector.TabIndex = 3
		Me.gpbInspector.TabStop = False
		Me.gpbInspector.Text = "Was Inspector Present?"
		'
		'rbtnInspectorNo
		'
		Me.rbtnInspectorNo.AutoSize = True
		Me.rbtnInspectorNo.Checked = True
		Me.rbtnInspectorNo.Location = New System.Drawing.Point(146, 34)
		Me.rbtnInspectorNo.Name = "rbtnInspectorNo"
		Me.rbtnInspectorNo.Size = New System.Drawing.Size(45, 24)
		Me.rbtnInspectorNo.TabIndex = 1
		Me.rbtnInspectorNo.TabStop = True
		Me.rbtnInspectorNo.Text = "No"
		Me.rbtnInspectorNo.UseVisualStyleBackColor = True
		'
		'rbtnInspectorYes
		'
		Me.rbtnInspectorYes.AutoSize = True
		Me.rbtnInspectorYes.Location = New System.Drawing.Point(40, 34)
		Me.rbtnInspectorYes.Name = "rbtnInspectorYes"
		Me.rbtnInspectorYes.Size = New System.Drawing.Size(50, 24)
		Me.rbtnInspectorYes.TabIndex = 0
		Me.rbtnInspectorYes.Text = "Yes"
		Me.rbtnInspectorYes.UseVisualStyleBackColor = True
		'
		'lblInpectorDetails
		'
		Me.lblInpectorDetails.AutoSize = True
		Me.lblInpectorDetails.Location = New System.Drawing.Point(56, 200)
		Me.lblInpectorDetails.Name = "lblInpectorDetails"
		Me.lblInpectorDetails.Size = New System.Drawing.Size(243, 13)
		Me.lblInpectorDetails.TabIndex = 2
		Me.lblInpectorDetails.Text = "Include: Name, Inspector Number, Company, etc. "
		'
		'lblInspectorCaption
		'
		Me.lblInspectorCaption.AutoSize = True
		Me.lblInspectorCaption.BackColor = System.Drawing.Color.Transparent
		Me.lblInspectorCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInspectorCaption.Location = New System.Drawing.Point(55, 78)
		Me.lblInspectorCaption.Name = "lblInspectorCaption"
		Me.lblInspectorCaption.Size = New System.Drawing.Size(160, 20)
		Me.lblInspectorCaption.TabIndex = 0
		Me.lblInspectorCaption.Text = "Inspector Information:"
		'
		'wzdUH_Witnesses
		'
		Me.wzdUH_Witnesses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_Witnesses.Controls.Add(Me.lblString7)
		Me.wzdUH_Witnesses.Controls.Add(Me.rtxtWitnesses)
		Me.wzdUH_Witnesses.Controls.Add(Me.lblWitnessCaption)
		Me.wzdUH_Witnesses.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_Witnesses.Name = "wzdUH_Witnesses"
		Me.wzdUH_Witnesses.PageCaption = "Witnesses"
		Me.wzdUH_Witnesses.PageDescription = "List Witnesses to the incident."
		Me.wzdUH_Witnesses.Size = New System.Drawing.Size(1936, 553)
		Me.wzdUH_Witnesses.TabIndex = 8
		'
		'lblString7
		'
		Me.lblString7.AutoSize = True
		Me.lblString7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString7.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString7.Location = New System.Drawing.Point(387, 220)
		Me.lblString7.Name = "lblString7"
		Me.lblString7.Size = New System.Drawing.Size(31, 16)
		Me.lblString7.TabIndex = 7
		Me.lblString7.Text = "Job#"
		'
		'rtxtWitnesses
		'
		Me.rtxtWitnesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtWitnesses.Location = New System.Drawing.Point(51, 39)
		Me.rtxtWitnesses.Name = "rtxtWitnesses"
		Me.rtxtWitnesses.Size = New System.Drawing.Size(446, 149)
		Me.rtxtWitnesses.TabIndex = 1
		Me.rtxtWitnesses.Text = ""
		'
		'lblWitnessCaption
		'
		Me.lblWitnessCaption.AutoSize = True
		Me.lblWitnessCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWitnessCaption.Location = New System.Drawing.Point(47, 16)
		Me.lblWitnessCaption.Name = "lblWitnessCaption"
		Me.lblWitnessCaption.Size = New System.Drawing.Size(328, 20)
		Me.lblWitnessCaption.TabIndex = 0
		Me.lblWitnessCaption.Text = "List Witnesses to the incident (Employees First)"
		'
		'wzdUH_IncidentNotes
		'
		Me.wzdUH_IncidentNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_IncidentNotes.Controls.Add(Me.btnAddTimeLineEvent)
		Me.wzdUH_IncidentNotes.Controls.Add(Me.lstTimeLineEvents)
		Me.wzdUH_IncidentNotes.Controls.Add(Me.lblString8)
		Me.wzdUH_IncidentNotes.Controls.Add(Me.rtxtIncidentNotes)
		Me.wzdUH_IncidentNotes.Controls.Add(Me.lblIncidentCaption)
		Me.wzdUH_IncidentNotes.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_IncidentNotes.Name = "wzdUH_IncidentNotes"
		Me.wzdUH_IncidentNotes.PageCaption = "Incident Notes"
		Me.wzdUH_IncidentNotes.PageDescription = "Timeline of events that occured."
		Me.wzdUH_IncidentNotes.Size = New System.Drawing.Size(3326, 873)
		Me.wzdUH_IncidentNotes.TabIndex = 9
		'
		'btnAddTimeLineEvent
		'
		Me.btnAddTimeLineEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddTimeLineEvent.Location = New System.Drawing.Point(459, 36)
		Me.btnAddTimeLineEvent.Name = "btnAddTimeLineEvent"
		Me.btnAddTimeLineEvent.Size = New System.Drawing.Size(23, 27)
		Me.btnAddTimeLineEvent.TabIndex = 1
		Me.btnAddTimeLineEvent.Text = "+"
		Me.btnAddTimeLineEvent.UseVisualStyleBackColor = True
		'
		'lstTimeLineEvents
		'
		Me.lstTimeLineEvents.FormattingEnabled = True
		Me.lstTimeLineEvents.Location = New System.Drawing.Point(69, 67)
		Me.lstTimeLineEvents.Name = "lstTimeLineEvents"
		Me.lstTimeLineEvents.Size = New System.Drawing.Size(413, 147)
		Me.lstTimeLineEvents.TabIndex = 2
		Me.lstTimeLineEvents.TabStop = False
		'
		'lblString8
		'
		Me.lblString8.AutoSize = True
		Me.lblString8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString8.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString8.Location = New System.Drawing.Point(387, 220)
		Me.lblString8.Name = "lblString8"
		Me.lblString8.Size = New System.Drawing.Size(31, 16)
		Me.lblString8.TabIndex = 7
		Me.lblString8.Text = "Job#"
		'
		'rtxtIncidentNotes
		'
		Me.rtxtIncidentNotes.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtxtIncidentNotes.ForeColor = System.Drawing.Color.DimGray
		Me.rtxtIncidentNotes.Location = New System.Drawing.Point(69, 38)
		Me.rtxtIncidentNotes.Name = "rtxtIncidentNotes"
		Me.rtxtIncidentNotes.Size = New System.Drawing.Size(384, 27)
		Me.rtxtIncidentNotes.TabIndex = 0
		Me.rtxtIncidentNotes.Text = ""
		'
		'lblIncidentCaption
		'
		Me.lblIncidentCaption.AutoSize = True
		Me.lblIncidentCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIncidentCaption.Location = New System.Drawing.Point(65, 15)
		Me.lblIncidentCaption.Name = "lblIncidentCaption"
		Me.lblIncidentCaption.Size = New System.Drawing.Size(244, 20)
		Me.lblIncidentCaption.TabIndex = 0
		Me.lblIncidentCaption.Text = "Timeline of Events (Be Descriptive)"
		'
		'wzdUH_PicUpload
		'
		Me.wzdUH_PicUpload.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.wzdUH_PicUpload.Controls.Add(Me.lblProcessing)
		Me.wzdUH_PicUpload.Controls.Add(Me.lblNumProcessed)
		Me.wzdUH_PicUpload.Controls.Add(Me.lstDrives)
		Me.wzdUH_PicUpload.Controls.Add(Me.btnTransferImages)
		Me.wzdUH_PicUpload.Controls.Add(Me.lblString9)
		Me.wzdUH_PicUpload.Location = New System.Drawing.Point(16, 76)
		Me.wzdUH_PicUpload.Name = "wzdUH_PicUpload"
		Me.wzdUH_PicUpload.PageCaption = "Image Transfer"
		Me.wzdUH_PicUpload.PageDescription = "Transfer Pictures/Images from Memory  Card to this computer."
		Me.wzdUH_PicUpload.Size = New System.Drawing.Size(4160, 1065)
		Me.wzdUH_PicUpload.TabIndex = 10
		'
		'lblProcessing
		'
		Me.lblProcessing.AutoSize = True
		Me.lblProcessing.BackColor = System.Drawing.Color.Transparent
		Me.lblProcessing.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProcessing.Location = New System.Drawing.Point(181, 191)
		Me.lblProcessing.Name = "lblProcessing"
		Me.lblProcessing.Size = New System.Drawing.Size(184, 20)
		Me.lblProcessing.TabIndex = 11
		Me.lblProcessing.Text = "Processing. Please Wait..."
		Me.lblProcessing.Visible = False
		'
		'lblNumProcessed
		'
		Me.lblNumProcessed.AutoSize = True
		Me.lblNumProcessed.BackColor = System.Drawing.Color.Transparent
		Me.lblNumProcessed.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumProcessed.Location = New System.Drawing.Point(166, 171)
		Me.lblNumProcessed.Name = "lblNumProcessed"
		Me.lblNumProcessed.Size = New System.Drawing.Size(214, 20)
		Me.lblNumProcessed.TabIndex = 10
		Me.lblNumProcessed.Text = "Number of images processed: "
		Me.lblNumProcessed.Visible = False
		'
		'lstDrives
		'
		Me.lstDrives.FormattingEnabled = True
		Me.lstDrives.Location = New System.Drawing.Point(88, 23)
		Me.lstDrives.Name = "lstDrives"
		Me.lstDrives.Size = New System.Drawing.Size(370, 56)
		Me.lstDrives.TabIndex = 9
		'
		'btnTransferImages
		'
		Me.btnTransferImages.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTransferImages.Image = Global.AE_Ground.My.Resources.Resources.utiltyHit
		Me.btnTransferImages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnTransferImages.Location = New System.Drawing.Point(187, 104)
		Me.btnTransferImages.Name = "btnTransferImages"
		Me.btnTransferImages.Size = New System.Drawing.Size(172, 41)
		Me.btnTransferImages.TabIndex = 8
		Me.btnTransferImages.Text = "Transfer Images"
		Me.btnTransferImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnTransferImages.UseVisualStyleBackColor = True
		'
		'lblString9
		'
		Me.lblString9.AutoSize = True
		Me.lblString9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblString9.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lblString9.Location = New System.Drawing.Point(387, 220)
		Me.lblString9.Name = "lblString9"
		Me.lblString9.Size = New System.Drawing.Size(31, 16)
		Me.lblString9.TabIndex = 7
		Me.lblString9.Text = "Job#"
		'
		'WizardPage1
		'
		Me.WizardPage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WizardPage1.BackColor = System.Drawing.SystemColors.Window
		Me.WizardPage1.Controls.Add(Me.lblFinish)
		Me.WizardPage1.Controls.Add(Me.picFinish)
		Me.WizardPage1.IsInteriorPage = False
		Me.WizardPage1.Location = New System.Drawing.Point(0, 0)
		Me.WizardPage1.Name = "WizardPage1"
		Me.WizardPage1.PageCaption = "Complete!"
		Me.WizardPage1.PageDescription = "Wizard Complete"
		Me.WizardPage1.Size = New System.Drawing.Size(4192, 1157)
		Me.WizardPage1.TabIndex = 11
		'
		'lblFinish
		'
		Me.lblFinish.AutoSize = True
		Me.lblFinish.Location = New System.Drawing.Point(261, 291)
		Me.lblFinish.Name = "lblFinish"
		Me.lblFinish.Size = New System.Drawing.Size(201, 13)
		Me.lblFinish.TabIndex = 1
		Me.lblFinish.Text = "Click Finish to complete Utility Hit Wizard."
		'
		'picFinish
		'
		Me.picFinish.Image = CType(resources.GetObject("picFinish.Image"), System.Drawing.Image)
		Me.picFinish.Location = New System.Drawing.Point(197, 75)
		Me.picFinish.Name = "picFinish"
		Me.picFinish.Size = New System.Drawing.Size(179, 161)
		Me.picFinish.TabIndex = 0
		Me.picFinish.TabStop = False
		'
		'DPBindingSource
		'
		Me.DPBindingSource.DataMember = "DP"
		Me.DPBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'SiteListTableAdapter
		'
		Me.SiteListTableAdapter.ClearBeforeFill = True
		'
		'TimeReporting
		'
		Me.TimeReporting.DataSetName = "TimeReporting"
		Me.TimeReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'AtmUhDTBindingSource
		'
		Me.AtmUhDTBindingSource.DataMember = "atmUhDT"
		Me.AtmUhDTBindingSource.DataSource = Me.TimeReporting
		'
		'frmUH_Wizard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.AE_LT
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(600, 385)
		Me.Controls.Add(Me.pnlUtilityHitWizard)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmUH_Wizard"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Utility Hit Wizard"
		Me.pnlUtilityHitWizard.ResumeLayout(False)
		CType(Me.wzdUH, System.ComponentModel.ISupportInitialize).EndInit()
		Me.wzdUH_Welcome.ResumeLayout(False)
		Me.wzdUH_Welcome.PerformLayout()
		Me.wzdUH_JobNumber.ResumeLayout(False)
		Me.wzdUH_StationNumber.ResumeLayout(False)
		Me.wzdUH_StationNumber.PerformLayout()
		CType(Me.SiteListTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.wzdUH_Time.ResumeLayout(False)
		Me.wzdUH_Time.PerformLayout()
		Me.wzdUH_UtilityType.ResumeLayout(False)
		Me.wzdUH_UtilityType.PerformLayout()
		Me.gpbUtilityStaked.ResumeLayout(False)
		Me.gpbUtilityStaked.PerformLayout()
		Me.gpbUtilityType.ResumeLayout(False)
		Me.gpbUtilityType.PerformLayout()
		Me.wzdUH_OtherStaked.ResumeLayout(False)
		Me.wzdUH_OtherStaked.PerformLayout()
		Me.gpbOtherStaked.ResumeLayout(False)
		Me.gpbOtherStaked.PerformLayout()
		Me.gpbOtherUtilities.ResumeLayout(False)
		Me.gpbOtherUtilities.PerformLayout()
		Me.wzdUH_Responder.ResumeLayout(False)
		Me.wzdUH_Responder.PerformLayout()
		Me.wzdUH_Inspector.ResumeLayout(False)
		Me.wzdUH_Inspector.PerformLayout()
		Me.gpbInspector.ResumeLayout(False)
		Me.gpbInspector.PerformLayout()
		Me.wzdUH_Witnesses.ResumeLayout(False)
		Me.wzdUH_Witnesses.PerformLayout()
		Me.wzdUH_IncidentNotes.ResumeLayout(False)
		Me.wzdUH_IncidentNotes.PerformLayout()
		Me.wzdUH_PicUpload.ResumeLayout(False)
		Me.wzdUH_PicUpload.PerformLayout()
		Me.WizardPage1.ResumeLayout(False)
		Me.WizardPage1.PerformLayout()
		CType(Me.picFinish, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TimeReporting, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.AtmUhDTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlUtilityHitWizard As System.Windows.Forms.Panel
	Friend WithEvents wzdUH As ActiproSoftware.Wizard.Wizard
	Friend WithEvents wzdUH_Welcome As ActiproSoftware.Wizard.WizardWelcomePage
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents wzdUH_JobNumber As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblJobNumberCaption As System.Windows.Forms.Label
	Friend WithEvents lblJobDescription As System.Windows.Forms.Label
	Friend WithEvents lblJobNumber As System.Windows.Forms.Label
	Friend WithEvents wzdUH_StationNumber As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents rtxtPhysicalLocation As System.Windows.Forms.RichTextBox
	Friend WithEvents lblPhysicalLocation As System.Windows.Forms.Label
	Friend WithEvents lblSite As System.Windows.Forms.Label
	Friend WithEvents cmbStationNumber As System.Windows.Forms.ComboBox
	Friend WithEvents wzdUH_Time As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents dtpIncident As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblDate As System.Windows.Forms.Label
	Friend WithEvents wzdUH_UtilityType As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents gpbUtilityType As System.Windows.Forms.GroupBox
	Friend WithEvents rbtnOther As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnFreewayLighting As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnMits As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnSewer As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnWater As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnFiber As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnPhone As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnCable As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnGas As System.Windows.Forms.RadioButton
	Friend WithEvents rBtnElectric As System.Windows.Forms.RadioButton
	Friend WithEvents gpbUtilityStaked As System.Windows.Forms.GroupBox
	Friend WithEvents rbtnStakedNo As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnStakedYes As System.Windows.Forms.RadioButton
	Friend WithEvents wzdUH_OtherStaked As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents gpbOtherUtilities As System.Windows.Forms.GroupBox
	Friend WithEvents rbtnOtherUtilitiesNo As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnOtherUtilitiesYes As System.Windows.Forms.RadioButton
	Friend WithEvents gpbOtherStaked As System.Windows.Forms.GroupBox
	Friend WithEvents ckbFreewayLighting As System.Windows.Forms.CheckBox
	Friend WithEvents ckbMits As System.Windows.Forms.CheckBox
	Friend WithEvents ckbSewer As System.Windows.Forms.CheckBox
	Friend WithEvents ckbWater As System.Windows.Forms.CheckBox
	Friend WithEvents ckbFiber As System.Windows.Forms.CheckBox
	Friend WithEvents ckbPhone As System.Windows.Forms.CheckBox
	Friend WithEvents ckbCable As System.Windows.Forms.CheckBox
	Friend WithEvents ckbGas As System.Windows.Forms.CheckBox
	Friend WithEvents ckbElectric As System.Windows.Forms.CheckBox
	Friend WithEvents wzdUH_Responder As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblResponder As System.Windows.Forms.Label
	Friend WithEvents rtxtResponder As System.Windows.Forms.RichTextBox
	Friend WithEvents wzdUH_Inspector As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblInpectorDetails As System.Windows.Forms.Label
	Friend WithEvents lblInspectorCaption As System.Windows.Forms.Label
	Friend WithEvents gpbInspector As System.Windows.Forms.GroupBox
	Friend WithEvents rbtnInspectorNo As System.Windows.Forms.RadioButton
	Friend WithEvents rbtnInspectorYes As System.Windows.Forms.RadioButton
	Friend WithEvents wzdUH_Witnesses As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblWitnessCaption As System.Windows.Forms.Label
	Friend WithEvents wzdUH_IncidentNotes As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents lblIncidentCaption As System.Windows.Forms.Label
	Friend WithEvents wzdUH_PicUpload As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents WizardPage1 As ActiproSoftware.Wizard.WizardPage
	Friend WithEvents picFinish As System.Windows.Forms.PictureBox
	Friend WithEvents lblFinish As System.Windows.Forms.Label
	Friend WithEvents lblString1 As System.Windows.Forms.Label
	Friend WithEvents rtxtInspector As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtWitnesses As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtIncidentNotes As System.Windows.Forms.RichTextBox
	Friend WithEvents lblString2 As System.Windows.Forms.Label
	Friend WithEvents lblString3 As System.Windows.Forms.Label
	Friend WithEvents lblString4 As System.Windows.Forms.Label
	Friend WithEvents lblString5 As System.Windows.Forms.Label
	Friend WithEvents lblString6 As System.Windows.Forms.Label
	Friend WithEvents lblString7 As System.Windows.Forms.Label
	Friend WithEvents lblString8 As System.Windows.Forms.Label
	Friend WithEvents lblString9 As System.Windows.Forms.Label
	Friend WithEvents btnTransferImages As System.Windows.Forms.Button
	Friend WithEvents lstDrives As System.Windows.Forms.ListBox
	Friend WithEvents lblNumProcessed As System.Windows.Forms.Label
	Friend WithEvents lblProcessing As System.Windows.Forms.Label
	Friend WithEvents DPBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents lstTimeLineEvents As System.Windows.Forms.ListBox
	Friend WithEvents btnAddTimeLineEvent As System.Windows.Forms.Button
	Friend WithEvents SiteListTableAdapterBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents SiteListTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.SiteListTableAdapter
	Friend WithEvents AtmUhDTBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TimeReporting As AE_Ground.TimeReporting
End Class
