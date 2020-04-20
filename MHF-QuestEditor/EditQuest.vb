Imports System.Text
Imports System.IO
Imports MHF_QuestEditor.DamienG.Security.Cryptography
Imports MHF_QuestEditor.QuestInfo

Public Class EditQuest
    'Global Var.
    Dim QuestFilePath As String
    Dim MapTimer_Map
    Dim brInput


    'Form Stuff
    Private Sub btnLoadQuest_Click(sender As Object, e As EventArgs) Handles btnLoadQuest.Click
        ClearFields()
        OpenFile()
    End Sub

    Private Sub btnCreateQuest_Click(sender As Object, e As EventArgs)
        ClearFields()
        PrepForm()
    End Sub



    '-----------------Functions-----------------
    Public Function ClearFields()
        lbxLocation.Items.Clear()
        lbxMainObjective.Items.Clear()
        lbxSubAObjective.Items.Clear()
        lbxSubBObjective.Items.Clear()
        nudMainObjectiveDamage.Value = 0
        nudSubAObjectiveDamage.Value = 0
        nudSubBObjectiveDamage.Value = 0
    End Function

    '-----Load Quest-----
    Public Shared Function ReadNullterminatedString(ByVal brInput As BinaryReader, ByVal encoding As Encoding) As String
        Dim charByteList = New List(Of Byte)()
        Dim str As String = ""

        If brInput.BaseStream.Position = brInput.BaseStream.Length Then
            Dim charByteArray As Byte() = charByteList.ToArray()
            str = encoding.GetString(charByteArray)
            Return str
        End If

        Dim b As Byte = brInput.ReadByte()

        While (b <> &H0) AndAlso (brInput.BaseStream.Position <> brInput.BaseStream.Length)
            charByteList.Add(b)
            b = brInput.ReadByte()
        End While

        Dim char_bytes As Byte() = charByteList.ToArray()
        str = encoding.GetString(char_bytes)
        Return str
    End Function

    Public Shared Function ReturnMonster(ByVal inputArray As Byte(), ByVal index As Integer) As String
        Dim monster As String = Nothing

        If Monsters.MonsterNames.TryGetValue(inputArray(index), monster) Then
        Else
            monster = BitConverter.ToInt16(inputArray, index).ToString()
        End If

        Return monster
    End Function

    Public Shared Function ReturnMonster(ByVal monsterID As Integer) As String
        Dim monster As String = Nothing

        If Monsters.MonsterNames.TryGetValue(CByte(monsterID), monster) Then
        Else
            monster = monsterID.ToString()
        End If

        Return monster
    End Function

    Public Shared Function ReturnInterception(ByVal inputArray As Byte()) As String
        Dim monster As String = ""
        Dim monsterAdd As String = Nothing

        For i As Integer = 377 To 382 - 1
            If inputArray(i) = 0 Then Continue For

            If Monsters.MonsterNames.TryGetValue(inputArray(i), monsterAdd) Then
            Else
                monsterAdd = BitConverter.ToSingle(inputArray, i).ToString()
            End If

            If i = 377 Then
                monster += monsterAdd
            Else
                monster += $", {monsterAdd}"
            End If
        Next

        Return monster
    End Function

    Public Shared Function ReturnItem(ByVal inputArray As Byte(), ByVal index As Integer) As String
        Dim item As String = Nothing

        If Items.ItemIDs.TryGetValue(BitConverter.ToInt16(inputArray, index), item) Then
        Else
            item = BitConverter.ToInt16(inputArray, index).ToString()
        End If

        Return item
    End Function

    Public Shared Function ReturnObjectiveHex(ByVal inputArray As Byte(), ByVal index As Integer) As String
        Return BitConverter.ToString(New Byte() {inputArray(index), inputArray(index + 1), inputArray(index + 2), inputArray(index + 3)}).Replace("-", "")
    End Function

    Public Function OpenFile()
        'Call Dialog
        Dim result As DialogResult = OpenQuestFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            QuestFilePath = OpenQuestFile.FileName
            'Calls GetQuestInfo to get crc and quest info of file.
            GetQuestInfo(QuestFilePath)

            'Enabled Fields
            lbxLocation.Enabled = True
            lbxMainObjective.Enabled = True
            lbxSubAObjective.Enabled = True
            lbxSubBObjective.Enabled = True
            lbxVariant1a.Enabled = True
            lbxVariant1b.Enabled = True
            lbxVariant2a.Enabled = True
            lbxVariant2b.Enabled = True
            nudMainZeny.Enabled = True
            nudSubAZeny.Enabled = True
            nudSubBZeny.Enabled = True
            nudQuestFee.Enabled = True
        End If
    End Function

    Public Function GetQuestInfo(ByVal QuestFilePath As String) As Structs.QuestInfo
        'Get CRC
        Dim crc32 = New Crc32()
        Dim hash = String.Empty
        Dim fs = File.Open(QuestFilePath, FileMode.Open)
        For Each b As Byte In crc32.ComputeHash(fs)
            hash += b.ToString("x2").ToLower()
        Next
        fs.Close()

        Dim inputArray As Byte() = File.ReadAllBytes(QuestFilePath)
        inputArray.Reverse()

        brInput = New BinaryReader(New FileStream(QuestFilePath, FileMode.Open))

        'Start to Load Quest File Info
        LoadLocations(inputArray)
        LoadMainObjective(inputArray)
        LoadSubAObjective(inputArray)
        LoadSubBObjective(inputArray)
        LoadRank(inputArray)
        'LoadMonsterVariant(inputArray)
        LoadMoneyStuff(inputArray)
        'LoadMonsterCords(inputArray)
    End Function

    Public Function LoadLocations(ByVal inputArray)
        Dim location As String = Nothing
        If (LocationList.Locations.TryGetValue(BitConverter.ToInt32(inputArray, 228), location)) Then
            lbxLocation.Items.Add(location)
            MapTimer_Map = location
        End If
    End Function

    Public Function LoadMainObjective(ByVal inputArray)
        Dim objectiveMainHex As String = ReturnObjectiveHex(inputArray, 240)
        Dim objectiveMainType As String = Nothing
        Dim ObjectiveMainQuant
        Dim MainObj As String = Nothing

        If QuestObj.Objectives.TryGetValue(objectiveMainHex, objectiveMainType) Then

        Else
            objectiveMainType = objectiveMainHex
        End If

        If objectiveMainType = "Hunt" Or objectiveMainType = "Slay" Or objectiveMainType = "Damage" Or objectiveMainType = "Slay or Damage" Or objectiveMainType = "Capture" Then
            MainObj = ReturnMonster(inputArray, 244)
        ElseIf objectiveMainType = "Break Part" Then
            MainObj = BitConverter.ToInt16(inputArray, 244).ToString()
        ElseIf objectiveMainType = "Slay All" Then
            MainObj = ReturnInterception(inputArray)
        Else MainObj = ReturnItem(inputArray, 244)
        End If

        lbxMainObjective.Items.Add(MainObj)

        ObjectiveMainQuant = BitConverter.ToInt16(inputArray, 246)
        If objectiveMainType = "Damage" OrElse objectiveMainType = "Slay or Damage" Then
            nudMainObjectiveDamage.Enabled = True
            ObjectiveMainQuant = ObjectiveMainQuant * 100
            nudMainObjectiveDamage.Value = ObjectiveMainQuant
        End If
    End Function

    Public Function LoadSubAObjective(ByVal inputArray)
        Dim objectiveSubAHex As String = ReturnObjectiveHex(inputArray, 248)
        Dim objectiveSubAType As String = Nothing
        Dim ObjectiveSubAQuant
        Dim SubAObj As String = Nothing

        If QuestObj.Objectives.TryGetValue(objectiveSubAHex, objectiveSubAType) Then

        Else
            objectiveSubAType = objectiveSubAHex
        End If

        If objectiveSubAType = "Hunt" Or objectiveSubAType = "Slay" Or objectiveSubAType = "Damage" Or objectiveSubAType = "Slay or Damage" Or objectiveSubAType = "Capture" Then
            SubAObj = ReturnMonster(inputArray, 252)
        ElseIf objectiveSubAType = "Break Part" Then
            SubAObj = BitConverter.ToInt16(inputArray, 252).ToString()
        ElseIf objectiveSubAType = "Slay All" Then
            SubAObj = ReturnInterception(inputArray)
        Else SubAObj = ReturnItem(inputArray, 252)
        End If

        If SubAObj = "0" Or SubAObj = Nothing Then
            SubAObj = "None"
            lbxSubAObjective.Items.Add(SubAObj)
        Else
            lbxSubAObjective.Items.Add(SubAObj)
        End If

        ObjectiveSubAQuant = BitConverter.ToInt16(inputArray, 254)
        If objectiveSubAType = "Damage" OrElse objectiveSubAType = "Slay or Damage" Then
            nudSubAObjectiveDamage.Enabled = True
            ObjectiveSubAQuant = ObjectiveSubAQuant * 100
            nudSubAObjectiveDamage.Value = ObjectiveSubAQuant
        End If
    End Function

    Public Function LoadSubBObjective(ByVal inputArray)
        Dim objectiveSubBHex As String = ReturnObjectiveHex(inputArray, 256)
        Dim objectiveSubBType As String = Nothing
        Dim ObjectiveSubBQuant
        Dim SubBObj As String = Nothing

        If QuestObj.Objectives.TryGetValue(objectiveSubBHex, objectiveSubBType) Then

        Else
            objectiveSubBType = objectiveSubBHex
        End If

        If objectiveSubBType = "Hunt" Or objectiveSubBType = "Slay" Or objectiveSubBType = "Damage" Or objectiveSubBType = "Slay or Damage" Or objectiveSubBType = "Capture" Then
            SubBObj = ReturnMonster(inputArray, 260)
        ElseIf objectiveSubBType = "Break Part" Then
            SubBObj = BitConverter.ToInt16(inputArray, 260).ToString()
        ElseIf objectiveSubBType = "Slay All" Then
            SubBObj = ReturnInterception(inputArray)
        Else SubBObj = ReturnItem(inputArray, 260)
        End If

        If SubBObj = "0" Or SubBObj = Nothing Then
            SubBObj = "None"
            lbxSubBObjective.Items.Add(SubBObj)
        Else
            lbxSubBObjective.Items.Add(SubBObj)
        End If

        ObjectiveSubBQuant = BitConverter.ToInt16(inputArray, 262)
        If objectiveSubBType = "Damage" OrElse objectiveSubBType = "Slay or Damage" Then
            nudSubBObjectiveDamage.Enabled = True
            ObjectiveSubBQuant = ObjectiveSubBQuant * 100
            nudSubBObjectiveDamage.Value = ObjectiveSubBQuant
        End If
    End Function

    Public Function LoadRank(ByVal inputArray)
        Dim StatTable
        If (Ranks.RankBands.TryGetValue(BitConverter.ToInt32(inputArray, 72), StatTable)) Then
            StatTable = $"{BitConverter.ToInt32(inputArray, 72)}   |   {StatTable}"
            lblRank.Text = "Hunter Rank: " & StatTable
        Else
            StatTable = BitConverter.ToInt32(inputArray, 72).ToString
        End If
    End Function

    Public Function LoadMonsterVariant(ByVal inputArray)
        Dim Variant1A = inputArray(337).ToString("X2")
        Dim Variant2A = inputArray(338).ToString("X2")
        Dim Variant1B = inputArray(345).ToString("X2")
        Dim Variant2B = inputArray(346).ToString("X2")
        lbxVariant1a.Items.Add(Variant1A)
        lbxVariant1b.Items.Add(Variant1B)
        lbxVariant2a.Items.Add(Variant2A)
        lbxVariant2b.Items.Add(Variant2B)
    End Function

    Public Function LoadMoneyStuff(ByVal inputArray)
        Dim QuestFee = BitConverter.ToInt32(inputArray, 204)
        Dim RewardMain = BitConverter.ToInt32(inputArray, 208)
        Dim RewardA = BitConverter.ToInt32(inputArray, 216)
        Dim RewardB = BitConverter.ToInt32(inputArray, 220)
        nudQuestFee.Value = QuestFee
        nudMainZeny.Value = RewardMain
        nudSubAZeny.Value = RewardA
        nudSubBZeny.Value = RewardB
    End Function

    Public Function LoadMonsterCords(ByVal inputarray)
        Dim monsterStart As Integer = BitConverter.ToInt32(inputarray, 24)
        Dim monsterTypePointer As Integer = BitConverter.ToInt32(inputarray, monsterStart + 8)
        Dim monsterSpawns As Integer = 0

        While BitConverter.ToInt32(inputarray, monsterTypePointer) > 0
            monsterTypePointer += 4
            monsterSpawns += 1
        End While
        Dim monsterStatPointer As Integer = BitConverter.ToInt32(inputarray, monsterStart + 12)
        Console.WriteLine($"{monsterStatPointer}")
        If monsterSpawns > 0 Then
            Dim MonsterData As Structs.MonsterSpawn() = New Structs.MonsterSpawn(monsterSpawns - 1) {}
            brInput.BaseStream.Seek(monsterStatPointer, SeekOrigin.Begin)
            For i As Integer = 0 To monsterSpawns - 1
                Dim cMon As Structs.MonsterSpawn = New Structs.MonsterSpawn()
                cMon.Monster = ReturnMonster(brInput.ReadInt32())
                cMon.Unk1 = brInput.ReadInt32()
                cMon.Unk2 = brInput.ReadInt32()
                cMon.Unk3 = brInput.ReadInt32()
                cMon.Unk4 = brInput.ReadInt32()
                cMon.Unk5 = brInput.ReadInt32()
                cMon.Unk6 = brInput.ReadInt32()
                cMon.Unk7 = brInput.ReadInt32()
                cMon.XPos = brInput.ReadSingle()
                cMon.ZPos = brInput.ReadSingle()
                cMon.YPos = brInput.ReadSingle()
                cMon.Unk8 = brInput.ReadInt32()
                cMon.Unk9 = brInput.ReadInt32()
                cMon.Unk10 = brInput.ReadInt32()
                cMon.Unk11 = brInput.ReadInt32()
                MonsterData(i) = cMon
                lblMonsterCords.Text = $"Monster Starting Cords: X={cMon.XPos} Y={cMon.YPos} Z={cMon.ZPos}"
            Next
            brInput.Close()
        End If

    End Function
    '-----End Load Quest-----
    '-----Create Quest-----
    Public Function PrepForm()
        Dim Location As String = Nothing
        For Each kvp As KeyValuePair(Of Integer, String) In LocationList.Locations
            lbxLocation.Items.Add(kvp.Value)
        Next
        Dim Monster As String = Nothing
        For Each kvp As KeyValuePair(Of Byte, String) In Monsters.MonsterNames
            lbxMainObjective.Items.Add(kvp.Value)
            lbxSubAObjective.Items.Add(kvp.Value)
            lbxSubBObjective.Items.Add(kvp.Value)
        Next
    End Function
    '-----End Create Quest-----
    '-----------------END Functions-----------------



    'Timers
    Private Sub MapTimer_Tick(sender As Object, e As EventArgs) Handles MapTimer.Tick
        Try
            PictureBox2.BackgroundImage = Image.FromFile("Assets/Maps/" + lbxLocation.GetItemText(lbxLocation.SelectedItem) + ".png")
        Catch ex As Exception

        End Try
    End Sub
End Class
