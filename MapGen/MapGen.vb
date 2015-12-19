Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class MapGen

    Private randomNo As New Random

    Private Sub RenderTerrain()
        Dim g As Graphics = Me.CreateGraphics()
        Dim rect As Rectangle
        Dim tileTextPosition As Point, tileTextFont As New Font("verdana", 8), tileTextfontBrush As New SolidBrush(Color.White)

        Dim currentTile As Tile

        For x = 0 To 39
            For y = 0 To 24
                currentTile = Tilemap.TileMap(x, y)

                tileTextPosition = New Point(currentTile.DrawCoordinates.X + 4, currentTile.DrawCoordinates.Y + 4)

                rect = New Rectangle(currentTile.DrawCoordinates.X, currentTile.DrawCoordinates.Y, 20, 20)
                g.FillRectangle(currentTile.DrawBrush, rect)

                g.DrawRectangle(Pens.Black, rect)
                g.DrawString(currentTile.TerrainChar, tileTextFont, tileTextfontBrush, tileTextPosition)
            Next

        Next
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Tilemap.GenerateBaseTerrain()
        RenderTerrain()
    End Sub

    Private Sub btnAddAnts_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAnts.Click
        Dim startTileX As Integer = 0, startTileY As Integer = 0
        Dim ant As Ant

        Dim amountAnts As Integer = CInt(txtAmountAnts.Text)
        Dim antLifespan As Integer = CInt(txtAntLifetime.Text)

        Dim terrainCollection() As Tilemap.TerrainType
        If checkDefaultTerrainCollection.Checked = True Then
            terrainCollection = Tilemap.DefaultTerrainCollectionArray()
        Else
            terrainCollection = buildTerrainCollection()
        End If

        For counter = 1 To amountAnts
            startTileX = Misc.randomNo.Next(0, 40)
            startTileY = Misc.randomNo.Next(0, 25)
            ant = New Ant(Tilemap.TileMap(startTileX, startTileY), antLifespan, terrainCollection)
        Next

        RenderTerrain()
    End Sub

    Private Function buildTerrainCollection() As Tilemap.TerrainType()
        Dim amountGrass As Integer = CInt(txtGrass.Text)
        Dim amountMoss As Integer = CInt(txtMoss.Text)
        Dim amountDirt As Integer = CInt(txtDirt.Text)
        Dim amountReed As Integer = CInt(txtReed.Text)
        Dim amountStone As Integer = CInt(txtStone.Text)
        Dim amountTree As Integer = CInt(txtTree.Text)
        Dim totalAmountInCollection = amountGrass + amountMoss + amountDirt + amountReed + amountStone + amountTree
        Dim terrainCollection(totalAmountInCollection - 1) As Tilemap.TerrainType

        Dim arrayIndex As Integer = 0

        For i = 1 To amountGrass
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Grass
            arrayIndex = arrayIndex + 1
        Next
        For i = 1 To amountMoss
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Moss
            arrayIndex = arrayIndex + 1
        Next
        For i = 1 To amountDirt
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Dirt
            arrayIndex = arrayIndex + 1
        Next
        For i = 1 To amountReed
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Reed
            arrayIndex = arrayIndex + 1
        Next
        For i = 1 To amountStone
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Stone
            arrayIndex = arrayIndex + 1
        Next
        For i = 1 To amountTree
            terrainCollection(arrayIndex) = Tilemap.TerrainType.Tree
            arrayIndex = arrayIndex + 1
        Next
        Return terrainCollection

    End Function

    Private Sub checkDefaultTerrainCollection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkDefaultTerrainCollection.CheckedChanged
        If checkDefaultTerrainCollection.Checked = True Then
            groupTerrain.Enabled = False
        Else
            groupTerrain.Enabled = True
        End If
    End Sub
End Class