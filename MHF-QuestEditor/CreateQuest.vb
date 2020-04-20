Imports MHF_QuestEditor.QuestInfo
Imports System.Drawing.Text
Imports System
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class CreateQuest

    Private Sub CreateQuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxHunterRank.SelectedIndex = 0
    End Sub

    Private Sub pboxBack_Click(sender As Object, e As EventArgs) Handles pboxBack.Click
        Me.Close()
    End Sub

    Private Sub pboxNext_Click(sender As Object, e As EventArgs) Handles pboxNext.Click

    End Sub

    Private Sub btnChooseLocation_Click(sender As Object, e As EventArgs) Handles btnChooseLocation.Click
        Create_Choose.Check("ChooseLocation")
        Create_Choose.Show()
    End Sub

    Private Sub btnChooseMonster_Click(sender As Object, e As EventArgs) Handles btnChooseMonster.Click
        Create_Choose.Check("ChooseMonster")
        Create_Choose.Show()
    End Sub

    Private Sub btnChooseSubAMonster_Click(sender As Object, e As EventArgs) Handles btnChooseSubAMonster.Click
        Create_Choose.Check("ChooseSubAMonster")
        Create_Choose.Show()
    End Sub

    Private Sub btnChooseSubBMonster_Click(sender As Object, e As EventArgs) Handles btnChooseSubBMonster.Click
        Create_Choose.Check("ChooseSubBMonster")
        Create_Choose.Show()
    End Sub

    Private Sub lbxMainObj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxMainObj.SelectedIndexChanged, lbxSubAObj.SelectedIndexChanged, lbxSubBObj.SelectedIndexChanged
        If lbxMainObj.GetItemText(lbxMainObj.SelectedItem) = "Damage" Or lbxMainObj.GetItemText(lbxMainObj.SelectedItem) = "Slay or Damage" Then
            nudMainMonsterDamage.Enabled = True
        Else
            nudMainMonsterDamage.Enabled = False
        End If

        If lbxSubBObj.GetItemText(lbxSubBObj.SelectedItem) = "Damage" Or lbxSubBObj.GetItemText(lbxSubBObj.SelectedItem) = "Slay or Damage" Then
            nudSubBMonsterDamage.Enabled = True
        Else
            nudSubBMonsterDamage.Enabled = False
        End If

        If lbxSubAObj.GetItemText(lbxSubAObj.SelectedItem) = "Damage" Or lbxSubAObj.GetItemText(lbxSubAObj.SelectedItem) = "Slay or Damage" Then
            nudSubAMonsterDamage.Enabled = True
        Else
            nudSubAMonsterDamage.Enabled = False
        End If
    End Sub

    Private Sub btnMainMonsterSpawn_Click(sender As Object, e As EventArgs) Handles btnMainMonsterSpawn.Click
        Create_ChooseMonsterLocation.Check("ChooseSpawnMain")
        Create_ChooseMonsterLocation.Show()
    End Sub

    Private Sub btnSubAMonsterSpawn_Click(sender As Object, e As EventArgs) Handles btnSubAMonsterSpawn.Click
        Create_ChooseMonsterLocation.Check("ChooseSpawnSubA")
        Create_ChooseMonsterLocation.Show()
    End Sub

    Private Sub btnSubBMonsterSpawn_Click(sender As Object, e As EventArgs) Handles btnSubBMonsterSpawn.Click
        Create_ChooseMonsterLocation.Check("ChooseSpawnSubB")
        Create_ChooseMonsterLocation.Show()
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtMainMonster.TextChanged, txtSubAMonster.TextChanged, txtSubBMonster.TextChanged
        If Not txtMainMonster.Text = "Monster Name" Or Not txtMainMonster.Text = "None" Then
            btnMainMonsterSpawn.Enabled = True
        End If
        If Not txtSubAMonster.Text = "Monster Name" Or Not txtSubAMonster.Text = "None" Then
            btnSubAMonsterSpawn.Enabled = True
        End If
        If Not txtSubBMonster.Text = "Monster Name" Or Not txtSubBMonster.Text = "None" Then
            btnSubBMonsterSpawn.Enabled = True
        End If
    End Sub
End Class