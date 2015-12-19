<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.groupAnts = New System.Windows.Forms.GroupBox()
        Me.groupTerrain = New System.Windows.Forms.GroupBox()
        Me.txtReed = New System.Windows.Forms.TextBox()
        Me.txtTree = New System.Windows.Forms.TextBox()
        Me.txtStone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDirt = New System.Windows.Forms.TextBox()
        Me.txtMoss = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrass = New System.Windows.Forms.TextBox()
        Me.checkDefaultTerrainCollection = New System.Windows.Forms.CheckBox()
        Me.btnAddAnts = New System.Windows.Forms.Button()
        Me.txtAntLifetime = New System.Windows.Forms.TextBox()
        Me.labAntLifetime = New System.Windows.Forms.Label()
        Me.txtAmountAnts = New System.Windows.Forms.TextBox()
        Me.labAmountAnts = New System.Windows.Forms.Label()
        Me.groupAnts.SuspendLayout()
        Me.groupTerrain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(13, 34)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(276, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate baseterrain"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'groupAnts
        '
        Me.groupAnts.Controls.Add(Me.groupTerrain)
        Me.groupAnts.Controls.Add(Me.checkDefaultTerrainCollection)
        Me.groupAnts.Controls.Add(Me.btnAddAnts)
        Me.groupAnts.Controls.Add(Me.btnGenerate)
        Me.groupAnts.Controls.Add(Me.txtAntLifetime)
        Me.groupAnts.Controls.Add(Me.labAntLifetime)
        Me.groupAnts.Controls.Add(Me.txtAmountAnts)
        Me.groupAnts.Controls.Add(Me.labAmountAnts)
        Me.groupAnts.Location = New System.Drawing.Point(808, 10)
        Me.groupAnts.Name = "groupAnts"
        Me.groupAnts.Size = New System.Drawing.Size(295, 489)
        Me.groupAnts.TabIndex = 4
        Me.groupAnts.TabStop = False
        Me.groupAnts.Text = "Ant control"
        '
        'groupTerrain
        '
        Me.groupTerrain.Controls.Add(Me.txtReed)
        Me.groupTerrain.Controls.Add(Me.txtTree)
        Me.groupTerrain.Controls.Add(Me.txtStone)
        Me.groupTerrain.Controls.Add(Me.Label6)
        Me.groupTerrain.Controls.Add(Me.Label5)
        Me.groupTerrain.Controls.Add(Me.Label4)
        Me.groupTerrain.Controls.Add(Me.txtDirt)
        Me.groupTerrain.Controls.Add(Me.txtMoss)
        Me.groupTerrain.Controls.Add(Me.Label3)
        Me.groupTerrain.Controls.Add(Me.Label2)
        Me.groupTerrain.Controls.Add(Me.Label1)
        Me.groupTerrain.Controls.Add(Me.txtGrass)
        Me.groupTerrain.Location = New System.Drawing.Point(7, 254)
        Me.groupTerrain.Name = "groupTerrain"
        Me.groupTerrain.Size = New System.Drawing.Size(282, 200)
        Me.groupTerrain.TabIndex = 7
        Me.groupTerrain.TabStop = False
        Me.groupTerrain.Text = "Terrain collection"
        '
        'txtReed
        '
        Me.txtReed.Location = New System.Drawing.Point(52, 159)
        Me.txtReed.Name = "txtReed"
        Me.txtReed.Size = New System.Drawing.Size(63, 20)
        Me.txtReed.TabIndex = 11
        Me.txtReed.Text = "10"
        '
        'txtTree
        '
        Me.txtTree.Location = New System.Drawing.Point(52, 133)
        Me.txtTree.Name = "txtTree"
        Me.txtTree.Size = New System.Drawing.Size(63, 20)
        Me.txtTree.TabIndex = 10
        Me.txtTree.Text = "40"
        '
        'txtStone
        '
        Me.txtStone.Location = New System.Drawing.Point(52, 106)
        Me.txtStone.Name = "txtStone"
        Me.txtStone.Size = New System.Drawing.Size(63, 20)
        Me.txtStone.TabIndex = 9
        Me.txtStone.Text = "20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Reed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tree"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stone"
        '
        'txtDirt
        '
        Me.txtDirt.Location = New System.Drawing.Point(52, 80)
        Me.txtDirt.Name = "txtDirt"
        Me.txtDirt.Size = New System.Drawing.Size(63, 20)
        Me.txtDirt.TabIndex = 5
        Me.txtDirt.Text = "20"
        '
        'txtMoss
        '
        Me.txtMoss.Location = New System.Drawing.Point(52, 52)
        Me.txtMoss.Name = "txtMoss"
        Me.txtMoss.Size = New System.Drawing.Size(63, 20)
        Me.txtMoss.TabIndex = 4
        Me.txtMoss.Text = "20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Moss"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grass"
        '
        'txtGrass
        '
        Me.txtGrass.Location = New System.Drawing.Point(52, 26)
        Me.txtGrass.Name = "txtGrass"
        Me.txtGrass.Size = New System.Drawing.Size(63, 20)
        Me.txtGrass.TabIndex = 0
        Me.txtGrass.Text = "30"
        '
        'checkDefaultTerrainCollection
        '
        Me.checkDefaultTerrainCollection.AutoSize = True
        Me.checkDefaultTerrainCollection.Location = New System.Drawing.Point(13, 219)
        Me.checkDefaultTerrainCollection.Name = "checkDefaultTerrainCollection"
        Me.checkDefaultTerrainCollection.Size = New System.Drawing.Size(160, 17)
        Me.checkDefaultTerrainCollection.TabIndex = 6
        Me.checkDefaultTerrainCollection.Text = "Use default terrain collection"
        Me.checkDefaultTerrainCollection.UseVisualStyleBackColor = True
        '
        'btnAddAnts
        '
        Me.btnAddAnts.Location = New System.Drawing.Point(13, 460)
        Me.btnAddAnts.Name = "btnAddAnts"
        Me.btnAddAnts.Size = New System.Drawing.Size(276, 23)
        Me.btnAddAnts.TabIndex = 5
        Me.btnAddAnts.Text = "Add ants"
        Me.btnAddAnts.UseVisualStyleBackColor = True
        '
        'txtAntLifetime
        '
        Me.txtAntLifetime.Location = New System.Drawing.Point(13, 174)
        Me.txtAntLifetime.Name = "txtAntLifetime"
        Me.txtAntLifetime.Size = New System.Drawing.Size(63, 20)
        Me.txtAntLifetime.TabIndex = 4
        Me.txtAntLifetime.Text = "15"
        '
        'labAntLifetime
        '
        Me.labAntLifetime.AutoSize = True
        Me.labAntLifetime.Location = New System.Drawing.Point(10, 158)
        Me.labAntLifetime.Name = "labAntLifetime"
        Me.labAntLifetime.Size = New System.Drawing.Size(82, 13)
        Me.labAntLifetime.TabIndex = 3
        Me.labAntLifetime.Text = "Lifetime in steps"
        '
        'txtAmountAnts
        '
        Me.txtAmountAnts.Location = New System.Drawing.Point(10, 113)
        Me.txtAmountAnts.Name = "txtAmountAnts"
        Me.txtAmountAnts.Size = New System.Drawing.Size(63, 20)
        Me.txtAmountAnts.TabIndex = 2
        Me.txtAmountAnts.Text = "35"
        '
        'labAmountAnts
        '
        Me.labAmountAnts.AutoSize = True
        Me.labAmountAnts.Location = New System.Drawing.Point(7, 97)
        Me.labAmountAnts.Name = "labAmountAnts"
        Me.labAmountAnts.Size = New System.Drawing.Size(66, 13)
        Me.labAmountAnts.TabIndex = 1
        Me.labAmountAnts.Text = "Amount ants"
        '
        'MapGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 514)
        Me.Controls.Add(Me.groupAnts)
        Me.Name = "MapGen"
        Me.Text = "RectangleGen"
        Me.groupAnts.ResumeLayout(False)
        Me.groupAnts.PerformLayout()
        Me.groupTerrain.ResumeLayout(False)
        Me.groupTerrain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents groupAnts As System.Windows.Forms.GroupBox
    Friend WithEvents labAmountAnts As System.Windows.Forms.Label
    Friend WithEvents btnAddAnts As System.Windows.Forms.Button
    Friend WithEvents txtAntLifetime As System.Windows.Forms.TextBox
    Friend WithEvents labAntLifetime As System.Windows.Forms.Label
    Friend WithEvents txtAmountAnts As System.Windows.Forms.TextBox
    Friend WithEvents checkDefaultTerrainCollection As System.Windows.Forms.CheckBox
    Friend WithEvents groupTerrain As System.Windows.Forms.GroupBox
    Friend WithEvents txtReed As System.Windows.Forms.TextBox
    Friend WithEvents txtTree As System.Windows.Forms.TextBox
    Friend WithEvents txtStone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDirt As System.Windows.Forms.TextBox
    Friend WithEvents txtMoss As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGrass As System.Windows.Forms.TextBox
End Class
