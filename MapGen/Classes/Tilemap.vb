Public Class Tilemap
    Public Shared TileMap(39, 24) As Tile

    Public Shared Sub GenerateBaseTerrain()
        For x = 0 To 39
            For y = 0 To 24
                TileMap(x, y) = New Tile(x, y)
            Next
        Next
    End Sub

    Public Enum TerrainType
        Grass = 1
        Moss = 2
        Stone = 3
        Tree = 4
        Reed = 5
        Dirt = 6
    End Enum

    Public Shared ReadOnly Property DefaultTerrainCollectionArray() As TerrainType()
        Get
            Dim terrainCollection(5) As TerrainType
            terrainCollection(0) = TerrainType.Grass
            terrainCollection(1) = TerrainType.Moss
            terrainCollection(2) = TerrainType.Stone
            terrainCollection(3) = TerrainType.Tree
            terrainCollection(4) = TerrainType.Reed
            terrainCollection(5) = TerrainType.Dirt
            Return terrainCollection
        End Get

    End Property
End Class
