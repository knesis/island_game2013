Public Class frmAbout

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnAboutLog_Click(sender As Object, e As EventArgs) Handles btnAboutLog.Click
        MsgBox(Prompt:="09/24/12 - Indev: Created form, title.                            " & vbCrLf & _
                       "09/25/12 - Indev: Background, Icon.                               " & vbCrLf & _
                       "09/26/12 - Pre-Alpha: Main Menu buttons.                          " & vbCrLf & _
                       "10/01/12 - Pre-Alpha: Form now 20% Larger.                        " & vbCrLf & _
                       "10/08/12 - Alpha: Name Input Box, List box, Beach picture created." & vbCrLf & _
                       "10/12/12 - Alpha: Sleep function activated                        " & vbCrLf & _
                       "10/22/12 - Alpha: Preliminary Do and Examine functions created    " & vbCrLf & _
                       "11/07/12 - Pre-Beta: Move North and West activated                " & vbCrLf & _
                       "11/21/12 - Beta: All Move options enabled for the whole map.      " & vbCrLf & _
                       "11/25/12 - Beta: Options Menu, First Puzzle.                      " & vbCrLf & _
                       "11/27/12 - Beta: Map Doubled, More Items.                         " & vbCrLf & _
                       "11/28/12 - Pre-Release: Adventure completed.                      " & vbCrLf & _
                       "12/19/12 - Release: Easy and Hard modes completed.", Buttons:=MsgBoxStyle.DefaultButton1, Title:="About Log")
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        MsgBox("Design:     Anthony Knesis" & vbCrLf & _
               "Coding:    Anthony Knesis" & vbCrLf & _
               "Story:        Anthony Knesis" & vbCrLf & _
               "Pictures:         The Internet" & vbCrLf & _
               "Testing:                    HGMP" & vbCrLf & _
               "Idea:         Anthony Knesis" & vbCrLf & vbCrLf & _
               "With special thanks to   " & vbCrLf & _
               "Anthony Knesis           " & vbCrLf & _
               "Howard Gadsby            " & vbCrLf & _
               "Brother Tran             ", MsgBoxStyle.DefaultButton1, "Credits")
    End Sub
End Class