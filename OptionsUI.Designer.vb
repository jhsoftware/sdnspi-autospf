<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsUI
  Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.CtlTTL1 = New JHSoftware.SimpleDNS.ctlTTL()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SPF-record data:"
        '
        'txtValue
        '
        Me.txtValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue.Location = New System.Drawing.Point(3, 16)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
        Me.txtValue.Multiline = True
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(424, 99)
        Me.txtValue.TabIndex = 1
        Me.txtValue.Text = "v=spf1 mx -all"
        '
        'CtlTTL1
        '
        Me.CtlTTL1.AutoSize = True
        Me.CtlTTL1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CtlTTL1.BackColor = System.Drawing.Color.Transparent
        Me.CtlTTL1.Location = New System.Drawing.Point(3, 144)
        Me.CtlTTL1.Name = "CtlTTL1"
        Me.CtlTTL1.ReadOnly = False
        Me.CtlTTL1.Size = New System.Drawing.Size(156, 21)
        Me.CtlTTL1.TabIndex = 2
        Me.CtlTTL1.Value = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TTL:"
        '
        'OptionsUI
        '
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CtlTTL1)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OptionsUI"
        Me.Size = New System.Drawing.Size(427, 173)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents CtlTTL1 As JHSoftware.SimpleDNS.ctlTTL
    Friend WithEvents Label2 As Label
End Class
