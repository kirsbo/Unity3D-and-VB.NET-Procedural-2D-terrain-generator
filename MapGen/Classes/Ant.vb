Public Class Ant
    Private currentTile As Tile
    Private randomNo As New Random


    Public Sub New(ByVal startTile As Tile, ByVal lifespan As Integer, ByVal terrainCollection() As Tilemap.TerrainType)

        currentTile = startTile

        For counter = 1 To lifespan
            MoveAnt()
            changeTerrain(currentTile, terrainCollection)
        Next
    End Sub

    Private Sub MoveAnt()
        Dim xToAdd, yToAdd As Integer

        Do
            xToAdd = Misc.randomNo.Next(-1, 2)
        Loop Until xIsValid(currentTile.GridX + xToAdd)

        Do
            yToAdd = Misc.randomNo.Next(-1, 2)
        Loop Until yIsValid(currentTile.GridY + yToAdd)

        currentTile = Tilemap.TileMap(currentTile.GridX + xToAdd, currentTile.GridY + yToAdd)

    End Sub

    Private Sub changeTerrain(ByRef tileToChange As Tile, ByRef terrainCollection() As Tilemap.TerrainType)
        tileToChange.TileTerrainType = terrainCollection(Misc.randomNo.Next(1, terrainCollection.Count))
    End Sub

#Region "Validator functions"
    Private Function xIsValid(ByVal x As Integer) As Boolean
        'Making sure that parent function (MoveAnt) does not attempt to move the ant to a X coordinate on the tilemap, that doesn't exist.
        'This would result in a overflow error in the tilemap array. The tilemap X coordinates are from 0 to 39.
        If x > -1 And x < 40 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function yIsValid(ByVal y As Integer) As Boolean
        'Same as xIsValid function, but for Y coordinates.
        If y > -1 And y < 25 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function locationIsValid(ByVal tileLocation As Integer)
        If tileLocation > 0 And tileLocation < 1000 Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region
End Class
