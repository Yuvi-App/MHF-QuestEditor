Imports System.Drawing.Text

Public Class StartupForm
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateQuest.Show()
        My.Computer.Audio.Play("Assets/Sounds/create.wav")
    End Sub

    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        EditQuest.Show()
        My.Computer.Audio.Play("Assets/Sounds/load.wav")
    End Sub
End Class