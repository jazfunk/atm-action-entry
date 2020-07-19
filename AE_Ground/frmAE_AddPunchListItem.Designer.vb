<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAE_AddPunchListItem
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAE_AddPunchListItem))
		Me.pnlAddItemMain = New System.Windows.Forms.Panel
		Me.btnAddCategory = New System.Windows.Forms.Button
		Me.ckbViewAll = New System.Windows.Forms.CheckBox
		Me.lblUserList = New System.Windows.Forms.Label
		Me.lblInstructions = New System.Windows.Forms.Label
		Me.dgvMyPunchList = New System.Windows.Forms.DataGridView
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ItemNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.EntryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ItemSolvedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.QryPunchListItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ActionEntryDataSet = New AE_Ground.ActionEntryDataSet
		Me.rtbNote = New System.Windows.Forms.RichTextBox
		Me.lblCategory = New System.Windows.Forms.Label
		Me.cmbCategories = New System.Windows.Forms.ComboBox
		Me.TblPunchListCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.TblPunchListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TblPunchListCategoriesTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.tblPunchListCategoriesTableAdapter
		Me.TblPunchListTableAdapter1 = New AE_Ground.ActionEntryDataSetTableAdapters.tblPunchListTableAdapter
		Me.QryPunchListItemsTableAdapter = New AE_Ground.ActionEntryDataSetTableAdapters.qryPunchListItemsTableAdapter
		Me.pnlAddItemMain.SuspendLayout()
		CType(Me.dgvMyPunchList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.QryPunchListItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblPunchListCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TblPunchListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlAddItemMain
		'
		Me.pnlAddItemMain.BackgroundImage = Global.AE_Ground.My.Resources.Resources.SilverBrushedHorizontal
		Me.pnlAddItemMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlAddItemMain.Controls.Add(Me.btnAddCategory)
		Me.pnlAddItemMain.Controls.Add(Me.ckbViewAll)
		Me.pnlAddItemMain.Controls.Add(Me.lblUserList)
		Me.pnlAddItemMain.Controls.Add(Me.lblInstructions)
		Me.pnlAddItemMain.Controls.Add(Me.dgvMyPunchList)
		Me.pnlAddItemMain.Controls.Add(Me.rtbNote)
		Me.pnlAddItemMain.Controls.Add(Me.lblCategory)
		Me.pnlAddItemMain.Controls.Add(Me.cmbCategories)
		Me.pnlAddItemMain.Controls.Add(Me.btnCancel)
		Me.pnlAddItemMain.Controls.Add(Me.btnOK)
		Me.pnlAddItemMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlAddItemMain.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlAddItemMain.Location = New System.Drawing.Point(0, 0)
		Me.pnlAddItemMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.pnlAddItemMain.Name = "pnlAddItemMain"
		Me.pnlAddItemMain.Size = New System.Drawing.Size(674, 462)
		Me.pnlAddItemMain.TabIndex = 0
		'
		'btnAddCategory
		'
		Me.btnAddCategory.Location = New System.Drawing.Point(532, 22)
		Me.btnAddCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnAddCategory.Name = "btnAddCategory"
		Me.btnAddCategory.Size = New System.Drawing.Size(129, 28)
		Me.btnAddCategory.TabIndex = 9
		Me.btnAddCategory.Text = "Add New Category"
		Me.btnAddCategory.UseVisualStyleBackColor = True
		'
		'ckbViewAll
		'
		Me.ckbViewAll.AutoSize = True
		Me.ckbViewAll.BackColor = System.Drawing.Color.Transparent
		Me.ckbViewAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ckbViewAll.ForeColor = System.Drawing.Color.Black
		Me.ckbViewAll.Location = New System.Drawing.Point(484, 215)
		Me.ckbViewAll.Name = "ckbViewAll"
		Me.ckbViewAll.Size = New System.Drawing.Size(177, 22)
		Me.ckbViewAll.TabIndex = 8
		Me.ckbViewAll.Text = "View Entries From All Users"
		Me.ckbViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ckbViewAll.UseVisualStyleBackColor = False
		'
		'lblUserList
		'
		Me.lblUserList.AutoSize = True
		Me.lblUserList.BackColor = System.Drawing.Color.Transparent
		Me.lblUserList.Location = New System.Drawing.Point(8, 219)
		Me.lblUserList.Name = "lblUserList"
		Me.lblUserList.Size = New System.Drawing.Size(96, 18)
		Me.lblUserList.TabIndex = 7
		Me.lblUserList.Text = "Previous Entries"
		'
		'lblInstructions
		'
		Me.lblInstructions.AutoSize = True
		Me.lblInstructions.BackColor = System.Drawing.Color.White
		Me.lblInstructions.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInstructions.ForeColor = System.Drawing.Color.DarkGray
		Me.lblInstructions.Location = New System.Drawing.Point(17, 92)
		Me.lblInstructions.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
		Me.lblInstructions.Name = "lblInstructions"
		Me.lblInstructions.Size = New System.Drawing.Size(132, 18)
		Me.lblInstructions.TabIndex = 6
		Me.lblInstructions.Text = "Type Your Entry Here"
		Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'dgvMyPunchList
		'
		Me.dgvMyPunchList.AllowUserToAddRows = False
		Me.dgvMyPunchList.AllowUserToDeleteRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
		Me.dgvMyPunchList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvMyPunchList.AutoGenerateColumns = False
		Me.dgvMyPunchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvMyPunchList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
		Me.dgvMyPunchList.BackgroundColor = System.Drawing.Color.White
		Me.dgvMyPunchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvMyPunchList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.ItemNoteDataGridViewTextBoxColumn, Me.EntryDateDataGridViewTextBoxColumn, Me.ItemSolvedDataGridViewCheckBoxColumn})
		Me.dgvMyPunchList.DataSource = Me.QryPunchListItemsBindingSource
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvMyPunchList.DefaultCellStyle = DataGridViewCellStyle6
		Me.dgvMyPunchList.Location = New System.Drawing.Point(11, 240)
		Me.dgvMyPunchList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.dgvMyPunchList.Name = "dgvMyPunchList"
		Me.dgvMyPunchList.ReadOnly = True
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvMyPunchList.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvMyPunchList.RowHeadersVisible = False
		Me.dgvMyPunchList.RowHeadersWidth = 5
		DataGridViewCellStyle8.Format = "d"
		DataGridViewCellStyle8.NullValue = Nothing
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvMyPunchList.RowsDefaultCellStyle = DataGridViewCellStyle8
		Me.dgvMyPunchList.RowTemplate.DefaultCellStyle.Format = "d"
		Me.dgvMyPunchList.RowTemplate.DefaultCellStyle.NullValue = Nothing
		Me.dgvMyPunchList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvMyPunchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvMyPunchList.Size = New System.Drawing.Size(650, 208)
		Me.dgvMyPunchList.TabIndex = 5
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		Me.IDDataGridViewTextBoxColumn.ReadOnly = True
		Me.IDDataGridViewTextBoxColumn.Visible = False
		'
		'FirstNameDataGridViewTextBoxColumn
		'
		Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		Me.FirstNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
		Me.FirstNameDataGridViewTextBoxColumn.FillWeight = 15.0!
		Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "User"
		Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
		Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
		'
		'LastNameDataGridViewTextBoxColumn
		'
		Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
		Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
		Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
		Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
		Me.LastNameDataGridViewTextBoxColumn.Visible = False
		'
		'CategoryDataGridViewTextBoxColumn
		'
		Me.CategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CategoryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
		Me.CategoryDataGridViewTextBoxColumn.FillWeight = 15.0!
		Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
		Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
		Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ItemNoteDataGridViewTextBoxColumn
		'
		Me.ItemNoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.ItemNoteDataGridViewTextBoxColumn.DataPropertyName = "itemNote"
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ItemNoteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
		Me.ItemNoteDataGridViewTextBoxColumn.FillWeight = 35.0!
		Me.ItemNoteDataGridViewTextBoxColumn.HeaderText = "Item/Note"
		Me.ItemNoteDataGridViewTextBoxColumn.Name = "ItemNoteDataGridViewTextBoxColumn"
		Me.ItemNoteDataGridViewTextBoxColumn.ReadOnly = True
		'
		'EntryDateDataGridViewTextBoxColumn
		'
		Me.EntryDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.EntryDateDataGridViewTextBoxColumn.DataPropertyName = "entryDate"
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.Format = "M"
		DataGridViewCellStyle5.NullValue = Nothing
		Me.EntryDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
		Me.EntryDateDataGridViewTextBoxColumn.FillWeight = 25.0!
		Me.EntryDateDataGridViewTextBoxColumn.HeaderText = "Date"
		Me.EntryDateDataGridViewTextBoxColumn.Name = "EntryDateDataGridViewTextBoxColumn"
		Me.EntryDateDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ItemSolvedDataGridViewCheckBoxColumn
		'
		Me.ItemSolvedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.ItemSolvedDataGridViewCheckBoxColumn.DataPropertyName = "itemSolved"
		Me.ItemSolvedDataGridViewCheckBoxColumn.FillWeight = 10.0!
		Me.ItemSolvedDataGridViewCheckBoxColumn.HeaderText = "Solved?"
		Me.ItemSolvedDataGridViewCheckBoxColumn.Name = "ItemSolvedDataGridViewCheckBoxColumn"
		Me.ItemSolvedDataGridViewCheckBoxColumn.ReadOnly = True
		'
		'QryPunchListItemsBindingSource
		'
		Me.QryPunchListItemsBindingSource.DataMember = "qryPunchListItems"
		Me.QryPunchListItemsBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'ActionEntryDataSet
		'
		Me.ActionEntryDataSet.DataSetName = "ActionEntryDataSet"
		Me.ActionEntryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'rtbNote
		'
		Me.rtbNote.AutoWordSelection = True
		Me.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.rtbNote.BulletIndent = 4
		Me.rtbNote.EnableAutoDragDrop = True
		Me.rtbNote.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rtbNote.Location = New System.Drawing.Point(11, 86)
		Me.rtbNote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtbNote.Name = "rtbNote"
		Me.rtbNote.Size = New System.Drawing.Size(650, 79)
		Me.rtbNote.TabIndex = 4
		Me.rtbNote.Text = ""
		'
		'lblCategory
		'
		Me.lblCategory.AutoSize = True
		Me.lblCategory.BackColor = System.Drawing.Color.Transparent
		Me.lblCategory.Location = New System.Drawing.Point(8, 32)
		Me.lblCategory.Name = "lblCategory"
		Me.lblCategory.Size = New System.Drawing.Size(57, 18)
		Me.lblCategory.TabIndex = 3
		Me.lblCategory.Text = "Category"
		'
		'cmbCategories
		'
		Me.cmbCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
		Me.cmbCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.cmbCategories.DataSource = Me.TblPunchListCategoriesBindingSource
		Me.cmbCategories.DisplayMember = "category"
		Me.cmbCategories.DropDownHeight = 88
		Me.cmbCategories.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbCategories.FormattingEnabled = True
		Me.cmbCategories.IntegralHeight = False
		Me.cmbCategories.ItemHeight = 18
		Me.cmbCategories.Location = New System.Drawing.Point(11, 52)
		Me.cmbCategories.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.cmbCategories.MaxDropDownItems = 10
		Me.cmbCategories.Name = "cmbCategories"
		Me.cmbCategories.Size = New System.Drawing.Size(650, 26)
		Me.cmbCategories.TabIndex = 2
		Me.cmbCategories.ValueMember = "ID"
		'
		'TblPunchListCategoriesBindingSource
		'
		Me.TblPunchListCategoriesBindingSource.DataMember = "tblPunchListCategories"
		Me.TblPunchListCategoriesBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(564, 173)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(97, 28)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnOK
		'
		Me.btnOK.Location = New System.Drawing.Point(461, 173)
		Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(97, 28)
		Me.btnOK.TabIndex = 0
		Me.btnOK.Text = "Add"
		Me.btnOK.UseVisualStyleBackColor = True
		'
		'TblPunchListBindingSource
		'
		Me.TblPunchListBindingSource.DataMember = "tblPunchList"
		Me.TblPunchListBindingSource.DataSource = Me.ActionEntryDataSet
		'
		'TblPunchListCategoriesTableAdapter
		'
		Me.TblPunchListCategoriesTableAdapter.ClearBeforeFill = True
		'
		'TblPunchListTableAdapter1
		'
		Me.TblPunchListTableAdapter1.ClearBeforeFill = True
		'
		'QryPunchListItemsTableAdapter
		'
		Me.QryPunchListItemsTableAdapter.ClearBeforeFill = True
		'
		'frmAE_AddPunchListItem
		'
		Me.AcceptButton = Me.btnOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(674, 462)
		Me.Controls.Add(Me.pnlAddItemMain)
		Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.Name = "frmAE_AddPunchListItem"
		Me.Opacity = 0.75
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add DeBugging Item/Note"
		Me.pnlAddItemMain.ResumeLayout(False)
		Me.pnlAddItemMain.PerformLayout()
		CType(Me.dgvMyPunchList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.QryPunchListItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ActionEntryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblPunchListCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TblPunchListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlAddItemMain As System.Windows.Forms.Panel
	Friend WithEvents rtbNote As System.Windows.Forms.RichTextBox
	Friend WithEvents lblCategory As System.Windows.Forms.Label
	Friend WithEvents cmbCategories As System.Windows.Forms.ComboBox
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents btnOK As System.Windows.Forms.Button
	Friend WithEvents ActionEntryDataSet As AE_Ground.ActionEntryDataSet
	Friend WithEvents TblPunchListCategoriesBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TblPunchListCategoriesTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.tblPunchListCategoriesTableAdapter
	Friend WithEvents TblPunchListTableAdapter1 As AE_Ground.ActionEntryDataSetTableAdapters.tblPunchListTableAdapter
	Friend WithEvents dgvMyPunchList As System.Windows.Forms.DataGridView
	Friend WithEvents TblPunchListBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents lblInstructions As System.Windows.Forms.Label
	Friend WithEvents ckbViewAll As System.Windows.Forms.CheckBox
	Friend WithEvents lblUserList As System.Windows.Forms.Label
	Friend WithEvents btnAddCategory As System.Windows.Forms.Button
	Friend WithEvents QryPunchListItemsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents QryPunchListItemsTableAdapter As AE_Ground.ActionEntryDataSetTableAdapters.qryPunchListItemsTableAdapter
	Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ItemNoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents EntryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ItemSolvedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
