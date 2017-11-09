Public Class Player

    Dim ifSupport As Boolean
    Dim numSupport As Integer
    Dim whoSupport As String
    Dim playerStart As String

    Private Function checkifSupport()

        Select Case Generator.roll3()

            Case 1

                Return True

            Case 2 To 3

                Return False

            Case Else

                Return Nothing

        End Select

    End Function

    Private Sub setifSupport(scenario)

        Dim checkScenario As String = scenario.getScenario()
        Dim indexScenario As Integer = Array.IndexOf(scenario.arrayScenario, checkScenario)

        If Generator.arraySupport.Count = 0 Then

            ifSupport = False

        ElseIf indexScenario = 13 Then

            ifSupport = False

        ElseIf indexScenario = 14 Then

            ifSupport = False

        Else

            ifSupport = checkifSupport()

        End If

    End Sub

    Public Function getifSupport()

        Return ifSupport

    End Function

    Private Function checknumSupport()

        Dim total As Integer = Generator.arraySupport.Count

        Select Case total

            Case 0

                Return 0

            Case 1

                Return 1

            Case 2

                Return randnumSupport2()

            Case 3

                Return randnumSupport3()

            Case 4

                Return randnumSupport4()

            Case Else

                Return Nothing

        End Select

    End Function

    Private Sub setnumSupport()

        If ifSupport = False Then

        Else

            numSupport = checknumSupport()

        End If

    End Sub

    Public Function getnumSupport()

        Return numSupport

    End Function

    Private Function randnumSupport2()

        Select Case Generator.roll7

            Case 1

                Return 2

            Case 2 To 3

                Return 1

            Case 4 To 7

                Return 0

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function randnumSupport3()

        Select Case Generator.roll15

            Case 1

                Return 3

            Case 2 To 3

                Return 2

            Case 4 To 7

                Return 1

            Case 8 To 15

                Return 0

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function randnumSupport4()

        Select Case Generator.roll31

            Case 1

                Return 4

            Case 2 To 3

                Return 3

            Case 4 To 7

                Return 2

            Case 8 To 15

                Return 1

            Case 16 To 31

                Return 0

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function pickwhoSupport(numSupport As Integer)

        Select Case numSupport

            Case 0

                Return Nothing

            Case 1 And Generator.arraySupport.Count = 1

                Return Generator.arraySupport(0)

            Case 1 And Generator.arraySupport.Count = 2

                Return Generator.arraySupport(get1From2)

            Case 1 And Generator.arraySupport.Count = 3

                Return Generator.arraySupport(get1From3)

            Case 1 And Generator.arraySupport.Count = 4

                Return Generator.arraySupport(get1From4)

            Case 2 And Generator.arraySupport.Count = 2

                Return Generator.arraySupport(0) & ", " & Generator.arraySupport(1)

            Case 2 And Generator.arraySupport.Count = 3

                Return get2From3()

            Case 2 And Generator.arraySupport.Count = 4

                Return get2From4()

            Case 3 And Generator.arraySupport.Count = 3

                Return Generator.arraySupport(0) & ", " & Generator.arraySupport(1) & ", " & Generator.arraySupport(2)

            Case 3 And Generator.arraySupport.Count = 4

                Return get3From4()

            Case 4 And Generator.arraySupport.Count = 4

                Return Generator.arraySupport(0) & ", " & Generator.arraySupport(1) & ", " & Generator.arraySupport(2) & ", " &
                    Generator.arraySupport(3)

            Case Else

                Return Nothing

        End Select

    End Function

    Private Sub setwhoSupport()

        If ifSupport = False Then

        Else

            whoSupport = pickwhoSupport(numSupport)

        End If

    End Sub

    Public Function getwhoSupport()

        Return whoSupport

    End Function

    Private Function get1From2()

        Select Case Generator.roll3

            Case 1

                Return 0

            Case 2 To 3

                Return 1

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function get1From3() As Integer

        Select Case Generator.roll7

            Case 1

                Return 0

            Case 2 To 3

                Return 1

            Case 4 To 7

                Return 2

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function get1From4() As Integer

        Select Case Generator.roll31

            Case 1

                Return 0

            Case 2 To 3

                Return 1

            Case 4 To 7

                Return 2

            Case 8 To 15

                Return 3

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function get2From3() As String

        Dim one As String
        Dim two As String

        one = Generator.arraySupport(get1From3())
        Generator.arraySupport.Remove(one)
        two = Generator.arraySupport(get1From2())

        Return one & ", " & two

    End Function

    Private Function get2From4() As String

        Dim one As String
        Dim two As String

        one = Generator.arraySupport(get1From4())
        Generator.arraySupport.Remove(one)
        two = Generator.arraySupport(get1From3())

        Return one & ", " & two

    End Function

    Private Function get3From4() As String

        Dim one As String
        Dim two As String
        Dim three As String

        one = Generator.arraySupport(get1From4())
        Generator.arraySupport.Remove(one)
        two = Generator.arraySupport(get1From3())
        Generator.arraySupport.Remove(two)
        three = Generator.arraySupport(get1From2())

        Return one & ", " & two & ", " & three

    End Function

    Private Function pickStart()

        Select Case rollStart()

            Case 1

                Return 9

            Case 2 To 3

                Return 8

            Case 4 To 5

                Return 7

            Case 6 To 7

                Return 6

            Case 8 To 9

                Return 5

            Case 10 To 11

                Return 4

            Case 12 To 13

                Return 3

            Case 14 To 15

                Return 2

            Case 16 To 17

                Return 1

            Case 18 To 19

                Return 0

            Case Else

                Return Nothing

        End Select

    End Function

    Private Function rollStart()

        Dim rollResult As Integer = CInt((Rnd() * 18) + 1)
        Return rollResult

    End Function

    Private Sub setStart(mission, scenario)

        Dim checkMission As Integer = Array.IndexOf(Generator.arrayMission, mission)
        Dim checkStart As Integer = pickStart()
        Dim checkScenario = scenario.getScenario()
        Dim indexScenario = Array.IndexOf(scenario.arrayScenario, checkScenario)

        If indexScenario = 0 And checkStart = 4 Then
            'Extraction Raid cannot start CTR
            While checkStart = 4

                checkStart = pickStart()

            End While

        ElseIf indexScenario = 1 And checkStart = 9 Then
            'Capture Intercept cannot start Edge
            While checkStart = 9

                checkStart = pickStart()

            End While

        ElseIf indexScenario = 2 And checkStart = 4 Then
            'Target Escort cannot start CTR
            While checkStart = 4

                checkStart = pickStart()

            End While

        ElseIf indexScenario = 3 And checkStart = 9 Then
            'Target Intercept cannot start Edge
            While checkStart = 9

                checkStart = pickStart()

            End While

        ElseIf indexScenario = 4 Then
            'Target Defend starts CTR
            checkStart = 4

        ElseIf indexScenario = 5 And checkStart = 4 Then
            'Target Raid cannot start CTR
            checkStart = pickStart()

        ElseIf indexScenario = 6 Then
            'Location Defend starts CTR
            checkStart = 4

        ElseIf indexScenario = 7 And checkStart = 4 Then
            'Capture Raid cannot start CTR
            checkStart = pickStart()

        ElseIf indexScenario = 11 Then
            'Uncontested Landing starts CTR
            checkStart = 4

        ElseIf indexScenario = 12 Then
            'Assault Drop starts CTR
            checkStart = 4

        ElseIf indexScenario = 13 And checkStart = 4 Then
            'Low Atmosphere Battle cannot start CTR
            While checkStart = 4

                checkStart = pickStart()

            End While

        ElseIf indexScenario = 14 Then
            'Space Battle starts N, enter planet's atmosphere S
            checkStart = 1

        Else

        End If

        If checkMission = 6 And checkStart = 4 Then
            'Relief Duty cannot start CTR, player is reinforcements
            While checkStart = 4

                checkStart = pickStart()

            End While

        Else

        End If

        playerStart = Generator.arrayplayerStart(checkStart)

    End Sub

    Public Function getStart()

        Return playerStart

    End Function

    Public Sub New(mission As String, scenario As Scenario)

        setifSupport(scenario)
        setnumSupport()
        setwhoSupport()
        setStart(mission, scenario)

    End Sub

End Class
