<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustQtyDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjustQtyDialog))
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
		Me.OK_Button = New System.Windows.Forms.Button
		Me.Cancel_Button = New System.Windows.Forms.Button
		Me.nudQty = New System.Windows.Forms.NumericUpDown
		Me.lblPayItemDescription = New System.Windows.Forms.Label
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(145, 119)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.Location = New System.Drawing.Point(3, 3)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(67, 23)
		Me.OK_Button.TabIndex = 0
		Me.OK_Button.Text = "OK"
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
		Me.Cancel_Button.TabIndex = 1
		Me.Cancel_Button.Text = "Cancel"
		'
		'nudQty
		'
		Me.nudQty.AutoSize = True
		Me.nudQty.BackColor = System.Drawing.Color.White
		Me.nudQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.nudQty.DecimalPlaces = 2
		Me.nudQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudQty.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
		Me.nudQty.Location = New System.Drawing.Point(30, 36)
		Me.nudQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
		Me.nudQty.Name = "nudQty"
		Me.nudQty.Size = New System.Drawing.Size(222, 62)
		Me.nudQty.TabIndex = 1
		Me.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.nudQty.ThousandsSeparator = True
		'
		'lblPayItemDescription
		'
		Me.lblPayItemDescription.AutoSize = True
		Me.lblPayItemDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblPayItemDescription.Location = New System.Drawing.Point(27, 20)
		Me.lblPayItemDescription.Name = "lblPayItemDescription"
		Me.lblPayItemDescription.Size = New System.Drawing.Size(104, 13)
		Me.lblPayItemDescription.TabIndex = 3
		Me.lblPayItemDescription.Text = "Pay Item Description"
		'
		'frmAdjustQtyDialog
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = Global.AE_Ground.My.Resources.Resources.LightBluePipeFade
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(303, 151)
		Me.Controls.Add(Me.lblPayItemDescription)
		Me.Controls.Add(Me.nudQty)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmAdjustQtyDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Quantity Adjustment"
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents OK_Button As System.Windows.Forms.Button
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
	Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblPayItemDescription As System.Windows.Forms.Label

End Class
