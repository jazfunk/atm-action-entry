<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMigrateProductions
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
		Me.dgvImportedCSV = New System.Windows.Forms.DataGridView
		CType(Me.dgvImportedCSV, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvImportedCSV
		'
		Me.dgvImportedCSV.AllowUserToAddRows = False
		Me.dgvImportedCSV.AllowUserToDeleteRows = False
		Me.dgvImportedCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvImportedCSV.Location = New System.Drawing.Point(28, 107)
		Me.dgvImportedCSV.Name = "dgvImportedCSV"
		Me.dgvImportedCSV.ReadOnly = True
		Me.dgvImportedCSV.Size = New System.Drawing.Size(767, 281)
		Me.dgvImportedCSV.TabIndex = 0
		'
		'frmMigrateProductions
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(807, 551)
		Me.Controls.Add(Me.dgvImportedCSV)
		Me.Name = "frmMigrateProductions"
		Me.Text = "frmMigrateProductions"
		CType(Me.dgvImportedCSV, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgvImportedCSV As System.Windows.Forms.DataGridView
End Class
