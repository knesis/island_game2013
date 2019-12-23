<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdventureGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdventureGame))
        Me.lblAdventure = New System.Windows.Forms.Label()
        Me.lstChoices = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ovlVolcano = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlCave = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlSummit = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlCavern = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlTemple = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlJungle = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlClearing = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlBeach = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ovlIsland = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.picBoat = New System.Windows.Forms.PictureBox()
        Me.picShards = New System.Windows.Forms.PictureBox()
        Me.picPlanks = New System.Windows.Forms.PictureBox()
        Me.picHammer = New System.Windows.Forms.PictureBox()
        Me.picNails = New System.Windows.Forms.PictureBox()
        Me.picOars = New System.Windows.Forms.PictureBox()
        Me.picKey = New System.Windows.Forms.PictureBox()
        Me.picAdventure = New System.Windows.Forms.PictureBox()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.tmrAdventure = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnHints = New System.Windows.Forms.Button()
        CType(Me.picBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlanks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHammer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdventure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdventure
        '
        Me.lblAdventure.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdventure.Location = New System.Drawing.Point(12, 15)
        Me.lblAdventure.Name = "lblAdventure"
        Me.lblAdventure.Size = New System.Drawing.Size(651, 114)
        Me.lblAdventure.TabIndex = 9
        Me.lblAdventure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAdventure.Visible = False
        '
        'lstChoices
        '
        Me.lstChoices.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstChoices.FormattingEnabled = True
        Me.lstChoices.ItemHeight = 23
        Me.lstChoices.Location = New System.Drawing.Point(195, 132)
        Me.lstChoices.Name = "lstChoices"
        Me.lstChoices.Size = New System.Drawing.Size(284, 119)
        Me.lstChoices.TabIndex = 10
        Me.lstChoices.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(1, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 26)
        Me.lblName.TabIndex = 12
        Me.lblName.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line6, Me.Line5, Me.Line3, Me.Line7, Me.Line2, Me.Line4, Me.Line1, Me.ovlVolcano, Me.ovlCave, Me.ovlSummit, Me.ovlCavern, Me.ovlTemple, Me.ovlJungle, Me.ovlClearing, Me.ovlBeach, Me.ovlIsland})
        Me.ShapeContainer1.Size = New System.Drawing.Size(675, 592)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'Line6
        '
        Me.Line6.Name = "Line6"
        Me.Line6.X1 = 95
        Me.Line6.X2 = 95
        Me.Line6.Y1 = 219
        Me.Line6.Y2 = 230
        '
        'Line5
        '
        Me.Line5.Name = "Line5"
        Me.Line5.X1 = 36
        Me.Line5.X2 = 47
        Me.Line5.Y1 = 279
        Me.Line5.Y2 = 279
        '
        'Line3
        '
        Me.Line3.Name = "Line3"
        Me.Line3.X1 = 95
        Me.Line3.X2 = 95
        Me.Line3.Y1 = 250
        Me.Line3.Y2 = 257
        '
        'Line7
        '
        Me.Line7.Name = "Line7"
        Me.Line7.X1 = 142
        Me.Line7.X2 = 155
        Me.Line7.Y1 = 279
        Me.Line7.Y2 = 279
        '
        'Line2
        '
        Me.Line2.Name = "Line2"
        Me.Line2.X1 = 67
        Me.Line2.X2 = 75
        Me.Line2.Y1 = 279
        Me.Line2.Y2 = 279
        '
        'Line4
        '
        Me.Line4.Name = "Line4"
        Me.Line4.X1 = 115
        Me.Line4.X2 = 121
        Me.Line4.Y1 = 279
        Me.Line4.Y2 = 279
        '
        'Line1
        '
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 95
        Me.Line1.X2 = 95
        Me.Line1.Y1 = 297
        Me.Line1.Y2 = 335
        '
        'ovlVolcano
        '
        Me.ovlVolcano.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlVolcano.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlVolcano.Location = New System.Drawing.Point(85, 230)
        Me.ovlVolcano.Name = "ovlVolcano"
        Me.ovlVolcano.Size = New System.Drawing.Size(20, 20)
        '
        'ovlCave
        '
        Me.ovlCave.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlCave.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlCave.Location = New System.Drawing.Point(48, 268)
        Me.ovlCave.Name = "ovlCave"
        Me.ovlCave.Size = New System.Drawing.Size(20, 20)
        '
        'ovlSummit
        '
        Me.ovlSummit.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlSummit.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlSummit.Location = New System.Drawing.Point(85, 198)
        Me.ovlSummit.Name = "ovlSummit"
        Me.ovlSummit.Size = New System.Drawing.Size(20, 20)
        '
        'ovlCavern
        '
        Me.ovlCavern.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlCavern.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlCavern.Location = New System.Drawing.Point(15, 268)
        Me.ovlCavern.Name = "ovlCavern"
        Me.ovlCavern.Size = New System.Drawing.Size(20, 20)
        '
        'ovlTemple
        '
        Me.ovlTemple.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlTemple.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlTemple.Location = New System.Drawing.Point(155, 268)
        Me.ovlTemple.Name = "ovlTemple"
        Me.ovlTemple.Size = New System.Drawing.Size(20, 20)
        '
        'ovlJungle
        '
        Me.ovlJungle.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlJungle.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlJungle.Location = New System.Drawing.Point(122, 268)
        Me.ovlJungle.Name = "ovlJungle"
        Me.ovlJungle.Size = New System.Drawing.Size(20, 20)
        '
        'ovlClearing
        '
        Me.ovlClearing.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlClearing.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlClearing.Location = New System.Drawing.Point(75, 258)
        Me.ovlClearing.Name = "ovlClearing"
        Me.ovlClearing.Size = New System.Drawing.Size(40, 40)
        '
        'ovlBeach
        '
        Me.ovlBeach.FillColor = System.Drawing.Color.DodgerBlue
        Me.ovlBeach.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlBeach.Location = New System.Drawing.Point(85, 334)
        Me.ovlBeach.Name = "ovlBeach"
        Me.ovlBeach.Size = New System.Drawing.Size(20, 20)
        '
        'ovlIsland
        '
        Me.ovlIsland.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ovlIsland.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ovlIsland.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ovlIsland.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovlIsland.Location = New System.Drawing.Point(7, 188)
        Me.ovlIsland.Name = "ovlIsland"
        Me.ovlIsland.Size = New System.Drawing.Size(180, 180)
        Me.ovlIsland.Visible = False
        '
        'lblMap
        '
        Me.lblMap.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.Location = New System.Drawing.Point(67, 145)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(65, 36)
        Me.lblMap.TabIndex = 20
        Me.lblMap.Text = "Map"
        '
        'picBoat
        '
        Me.picBoat.Image = Global.Island_Adventure.My.Resources.Resources.Boat
        Me.picBoat.Location = New System.Drawing.Point(7, 394)
        Me.picBoat.Name = "picBoat"
        Me.picBoat.Size = New System.Drawing.Size(181, 114)
        Me.picBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoat.TabIndex = 21
        Me.picBoat.TabStop = False
        Me.picBoat.Visible = False
        '
        'picShards
        '
        Me.picShards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShards.Image = Global.Island_Adventure.My.Resources.Resources.Knife
        Me.picShards.Location = New System.Drawing.Point(112, 533)
        Me.picShards.Name = "picShards"
        Me.picShards.Size = New System.Drawing.Size(116, 59)
        Me.picShards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShards.TabIndex = 18
        Me.picShards.TabStop = False
        Me.picShards.Visible = False
        '
        'picPlanks
        '
        Me.picPlanks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlanks.Image = Global.Island_Adventure.My.Resources.Resources.Planks
        Me.picPlanks.Location = New System.Drawing.Point(223, 533)
        Me.picPlanks.Name = "picPlanks"
        Me.picPlanks.Size = New System.Drawing.Size(112, 59)
        Me.picPlanks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlanks.TabIndex = 17
        Me.picPlanks.TabStop = False
        Me.picPlanks.Visible = False
        '
        'picHammer
        '
        Me.picHammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHammer.Image = Global.Island_Adventure.My.Resources.Resources.Hammer
        Me.picHammer.InitialImage = Nothing
        Me.picHammer.Location = New System.Drawing.Point(331, 533)
        Me.picHammer.Name = "picHammer"
        Me.picHammer.Size = New System.Drawing.Size(131, 59)
        Me.picHammer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHammer.TabIndex = 16
        Me.picHammer.TabStop = False
        Me.picHammer.Visible = False
        '
        'picNails
        '
        Me.picNails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNails.Image = Global.Island_Adventure.My.Resources.Resources.Nails
        Me.picNails.Location = New System.Drawing.Point(454, 533)
        Me.picNails.Name = "picNails"
        Me.picNails.Size = New System.Drawing.Size(118, 59)
        Me.picNails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNails.TabIndex = 15
        Me.picNails.TabStop = False
        Me.picNails.Visible = False
        '
        'picOars
        '
        Me.picOars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOars.Image = Global.Island_Adventure.My.Resources.Resources.Oars
        Me.picOars.Location = New System.Drawing.Point(571, 533)
        Me.picOars.Name = "picOars"
        Me.picOars.Size = New System.Drawing.Size(104, 59)
        Me.picOars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOars.TabIndex = 14
        Me.picOars.TabStop = False
        Me.picOars.Visible = False
        '
        'picKey
        '
        Me.picKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picKey.Image = Global.Island_Adventure.My.Resources.Resources.Key
        Me.picKey.InitialImage = Nothing
        Me.picKey.Location = New System.Drawing.Point(0, 533)
        Me.picKey.Name = "picKey"
        Me.picKey.Size = New System.Drawing.Size(114, 59)
        Me.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKey.TabIndex = 13
        Me.picKey.TabStop = False
        Me.picKey.Visible = False
        '
        'picAdventure
        '
        Me.picAdventure.Location = New System.Drawing.Point(195, 268)
        Me.picAdventure.Name = "picAdventure"
        Me.picAdventure.Size = New System.Drawing.Size(284, 240)
        Me.picAdventure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAdventure.TabIndex = 11
        Me.picAdventure.TabStop = False
        Me.picAdventure.Visible = False
        '
        'btnCredits
        '
        Me.btnCredits.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(496, 286)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(157, 69)
        Me.btnCredits.TabIndex = 22
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = True
        Me.btnCredits.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(496, 377)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(157, 69)
        Me.btnMenu.TabIndex = 23
        Me.btnMenu.Text = "Return to Main Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        Me.btnMenu.Visible = False
        '
        'tmrAdventure
        '
        Me.tmrAdventure.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(479, 145)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(196, 106)
        Me.lblTimer.TabIndex = 24
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHints
        '
        Me.btnHints.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHints.Location = New System.Drawing.Point(538, 160)
        Me.btnHints.Name = "btnHints"
        Me.btnHints.Size = New System.Drawing.Size(72, 70)
        Me.btnHints.TabIndex = 25
        Me.btnHints.Text = "Hints"
        Me.btnHints.UseVisualStyleBackColor = True
        '
        'frmAdventureGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 592)
        Me.Controls.Add(Me.btnHints)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.picBoat)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.picShards)
        Me.Controls.Add(Me.picPlanks)
        Me.Controls.Add(Me.picHammer)
        Me.Controls.Add(Me.picNails)
        Me.Controls.Add(Me.picOars)
        Me.Controls.Add(Me.picKey)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picAdventure)
        Me.Controls.Add(Me.lstChoices)
        Me.Controls.Add(Me.lblAdventure)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdventureGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Island Adventure"
        CType(Me.picBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlanks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHammer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdventure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAdventure As System.Windows.Forms.Label
    Friend WithEvents lstChoices As System.Windows.Forms.ListBox
    Friend WithEvents picAdventure As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents picKey As System.Windows.Forms.PictureBox
    Friend WithEvents picOars As System.Windows.Forms.PictureBox
    Friend WithEvents picNails As System.Windows.Forms.PictureBox
    Friend WithEvents picHammer As System.Windows.Forms.PictureBox
    Friend WithEvents picPlanks As System.Windows.Forms.PictureBox
    Friend WithEvents picShards As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovlIsland As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lblMap As System.Windows.Forms.Label
    Friend WithEvents ovlBeach As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlSummit As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlCavern As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlTemple As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlJungle As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlClearing As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlVolcano As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ovlCave As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Line6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents picBoat As System.Windows.Forms.PictureBox
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents tmrAdventure As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents btnHints As System.Windows.Forms.Button
End Class
