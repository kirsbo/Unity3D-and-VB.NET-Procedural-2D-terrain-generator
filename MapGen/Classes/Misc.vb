Public Class Misc
    Public Shared randomNo As New Random

    Public Shared Function rnd(ByVal minValue As Integer, ByVal maxValue As Integer) As Integer 'Return random number
        Dim randomGenerator = New Random
        Return randomGenerator.Next
        randomGenerator = Nothing
    End Function
End Class
