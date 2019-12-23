Imports System.IO
Public Class frmHints

    Private Sub frmHints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StreamToDisplay As StreamReader
        StreamToDisplay = New StreamReader("E:\Visual Basic Programming\Assignments\Final\Island Adventure\Resources\hints.txt")
        txtHints.Text = StreamToDisplay.ReadToEnd
        StreamToDisplay.Close()
        txtHints.Select(0, 0)
    End Sub
End Class