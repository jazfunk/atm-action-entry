<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenericReport
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenericReport))
		Me.GenericCRPT = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.SuspendLayout()
		'
		'GenericCRPT
		'
		Me.GenericCRPT.ActiveViewIndex = -1
		Me.GenericCRPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.GenericCRPT.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GenericCRPT.Location = New System.Drawing.Point(0, 0)
		Me.GenericCRPT.Name = "GenericCRPT"
		Me.GenericCRPT.SelectionFormula = ""
		Me.GenericCRPT.Size = New System.Drawing.Size(994, 621)
		Me.GenericCRPT.TabIndex = 0
		Me.GenericCRPT.ViewTimeSelectionFormula = ""
		'
		'frmGenericReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(994, 621)
		Me.Controls.Add(Me.GenericCRPT)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmGenericReport"
		Me.Text = "Report Viewer"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GenericCRPT As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
