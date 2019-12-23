
Public Class frmAdventureGame
    'Define variables crucial for game execution
    'Location Controlling Variable
    Dim intLocation As Integer
    'Name String
    Dim strName As String
    'Sleep control
    Dim intSleep As Integer
    'Action Responses
    Dim strAction As String
    Dim strExamine As String
    Dim strItem As String
    'Use Item Dialog Controller
    Dim blnItem As Boolean = False
    'Item Progress Checkpoints
    Dim blnKeyUsed As Boolean = False
    Dim blnShardsUsed As Boolean = False
    Dim blnHammerFound As Boolean = False
    Dim blnPlanksFound As Boolean = False
    Dim blnOarsFound As Boolean = False
    Dim strMaterials As String = "You have enough materials to make a small boat."
    Dim blnBoat As Boolean = False
    'Timer control for Hard difficulty.
    Dim startTime As DateTime
    Dim intMins As Integer
    Dim timeLeft As TimeSpan
    Private Sub frmAdventureGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Name box
        strName = InputBox("Who are you?", "Name?")
        lblName.Visible = True
        If strName = "" Then strName = "Adventurer"
        lblName.Text = "Name: " & strName
        'Initiate Adventure!!
        picAdventure.Visible = True
        picAdventure.Image = My.Resources.Beach
        lblAdventure.Visible = True
        lblAdventure.Text = "You woke up from a deep sleep, and realized you are on a mysterious island." _
          & "It seems you have to escape from your surroundings and get home."
        intLocation = 0
        ovlIsland.Visible = True
        ovlBeach.FillColor = Color.Red
        lstChoices.Visible = True
        'Hint box
        If frmIslandAdventure.intDifficulty = 1 Then
            btnHints.Visible = True
        Else
            btnHints.Visible = False
        End If
        'Timer
        If frmIslandAdventure.intDifficulty = 3 Then
            tmrAdventure.Enabled = True
            intMins = Integer.Parse("5")
            startTime = Now.AddMinutes(intMins)
            timeLeft = startTime.Subtract(Now)
            lblTimer.Text = "You will die of thirst in   " & vbCrLf & Format(timeLeft.Minutes, "#0") & " Minutes" & " & " & Format(timeLeft.Seconds, "00") & " Seconds"
        Else
            tmrAdventure.Enabled = False
        End If
        'BGM Selection
        If frmIslandAdventure.intMusic = 1 Then
            My.Computer.Audio.Play(My.Resources.Noki_Bay, AudioPlayMode.BackgroundLoop)
        ElseIf frmIslandAdventure.intMusic = 2 Then
            My.Computer.Audio.Play(My.Resources.Pianta_Village, AudioPlayMode.BackgroundLoop)
        ElseIf frmIslandAdventure.intMusic = 3 Then
            My.Computer.Audio.Play(My.Resources.Band, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(My.Resources.Noki_Bay, AudioPlayMode.BackgroundLoop)
        End If
        'List box choices
        lstChoices.Items.Add("Do an action")
        lstChoices.Items.Add("Examine")
        lstChoices.Items.Add("Use Item")
        lstChoices.Items.Add("Sleep")
    End Sub

    Private Sub lstChoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstChoices.SelectedIndexChanged
        Select Case lstChoices.SelectedIndex
            Case 0
                'Input Box control
                strAction = InputBox("What would you like to do?", "Do What?", "").ToLower
                'Alduin Easter Egg + Fly Action
                If strName.ToLower = "alduin" And strAction = "fly" Then
                    lblAdventure.Text = "And so, Alduin flew off the island. The End."
                ElseIf strName <> "alduin" And strAction = "fly" Then
                    lblAdventure.Text = "If God had wanted man to fly, he would have given him wings."
                End If
                'Moving North
                If strAction = "move north" And _
                    intLocation = 3 Then
                    lblAdventure.Text = "You have reached the summit of the volcano. Shards of volcanic glass litter the ground."
                    picAdventure.Image = My.Resources.Summit
                    intLocation = 6
                    ovlVolcano.FillColor = Color.DodgerBlue
                    ovlSummit.FillColor = Color.Red
                ElseIf strAction = "move north" And _
                    intLocation = 1 Then
                    lblAdventure.Text = "A great volcano towers above you. Smoke billows from its peak. On a lesser note, something shiny in the sand glistens in your eye."
                    If blnKeyUsed = True Then
                        lblAdventure.Text = "A great volcano towers above you. Smoke billows from its peak."
                    End If
                    picAdventure.Image = My.Resources.Volcano
                    intLocation = 3
                    ovlClearing.FillColor = Color.DodgerBlue
                    ovlVolcano.FillColor = Color.Red
                ElseIf strAction = "move north" And _
                    intLocation = 0 Then
                    lblAdventure.Text = "You stand in a central island clearing. There is a volcano to the north, some jungle to the east, and to the west is a cave."
                    picAdventure.Image = My.Resources.Clearing
                    intLocation = 1
                    ovlBeach.FillColor = Color.DodgerBlue
                    ovlClearing.FillColor = Color.Red
                End If
                'Moving West
                If (strAction = "move west" Or strAction = "enter cave") And blnKeyUsed = True And _
                intLocation = 2 Then
                    If blnHammerFound = False Then
                        lblAdventure.Text = "You have entered the dark cavern. A single ray of light falls on a stone platform holding a hammer + nails."
                    ElseIf blnHammerFound = True Then
                        lblAdventure.Text = "You have entered the dark cavern. A single ray of light falls on a stone platform."
                    End If
                    picAdventure.Image = My.Resources.Cavern
                    intLocation = 5
                    ovlCave.FillColor = Color.DodgerBlue
                    ovlCavern.FillColor = Color.Red
                ElseIf strAction = "move west" And _
                                    intLocation = 1 Then
                    lblAdventure.Text = "The dark entrance to a cave appears, blocked by a rusty iron door."
                    picAdventure.Image = My.Resources.Cave
                    If blnKeyUsed = True Then
                        lblAdventure.Text = "The dark entrance to a cave appears."
                        picAdventure.Image = My.Resources.Open_Cave
                    End If
                    intLocation = 2
                    ovlClearing.FillColor = Color.DodgerBlue
                    ovlCave.FillColor = Color.Red
                ElseIf strAction = "move west" And _
                    intLocation = 4 Then
                    lblAdventure.Text = "You have returned to the central island clearing."
                    picAdventure.Image = My.Resources.Clearing
                    intLocation = 1
                    ovlJungle.FillColor = Color.DodgerBlue
                    ovlClearing.FillColor = Color.Red
                ElseIf strAction = "move west" And _
                    intLocation = 7 Then
                    lblAdventure.Text = "There is lush jungle around you."
                    intLocation = 4
                    picAdventure.Image = My.Resources.Free_Jungle
                    ovlTemple.FillColor = Color.DodgerBlue
                    ovlJungle.FillColor = Color.Red
                End If
                'Moving South from Summit
                If strAction = "move south" And _
                intLocation = 6 Then
                    lblAdventure.Text = "You have descended the great volcano."
                    picAdventure.Image = My.Resources.Volcano
                    intLocation = 3
                    ovlSummit.FillColor = Color.DodgerBlue
                    ovlVolcano.FillColor = Color.Red
                    'Moving South from Volcano
                ElseIf strAction = "move south" And _
                    intLocation = 3 Then
                    lblAdventure.Text = "You have returned to the central island clearing."
                    picAdventure.Image = My.Resources.Clearing
                    intLocation = 1
                    ovlVolcano.FillColor = Color.DodgerBlue
                    ovlClearing.FillColor = Color.Red
                    'Moving South from clearing
                ElseIf strAction = "move south" And _
                    intLocation = 1 Then
                    lblAdventure.Text = "You stand on the beach with the ocean spread far in front of you. The sandy beach appears to hold many a valuable item."
                    picAdventure.Image = My.Resources.Beach
                    intLocation = 0
                    ovlClearing.FillColor = Color.DodgerBlue
                    ovlBeach.FillColor = Color.Red
                End If
                'Moving East
                If (strAction = "move east" Or strAction = "exit cave") And _
                    intLocation = 5 Then
                    lblAdventure.Text = "You have exited the cave."
                    picAdventure.Image = My.Resources.Open_Cave
                    intLocation = 2
                    ovlCavern.FillColor = Color.DodgerBlue
                    ovlCave.FillColor = Color.Red
                ElseIf strAction = "move east" And _
                                    intLocation = 2 Then
                    lblAdventure.Text = "You have returned to the central island clearing."
                    picAdventure.Image = My.Resources.Clearing
                    intLocation = 1
                    ovlCave.FillColor = Color.DodgerBlue
                    ovlClearing.FillColor = Color.Red
                ElseIf strAction = "move east" And _
                    intLocation = 1 Then
                    lblAdventure.Text = "There is lush jungle around you. Thick jungle vines block your path."
                    picAdventure.Image = My.Resources.Jungle
                    If blnShardsUsed = True Then
                        lblAdventure.Text = "There is lush jungle around you."
                        picAdventure.Image = My.Resources.Free_Jungle
                    End If
                    intLocation = 4
                    ovlClearing.FillColor = Color.DodgerBlue
                    ovlJungle.FillColor = Color.Red
                ElseIf strAction = "move east" And blnShardsUsed = True And _
                    intLocation = 4 Then
                    lblAdventure.Text = "You have discovered the ruins of a lost temple. There are planks scattered about."
                    If blnPlanksFound = True Then
                        lblAdventure.Text = "You have discovered the ruins of a lost temple."
                    End If
                    intLocation = 7
                    picAdventure.Image = My.Resources.Temple
                    ovlJungle.FillColor = Color.DodgerBlue
                    ovlTemple.FillColor = Color.Red
                End If
                'Pick up Hammer/Nails
                If (strAction = "pick up hammer" Or strAction = "pick up nails" Or strAction = "pick up hammer and nails" Or strAction = "pick up hammer + nails") And _
                    intLocation = 5 Then
                    lblAdventure.Text = "You have found the hammer and nails!"
                    picHammer.Visible = True
                    picNails.Visible = True
                    blnHammerFound = True
                    If blnHammerFound = True And blnPlanksFound = True And blnOarsFound = True Then
                        lblAdventure.Text = "You have found the hammer and nails" & vbCrLf & strMaterials
                    End If
                End If
                'Pick up Obsidian Knife
                If (strAction = "pick up shards" Or strAction = "pick up volcanic glass" Or strAction = "pick up obsidian") And _
                    intLocation = 6 Then
                    lblAdventure.Text = "You picked up the obsidian shards. They are very sharp. Maybe they could be used for something."
                    picShards.Visible = True
                End If
                'Pick up Planks
                If (strAction = "pick up planks" Or strAction = "pick up wooden planks") And _
                    intLocation = 7 Then
                    lblAdventure.Text = "Planks get!"
                    picPlanks.Visible = True
                    blnPlanksFound = True
                    If blnHammerFound = True And blnPlanksFound = True And blnOarsFound = True Then
                        lblAdventure.Text = "Planks get!" & vbCrLf & strMaterials
                    End If
                End If
                'Make Boat
                If strAction = "make boat" Then
                    lblAdventure.Text = "You have created a boat perfect for sea travel!"
                    picHammer.Visible = False
                    picNails.Visible = False
                    picPlanks.Visible = False
                    picOars.Visible = False
                    picBoat.Visible = True
                    blnBoat = True
                End If
                'Try to Push Gate
                If strAction = "push gate" And intLocation = 2 Then
                    lblAdventure.Text = "You try to push the gate open to no avail. It is sturdy and locked tight. A key may be required."
                End If
                'Try to Swim
                If strAction = "swim" And intLocation = 0 Then
                    lblAdventure.Text = "You don't know how to swim, and you don't plan to learn either."
                End If
            Case 1
                strExamine = InputBox("What would you like to examine?", "Examine what?").ToLower
                'Examine Sky
                If strExamine = "sky" Then
                    lblAdventure.Text = "The sky is looking unbelievably normal... and blue. This contributes nothing to the plot however."
                End If
                'Examine island from beach
                If strExamine = "island" And intLocation = 0 Then
                    lblAdventure.Text = "You follow a path to an island clearing. There is a volcano to the north, some jungle to the east, and to the west is a cave."
                    picAdventure.Image = My.Resources.Clearing
                    intLocation = 1
                    ovlBeach.FillColor = Color.DodgerBlue
                    ovlClearing.FillColor = Color.Red
                End If
                'Find Key
                If strExamine = "sand" And intLocation = 3 Then
                    lblAdventure.Text = "You have found the key!"
                    picKey.Visible = True
                End If
                'Examine Gate
                If strExamine = "gate" And intLocation = 2 Then
                    lblAdventure.Text = "The old rusted gate looks fragile, but it is actually strong and stable."
                End If
                'Warp to Cavern
                If strExamine = "temple" And intLocation = 7 Then
                    lblAdventure.Text = "The ruins appear to be of late Mayan descent."
                    If blnKeyUsed = True Then
                        lblAdventure.Text = "The ruins appear to be of late Mayan descent. While examining the temple, you fall through a hole into a cave."

                        picAdventure.Image = My.Resources.Cavern
                        intLocation = 5
                        ovlTemple.FillColor = Color.DodgerBlue
                        ovlCavern.FillColor = Color.Red
                    End If
                End If
                'Find Oars
                If strExamine = "beach" And intLocation = 0 Then
                    lblAdventure.Text = "You find a set of old oars lying in the sand."
                    picOars.Visible = True
                    blnOarsFound = True
                    If blnHammerFound = True And blnPlanksFound = True And blnOarsFound = True Then
                        lblAdventure.Text = "You find a set of old oars lying in the sand." & vbCrLf & strMaterials
                    End If
                End If
            Case 2
                If (picKey.Visible = True) Or (picShards.Visible = True) Or (picPlanks.Visible = True) Or (picHammer.Visible = True) Or (picNails.Visible = True) Or (picOars.Visible = True) Or (picBoat.Visible = True) Then
                    blnItem = True
                    strItem = InputBox("Use which item?", "Use Item", ).ToLower
                    'Unlock Cave Door
                    If strItem = "key" And intLocation = 2 Then
                        lblAdventure.Text = "The rusty gate opens, allowing access to the cave."
                        picAdventure.Image = My.Resources.Open_Cave
                        picKey.Visible = False
                        blnKeyUsed = True
                    End If
                    'Cut Jungle Vines
                    If (strItem = "shard" Or strItem = "shards" Or strItem = "obsidian shard" Or strItem = "obsidian shards") And _
                        intLocation = 4 Then
                        lblAdventure.Text = "The obsidian shard cuts the vines, but breaks in the process."
                        picAdventure.Image = My.Resources.Free_Jungle
                        picShards.Visible = False
                        blnShardsUsed = True
                    End If
                    'Win Game!!!
                    If strItem = "boat" And blnBoat = True And _
                        intLocation = 0 Then
                        lblAdventure.Text = "Congratulations!" & vbCrLf & "You have escaped the island."
                        picAdventure.Image = My.Resources.Win
                        lstChoices.Enabled = False
                        picBoat.Visible = False
                        btnCredits.Visible = True
                        btnMenu.Visible = True
                        tmrAdventure.Enabled = False
                    End If
                    'Debug Win
                    If strItem = "debug power" Then
                        lblAdventure.Text = "Congratulations!" & vbCrLf & "You have escaped the island."
                        picAdventure.Image = My.Resources.Win
                        lstChoices.Enabled = False
                        picBoat.Visible = False
                        btnCredits.Visible = True
                        btnMenu.Visible = True
                        tmrAdventure.Enabled = False
                    End If
                Else : MsgBox("You have no items", MsgBoxStyle.OkOnly)
                End If
            Case 3
                intSleep = MsgBox("Are you sure you want to sleep?", MsgBoxStyle.YesNo, "Sleep")
                If intSleep = 6 Then
                    Me.Hide()
                    frmIslandAdventure.Show()
                    tmrAdventure.Enabled = False
                ElseIf intSleep = 7 Then
                End If
        End Select
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'Close form and transfer to Main Menu
        Me.Close()
        frmIslandAdventure.Show()
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        'Close form and transfer to About Page
        Me.Close()
        frmAbout.Visible = True
    End Sub

    Private Sub tmrAdventure_Tick(sender As Object, e As EventArgs) Handles tmrAdventure.Tick
        'Countdown
        timeLeft = startTime.Subtract(Now)
        If Not timeLeft.Milliseconds < 0 Then
            lblTimer.Text = "You will die of thirst in   " & vbCrLf & Format(timeLeft.Minutes, "#0") & " Minutes" & " & " & Format(timeLeft.Seconds, "00") & " Seconds"
        Else
            tmrAdventure.Enabled = False
            lblTimer.Text = "You have died of thirst."
            lstChoices.Enabled = False
            btnMenu.Visible = True
        End If
    End Sub

    Private Sub btnHints_Click(sender As Object, e As EventArgs) Handles btnHints.Click
        frmHints.Show()
    End Sub
End Class