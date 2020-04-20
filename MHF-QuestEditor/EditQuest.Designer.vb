<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditQuest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenQuestFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnLoadQuest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxQuestInfo = New System.Windows.Forms.GroupBox()
        Me.nudSubBZeny = New System.Windows.Forms.NumericUpDown()
        Me.pboxMap = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nudSubAZeny = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudMainZeny = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudQuestFee = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbxVariant2b = New System.Windows.Forms.ListBox()
        Me.lbxVariant2a = New System.Windows.Forms.ListBox()
        Me.lbxVariant1b = New System.Windows.Forms.ListBox()
        Me.lbxVariant1a = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMonsterCords = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.nudSubBObjectiveDamage = New System.Windows.Forms.NumericUpDown()
        Me.nudSubAObjectiveDamage = New System.Windows.Forms.NumericUpDown()
        Me.nudMainObjectiveDamage = New System.Windows.Forms.NumericUpDown()
        Me.lbxSubBObjective = New System.Windows.Forms.ListBox()
        Me.lbxSubAObjective = New System.Windows.Forms.ListBox()
        Me.lbxMainObjective = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbxLocation = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbldebug = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbxQuestInfo.SuspendLayout()
        CType(Me.nudSubBZeny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubAZeny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMainZeny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuestFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubBObjectiveDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubAObjectiveDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMainObjectiveDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenQuestFile
        '
        Me.OpenQuestFile.DefaultExt = "bin"
        Me.OpenQuestFile.Title = "Select .bin File"
        '
        'btnLoadQuest
        '
        Me.btnLoadQuest.Location = New System.Drawing.Point(12, 411)
        Me.btnLoadQuest.Name = "btnLoadQuest"
        Me.btnLoadQuest.Size = New System.Drawing.Size(99, 23)
        Me.btnLoadQuest.TabIndex = 1
        Me.btnLoadQuest.Text = "Load Quest"
        Me.btnLoadQuest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 9)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "- Yuvi"
        '
        'gbxQuestInfo
        '
        Me.gbxQuestInfo.Controls.Add(Me.nudSubBZeny)
        Me.gbxQuestInfo.Controls.Add(Me.pboxMap)
        Me.gbxQuestInfo.Controls.Add(Me.Label17)
        Me.gbxQuestInfo.Controls.Add(Me.nudSubAZeny)
        Me.gbxQuestInfo.Controls.Add(Me.Label16)
        Me.gbxQuestInfo.Controls.Add(Me.nudMainZeny)
        Me.gbxQuestInfo.Controls.Add(Me.Label15)
        Me.gbxQuestInfo.Controls.Add(Me.nudQuestFee)
        Me.gbxQuestInfo.Controls.Add(Me.Label14)
        Me.gbxQuestInfo.Controls.Add(Me.lbxVariant2b)
        Me.gbxQuestInfo.Controls.Add(Me.lbxVariant2a)
        Me.gbxQuestInfo.Controls.Add(Me.lbxVariant1b)
        Me.gbxQuestInfo.Controls.Add(Me.lbxVariant1a)
        Me.gbxQuestInfo.Controls.Add(Me.Label13)
        Me.gbxQuestInfo.Controls.Add(Me.Label12)
        Me.gbxQuestInfo.Controls.Add(Me.Label11)
        Me.gbxQuestInfo.Controls.Add(Me.Label10)
        Me.gbxQuestInfo.Controls.Add(Me.lblMonsterCords)
        Me.gbxQuestInfo.Controls.Add(Me.lblRank)
        Me.gbxQuestInfo.Controls.Add(Me.nudSubBObjectiveDamage)
        Me.gbxQuestInfo.Controls.Add(Me.nudSubAObjectiveDamage)
        Me.gbxQuestInfo.Controls.Add(Me.nudMainObjectiveDamage)
        Me.gbxQuestInfo.Controls.Add(Me.lbxSubBObjective)
        Me.gbxQuestInfo.Controls.Add(Me.lbxSubAObjective)
        Me.gbxQuestInfo.Controls.Add(Me.lbxMainObjective)
        Me.gbxQuestInfo.Controls.Add(Me.Label7)
        Me.gbxQuestInfo.Controls.Add(Me.Label9)
        Me.gbxQuestInfo.Controls.Add(Me.Label8)
        Me.gbxQuestInfo.Controls.Add(Me.Label5)
        Me.gbxQuestInfo.Controls.Add(Me.Label6)
        Me.gbxQuestInfo.Controls.Add(Me.Label4)
        Me.gbxQuestInfo.Controls.Add(Me.lbxLocation)
        Me.gbxQuestInfo.Controls.Add(Me.Label3)
        Me.gbxQuestInfo.Controls.Add(Me.Label2)
        Me.gbxQuestInfo.Location = New System.Drawing.Point(12, 134)
        Me.gbxQuestInfo.Name = "gbxQuestInfo"
        Me.gbxQuestInfo.Size = New System.Drawing.Size(529, 271)
        Me.gbxQuestInfo.TabIndex = 4
        Me.gbxQuestInfo.TabStop = False
        Me.gbxQuestInfo.Text = "Quest Info"
        '
        'nudSubBZeny
        '
        Me.nudSubBZeny.Enabled = False
        Me.nudSubBZeny.Location = New System.Drawing.Point(414, 175)
        Me.nudSubBZeny.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSubBZeny.Name = "nudSubBZeny"
        Me.nudSubBZeny.Size = New System.Drawing.Size(101, 20)
        Me.nudSubBZeny.TabIndex = 8
        '
        'pboxMap
        '
        Me.pboxMap.Location = New System.Drawing.Point(337, -130)
        Me.pboxMap.Name = "pboxMap"
        Me.pboxMap.Size = New System.Drawing.Size(192, 124)
        Me.pboxMap.TabIndex = 5
        Me.pboxMap.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(402, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Sub B Zeny"
        '
        'nudSubAZeny
        '
        Me.nudSubAZeny.Enabled = False
        Me.nudSubAZeny.Location = New System.Drawing.Point(414, 125)
        Me.nudSubAZeny.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSubAZeny.Name = "nudSubAZeny"
        Me.nudSubAZeny.Size = New System.Drawing.Size(101, 20)
        Me.nudSubAZeny.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(402, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Sub A Zeny"
        '
        'nudMainZeny
        '
        Me.nudMainZeny.Enabled = False
        Me.nudMainZeny.Location = New System.Drawing.Point(414, 77)
        Me.nudMainZeny.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudMainZeny.Name = "nudMainZeny"
        Me.nudMainZeny.Size = New System.Drawing.Size(101, 20)
        Me.nudMainZeny.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Main Zeny"
        '
        'nudQuestFee
        '
        Me.nudQuestFee.Enabled = False
        Me.nudQuestFee.Location = New System.Drawing.Point(414, 33)
        Me.nudQuestFee.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudQuestFee.Name = "nudQuestFee"
        Me.nudQuestFee.Size = New System.Drawing.Size(101, 20)
        Me.nudQuestFee.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(402, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Quest Fee"
        '
        'lbxVariant2b
        '
        Me.lbxVariant2b.Enabled = False
        Me.lbxVariant2b.FormattingEnabled = True
        Me.lbxVariant2b.Location = New System.Drawing.Point(253, 144)
        Me.lbxVariant2b.Name = "lbxVariant2b"
        Me.lbxVariant2b.Size = New System.Drawing.Size(128, 17)
        Me.lbxVariant2b.TabIndex = 6
        '
        'lbxVariant2a
        '
        Me.lbxVariant2a.Enabled = False
        Me.lbxVariant2a.FormattingEnabled = True
        Me.lbxVariant2a.Location = New System.Drawing.Point(253, 107)
        Me.lbxVariant2a.Name = "lbxVariant2a"
        Me.lbxVariant2a.Size = New System.Drawing.Size(128, 17)
        Me.lbxVariant2a.TabIndex = 6
        '
        'lbxVariant1b
        '
        Me.lbxVariant1b.Enabled = False
        Me.lbxVariant1b.FormattingEnabled = True
        Me.lbxVariant1b.Location = New System.Drawing.Point(253, 70)
        Me.lbxVariant1b.Name = "lbxVariant1b"
        Me.lbxVariant1b.Size = New System.Drawing.Size(128, 17)
        Me.lbxVariant1b.TabIndex = 6
        '
        'lbxVariant1a
        '
        Me.lbxVariant1a.Enabled = False
        Me.lbxVariant1a.FormattingEnabled = True
        Me.lbxVariant1a.Location = New System.Drawing.Point(253, 33)
        Me.lbxVariant1a.Name = "lbxVariant1a"
        Me.lbxVariant1a.Size = New System.Drawing.Size(128, 17)
        Me.lbxVariant1a.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(250, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Variant 2B"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(250, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Variant 2A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(250, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Variant 1B"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(250, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Variant 1A"
        '
        'lblMonsterCords
        '
        Me.lblMonsterCords.AutoSize = True
        Me.lblMonsterCords.Location = New System.Drawing.Point(12, 239)
        Me.lblMonsterCords.Name = "lblMonsterCords"
        Me.lblMonsterCords.Size = New System.Drawing.Size(120, 13)
        Me.lblMonsterCords.TabIndex = 4
        Me.lblMonsterCords.Text = "Monster Starting Cords: "
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Location = New System.Drawing.Point(12, 215)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(74, 13)
        Me.lblRank.TabIndex = 4
        Me.lblRank.Text = "Hunter Rank: "
        '
        'nudSubBObjectiveDamage
        '
        Me.nudSubBObjectiveDamage.Enabled = False
        Me.nudSubBObjectiveDamage.Location = New System.Drawing.Point(142, 165)
        Me.nudSubBObjectiveDamage.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSubBObjectiveDamage.Name = "nudSubBObjectiveDamage"
        Me.nudSubBObjectiveDamage.Size = New System.Drawing.Size(80, 20)
        Me.nudSubBObjectiveDamage.TabIndex = 3
        '
        'nudSubAObjectiveDamage
        '
        Me.nudSubAObjectiveDamage.Enabled = False
        Me.nudSubAObjectiveDamage.Location = New System.Drawing.Point(142, 116)
        Me.nudSubAObjectiveDamage.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudSubAObjectiveDamage.Name = "nudSubAObjectiveDamage"
        Me.nudSubAObjectiveDamage.Size = New System.Drawing.Size(80, 20)
        Me.nudSubAObjectiveDamage.TabIndex = 3
        '
        'nudMainObjectiveDamage
        '
        Me.nudMainObjectiveDamage.Enabled = False
        Me.nudMainObjectiveDamage.Location = New System.Drawing.Point(142, 67)
        Me.nudMainObjectiveDamage.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudMainObjectiveDamage.Name = "nudMainObjectiveDamage"
        Me.nudMainObjectiveDamage.Size = New System.Drawing.Size(80, 20)
        Me.nudMainObjectiveDamage.TabIndex = 3
        '
        'lbxSubBObjective
        '
        Me.lbxSubBObjective.Enabled = False
        Me.lbxSubBObjective.FormattingEnabled = True
        Me.lbxSubBObjective.Location = New System.Drawing.Point(28, 165)
        Me.lbxSubBObjective.Name = "lbxSubBObjective"
        Me.lbxSubBObjective.Size = New System.Drawing.Size(110, 30)
        Me.lbxSubBObjective.TabIndex = 2
        '
        'lbxSubAObjective
        '
        Me.lbxSubAObjective.Enabled = False
        Me.lbxSubAObjective.FormattingEnabled = True
        Me.lbxSubAObjective.Location = New System.Drawing.Point(28, 116)
        Me.lbxSubAObjective.Name = "lbxSubAObjective"
        Me.lbxSubAObjective.Size = New System.Drawing.Size(110, 30)
        Me.lbxSubAObjective.TabIndex = 2
        '
        'lbxMainObjective
        '
        Me.lbxMainObjective.Enabled = False
        Me.lbxMainObjective.FormattingEnabled = True
        Me.lbxMainObjective.Location = New System.Drawing.Point(28, 67)
        Me.lbxMainObjective.Name = "lbxMainObjective"
        Me.lbxMainObjective.Size = New System.Drawing.Size(110, 30)
        Me.lbxMainObjective.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "SubB Objective"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(153, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Damage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(153, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Damage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(153, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Damage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "SubA Objective"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Main Objective"
        '
        'lbxLocation
        '
        Me.lbxLocation.Enabled = False
        Me.lbxLocation.FormattingEnabled = True
        Me.lbxLocation.Location = New System.Drawing.Point(28, 31)
        Me.lbxLocation.Name = "lbxLocation"
        Me.lbxLocation.Size = New System.Drawing.Size(194, 17)
        Me.lbxLocation.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 0
        '
        'MapTimer
        '
        Me.MapTimer.Enabled = True
        Me.MapTimer.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MHF_QuestEditor.My.Resources.Resources.Logo_MHFG
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbldebug
        '
        Me.lbldebug.AutoSize = True
        Me.lbldebug.Location = New System.Drawing.Point(251, 416)
        Me.lbldebug.Name = "lbldebug"
        Me.lbldebug.Size = New System.Drawing.Size(39, 13)
        Me.lbldebug.TabIndex = 6
        Me.lbldebug.Text = "Label6"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(349, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 116)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'EditQuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 441)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbldebug)
        Me.Controls.Add(Me.gbxQuestInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLoadQuest)
        Me.Name = "EditQuest"
        Me.Text = "Form1"
        Me.gbxQuestInfo.ResumeLayout(False)
        Me.gbxQuestInfo.PerformLayout()
        CType(Me.nudSubBZeny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubAZeny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMainZeny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuestFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubBObjectiveDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubAObjectiveDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMainObjectiveDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenQuestFile As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnLoadQuest As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxQuestInfo As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbxMainObjective As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudMainObjectiveDamage As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents MapTimer As Timer
    Friend WithEvents lbldebug As Label
    Friend WithEvents lbxSubBObjective As ListBox
    Friend WithEvents lbxSubAObjective As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nudSubBObjectiveDamage As NumericUpDown
    Friend WithEvents nudSubAObjectiveDamage As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbxLocation As ListBox
    Friend WithEvents lblRank As Label
    Friend WithEvents lbxVariant2b As ListBox
    Friend WithEvents lbxVariant2a As ListBox
    Friend WithEvents lbxVariant1b As ListBox
    Friend WithEvents lbxVariant1a As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nudSubBZeny As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents nudSubAZeny As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents nudMainZeny As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents nudQuestFee As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents lblMonsterCords As Label
    Friend WithEvents pboxMap As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
