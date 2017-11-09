Public Class Generator

    Public arrayMission() As String = Split(My.Resources.Missions, ", ")

    Private arrayLabels() As String = Split(My.Resources.Labels, ", ")

    Public arrayMisc() As String = Split(My.Resources.Misc, ", ")

    Public arrayFactions() As String = Split(My.Resources.Factions, ", ")

    Public arraysizeIS() As String = Split(My.Resources.sizeInnerSphere, ", ")

    Public arraysizeClan() As String = Split(My.Resources.sizeClan, ", ")

    Public arrayRating() As String = Split(My.Resources.Rating, ", ")

    Public arraySupport As New ArrayList

    Public arrayplayerStart() As String = Split(My.Resources.startLocations, ", ")

    Private Sub Generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(720, 600)

        lblMission.Text = arrayLabels(0)
        lblScenario.Text = arrayLabels(1)
        lblIntensity.Text = arrayLabels(2)
        lblObjective.Text = arrayLabels(3)
        lblPlayerFaction.Text = arrayLabels(4)
        lblPlayerSize.Text = arrayLabels(5)
        lblPlayerRating.Text = arrayLabels(6)
        lblPlayerStart.Text = arrayLabels(7)
        lblSpecial.Text = arrayLabels(8)
        lblCO.Text = arrayLabels(9)
        lblSEA.Text = arrayLabels(10)
        lblXO.Text = arrayLabels(11)
        lblOC.Text = arrayLabels(12)
        lblSupport.Text = arrayLabels(13)
        lblPlanet.Text = arrayLabels(14)
        lblAxisOrbit.Text = arrayLabels(15)
        lblSeason.Text = arrayLabels(16)
        lblMoons.Text = arrayLabels(17)
        lblGravity.Text = arrayLabels(18)
        lblAtmosphere.Text = arrayLabels(19)
        lblEQTemp.Text = arrayLabels(20)
        lblSurfaceWater.Text = arrayLabels(21)
        lblLatitude.Text = arrayLabels(22)
        lblLongitude.Text = arrayLabels(23)
        lblTheme.Text = arrayLabels(24)
        lblTerrain.Text = arrayLabels(25)
        lblTemp.Text = arrayLabels(26)
        lblLight.Text = arrayLabels(27)
        lblWeather.Text = arrayLabels(28)
        lblWind.Text = arrayLabels(29)
        lblSand.Text = arrayLabels(30)
        lblFog.Text = arrayLabels(31)
        lblEMI.Text = arrayLabels(32)
        lblMapSize.Text = arrayLabels(33)

        cbMission.Items.AddRange(arrayMission)
        cbMission.SelectedIndex = 0
        cbPlayerFaction.Items.AddRange(arrayFactions)
        cbPlayerFaction.SelectedIndex = 0
        cbPlayerSize.Items.AddRange(arraysizeIS)
        cbPlayerSize.SelectedIndex = 0
        cbPlayerRating.Items.AddRange(arrayRating)
        cbPlayerRating.SelectedIndex = 0

        Dim planets As New Planets() 'Planets object needs to be called here on start-up to get names for dropdown box

        cbPlanets.SelectedIndex = 0

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        Dim mission As String = arrayMission(cbMission.SelectedIndex)

        Dim scenario As New Scenario(mission)

        txtIntensity.Text = scenario.getIntensity()
        txtScenario.Text = scenario.getScenario()
        'If scenario is guerrilla/cadre duty then make 2nd scenario box visible and assign cadreScenario to it
        If Array.IndexOf(scenario.arrayScenario, txtScenario.Text) = 10 Then

            txtCadreScenario.Visible = True
            txtCadreScenario.Text = scenario.getcadreScenario()

        Else

            txtCadreScenario.Visible = False

        End If

        txtObjective.Text = scenario.gettxtSpecialMod & scenario.gettxtObjective & scenario.gettxtSpecial
        setarraySupport()

        Dim player As New Player(mission, scenario)

        txtSupport.Text = player.getwhoSupport()
        txtPlayerStart.Text = player.getStart()

        If Array.IndexOf(scenario.arrayScenario, scenario.getScenario) = 0 And
            Array.IndexOf(scenario.arrayObjective, scenario.gettypeObjective) = 0 Then

            txtSpecial.Text = "APC(s) provided if player has none"

        ElseIf Array.IndexOf(scenario.arrayScenario, scenario.getScenario) = 1 Then

            txtSpecial.Text = "Use /traitor to capture target(s)"

        ElseIf Array.IndexOf(scenario.arrayScenario, scenario.getScenario) >= 13 Then

            txtSpecial.Text = "Aerospace provided if player has none"

        ElseIf Array.IndexOf(arrayMission, mission) = 6 Then

            txtSpecial.Text = "Player arrives on turn " & roll2D6()

        Else

            txtSpecial.Text = String.Empty

        End If

    End Sub

    Private Sub cbPlayerFaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlayerFaction.SelectedIndexChanged

        If cbPlayerFaction.SelectedIndex = 0 Then

            cbPlayerSize.Items.Clear()
            cbPlayerSize.Items.AddRange(arraysizeIS)
            cbPlayerSize.SelectedIndex = 0

        ElseIf cbPlayerFaction.SelectedIndex = 1 Then

            cbPlayerSize.Items.Clear()
            cbPlayerSize.Items.AddRange(arraysizeClan)
            cbPlayerSize.SelectedIndex = 0

        Else

            cbPlayerSize.SelectedText = arrayMisc(0)

        End If

    End Sub

    Private Sub setarraySupport()

        Dim listSupport As New ArrayList

        If txtCO.Text = String.Empty Then

        Else

            listSupport.Add(txtCO.Text)

        End If

        If txtSEA.Text = String.Empty Then

        Else

            listSupport.Add(txtSEA.Text)

        End If

        If txtXO.Text = String.Empty Then

        Else

            listSupport.Add(txtXO.Text)

        End If

        If txtOC.Text = String.Empty Then

        Else

            listSupport.Add(txtOC.Text)

        End If

        arraySupport = listSupport

    End Sub

    Private Sub cbPlanets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPlanets.SelectedIndexChanged

        Planets.listPlanets() 'nope wants me to call an object here

    End Sub

    Public Function roll2D6() As Integer

        Dim roll1 As Integer = CInt((Rnd() * 5) + 1)
        Dim roll2 As Integer = CInt((Rnd() * 5) + 1)
        Return roll1 + roll2

    End Function

    Public Function roll3() As Integer

        Dim rollResult As Integer = CInt((Rnd() * 2) + 1)
        Return rollResult

    End Function

    Public Function roll7() As Integer

        Dim rollResult As Integer = CInt((Rnd() * 6) + 1)
        Return rollResult

    End Function

    Public Function roll15()

        Dim rollResult As Integer = CInt((Rnd() * 14) + 1)
        Return rollResult

    End Function

    Public Function roll31()

        Dim rollResult As Integer = CInt((Rnd() * 30) + 1)
        Return rollResult

    End Function

    Public Function roll63()

        Dim rollResult As Integer = CInt((Rnd() * 62) + 1)
        Return rollResult

    End Function

    Public Function roll127()

        Dim rollResult As Integer = CInt((Rnd() * 126) + 1)
        Return rollResult

    End Function

    Public Function roll255()

        Dim rollResult As Integer = CInt((Rnd() * 254) + 1)
        Return rollResult

    End Function

    Public Function roll511()

        Dim rollResult As Integer = CInt((Rnd() * 510) + 1)
        Return rollResult

    End Function

    Public Function roll1023() As Integer

        Dim rollResult As Integer = CInt((Rnd() * 1022) + 1)
        Return rollResult

    End Function

End Class