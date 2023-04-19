Public Class frmMain

    Dim KillCam As String = "0"
    Dim DeathPointLoss As String = "0"
    Dim SuicidePointLoss As String = "0"
    Dim Grenades As String = "0"
    Dim SpawnProtection As String = "0"
    Dim Camping As String = "0"
    Dim JumpShot As String = "0"
    Dim Suicide As String = "0"
    Dim Respawn As String = "0"

    Dim DMType As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim directory = My.Application.Info.DirectoryPath
        Dim pezbotdirectory = directory & "\usermaps\"
        Dim files() As System.IO.FileInfo
        Dim dirinfo As New System.IO.DirectoryInfo(pezbotdirectory)

        comboMap.Items.Add("=============================")
        comboMap.Items.Add("Downloaded Maps")
        comboMap.Items.Add("=============================")

        files = dirinfo.GetFiles("*.iwd", IO.SearchOption.AllDirectories)
        For Each file In files

            Dim MPname As String = file.Name
            Dim testForMP As String = MPname.Substring(0, 2)

            If file.Name = "PeZBOT.iwd" Or file.Name = "pezbot.iwd" Then
                'Do nothing
            Else
                If testForMP = "mp" Then
                    comboMap.Items.Add(file.Name)
                End If
            End If
        Next



        comboMap.Items.Add("=============================")
        comboMap.Items.Add("Call of Duty Maps")
        comboMap.Items.Add("=============================")
        comboMap.Items.Add("mp_convoy.iwd(Ambush)")
        comboMap.Items.Add("mp_backlot.iwd(Backlot)")
        comboMap.Items.Add("mp_bloc.iwd(Bloc)")
        comboMap.Items.Add("mp_bog.iwd(Bog)")
        comboMap.Items.Add("mp_countdown.iwd(Countdown)")
        comboMap.Items.Add("mp_crash.iwd(Crash)")
        comboMap.Items.Add("mp_crossfire.iwd(Crossfire)")
        comboMap.Items.Add("mp_citystreets.iwd(District)")
        comboMap.Items.Add("mp_farm.iwd(Downpour)")
        comboMap.Items.Add("mp_overgrown.iwd(Overgrown)")
        comboMap.Items.Add("mp_pipeline.iwd(Pipeline)")
        comboMap.Items.Add("mp_shipment.iwd(Shipment)")
        comboMap.Items.Add("mp_showdown.iwd(Showdown)")
        comboMap.Items.Add("mp_strike.iwd(Strike)")
        comboMap.Items.Add("mp_vacant.iwd(Vacant)")
        comboMap.Items.Add("mp_cargoship.iwd(Wet Work)")
        comboMap.Items.Add("mp_crash_snow.iwd(Winter Crash)")
        comboMap.Items.Add("mp_broadcast.iwd(Broadcast)")
        comboMap.Items.Add("mp_carentan.iwd(Chinatown)")
        comboMap.Items.Add("mp_creek.iwd(Creek)")
        comboMap.Items.Add("mp_killhouse.iwd(Killhouse)")


        Dim nums As Integer = 0
        Do While nums < 20
            nums += 1
            comboBots.Items.Add(nums)
        Loop

        Dim skill As Integer = 0
        Do While skill < 10
            skill += 1
            comboSkillLevel.Items.Add(skill)
        Loop

        Dim timelimit As Integer = 5
        Do While timelimit < 60
            timelimit += 5
            comboTime.Items.Add(timelimit)
        Loop

        Dim kills As Integer = 0
        Do While kills < 750
            kills += 50
            comboScoreLimit.Items.Add(kills)
        Loop

    End Sub


    Private Function RemoveBracketsAntContents(inputString As String) As String
        Dim i As Integer
        While i < inputString.Length
            Dim bracketDepth As Integer = 0
            Dim firstBracketIndex As Integer = 0
            Do
                If inputString(i) = "(" Then
                    If firstBracketIndex = 0 Then
                        firstBracketIndex = i
                    End If
                    bracketDepth += 1
                End If
                i += 1
            Loop Until i = inputString.Length OrElse inputString(i) = ")"
            If i = inputString.Length Then Exit While
            Do
                If inputString(i) = ")" Then
                    bracketDepth -= 1
                End If
                i += 1
            Loop Until bracketDepth = 0
            inputString = inputString.Remove(firstBracketIndex, i - firstBracketIndex)
            i = i - (i - firstBracketIndex)
        End While
        inputString = inputString.Replace("  ", " ")
        Return inputString
    End Function


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim SelectedMap As String = comboMap.SelectedItem
        Dim SelectedMapBracket As String = RemoveBracketsAntContents(SelectedMap)
        Dim SelectedMapExtension As String = SelectedMapBracket.Remove(SelectedMapBracket.Length - 4)
        SelectedMap = SelectedMapExtension

        Dim BotTeamSelect As String = comboTeam.SelectedItem
        If BotTeamSelect = "Imperial Forces" Then
            BotTeamSelect = "axis"
        End If

        If BotTeamSelect = "Rebel Alliance" Then
            BotTeamSelect = "allies"
        End If
        If BotTeamSelect = "Auto Assign" Then
            BotTeamSelect = "autoassign"
        End If


        Dim BotNumber As Integer = comboBots.SelectedItem
        Dim SkillLevel As Double = comboSkillLevel.SelectedItem
        SkillLevel /= 10

        Dim TimeLimit As Integer = comboTime.SelectedItem
        Dim KillLimit As Integer = comboScoreLimit.SelectedItem



        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("StarWars.bat", False)

        file.WriteLine("@echo off")

        If DMType = "Free for All" Then
            file.WriteLine("start iw3mp.exe +set sv_punkbuster 0 +set fs_game ""mods/swm_gw1"" +set svr_pezbots_mode ""normal"" +set g_gametype ""dm"" +map " & SelectedMap & " " & "+set svr_pezbots_skill" & " " & SkillLevel & " " & "+set scr_dm_timelimit" & " " & TimeLimit & " " & "+set scr_dm_scorelimit" & " " & KillLimit & " " & "+set svr_pezbots" & " " & BotNumber & " " & "+set svr_pezbots_team" & " " & BotTeamSelect & " " & "+set scr_game_allowkillcam" & " " & KillCam & " " & "+set svr_pezbots_grenadepickup" & " " & Grenades & " " & "+set swm_spawnprotection" & " " & SpawnProtection & " " & "+set swm_anticamp" & " " & Camping & " " & "+set swm_disablejumpshot" & " " & JumpShot & " " & "+set scr_game_suicidepointloss" & " " & Suicide & " " & "+set scr_dm_playerrespawndelay" & " " & Respawn)
        Else
            file.WriteLine("start iw3mp.exe +set sv_punkbuster 0 +set fs_game ""mods/swm_gw1"" +set svr_pezbots_mode ""normal"" +set g_gametype ""war"" +map " & SelectedMap & " " & "+set svr_pezbots_skill" & " " & SkillLevel & " " & "+set scr_war_timelimit" & " " & TimeLimit & " " & "+set scr_war_scorelimit" & " " & KillLimit & " " & "+set svr_pezbots" & " " & BotNumber & " " & "+set svr_pezbots_team" & " " & BotTeamSelect & " " & "+set scr_game_allowkillcam" & " " & KillCam & " " & "+set svr_pezbots_grenadepickup" & " " & Grenades & " " & "+set swm_spawnprotection" & " " & SpawnProtection & " " & "+set swm_anticamp" & " " & Camping & " " & "+set swm_disablejumpshot" & " " & JumpShot & " " & "+set scr_game_suicidepointloss" & " " & Suicide & " " & "+set scr_war_playerrespawndelay" & " " & Respawn)
        End If

        file.Close()
        Shell("StarWars.bat")
    End Sub


    Private Sub comboMap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMap.SelectedIndexChanged
        Dim Map As String = comboMap.SelectedItem
        If Map = "=============================" Or Map = "Downloaded Maps" Or Map = "Call of Duty Maps" Then
            'do nothing
        Else
            lblDMType.Show()
            comboDMType.Show()
        End If
    End Sub

    Private Sub comboDMType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDMType.SelectedIndexChanged
        lblTeam.Show()
        comboTeam.Show()
        DMType = comboDMType.SelectedItem
    End Sub

    Private Sub comboBots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBots.SelectedIndexChanged
        lblSkill.Show()
        comboSkillLevel.Show()
        Dim Test As String = comboBots.SelectedItem
    End Sub

    Private Sub comboTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTeam.SelectedIndexChanged
        lblBots.Show()
        comboBots.Show()
    End Sub

    Private Sub comboSkillLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSkillLevel.SelectedIndexChanged
        lblTime.Show()
        comboTime.Show()
    End Sub

    Private Sub comboTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTime.SelectedIndexChanged
        lblScoreLimit.Show()
        comboScoreLimit.Show()
    End Sub

    Private Sub comboScoreLimit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboScoreLimit.SelectedIndexChanged
        btnStart.Show()
    End Sub

    Private Sub lblOptions_Click(sender As Object, e As EventArgs) Handles lblShowOptions.Click
        lblAdditonalOps.Show()
        lblHideOptions.Show()
        lblShowOptions.Hide()

        lblKillCam.Show()
        GroupBox1.Show()
        rbtnKillCamOn.Show()
        rbtnKillCamOff.Show()

        lblGrenades.Show()
        GroupBox2.Show()
        rbtnGrenadesOff.Show()
        rbtnGrenadesOn.Show()

        GroupBox3.Show()
        lblSPawnProt.Show()
        rbtnSpawnProtOn.Show()
        rbtnSpawnProtOff.Show()

        GroupBox4.Show()
        lblCamping.Show()
        rbtnCampingOn.Show()
        rbtnCampingOff.Show()

        GroupBox5.Show()
        lblJumpShot.Show()
        rbtnJumpShotOn.Show()
        rbtnJumpShotOff.Show()

        GroupBox6.Show()
        lblSuicide.Show()
        rbtnSuicideOn.Show()
        rbtnSuicideOff.Show()

        GroupBox7.Show()
        lblRespawn.Show()
        rbtnRespawnOn.Show()
        rbtnRespawnOff.Show()

    End Sub


    Private Sub lblHideOptions_Click(sender As Object, e As EventArgs) Handles lblHideOptions.Click

        lblAdditonalOps.Hide()
        lblHideOptions.Hide()
        lblShowOptions.Show()

        lblKillCam.Hide()
        GroupBox1.Hide()
        rbtnKillCamOn.Hide()
        rbtnKillCamOff.Hide()

        lblGrenades.Hide()
        GroupBox2.Hide()
        rbtnGrenadesOff.Hide()
        rbtnGrenadesOn.Hide()

        lblSPawnProt.Hide()
        GroupBox3.Hide()
        rbtnSpawnProtOn.Hide()
        rbtnSpawnProtOff.Hide()

        lblCamping.Hide()
        GroupBox4.Hide()
        rbtnCampingOn.Hide()
        rbtnCampingOff.Hide()

        lblJumpShot.Hide()
        GroupBox5.Hide()
        rbtnJumpShotOn.Hide()
        rbtnJumpShotOff.Hide()

        lblSuicide.Hide()
        GroupBox6.Hide()
        rbtnSuicideOn.Hide()
        rbtnSuicideOff.Hide()

        lblRespawn.Hide()
        GroupBox7.Hide()
        rbtnRespawnOn.Hide()
        rbtnRespawnOff.Hide()

    End Sub


    Private Sub rbtnKillCamOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnKillCamOn.CheckedChanged
        KillCam = "1"
    End Sub

    Private Sub rbtnKillCamOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnKillCamOff.CheckedChanged
        KillCam = "0"
    End Sub

    Private Sub rbtnGrenadesOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGrenadesOn.CheckedChanged
        Grenades = "1"
    End Sub

    Private Sub rbtnGrenadesOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGrenadesOff.CheckedChanged
        Grenades = "0"
    End Sub

    Private Sub rbtnSpawnProtOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSpawnProtOn.CheckedChanged
        SpawnProtection = "1"
    End Sub

    Private Sub rbtnSpawnProtOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSpawnProtOff.CheckedChanged
        SpawnProtection = "0"
    End Sub

    Private Sub rbtnCampingOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCampingOn.CheckedChanged
        Camping = "1"
    End Sub

    Private Sub rbtnCampingOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCampingOff.CheckedChanged
        Camping = "0"
    End Sub

    Private Sub rbtnJumpShotOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnJumpShotOn.CheckedChanged
        JumpShot = "1"
    End Sub

    Private Sub rbtnJumpShotOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnJumpShotOff.CheckedChanged
        JumpShot = "0"
    End Sub

    Private Sub rbtnSuicideOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSuicideOn.CheckedChanged
        Suicide = "1"
    End Sub

    Private Sub rbtnSuicideOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSuicideOff.CheckedChanged
        Suicide = "0"
    End Sub

    Private Sub rbtnRespawnOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRespawnOn.CheckedChanged
        Respawn = "3"
    End Sub

    Private Sub rbtnRespawnOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRespawnOff.CheckedChanged
        Respawn = "0"
    End Sub
End Class
