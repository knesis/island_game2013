<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHints
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
        Me.txtHints = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtHints
        '
        Me.txtHints.Location = New System.Drawing.Point(12, 12)
        Me.txtHints.Multiline = True
        Me.txtHints.Name = "txtHints"
        Me.txtHints.ReadOnly = True
        Me.txtHints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHints.Size = New System.Drawing.Size(480, 401)
        Me.txtHints.TabIndex = 0
        '
        'frmHints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 425)
        Me.Controls.Add(Me.txtHints)
        Me.Name = "frmHints"
        Me.Text = "Hints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHints As System.Windows.Forms.TextBox
End Class
