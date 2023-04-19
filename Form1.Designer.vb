<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.comboMap = New System.Windows.Forms.ComboBox()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.lblBots = New System.Windows.Forms.Label()
        Me.comboBots = New System.Windows.Forms.ComboBox()
        Me.lblSkill = New System.Windows.Forms.Label()
        Me.comboSkillLevel = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.comboTime = New System.Windows.Forms.ComboBox()
        Me.lblScoreLimit = New System.Windows.Forms.Label()
        Me.comboScoreLimit = New System.Windows.Forms.ComboBox()
        Me.lblShowOptions = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblDMType = New System.Windows.Forms.Label()
        Me.comboDMType = New System.Windows.Forms.ComboBox()
        Me.comboTeam = New System.Windows.Forms.ComboBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblAdditonalOps = New System.Windows.Forms.Label()
        Me.lblKillCam = New System.Windows.Forms.Label()
        Me.rbtnKillCamOn = New System.Windows.Forms.RadioButton()
        Me.rbtnKillCamOff = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGrenades = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnGrenadesOff = New System.Windows.Forms.RadioButton()
        Me.rbtnGrenadesOn = New System.Windows.Forms.RadioButton()
        Me.lblHideOptions = New System.Windows.Forms.Label()
        Me.lblSPawnProt = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtnSpawnProtOff = New System.Windows.Forms.RadioButton()
        Me.rbtnSpawnProtOn = New System.Windows.Forms.RadioButton()
        Me.lblCamping = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtnCampingOff = New System.Windows.Forms.RadioButton()
        Me.rbtnCampingOn = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbtnJumpShotOff = New System.Windows.Forms.RadioButton()
        Me.rbtnJumpShotOn = New System.Windows.Forms.RadioButton()
        Me.lblJumpShot = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtnRespawnOff = New System.Windows.Forms.RadioButton()
        Me.rbtnRespawnOn = New System.Windows.Forms.RadioButton()
        Me.lblRespawn = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbtnSuicideOff = New System.Windows.Forms.RadioButton()
        Me.rbtnSuicideOn = New System.Windows.Forms.RadioButton()
        Me.lblSuicide = New System.Windows.Forms.Label()
        Me.lblDeathmatch = New System.Windows.Forms.Label()
        Me.lblLauncher = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboMap
        '
        Me.comboMap.FormattingEnabled = True
        Me.comboMap.Location = New System.Drawing.Point(26, 149)
        Me.comboMap.Name = "comboMap"
        Me.comboMap.Size = New System.Drawing.Size(265, 24)
        Me.comboMap.TabIndex = 0
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.BackColor = System.Drawing.Color.Transparent
        Me.lblMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.Location = New System.Drawing.Point(26, 119)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(121, 25)
        Me.lblMap.TabIndex = 1
        Me.lblMap.Text = "Select Map"
        '
        'lblBots
        '
        Me.lblBots.AutoSize = True
        Me.lblBots.BackColor = System.Drawing.Color.Transparent
        Me.lblBots.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBots.Location = New System.Drawing.Point(26, 296)
        Me.lblBots.Name = "lblBots"
        Me.lblBots.Size = New System.Drawing.Size(227, 25)
        Me.lblBots.TabIndex = 2
        Me.lblBots.Text = "Select Number of Bots"
        Me.lblBots.Visible = False
        '
        'comboBots
        '
        Me.comboBots.FormattingEnabled = True
        Me.comboBots.Location = New System.Drawing.Point(26, 326)
        Me.comboBots.Name = "comboBots"
        Me.comboBots.Size = New System.Drawing.Size(67, 24)
        Me.comboBots.TabIndex = 3
        Me.comboBots.Visible = False
        '
        'lblSkill
        '
        Me.lblSkill.AutoSize = True
        Me.lblSkill.BackColor = System.Drawing.Color.Transparent
        Me.lblSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkill.Location = New System.Drawing.Point(26, 355)
        Me.lblSkill.Name = "lblSkill"
        Me.lblSkill.Size = New System.Drawing.Size(188, 25)
        Me.lblSkill.TabIndex = 4
        Me.lblSkill.Text = "Set Bot Skill Level"
        Me.lblSkill.Visible = False
        '
        'comboSkillLevel
        '
        Me.comboSkillLevel.FormattingEnabled = True
        Me.comboSkillLevel.Location = New System.Drawing.Point(26, 385)
        Me.comboSkillLevel.Name = "comboSkillLevel"
        Me.comboSkillLevel.Size = New System.Drawing.Size(67, 24)
        Me.comboSkillLevel.TabIndex = 5
        Me.comboSkillLevel.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(26, 414)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(150, 25)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Set Time Limit"
        Me.lblTime.UseMnemonic = False
        Me.lblTime.Visible = False
        '
        'comboTime
        '
        Me.comboTime.FormattingEnabled = True
        Me.comboTime.Location = New System.Drawing.Point(26, 444)
        Me.comboTime.Name = "comboTime"
        Me.comboTime.Size = New System.Drawing.Size(73, 24)
        Me.comboTime.TabIndex = 7
        Me.comboTime.Visible = False
        '
        'lblScoreLimit
        '
        Me.lblScoreLimit.AutoSize = True
        Me.lblScoreLimit.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreLimit.Location = New System.Drawing.Point(26, 473)
        Me.lblScoreLimit.Name = "lblScoreLimit"
        Me.lblScoreLimit.Size = New System.Drawing.Size(159, 25)
        Me.lblScoreLimit.TabIndex = 8
        Me.lblScoreLimit.Text = "Set Score Limit"
        Me.lblScoreLimit.UseMnemonic = False
        Me.lblScoreLimit.Visible = False
        '
        'comboScoreLimit
        '
        Me.comboScoreLimit.FormattingEnabled = True
        Me.comboScoreLimit.Location = New System.Drawing.Point(26, 503)
        Me.comboScoreLimit.Name = "comboScoreLimit"
        Me.comboScoreLimit.Size = New System.Drawing.Size(69, 24)
        Me.comboScoreLimit.TabIndex = 9
        Me.comboScoreLimit.Visible = False
        '
        'lblShowOptions
        '
        Me.lblShowOptions.AutoSize = True
        Me.lblShowOptions.BackColor = System.Drawing.Color.Transparent
        Me.lblShowOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowOptions.Location = New System.Drawing.Point(757, 136)
        Me.lblShowOptions.Name = "lblShowOptions"
        Me.lblShowOptions.Size = New System.Drawing.Size(163, 20)
        Me.lblShowOptions.TabIndex = 10
        Me.lblShowOptions.Text = "Additional Options"
        Me.lblShowOptions.UseMnemonic = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(310, 91)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "PeZBot"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Location = New System.Drawing.Point(29, 548)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(187, 36)
        Me.btnStart.TabIndex = 14
        Me.btnStart.Text = "Launch Game"
        Me.btnStart.UseVisualStyleBackColor = False
        Me.btnStart.Visible = False
        '
        'lblDMType
        '
        Me.lblDMType.AutoSize = True
        Me.lblDMType.BackColor = System.Drawing.Color.Transparent
        Me.lblDMType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDMType.Location = New System.Drawing.Point(26, 178)
        Me.lblDMType.Name = "lblDMType"
        Me.lblDMType.Size = New System.Drawing.Size(167, 25)
        Me.lblDMType.TabIndex = 15
        Me.lblDMType.Text = "Select DM Type"
        Me.lblDMType.Visible = False
        '
        'comboDMType
        '
        Me.comboDMType.FormattingEnabled = True
        Me.comboDMType.Items.AddRange(New Object() {"Free for All", "Team Deathmatch"})
        Me.comboDMType.Location = New System.Drawing.Point(26, 208)
        Me.comboDMType.Name = "comboDMType"
        Me.comboDMType.Size = New System.Drawing.Size(158, 24)
        Me.comboDMType.TabIndex = 16
        Me.comboDMType.Visible = False
        '
        'comboTeam
        '
        Me.comboTeam.FormattingEnabled = True
        Me.comboTeam.Items.AddRange(New Object() {"Imperial Forces", "Rebel Alliance", "Auto Assign"})
        Me.comboTeam.Location = New System.Drawing.Point(26, 267)
        Me.comboTeam.Name = "comboTeam"
        Me.comboTeam.Size = New System.Drawing.Size(159, 24)
        Me.comboTeam.TabIndex = 17
        Me.comboTeam.Visible = False
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(26, 237)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(201, 25)
        Me.lblTeam.TabIndex = 18
        Me.lblTeam.Text = "Bot Team Selection"
        Me.lblTeam.Visible = False
        '
        'lblAdditonalOps
        '
        Me.lblAdditonalOps.AutoSize = True
        Me.lblAdditonalOps.BackColor = System.Drawing.Color.Transparent
        Me.lblAdditonalOps.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditonalOps.Location = New System.Drawing.Point(586, 177)
        Me.lblAdditonalOps.Name = "lblAdditonalOps"
        Me.lblAdditonalOps.Size = New System.Drawing.Size(348, 44)
        Me.lblAdditonalOps.TabIndex = 19
        Me.lblAdditonalOps.Text = "Additional Options"
        Me.lblAdditonalOps.Visible = False
        '
        'lblKillCam
        '
        Me.lblKillCam.BackColor = System.Drawing.Color.Transparent
        Me.lblKillCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKillCam.Location = New System.Drawing.Point(501, 235)
        Me.lblKillCam.Name = "lblKillCam"
        Me.lblKillCam.Size = New System.Drawing.Size(289, 25)
        Me.lblKillCam.TabIndex = 20
        Me.lblKillCam.Text = "Kill Cam"
        Me.lblKillCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblKillCam.Visible = False
        '
        'rbtnKillCamOn
        '
        Me.rbtnKillCamOn.AutoSize = True
        Me.rbtnKillCamOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnKillCamOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnKillCamOn.Name = "rbtnKillCamOn"
        Me.rbtnKillCamOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnKillCamOn.TabIndex = 21
        Me.rbtnKillCamOn.Text = "On"
        Me.rbtnKillCamOn.UseVisualStyleBackColor = False
        Me.rbtnKillCamOn.Visible = False
        '
        'rbtnKillCamOff
        '
        Me.rbtnKillCamOff.AutoSize = True
        Me.rbtnKillCamOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnKillCamOff.Checked = True
        Me.rbtnKillCamOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnKillCamOff.Name = "rbtnKillCamOff"
        Me.rbtnKillCamOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnKillCamOff.TabIndex = 22
        Me.rbtnKillCamOff.TabStop = True
        Me.rbtnKillCamOff.Text = "Off"
        Me.rbtnKillCamOff.UseVisualStyleBackColor = False
        Me.rbtnKillCamOff.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtnKillCamOff)
        Me.GroupBox1.Controls.Add(Me.rbtnKillCamOn)
        Me.GroupBox1.Location = New System.Drawing.Point(792, 229)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'lblGrenades
        '
        Me.lblGrenades.BackColor = System.Drawing.Color.Transparent
        Me.lblGrenades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrenades.Location = New System.Drawing.Point(501, 269)
        Me.lblGrenades.Name = "lblGrenades"
        Me.lblGrenades.Size = New System.Drawing.Size(289, 25)
        Me.lblGrenades.TabIndex = 25
        Me.lblGrenades.Text = "Bots Drop Grenades/RPG"
        Me.lblGrenades.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGrenades.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbtnGrenadesOff)
        Me.GroupBox2.Controls.Add(Me.rbtnGrenadesOn)
        Me.GroupBox2.Location = New System.Drawing.Point(792, 263)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'rbtnGrenadesOff
        '
        Me.rbtnGrenadesOff.AutoSize = True
        Me.rbtnGrenadesOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnGrenadesOff.Checked = True
        Me.rbtnGrenadesOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnGrenadesOff.Name = "rbtnGrenadesOff"
        Me.rbtnGrenadesOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnGrenadesOff.TabIndex = 22
        Me.rbtnGrenadesOff.TabStop = True
        Me.rbtnGrenadesOff.Text = "Off"
        Me.rbtnGrenadesOff.UseVisualStyleBackColor = False
        Me.rbtnGrenadesOff.Visible = False
        '
        'rbtnGrenadesOn
        '
        Me.rbtnGrenadesOn.AutoSize = True
        Me.rbtnGrenadesOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnGrenadesOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnGrenadesOn.Name = "rbtnGrenadesOn"
        Me.rbtnGrenadesOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnGrenadesOn.TabIndex = 21
        Me.rbtnGrenadesOn.Text = "On"
        Me.rbtnGrenadesOn.UseVisualStyleBackColor = False
        Me.rbtnGrenadesOn.Visible = False
        '
        'lblHideOptions
        '
        Me.lblHideOptions.AutoSize = True
        Me.lblHideOptions.BackColor = System.Drawing.Color.Transparent
        Me.lblHideOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHideOptions.Location = New System.Drawing.Point(706, 136)
        Me.lblHideOptions.Name = "lblHideOptions"
        Me.lblHideOptions.Size = New System.Drawing.Size(208, 20)
        Me.lblHideOptions.TabIndex = 27
        Me.lblHideOptions.Text = "Hide Additional Options"
        Me.lblHideOptions.UseMnemonic = False
        Me.lblHideOptions.Visible = False
        '
        'lblSPawnProt
        '
        Me.lblSPawnProt.BackColor = System.Drawing.Color.Transparent
        Me.lblSPawnProt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSPawnProt.Location = New System.Drawing.Point(501, 303)
        Me.lblSPawnProt.Name = "lblSPawnProt"
        Me.lblSPawnProt.Size = New System.Drawing.Size(289, 25)
        Me.lblSPawnProt.TabIndex = 28
        Me.lblSPawnProt.Text = "Spawn Protection 3 secs"
        Me.lblSPawnProt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSPawnProt.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rbtnSpawnProtOff)
        Me.GroupBox3.Controls.Add(Me.rbtnSpawnProtOn)
        Me.GroupBox3.Location = New System.Drawing.Point(792, 297)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'rbtnSpawnProtOff
        '
        Me.rbtnSpawnProtOff.AutoSize = True
        Me.rbtnSpawnProtOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnSpawnProtOff.Checked = True
        Me.rbtnSpawnProtOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnSpawnProtOff.Name = "rbtnSpawnProtOff"
        Me.rbtnSpawnProtOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnSpawnProtOff.TabIndex = 22
        Me.rbtnSpawnProtOff.TabStop = True
        Me.rbtnSpawnProtOff.Text = "Off"
        Me.rbtnSpawnProtOff.UseVisualStyleBackColor = False
        Me.rbtnSpawnProtOff.Visible = False
        '
        'rbtnSpawnProtOn
        '
        Me.rbtnSpawnProtOn.AutoSize = True
        Me.rbtnSpawnProtOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnSpawnProtOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnSpawnProtOn.Name = "rbtnSpawnProtOn"
        Me.rbtnSpawnProtOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnSpawnProtOn.TabIndex = 21
        Me.rbtnSpawnProtOn.Text = "On"
        Me.rbtnSpawnProtOn.UseVisualStyleBackColor = False
        Me.rbtnSpawnProtOn.Visible = False
        '
        'lblCamping
        '
        Me.lblCamping.BackColor = System.Drawing.Color.Transparent
        Me.lblCamping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamping.Location = New System.Drawing.Point(501, 337)
        Me.lblCamping.Name = "lblCamping"
        Me.lblCamping.Size = New System.Drawing.Size(289, 25)
        Me.lblCamping.TabIndex = 29
        Me.lblCamping.Text = "Anti Camping"
        Me.lblCamping.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCamping.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rbtnCampingOff)
        Me.GroupBox4.Controls.Add(Me.rbtnCampingOn)
        Me.GroupBox4.Location = New System.Drawing.Point(792, 331)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'rbtnCampingOff
        '
        Me.rbtnCampingOff.AutoSize = True
        Me.rbtnCampingOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnCampingOff.Checked = True
        Me.rbtnCampingOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnCampingOff.Name = "rbtnCampingOff"
        Me.rbtnCampingOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnCampingOff.TabIndex = 22
        Me.rbtnCampingOff.TabStop = True
        Me.rbtnCampingOff.Text = "Off"
        Me.rbtnCampingOff.UseVisualStyleBackColor = False
        Me.rbtnCampingOff.Visible = False
        '
        'rbtnCampingOn
        '
        Me.rbtnCampingOn.AutoSize = True
        Me.rbtnCampingOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnCampingOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnCampingOn.Name = "rbtnCampingOn"
        Me.rbtnCampingOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnCampingOn.TabIndex = 21
        Me.rbtnCampingOn.Text = "On"
        Me.rbtnCampingOn.UseVisualStyleBackColor = False
        Me.rbtnCampingOn.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rbtnJumpShotOff)
        Me.GroupBox5.Controls.Add(Me.rbtnJumpShotOn)
        Me.GroupBox5.Location = New System.Drawing.Point(792, 365)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox5.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'rbtnJumpShotOff
        '
        Me.rbtnJumpShotOff.AutoSize = True
        Me.rbtnJumpShotOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnJumpShotOff.Checked = True
        Me.rbtnJumpShotOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnJumpShotOff.Name = "rbtnJumpShotOff"
        Me.rbtnJumpShotOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnJumpShotOff.TabIndex = 22
        Me.rbtnJumpShotOff.TabStop = True
        Me.rbtnJumpShotOff.Text = "Off"
        Me.rbtnJumpShotOff.UseVisualStyleBackColor = False
        Me.rbtnJumpShotOff.Visible = False
        '
        'rbtnJumpShotOn
        '
        Me.rbtnJumpShotOn.AutoSize = True
        Me.rbtnJumpShotOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnJumpShotOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnJumpShotOn.Name = "rbtnJumpShotOn"
        Me.rbtnJumpShotOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnJumpShotOn.TabIndex = 21
        Me.rbtnJumpShotOn.Text = "On"
        Me.rbtnJumpShotOn.UseVisualStyleBackColor = False
        Me.rbtnJumpShotOn.Visible = False
        '
        'lblJumpShot
        '
        Me.lblJumpShot.BackColor = System.Drawing.Color.Transparent
        Me.lblJumpShot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumpShot.Location = New System.Drawing.Point(501, 371)
        Me.lblJumpShot.Name = "lblJumpShot"
        Me.lblJumpShot.Size = New System.Drawing.Size(289, 25)
        Me.lblJumpShot.TabIndex = 31
        Me.lblJumpShot.Text = "Disable Jump Shot"
        Me.lblJumpShot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblJumpShot.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.rbtnRespawnOff)
        Me.GroupBox6.Controls.Add(Me.rbtnRespawnOn)
        Me.GroupBox6.Location = New System.Drawing.Point(792, 433)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'rbtnRespawnOff
        '
        Me.rbtnRespawnOff.AutoSize = True
        Me.rbtnRespawnOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnRespawnOff.Checked = True
        Me.rbtnRespawnOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnRespawnOff.Name = "rbtnRespawnOff"
        Me.rbtnRespawnOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnRespawnOff.TabIndex = 22
        Me.rbtnRespawnOff.TabStop = True
        Me.rbtnRespawnOff.Text = "Off"
        Me.rbtnRespawnOff.UseVisualStyleBackColor = False
        Me.rbtnRespawnOff.Visible = False
        '
        'rbtnRespawnOn
        '
        Me.rbtnRespawnOn.AutoSize = True
        Me.rbtnRespawnOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnRespawnOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnRespawnOn.Name = "rbtnRespawnOn"
        Me.rbtnRespawnOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnRespawnOn.TabIndex = 21
        Me.rbtnRespawnOn.Text = "On"
        Me.rbtnRespawnOn.UseVisualStyleBackColor = False
        Me.rbtnRespawnOn.Visible = False
        '
        'lblRespawn
        '
        Me.lblRespawn.BackColor = System.Drawing.Color.Transparent
        Me.lblRespawn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespawn.Location = New System.Drawing.Point(501, 439)
        Me.lblRespawn.Name = "lblRespawn"
        Me.lblRespawn.Size = New System.Drawing.Size(289, 25)
        Me.lblRespawn.TabIndex = 35
        Me.lblRespawn.Text = "Respawn Delay 3 secs"
        Me.lblRespawn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRespawn.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.rbtnSuicideOff)
        Me.GroupBox7.Controls.Add(Me.rbtnSuicideOn)
        Me.GroupBox7.Location = New System.Drawing.Point(792, 399)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox7.Size = New System.Drawing.Size(170, 34)
        Me.GroupBox7.TabIndex = 32
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'rbtnSuicideOff
        '
        Me.rbtnSuicideOff.AutoSize = True
        Me.rbtnSuicideOff.BackColor = System.Drawing.Color.Transparent
        Me.rbtnSuicideOff.Checked = True
        Me.rbtnSuicideOff.Location = New System.Drawing.Point(85, 10)
        Me.rbtnSuicideOff.Name = "rbtnSuicideOff"
        Me.rbtnSuicideOff.Size = New System.Drawing.Size(48, 21)
        Me.rbtnSuicideOff.TabIndex = 22
        Me.rbtnSuicideOff.TabStop = True
        Me.rbtnSuicideOff.Text = "Off"
        Me.rbtnSuicideOff.UseVisualStyleBackColor = False
        Me.rbtnSuicideOff.Visible = False
        '
        'rbtnSuicideOn
        '
        Me.rbtnSuicideOn.AutoSize = True
        Me.rbtnSuicideOn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnSuicideOn.Location = New System.Drawing.Point(20, 10)
        Me.rbtnSuicideOn.Name = "rbtnSuicideOn"
        Me.rbtnSuicideOn.Size = New System.Drawing.Size(48, 21)
        Me.rbtnSuicideOn.TabIndex = 21
        Me.rbtnSuicideOn.Text = "On"
        Me.rbtnSuicideOn.UseVisualStyleBackColor = False
        Me.rbtnSuicideOn.Visible = False
        '
        'lblSuicide
        '
        Me.lblSuicide.BackColor = System.Drawing.Color.Transparent
        Me.lblSuicide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuicide.Location = New System.Drawing.Point(501, 405)
        Me.lblSuicide.Name = "lblSuicide"
        Me.lblSuicide.Size = New System.Drawing.Size(289, 25)
        Me.lblSuicide.TabIndex = 33
        Me.lblSuicide.Text = "Suicide Point Loss"
        Me.lblSuicide.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSuicide.Visible = False
        '
        'lblDeathmatch
        '
        Me.lblDeathmatch.AutoSize = True
        Me.lblDeathmatch.BackColor = System.Drawing.Color.Transparent
        Me.lblDeathmatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeathmatch.Location = New System.Drawing.Point(335, 30)
        Me.lblDeathmatch.Name = "lblDeathmatch"
        Me.lblDeathmatch.Size = New System.Drawing.Size(127, 25)
        Me.lblDeathmatch.TabIndex = 36
        Me.lblDeathmatch.Text = "Deathmatch"
        '
        'lblLauncher
        '
        Me.lblLauncher.AutoSize = True
        Me.lblLauncher.BackColor = System.Drawing.Color.Transparent
        Me.lblLauncher.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLauncher.Location = New System.Drawing.Point(327, 46)
        Me.lblLauncher.Name = "lblLauncher"
        Me.lblLauncher.Size = New System.Drawing.Size(234, 55)
        Me.lblLauncher.TabIndex = 37
        Me.lblLauncher.Text = "Launcher"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(914, 16)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(69, 20)
        Me.lblVersion.TabIndex = 38
        Me.lblVersion.Text = "Ver 1.0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 622)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDeathmatch)
        Me.Controls.Add(Me.lblLauncher)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblRespawn)
        Me.Controls.Add(Me.lblJumpShot)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.lblSuicide)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblCamping)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblSPawnProt)
        Me.Controls.Add(Me.lblGrenades)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblKillCam)
        Me.Controls.Add(Me.lblAdditonalOps)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.comboTeam)
        Me.Controls.Add(Me.comboDMType)
        Me.Controls.Add(Me.lblDMType)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.comboScoreLimit)
        Me.Controls.Add(Me.lblScoreLimit)
        Me.Controls.Add(Me.comboTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.comboSkillLevel)
        Me.Controls.Add(Me.lblSkill)
        Me.Controls.Add(Me.comboBots)
        Me.Controls.Add(Me.lblBots)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.comboMap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblShowOptions)
        Me.Controls.Add(Me.lblHideOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PeZBot Deathmatch Launcher"
        Me.TransparencyKey = System.Drawing.Color.LightGray
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboMap As ComboBox
    Friend WithEvents lblMap As Label
    Friend WithEvents lblBots As Label
    Friend WithEvents comboBots As ComboBox
    Friend WithEvents lblSkill As Label
    Friend WithEvents comboSkillLevel As ComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents comboTime As ComboBox
    Friend WithEvents lblScoreLimit As Label
    Friend WithEvents comboScoreLimit As ComboBox
    Friend WithEvents lblShowOptions As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblDMType As Label
    Friend WithEvents comboDMType As ComboBox
    Friend WithEvents comboTeam As ComboBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblAdditonalOps As Label
    Friend WithEvents lblKillCam As Label
    Friend WithEvents rbtnKillCamOn As RadioButton
    Friend WithEvents rbtnKillCamOff As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblGrenades As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnGrenadesOff As RadioButton
    Friend WithEvents rbtnGrenadesOn As RadioButton
    Friend WithEvents lblHideOptions As Label
    Friend WithEvents lblSPawnProt As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtnSpawnProtOff As RadioButton
    Friend WithEvents rbtnSpawnProtOn As RadioButton
    Friend WithEvents lblCamping As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbtnCampingOff As RadioButton
    Friend WithEvents rbtnCampingOn As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbtnJumpShotOff As RadioButton
    Friend WithEvents rbtnJumpShotOn As RadioButton
    Friend WithEvents lblJumpShot As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbtnRespawnOff As RadioButton
    Friend WithEvents rbtnRespawnOn As RadioButton
    Friend WithEvents lblRespawn As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents rbtnSuicideOff As RadioButton
    Friend WithEvents rbtnSuicideOn As RadioButton
    Friend WithEvents lblSuicide As Label
    Friend WithEvents lblDeathmatch As Label
    Friend WithEvents lblLauncher As Label
    Friend WithEvents lblVersion As Label
End Class
