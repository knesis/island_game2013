<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnAboutLog = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCredits
        '
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCredits.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(0, 0)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(195, 254)
        Me.btnCredits.TabIndex = 0
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = True
        '
        'btnAboutLog
        '
        Me.btnAboutLog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAboutLog.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutLog.Location = New System.Drawing.Point(193, 0)
        Me.btnAboutLog.Name = "btnAboutLog"
        Me.btnAboutLog.Size = New System.Drawing.Size(191, 254)
        Me.btnAboutLog.TabIndex = 1
        Me.btnAboutLog.Text = "About Log"
        Me.btnAboutLog.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBack.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(0, 252)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(385, 62)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 314)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAboutLog)
        Me.Controls.Add(Me.btnCredits)
        Me.Name = "frmAbout"
        Me.Text = "About Island Adventure"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnAboutLog As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
