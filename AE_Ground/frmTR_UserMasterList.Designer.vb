<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTR_UserMasterList
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
		Me.dgvUserMasterList = New System.Windows.Forms.DataGridView
		CType(Me.dgvUserMasterList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvUserMasterList
		'
		Me.dgvUserMasterList.AllowUserToAddRows = False
		Me.dgvUserMasterList.AllowUserToDeleteRows = False
		Me.dgvUserMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvUserMasterList.Location = New System.Drawing.Point(73, 30)
		Me.dgvUserMasterList.Name = "dgvUserMasterList"
		Me.dgvUserMasterList.ReadOnly = True
		Me.dgvUserMasterList.Size = New System.Drawing.Size(240, 474)
		Me.dgvUserMasterList.TabIndex = 0
		'
		'frmTR_UserMasterList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(652, 541)
		Me.Controls.Add(Me.dgvUserMasterList)
		Me.Name = "frmTR_UserMasterList"
		Me.Text = "Master List - Users"
		CType(Me.dgvUserMasterList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgvUserMasterList As System.Windows.Forms.DataGridView
End Class
