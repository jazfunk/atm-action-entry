﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailEquipProblem
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
		Me.Button1 = New System.Windows.Forms.Button
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(197, 204)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Send"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(12, 70)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(260, 119)
		Me.TextBox2.TabIndex = 4
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(12, 35)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(260, 20)
		Me.TextBox1.TabIndex = 3
		'
		'frmEmailEquipProblem
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "frmEmailEquipProblem"
		Me.Text = "Report Equipment Problem"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
