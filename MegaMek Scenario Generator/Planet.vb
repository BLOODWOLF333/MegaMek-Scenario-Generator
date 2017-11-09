Public Class Planet

    Dim n As String
    Dim p As Integer
    Dim g As Decimal
    Dim pW As Integer
    Dim t As Integer
    Dim s As Integer
    Dim aO As String

    Public Sub New(name As String, pressure As Integer, gravity As Decimal, percentWater As Integer, temperature As Integer, satellite As Integer,
                   axisOrbit As String)

        n = name
        p = pressure
        g = gravity
        pW = percentWater
        t = temperature
        s = satellite
        aO = axisOrbit

    End Sub

End Class
