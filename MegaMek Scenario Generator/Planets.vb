Imports System.Xml
Imports System.Text
Imports System.IO
Imports System.Linq

Public Class Planets

    Private xmlPlanets As XElement = getXML()
    Public listPlanets As New List(Of Planet)

    Private Sub loadPlanets()

        Dim listNames As IEnumerable(Of String) =
        From element In xmlPlanets.<planet>
        Let name = element.<name>.Value
        Order By name
        Select name
        For Each name As String In listNames

            Generator.cbPlanets.Items.Add(name)

        Next

        For Each element In xmlPlanets.<planet>

            Dim name = element.<name>.Value
            Dim pressure = element.<pressure>.Value
            Dim gravity = element.<gravity>.Value
            Dim percentWater = element.<percentWater>.Value
            Dim temperature = element.<temperature>.Value
            Dim satellite = element.<satellite>.Value
            Dim axisOrbit = element.<axisOrbit>.Value
            listPlanets.Add(New Planet(name, pressure, gravity, percentWater, temperature, satellite, axisOrbit))

        Next

    End Sub

    Private Function getXML()

        Try

            Dim xmlPlanets = XElement.Load(My.Application.Info.DirectoryPath & "\planets.xml")
            Return xmlPlanets

        Catch ex As FileNotFoundException

            MessageBox.Show("XML file does not exist in target directory.", "File Not Found")
            Return Nothing

        Catch ex As IOException

            MessageBox.Show("Input / output error.", "IO Exception")
            Return Nothing

        Catch ex As Exception

            MessageBox.Show("An error occured.", "Generic Error")
            Return Nothing

        End Try

    End Function

    Public Sub New()

        loadPlanets()

    End Sub

End Class
