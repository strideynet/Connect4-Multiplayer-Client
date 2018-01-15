<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.CbbxSelector = New System.Windows.Forms.ComboBox()
        Me.TxtHelp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CbbxSelector
        '
        Me.CbbxSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbxSelector.Items.AddRange(New Object() {"Single Player", "Multiplayer", "Other"})
        Me.CbbxSelector.Location = New System.Drawing.Point(12, 12)
        Me.CbbxSelector.MaxDropDownItems = 3
        Me.CbbxSelector.Name = "CbbxSelector"
        Me.CbbxSelector.Size = New System.Drawing.Size(460, 21)
        Me.CbbxSelector.TabIndex = 0
        '
        'TxtHelp
        '
        Me.TxtHelp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHelp.Location = New System.Drawing.Point(12, 39)
        Me.TxtHelp.Multiline = True
        Me.TxtHelp.Name = "TxtHelp"
        Me.TxtHelp.ReadOnly = True
        Me.TxtHelp.Size = New System.Drawing.Size(460, 310)
        Me.TxtHelp.TabIndex = 1
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.TxtHelp)
        Me.Controls.Add(Me.CbbxSelector)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHelp"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbxSelector As System.Windows.Forms.ComboBox
    Friend WithEvents TxtHelp As System.Windows.Forms.TextBox
End Class
