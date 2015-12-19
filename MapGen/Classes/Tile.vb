Public Class Tile

    Public TileTerrainType As Tilemap.TerrainType = Tilemap.TerrainType.Grass
    Public GridX, GridY As Integer
    Public DrawCoordinates As Point
    Public ReadOnly Property TerrainChar As Char
        Get
            Return Left(TileTerrainType.ToString(), 1)
        End Get
    End Property

    Public ReadOnly Property DrawBrush As SolidBrush
        Get
            Select Case TileTerrainType
                Case Tilemap.TerrainType.Grass
                    Return New SolidBrush(Color.LightGreen)
                Case Tilemap.TerrainType.Moss
                    Return New SolidBrush(Color.DarkGreen)
                Case Tilemap.TerrainType.Stone
                    Return New SolidBrush(Color.Gray)
                Case Tilemap.TerrainType.Tree
                    Return New SolidBrush(Color.Chocolate)
                Case Tilemap.TerrainType.Reed
                    Return New SolidBrush(Color.DarkRed)
                Case Tilemap.TerrainType.Dirt
                    Return New SolidBrush(Color.SandyBrown)
            End Select
            Return New SolidBrush(Color.LightGreen)
        End Get
    End Property


    Public Sub New(ByVal tileGridLocationX As Integer, ByVal tileGridLocationY As Integer)
        GridX = tileGridLocationX
        GridY = tileGridLocationY
        DrawCoordinates = New Point(tileGridLocationX * 20, tileGridLocationY * 20)
    End Sub




End Class
