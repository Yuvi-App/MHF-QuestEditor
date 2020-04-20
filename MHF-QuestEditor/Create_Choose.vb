Imports MHF_QuestEditor.QuestInfo
Public Class Create_Choose
    Dim Location As Boolean = False
    Dim Monster As Boolean = False
    Dim SubAMonster As Boolean = False
    Dim SubBMonster As Boolean = False


    Public Sub Check(valueToCheck As String)
        If valueToCheck = "ChooseLocation" Then
            Location = True
        ElseIf valueToCheck = "ChooseMonster" Then
            Monster = True
        ElseIf valueToCheck = "ChooseSubAMonster" Then
            SubAMonster = True
        ElseIf valueToCheck = "ChooseSubBMonster" Then
            SubBMonster = True
        End If
    End Sub

    Private Sub Create_ChooseLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rlist = New List(Of String)
        rlist.Add("Assets/bg2.png")
        rlist.Add("Assets/bg3.png")
        rlist.Add("Assets/bg4.png")
        rlist.Add("Assets/bg5.png")
        Dim rnd = New Random()
        Dim randombg = rlist(rnd.Next(0, rlist.Count))
        BackgroundImage = Image.FromFile(randombg)

        Try
            If Location = True Then
                For Each l In LocationList.Locations
                    ComboBox1.Items.Add(l.Value)
                Next
                ComboBox1.SelectedIndex = 0
            ElseIf Monster = True Or SubAMonster = True Or SubBMonster = True Then
                For Each m In Monsters.MonsterNames
                    ComboBox1.Items.Add(m.Value)
                Next
                ComboBox1.SelectedIndex = 0
            Else
                MessageBox.Show("Error Occured getting value")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Occured getting value")
        End Try



    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Location = True Then
            Dim CurrentLocation = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            lblTitle.Text = CurrentLocation
            Try
                PictureBox1.BackgroundImage = Image.FromFile("Assets/Maps/" + CurrentLocation + ".png")
            Catch ex As Exception

            End Try
        ElseIf Monster = True Or SubAMonster = True Or SubBMonster = True Then
            Dim CurrentMonster = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            lblTitle.Text = CurrentMonster
            Try
                PictureBox1.BackgroundImage = Image.FromFile("Assets/Monsters/" + CurrentMonster + ".png")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            ComboBox1.SelectedIndex = ComboBox1.SelectedIndex + 1
            My.Computer.Audio.Play("Assets/Sounds/click.wav")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Try
            ComboBox1.SelectedIndex = ComboBox1.SelectedIndex - 1
            My.Computer.Audio.Play("Assets/Sounds/click.wav")
        Catch
        End Try

    End Sub

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        If Location = True Then
            CreateQuest.txtLocation.Text = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            Location = False
            Me.Close()
        ElseIf Monster = True Then
            CreateQuest.txtMainMonster.Text = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            Monster = False
            Me.Close()
        ElseIf SubAMonster = True Then
            CreateQuest.txtSubAMonster.Text = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            SubAMonster = False
            Me.Close()
        ElseIf SubBMonster = True Then
            CreateQuest.txtSubBMonster.Text = ComboBox1.GetItemText(ComboBox1.SelectedItem)
            SubBMonster = False
            Me.Close()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If Location = True Then
            Location = False
            Me.Close()
        ElseIf Monster = True Then
            Monster = False
            Me.Close()
        ElseIf SubAMonster = True Then
            SubAMonster = False
            Me.Close()
        ElseIf SubBMonster = True Then
            SubBMonster = False
            Me.Close()
        End If
    End Sub
End Class