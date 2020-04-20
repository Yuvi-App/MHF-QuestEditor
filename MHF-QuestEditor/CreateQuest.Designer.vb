<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateQuest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateQuest))
        Me.pboxBack = New System.Windows.Forms.PictureBox()
        Me.pboxNext = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubBMonsterSpawn = New System.Windows.Forms.Button()
        Me.btnSubAMonsterSpawn = New System.Windows.Forms.Button()
        Me.btnMainMonsterSpawn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubBSpawnCoords = New System.Windows.Forms.Label()
        Me.lblSubASpawnCoords = New System.Windows.Forms.Label()
        Me.lblMainSpawnCoords = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudSubBMonsterDamage = New System.Windows.Forms.NumericUpDown()
        Me.nudSubAMonsterDamage = New System.Windows.Forms.NumericUpDown()
        Me.nudMainMonsterDamage = New System.Windows.Forms.NumericUpDown()
        Me.btnChooseSubBMonster = New System.Windows.Forms.Button()
        Me.btnChooseSubAMonster = New System.Windows.Forms.Button()
        Me.btnChooseMonster = New System.Windows.Forms.Button()
        Me.btnChooseLocation = New System.Windows.Forms.Button()
        Me.lbxSubBObj = New System.Windows.Forms.ListBox()
        Me.lbxSubAObj = New System.Windows.Forms.ListBox()
        Me.lbxMainObj = New System.Windows.Forms.ListBox()
        Me.txtSubBMonster = New System.Windows.Forms.TextBox()
        Me.txtSubAMonster = New System.Windows.Forms.TextBox()
        Me.txtMainMonster = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudQuestFee = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nudMainReward = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudSubAReward = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nudSubBReward = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.rtfQuestDescription = New System.Windows.Forms.RichTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NudHunterRank = New System.Windows.Forms.NumericUpDown()
        Me.cbxHunterRank = New System.Windows.Forms.ComboBox()
        CType(Me.pboxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudSubBMonsterDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubAMonsterDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMainMonsterDamage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuestFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMainReward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubAReward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSubBReward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudHunterRank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboxBack
        '
        Me.pboxBack.BackColor = System.Drawing.Color.Transparent
        Me.pboxBack.BackgroundImage = CType(resources.GetObject("pboxBack.BackgroundImage"), System.Drawing.Image)
        Me.pboxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pboxBack.Location = New System.Drawing.Point(64, 730)
        Me.pboxBack.Name = "pboxBack"
        Me.pboxBack.Size = New System.Drawing.Size(27, 38)
        Me.pboxBack.TabIndex = 5
        Me.pboxBack.TabStop = False
        '
        'pboxNext
        '
        Me.pboxNext.BackColor = System.Drawing.Color.Transparent
        Me.pboxNext.BackgroundImage = CType(resources.GetObject("pboxNext.BackgroundImage"), System.Drawing.Image)
        Me.pboxNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pboxNext.Location = New System.Drawing.Point(897, 730)
        Me.pboxNext.Name = "pboxNext"
        Me.pboxNext.Size = New System.Drawing.Size(27, 38)
        Me.pboxNext.TabIndex = 5
        Me.pboxNext.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 714)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Back"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(895, 714)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Next"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Location"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbxHunterRank)
        Me.GroupBox1.Controls.Add(Me.rtfQuestDescription)
        Me.GroupBox1.Controls.Add(Me.btnSubBMonsterSpawn)
        Me.GroupBox1.Controls.Add(Me.btnSubAMonsterSpawn)
        Me.GroupBox1.Controls.Add(Me.btnMainMonsterSpawn)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblSubBSpawnCoords)
        Me.GroupBox1.Controls.Add(Me.lblSubASpawnCoords)
        Me.GroupBox1.Controls.Add(Me.lblMainSpawnCoords)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.nudSubBMonsterDamage)
        Me.GroupBox1.Controls.Add(Me.nudSubAMonsterDamage)
        Me.GroupBox1.Controls.Add(Me.nudSubBReward)
        Me.GroupBox1.Controls.Add(Me.nudSubAReward)
        Me.GroupBox1.Controls.Add(Me.nudMainReward)
        Me.GroupBox1.Controls.Add(Me.NudHunterRank)
        Me.GroupBox1.Controls.Add(Me.nudQuestFee)
        Me.GroupBox1.Controls.Add(Me.nudMainMonsterDamage)
        Me.GroupBox1.Controls.Add(Me.btnChooseSubBMonster)
        Me.GroupBox1.Controls.Add(Me.btnChooseSubAMonster)
        Me.GroupBox1.Controls.Add(Me.btnChooseMonster)
        Me.GroupBox1.Controls.Add(Me.btnChooseLocation)
        Me.GroupBox1.Controls.Add(Me.lbxSubBObj)
        Me.GroupBox1.Controls.Add(Me.lbxSubAObj)
        Me.GroupBox1.Controls.Add(Me.lbxMainObj)
        Me.GroupBox1.Controls.Add(Me.txtSubBMonster)
        Me.GroupBox1.Controls.Add(Me.txtSubAMonster)
        Me.GroupBox1.Controls.Add(Me.txtMainMonster)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(67, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 521)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quest Information"
        '
        'btnSubBMonsterSpawn
        '
        Me.btnSubBMonsterSpawn.Enabled = False
        Me.btnSubBMonsterSpawn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubBMonsterSpawn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSubBMonsterSpawn.Location = New System.Drawing.Point(293, 431)
        Me.btnSubBMonsterSpawn.Name = "btnSubBMonsterSpawn"
        Me.btnSubBMonsterSpawn.Size = New System.Drawing.Size(84, 44)
        Me.btnSubBMonsterSpawn.TabIndex = 14
        Me.btnSubBMonsterSpawn.Text = "Choose Spawn"
        Me.btnSubBMonsterSpawn.UseVisualStyleBackColor = True
        '
        'btnSubAMonsterSpawn
        '
        Me.btnSubAMonsterSpawn.Enabled = False
        Me.btnSubAMonsterSpawn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubAMonsterSpawn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSubAMonsterSpawn.Location = New System.Drawing.Point(293, 303)
        Me.btnSubAMonsterSpawn.Name = "btnSubAMonsterSpawn"
        Me.btnSubAMonsterSpawn.Size = New System.Drawing.Size(84, 44)
        Me.btnSubAMonsterSpawn.TabIndex = 14
        Me.btnSubAMonsterSpawn.Text = "Choose Spawn"
        Me.btnSubAMonsterSpawn.UseVisualStyleBackColor = True
        '
        'btnMainMonsterSpawn
        '
        Me.btnMainMonsterSpawn.Enabled = False
        Me.btnMainMonsterSpawn.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMonsterSpawn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnMainMonsterSpawn.Location = New System.Drawing.Point(293, 174)
        Me.btnMainMonsterSpawn.Name = "btnMainMonsterSpawn"
        Me.btnMainMonsterSpawn.Size = New System.Drawing.Size(84, 44)
        Me.btnMainMonsterSpawn.TabIndex = 14
        Me.btnMainMonsterSpawn.Text = "Choose Spawn"
        Me.btnMainMonsterSpawn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Required Damage -"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(61, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 44)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Choose Spawn for Monster or else its Random"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(61, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 44)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Choose Spawn for Monster or else its Random"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Required Damage -"
        '
        'lblSubBSpawnCoords
        '
        Me.lblSubBSpawnCoords.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubBSpawnCoords.Location = New System.Drawing.Point(382, 431)
        Me.lblSubBSpawnCoords.Name = "lblSubBSpawnCoords"
        Me.lblSubBSpawnCoords.Size = New System.Drawing.Size(57, 44)
        Me.lblSubBSpawnCoords.TabIndex = 13
        Me.lblSubBSpawnCoords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubASpawnCoords
        '
        Me.lblSubASpawnCoords.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubASpawnCoords.Location = New System.Drawing.Point(382, 303)
        Me.lblSubASpawnCoords.Name = "lblSubASpawnCoords"
        Me.lblSubASpawnCoords.Size = New System.Drawing.Size(57, 44)
        Me.lblSubASpawnCoords.TabIndex = 13
        Me.lblSubASpawnCoords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMainSpawnCoords
        '
        Me.lblMainSpawnCoords.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainSpawnCoords.Location = New System.Drawing.Point(382, 174)
        Me.lblMainSpawnCoords.Name = "lblMainSpawnCoords"
        Me.lblMainSpawnCoords.Size = New System.Drawing.Size(57, 44)
        Me.lblMainSpawnCoords.TabIndex = 13
        Me.lblMainSpawnCoords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 44)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Choose Spawn for Monster or else its Random"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Required Damage -"
        '
        'nudSubBMonsterDamage
        '
        Me.nudSubBMonsterDamage.Enabled = False
        Me.nudSubBMonsterDamage.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSubBMonsterDamage.Location = New System.Drawing.Point(192, 404)
        Me.nudSubBMonsterDamage.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudSubBMonsterDamage.Name = "nudSubBMonsterDamage"
        Me.nudSubBMonsterDamage.Size = New System.Drawing.Size(186, 24)
        Me.nudSubBMonsterDamage.TabIndex = 12
        '
        'nudSubAMonsterDamage
        '
        Me.nudSubAMonsterDamage.Enabled = False
        Me.nudSubAMonsterDamage.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSubAMonsterDamage.Location = New System.Drawing.Point(191, 276)
        Me.nudSubAMonsterDamage.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudSubAMonsterDamage.Name = "nudSubAMonsterDamage"
        Me.nudSubAMonsterDamage.Size = New System.Drawing.Size(186, 24)
        Me.nudSubAMonsterDamage.TabIndex = 12
        '
        'nudMainMonsterDamage
        '
        Me.nudMainMonsterDamage.Enabled = False
        Me.nudMainMonsterDamage.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMainMonsterDamage.Location = New System.Drawing.Point(191, 147)
        Me.nudMainMonsterDamage.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudMainMonsterDamage.Name = "nudMainMonsterDamage"
        Me.nudMainMonsterDamage.Size = New System.Drawing.Size(186, 24)
        Me.nudMainMonsterDamage.TabIndex = 12
        '
        'btnChooseSubBMonster
        '
        Me.btnChooseSubBMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSubBMonster.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnChooseSubBMonster.Location = New System.Drawing.Point(384, 374)
        Me.btnChooseSubBMonster.Name = "btnChooseSubBMonster"
        Me.btnChooseSubBMonster.Size = New System.Drawing.Size(56, 24)
        Me.btnChooseSubBMonster.TabIndex = 11
        Me.btnChooseSubBMonster.Text = "Choose"
        Me.btnChooseSubBMonster.UseVisualStyleBackColor = True
        '
        'btnChooseSubAMonster
        '
        Me.btnChooseSubAMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSubAMonster.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnChooseSubAMonster.Location = New System.Drawing.Point(383, 246)
        Me.btnChooseSubAMonster.Name = "btnChooseSubAMonster"
        Me.btnChooseSubAMonster.Size = New System.Drawing.Size(56, 24)
        Me.btnChooseSubAMonster.TabIndex = 11
        Me.btnChooseSubAMonster.Text = "Choose"
        Me.btnChooseSubAMonster.UseVisualStyleBackColor = True
        '
        'btnChooseMonster
        '
        Me.btnChooseMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseMonster.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnChooseMonster.Location = New System.Drawing.Point(383, 116)
        Me.btnChooseMonster.Name = "btnChooseMonster"
        Me.btnChooseMonster.Size = New System.Drawing.Size(56, 24)
        Me.btnChooseMonster.TabIndex = 11
        Me.btnChooseMonster.Text = "Choose"
        Me.btnChooseMonster.UseVisualStyleBackColor = True
        '
        'btnChooseLocation
        '
        Me.btnChooseLocation.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnChooseLocation.Location = New System.Drawing.Point(258, 57)
        Me.btnChooseLocation.Name = "btnChooseLocation"
        Me.btnChooseLocation.Size = New System.Drawing.Size(56, 24)
        Me.btnChooseLocation.TabIndex = 11
        Me.btnChooseLocation.Text = "Choose"
        Me.btnChooseLocation.UseVisualStyleBackColor = True
        '
        'lbxSubBObj
        '
        Me.lbxSubBObj.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxSubBObj.FormattingEnabled = True
        Me.lbxSubBObj.ItemHeight = 19
        Me.lbxSubBObj.Items.AddRange(New Object() {"Hunt", "Slay", "Damage", "Slay or Damage", "Capture", "Break Part", "Slay All"})
        Me.lbxSubBObj.Location = New System.Drawing.Point(27, 374)
        Me.lbxSubBObj.Name = "lbxSubBObj"
        Me.lbxSubBObj.Size = New System.Drawing.Size(159, 23)
        Me.lbxSubBObj.TabIndex = 10
        '
        'lbxSubAObj
        '
        Me.lbxSubAObj.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxSubAObj.FormattingEnabled = True
        Me.lbxSubAObj.ItemHeight = 19
        Me.lbxSubAObj.Items.AddRange(New Object() {"Hunt", "Slay", "Damage", "Slay or Damage", "Capture", "Break Part", "Slay All"})
        Me.lbxSubAObj.Location = New System.Drawing.Point(26, 246)
        Me.lbxSubAObj.Name = "lbxSubAObj"
        Me.lbxSubAObj.Size = New System.Drawing.Size(159, 23)
        Me.lbxSubAObj.TabIndex = 10
        '
        'lbxMainObj
        '
        Me.lbxMainObj.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMainObj.FormattingEnabled = True
        Me.lbxMainObj.ItemHeight = 19
        Me.lbxMainObj.Items.AddRange(New Object() {"Hunt", "Slay", "Damage", "Slay or Damage", "Capture", "Break Part", "Slay All"})
        Me.lbxMainObj.Location = New System.Drawing.Point(26, 116)
        Me.lbxMainObj.Name = "lbxMainObj"
        Me.lbxMainObj.Size = New System.Drawing.Size(159, 23)
        Me.lbxMainObj.TabIndex = 10
        '
        'txtSubBMonster
        '
        Me.txtSubBMonster.Enabled = False
        Me.txtSubBMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubBMonster.Location = New System.Drawing.Point(192, 374)
        Me.txtSubBMonster.Name = "txtSubBMonster"
        Me.txtSubBMonster.Size = New System.Drawing.Size(186, 24)
        Me.txtSubBMonster.TabIndex = 9
        Me.txtSubBMonster.Text = "Monster Name"
        Me.txtSubBMonster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubAMonster
        '
        Me.txtSubAMonster.Enabled = False
        Me.txtSubAMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubAMonster.Location = New System.Drawing.Point(191, 246)
        Me.txtSubAMonster.Name = "txtSubAMonster"
        Me.txtSubAMonster.Size = New System.Drawing.Size(186, 24)
        Me.txtSubAMonster.TabIndex = 9
        Me.txtSubAMonster.Text = "Monster Name"
        Me.txtSubAMonster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMainMonster
        '
        Me.txtMainMonster.Enabled = False
        Me.txtMainMonster.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainMonster.Location = New System.Drawing.Point(191, 116)
        Me.txtMainMonster.Name = "txtMainMonster"
        Me.txtMainMonster.Size = New System.Drawing.Size(186, 24)
        Me.txtMainMonster.TabIndex = 9
        Me.txtMainMonster.Text = "Monster Name"
        Me.txtMainMonster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Sub B Objective"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sub A Objective"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Main Objective"
        '
        'txtLocation
        '
        Me.txtLocation.Enabled = False
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(27, 57)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(225, 24)
        Me.txtLocation.TabIndex = 9
        Me.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(451, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 21)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Quest Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(471, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 24)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(746, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 21)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Fee"
        '
        'nudQuestFee
        '
        Me.nudQuestFee.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuestFee.Location = New System.Drawing.Point(766, 107)
        Me.nudQuestFee.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudQuestFee.Name = "nudQuestFee"
        Me.nudQuestFee.Size = New System.Drawing.Size(86, 24)
        Me.nudQuestFee.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(467, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 21)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Main"
        '
        'nudMainReward
        '
        Me.nudMainReward.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMainReward.Location = New System.Drawing.Point(471, 194)
        Me.nudMainReward.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudMainReward.Name = "nudMainReward"
        Me.nudMainReward.Size = New System.Drawing.Size(70, 24)
        Me.nudMainReward.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(621, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 21)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Sub A"
        '
        'nudSubAReward
        '
        Me.nudSubAReward.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSubAReward.Location = New System.Drawing.Point(625, 194)
        Me.nudSubAReward.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudSubAReward.Name = "nudSubAReward"
        Me.nudSubAReward.Size = New System.Drawing.Size(71, 24)
        Me.nudSubAReward.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(777, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 21)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Sub B"
        '
        'nudSubBReward
        '
        Me.nudSubBReward.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSubBReward.Location = New System.Drawing.Point(781, 194)
        Me.nudSubBReward.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudSubBReward.Name = "nudSubBReward"
        Me.nudSubBReward.Size = New System.Drawing.Size(70, 24)
        Me.nudSubBReward.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(451, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 21)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Rewards in Zeny"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(451, 248)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 21)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Quest Description"
        '
        'rtfQuestDescription
        '
        Me.rtfQuestDescription.Location = New System.Drawing.Point(471, 273)
        Me.rtfQuestDescription.Name = "rtfQuestDescription"
        Me.rtfQuestDescription.Size = New System.Drawing.Size(379, 201)
        Me.rtfQuestDescription.TabIndex = 15
        Me.rtfQuestDescription.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(451, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 21)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Hunter Rank"
        '
        'NudHunterRank
        '
        Me.NudHunterRank.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudHunterRank.Location = New System.Drawing.Point(471, 107)
        Me.NudHunterRank.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NudHunterRank.Name = "NudHunterRank"
        Me.NudHunterRank.Size = New System.Drawing.Size(86, 24)
        Me.NudHunterRank.TabIndex = 12
        '
        'cbxHunterRank
        '
        Me.cbxHunterRank.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHunterRank.FormattingEnabled = True
        Me.cbxHunterRank.Items.AddRange(New Object() {"None", "G", "Z"})
        Me.cbxHunterRank.Location = New System.Drawing.Point(563, 106)
        Me.cbxHunterRank.Name = "cbxHunterRank"
        Me.cbxHunterRank.Size = New System.Drawing.Size(75, 27)
        Me.cbxHunterRank.TabIndex = 16
        '
        'CreateQuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MHF_QuestEditor.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 846)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pboxNext)
        Me.Controls.Add(Me.pboxBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateQuest"
        Me.Text = "CreateQuest"
        CType(Me.pboxBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudSubBMonsterDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubAMonsterDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMainMonsterDamage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuestFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMainReward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubAReward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSubBReward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudHunterRank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxBack As PictureBox
    Friend WithEvents pboxNext As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMainMonster As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents btnChooseMonster As Button
    Friend WithEvents btnChooseLocation As Button
    Friend WithEvents lbxMainObj As ListBox
    Friend WithEvents btnChooseSubAMonster As Button
    Friend WithEvents lbxSubAObj As ListBox
    Friend WithEvents txtSubAMonster As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnChooseSubBMonster As Button
    Friend WithEvents lbxSubBObj As ListBox
    Friend WithEvents txtSubBMonster As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nudSubBMonsterDamage As NumericUpDown
    Friend WithEvents nudSubAMonsterDamage As NumericUpDown
    Friend WithEvents nudMainMonsterDamage As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnMainMonsterSpawn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubBMonsterSpawn As Button
    Friend WithEvents btnSubAMonsterSpawn As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblSubBSpawnCoords As Label
    Friend WithEvents lblSubASpawnCoords As Label
    Friend WithEvents lblMainSpawnCoords As Label
    Friend WithEvents nudSubBReward As NumericUpDown
    Friend WithEvents nudSubAReward As NumericUpDown
    Friend WithEvents nudMainReward As NumericUpDown
    Friend WithEvents nudQuestFee As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rtfQuestDescription As RichTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents NudHunterRank As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxHunterRank As ComboBox
End Class
