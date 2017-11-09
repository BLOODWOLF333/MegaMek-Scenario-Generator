Public Class Scenario

    Public arrayScenario() As String = Split(My.Resources.Scenarios, ", ")

    Public arrayObjective() As String = Split(My.Resources.typeObjective, ", ")

    Private arrayCivilization() As String = Split(My.Resources.typeCivilization, ", ")

    Private arrayCivilScenarios() As String = Split(My.Resources.civilScenarios, ", ")

    Private arraytxtObjectives() As String = Split(My.Resources.Objectives, ", ")

    Private arraytxtSpecial() As String = Split(My.Resources.Special, ", ")

    Private Intensity As String = ""
    Private Scenario As String = ""
    Private cadreScenario As String = ""
    Private typeObjective As String = ""
    Private typeCivilization As String = ""
    Private txtObjective As String = ""
    Private txtSpecial As String = ""
    Private txtSpecialMod As String = ""

    Private Function matchIntensity(mission As String)

        Select Case Generator.cbMission.SelectedIndex

            Case 0

                Return 1.713

            Case 1

                Return 1.469

            Case 2

                Return 1.305

            Case 3

                Return 1.305

            Case 4

                Return 1.305

            Case 5

                Return 1.224

            Case 6

                Return 1.142

            Case 7

                Return 0.979

            Case 8

                Return 0.816

            Case 9

                Return 0.816

            Case 10

                Return 0.816

            Case 11

                Return 0.653

            Case 12

                Return arraytxtSpecial(0)

            Case Else

                Return Generator.arrayMisc(0)

        End Select

    End Function

    Public Sub setIntensity(mission)

        Dim i As String = matchIntensity(mission)
        Intensity = i

    End Sub

    Public Function getIntensity()

        Return Intensity

    End Function

    Public Function matchScenario(mission As String)

        Select Case Generator.cbMission.SelectedIndex

            Case 0

                Return matchGuerrillaScenario()

            Case 1

                Return matchDiversionaryRaidScenario()

            Case 2

                Return matchExtractionRaidScenario()

            Case 3

                Return matchObjectiveRaidScenario()

            Case 4

                Return matchReconRaidScenario()

            Case 5

                Return matchPlanetaryAssaultScenario()

            Case 6

                Return matchReliefDutyScenario()

            Case 7

                Return matchSecurityDutyScenario()

            Case 8

                Return matchPirateHuntingScenario()

            Case 9

                Return matchRiotDutyScenario()

            Case 10

                Return matchGarrisonDutyScenario()

            Case 11

                Return matchCadreDutyScenario()

            Case 12

                Return matchPlanetaryEntryScenario()

            Case Else

                Return Generator.arrayMisc(0)

        End Select

    End Function

    Public Sub setScenario(mission)

        Dim s As String = matchScenario(mission)
        Scenario = s

    End Sub

    Public Function getScenario()

        Return Scenario

    End Function

    Private Function matchGuerrillaScenario()

        Select Case Generator.roll1023()

            Case 1 To 8
                Return arrayScenario(0)
            Case 9 To 24
                Return arrayScenario(1)
            Case 25 To 56
                Return arrayScenario(3)
            Case 57 To 120
                Return arrayScenario(5)
            Case 121 To 249
                Return arrayScenario(7)
            Case 250 To 507
                Return arrayScenario(9)
            Case 508 To 1023
                Return arrayScenario(10)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchDiversionaryRaidScenario()

        Select Case Generator.roll1023()

            Case 1 To 341
                Return arrayScenario(3)
            Case 342 To 1023
                Return arrayScenario(5)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchExtractionRaidScenario()

        Select Case Generator.roll1023()

            Case 1 To 341
                Return arrayScenario(0)
            Case 342 To 1023
                Return arrayScenario(1)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchObjectiveRaidScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(3)
            Case 147 To 438
                Return arrayScenario(5)
            Case 439 To 1023
                Return arrayScenario(7)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchReconRaidScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(3)
            Case 147 To 438
                Return arrayScenario(5)
            Case 439 To 1023
                Return arrayScenario(9)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchPlanetaryAssaultScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(3)
            Case 147 To 438
                Return arrayScenario(7)
            Case 439 To 1023
                Return arrayScenario(9)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchReliefDutyScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(2)
            Case 147 To 438
                Return arrayScenario(4)
            Case 439 To 1023
                Return arrayScenario(6)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchSecurityDutyScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(2)
            Case 147 To 438
                Return arrayScenario(4)
            Case 439 To 1023
                Return arrayScenario(8)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchPirateHuntingScenario()

        Select Case Generator.roll1023()

            Case 1 To 146
                Return arrayScenario(3)
            Case 147 To 438
                Return arrayScenario(7)
            Case 439 To 1023
                Return arrayScenario(9)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchRiotDutyScenario()

        Select Case Generator.roll1023()

            Case 1 To 341
                Return arrayScenario(3)
            Case 342 To 1023
                Return arrayScenario(9)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchGarrisonDutyScenario()

        Select Case Generator.roll1023()

            Case 1 To 341
                Return arrayScenario(6)
            Case 342 To 1023
                Return arrayScenario(8)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchCadreDutyScenario()

        Select Case Generator.roll1023()

            Case 1
                Return arrayScenario(0)
            Case 2 To 3
                Return arrayScenario(1)
            Case 4 To 7
                Return arrayScenario(2)
            Case 8 To 15
                Return arrayScenario(3)
            Case 16 To 31
                Return arrayScenario(4)
            Case 32 To 63
                Return arrayScenario(5)
            Case 64 To 127
                Return arrayScenario(6)
            Case 128 To 255
                Return arrayScenario(7)
            Case 256 To 511
                Return arrayScenario(8)
            Case 512 To 1023
                Return arrayScenario(9)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Function matchPlanetaryEntryScenario()

        Select Case Generator.roll1023()

            Case 1 To 68
                Return arrayScenario(11)
            Case 69 To 204
                Return arrayScenario(12)
            Case 205 To 477
                Return arrayScenario(13)
            Case 478 To 1023
                Return arrayScenario(14)
            Case Else
                Return Generator.arrayMisc(0)

        End Select

    End Function
    'For when a guerrilla/cadre scenario is generated
    Public Function matchcadreScenario()

        Select Case Generator.roll1023()

            Case 1

                Return arrayScenario(0)

            Case 2 To 3

                Return arrayScenario(1)

            Case 4 To 7

                Return arrayScenario(2)

            Case 8 To 15

                Return arrayScenario(3)

            Case 16 To 31

                Return arrayScenario(4)

            Case 32 To 63

                Return arrayScenario(5)

            Case 64 To 127

                Return arrayScenario(6)

            Case 128 To 255

                Return arrayScenario(7)

            Case 256 To 511

                Return arrayScenario(8)

            Case 512 To 1023

                Return arrayScenario(9)

            Case Else

                Return Generator.arrayMisc(0)

        End Select

    End Function

    Public Sub setcadreScenario(mission)

        If Array.IndexOf(arrayScenario, Scenario) = 10 Then

            Dim cs As String = matchcadreScenario()
            cadreScenario = cs

        End If

    End Sub

    Public Function getcadreScenario()

        Return cadreScenario

    End Function

    Public Function matchtypeObjective()

        Select Case Generator.roll7()

            Case 1

                Return arrayObjective(0)

            Case 2 To 3

                Return arrayObjective(1)

            Case 4 To 7

                Return arrayObjective(2)

            Case Else

                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Sub settypeObjective()

        Dim o As String = matchtypeObjective()
        typeObjective = o

    End Sub

    Public Function gettypeObjective()

        Return typeObjective

    End Function

    Private Function matchtypeCivilization(Scenario As String, cadreScenario As String)

        Dim checkScenario As String

        If Array.IndexOf(arrayScenario, Scenario) = 10 Then

            checkScenario = cadreScenario

        Else

            checkScenario = Scenario

        End If

        If arrayCivilScenarios.Contains(checkScenario) Then

            Select Case Generator.roll7()
                Case 1
                    Return arrayCivilization(0)
                Case 2 To 3
                    Return arrayCivilization(1)
                Case 4 To 7
                    Return arrayCivilization(2)
                Case Else
                    Return Generator.arrayMisc(0)
            End Select

        Else

            Return Nothing

        End If

    End Function

    Private Sub settypeCivilization()

        Dim c As String = matchtypeCivilization(Scenario, cadreScenario)
        typeCivilization = c

    End Sub

    Public Function gettypeCivilization()

        Return typeCivilization

    End Function

    Public Function matchtxtObjective(Scenario As String, cadreScenario As String, typeCivilization As String, typeObjective As String)

        Dim checkScenario As Integer

        If Array.IndexOf(arrayScenario, Scenario) = 10 Then

            checkScenario = Array.IndexOf(arrayScenario, cadreScenario)

        Else

            checkScenario = Array.IndexOf(arrayScenario, Scenario)

        End If

        Select Case checkScenario

            Case 0

                Return matchExtractionRaidObjective()

            Case 1

                Return matchCaptureInterceptObjective()

            Case 2

                Return matchTargetEscortObjective()

            Case 3

                Return matchTargetInterceptObjective()

            Case 4

                Return matchTargetDefendObjective()

            Case 5

                Return matchTargetRaidObjective()

            Case 6

                Return arraytxtObjectives(2)

            Case 7

                Return arraytxtObjectives(1)

            Case 8, 9

                Return arraytxtObjectives(0)

            Case 11, 12

                Return arraytxtObjectives(17)

            Case 13, 14

                Return arraytxtObjectives(18)

            Case Else

                Return Generator.arrayMisc(0)

        End Select

    End Function

    Private Sub settxtObjective()

        Dim o As String = matchtxtObjective(Scenario, cadreScenario, typeCivilization, typeObjective)
        txtObjective = o

    End Sub

    Public Function gettxtObjective()

        Return txtObjective

    End Function

    Private Function matchExtractionRaidObjective()

        If Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(3)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(15)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(16)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(4)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(15)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(16)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(5)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(15)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(16)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Private Function matchCaptureInterceptObjective()

        If Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(13)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(9)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(8)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Private Function matchTargetEscortObjective()

        If Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(11)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(9)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(12)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Private Function matchTargetInterceptObjective()

        If Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(8)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(9)
        ElseIf Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(10)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Private Function matchTargetDefendObjective()

        If Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(3)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(4)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(5)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Private Function matchTargetRaidObjective()

        If Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(3)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 0 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(4)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 1 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 0 Then
            Return arraytxtObjectives(5)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 1 Then
            Return arraytxtObjectives(6)
        ElseIf Array.IndexOf(arrayCivilization, typeCivilization) = 2 And Array.IndexOf(arrayObjective, typeObjective) = 2 Then
            Return arraytxtObjectives(7)
        Else
            Return Generator.arrayMisc(0)
        End If

    End Function

    Public Function matchtxtSpecial(mission As String, Scenario As String, cadreScenario As String)

        Dim checkScenario As Integer

        If Array.IndexOf(arrayScenario, Scenario) = 10 Then

            checkScenario = Array.IndexOf(arrayScenario, cadreScenario)

        Else

            checkScenario = Array.IndexOf(arrayScenario, Scenario)

        End If

        Select Case checkScenario
            Case 0, 1, 3, 5
                Return arraytxtSpecial(1)
            Case 2
                Return arraytxtSpecial(2)
            Case Else
                Return Nothing
        End Select

    End Function

    Private Sub settxtSpecial(mission)

        Dim s As String

        If Generator.cbMission.SelectedIndex = 1 Or Generator.cbMission.SelectedIndex = 4 Then

            s = arraytxtSpecial(1)

        Else

            s = matchtxtSpecial(mission, Scenario, cadreScenario)

        End If

        txtSpecial = s

    End Sub

    Public Function gettxtSpecial()

        Return txtSpecial

    End Function

    Public Function matchtxtSpecialMod(mission As String, Scenario As String)

        If Generator.cbMission.SelectedIndex = 4 Or Generator.cbMission.SelectedIndex = 11 Then

            Return arraytxtSpecial(3)

        ElseIf Array.IndexOf(arrayScenario, Scenario) = 10 Then

            Return arraytxtSpecial(3)

        Else

            Return Nothing

        End If

    End Function

    Private Sub settxtSpecialMod(mission)

        Dim s As String = matchtxtSpecialMod(mission, Scenario)
        txtSpecialMod = s

    End Sub

    Public Function gettxtSpecialMod()

        Return txtSpecialMod

    End Function

    Public Sub New(mission As String)

        setIntensity(mission)
        setScenario(mission)
        setcadreScenario(mission)
        settypeObjective()
        settypeCivilization()
        settxtObjective()
        settxtSpecial(mission)
        settxtSpecialMod(mission)

    End Sub

End Class