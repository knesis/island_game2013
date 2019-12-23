'Anthony Knesis
'Island Adventure
'12/21/12
'This game uses list boxes, conditional If-Then statements, and boolean values to replicate an adventure on a deserted island.

Public Class frmIslandAdventure
    Public intMusic As String
    Public intDifficulty As Integer
    Dim intQuit As Integer

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        intQuit = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit")
        If intQuit = 6 Then
            End
        ElseIf intQuit = 7 Then
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Visible = False
        frmAdventureGame.Show()
    End Sub

    Public Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        'Hide Main Menu
        btnStart.Visible = False
        btnOptions.Visible = False
        btnAbout.Visible = False
        btnQuit.Visible = False
        lblTitle.Visible = False
        'Show Options Menu
        cmbMusic.Visible = True
        lblMusic.Visible = True
        btnBack.Visible = True
        btnReset.Visible = True
        cmbDifficulty.Visible = True
        lblDifficulty.Visible = True
    End Sub

    Public Sub btnStart_MouseHover(sender As Object, e As EventArgs) Handles btnStart.MouseHover
        btnStart.Text = "Start the escape"
    End Sub

    Public Sub btnHelp_MouseHover(sender As Object, e As EventArgs) Handles btnOptions.MouseHover
        btnOptions.Text = "Edit some game settings"
    End Sub

    Public Sub btnAbout_MouseHover(sender As Object, e As EventArgs) Handles btnAbout.MouseHover
        btnAbout.Text = "Learn about the game"
    End Sub

    Public Sub btnQuit_MouseHover(sender As Object, e As EventArgs) Handles btnQuit.MouseHover
        btnQuit.Text = "Stop the adventure"
    End Sub

    Private Sub cmbMusic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMusic.SelectedIndexChanged
        Select Case cmbMusic.SelectedIndex
            Case 0
                intMusic = 1
            Case 1
                intMusic = 2
            Case 2
                intMusic = 3
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Hide Options Menu
        lblMusic.Visible = False
        cmbMusic.Visible = False
        btnBack.Visible = False
        btnReset.Visible = False
        cmbDifficulty.Visible = False
        lblDifficulty.Visible = False
        'Enable Menu buttons
        lblTitle.Visible = True
        btnStart.Visible = True
        btnOptions.Visible = True
        btnAbout.Visible = True
        btnQuit.Visible = True
    End Sub

    Private Sub frmIslandAdventure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        frmAdventureGame.Close()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub cmbDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDifficulty.SelectedIndexChanged
        Select Case cmbDifficulty.SelectedIndex
            Case 0
                intDifficulty = 1
            Case 1
                intDifficulty = 2
            Case 2
                intDifficulty = 3
        End Select
    End Sub
End Class
