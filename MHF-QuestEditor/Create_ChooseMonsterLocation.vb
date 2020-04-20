
Public Class Create_ChooseMonsterLocation

    Dim LocalMousePosition As Point
    Dim MainMonster As Boolean = False
    Dim SubAMonster As Boolean = False
    Dim SubBMonster As Boolean = False
    Dim SpawnPointX As Int16
    Dim SpawnPointZ As Int16
    Dim SpawnpointY As Int16

    Public Sub Check(valueToCheck As String)
        If valueToCheck = "ChooseSpawnMain" Then
            MainMonster = True
        ElseIf valueToCheck = "ChooseSpawnSubA" Then
            SubAMonster = True
        ElseIf valueToCheck = "ChooseSpawnSubB" Then
            SubBMonster = True
        End If
    End Sub

    Private Sub Create_ChooseMonsterLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Random BG
        Dim rlist = New List(Of String)
        rlist.Add("Assets/bg2.png")
        rlist.Add("Assets/bg3.png")
        rlist.Add("Assets/bg4.png")
        rlist.Add("Assets/bg5.png")
        Dim rnd = New Random()
        Dim randombg = rlist(rnd.Next(0, rlist.Count))
        BackgroundImage = Image.FromFile(randombg)


        'Load Monster from create form
        Dim CurrentMonster = CreateQuest.txtMainMonster.Text
        Dim CurrentLocation = CreateQuest.txtLocation.Text
        Dim CurrentSubAMonster = CreateQuest.txtSubAMonster.Text
        Dim CurrentSubBMonster = CreateQuest.txtSubBMonster.Text


        Try
            If MainMonster = True Then
                lblTitle.Text = "Choose Spawn for " + CurrentMonster + " in " + CurrentLocation
                PictureBox1.BackgroundImage = Image.FromFile("Assets/Maps/" + CurrentLocation + ".png")
            ElseIf SubAMonster = True Then
                lblTitle.Text = "Choose Spawn for " + CurrentSubAMonster + " in " + CurrentLocation
                PictureBox1.BackgroundImage = Image.FromFile("Assets/Maps/" + CurrentLocation + ".png")
            ElseIf SubBMonster = True Then
                lblTitle.Text = "Choose Spawn for " + CurrentSubBMonster + " in " + CurrentLocation
                PictureBox1.BackgroundImage = Image.FromFile("Assets/Maps/" + CurrentLocation + ".png")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading assets")
        End Try
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As EventArgs) Handles PictureBox1.MouseMove
        'Get Mouse Coords
        LocalMousePosition = PictureBox1.PointToClient(Cursor.Position)
        SpawnPointX = LocalMousePosition.X * 86.2315789474
        SpawnpointY = LocalMousePosition.Y * 109.223333333

        lblMouseCoords.Text = ("Spawn Coords: " + "X=" & SpawnPointX & "," & "Y= " & SpawnpointY)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim pin = "Assets/pin.png"
        Dim pb As New PictureBox
        LocalMousePosition = PictureBox1.PointToClient(Cursor.Position)
        SpawnPointX = LocalMousePosition.X * 86.2315789474
        SpawnpointY = LocalMousePosition.Y * 109.223333333

        MessageBox.Show("Spawn Set to " + SpawnPointX.ToString + " / " + SpawnpointY.ToString, "Spawn Set!")

        If MainMonster = True Then
            CreateQuest.lblMainSpawnCoords.Text = "X= " + SpawnPointX.ToString + " Y= " + SpawnpointY.ToString
            MainMonster = False
            Me.Close()
        ElseIf SubAMonster = True Then
            CreateQuest.lblSubASpawnCoords.Text = "X= " + SpawnPointX.ToString + " Y= " + SpawnpointY.ToString
            SubAMonster = False
            Me.Close()
        ElseIf SubBMonster = True Then
            CreateQuest.lblSubBSpawnCoords.Text = "X= " + SpawnPointX.ToString + " Y= " + SpawnpointY.ToString
            SubBMonster = False
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MainMonster = True Then
            MainMonster = False
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