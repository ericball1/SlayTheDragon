<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MainPanelLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.useSword = New System.Windows.Forms.Button()
        Me.useFireball = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.playerHealthLabel = New System.Windows.Forms.Label()
        Me.playerMagicLevel = New System.Windows.Forms.Label()
        Me.dragonHealthLabel = New System.Windows.Forms.Label()
        Me.MainPanelLayout.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanelLayout
        '
        Me.MainPanelLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.MainPanelLayout.ColumnCount = 1
        Me.MainPanelLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainPanelLayout.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.MainPanelLayout.Controls.Add(Me.Label1, 0, 0)
        Me.MainPanelLayout.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.MainPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanelLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainPanelLayout.Name = "MainPanelLayout"
        Me.MainPanelLayout.RowCount = 3
        Me.MainPanelLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.43323!))
        Me.MainPanelLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.283387!))
        Me.MainPanelLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.283387!))
        Me.MainPanelLayout.Size = New System.Drawing.Size(755, 450)
        Me.MainPanelLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 363)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.playerHealthLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.playerMagicLevel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dragonHealthLabel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 410)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(747, 36)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.useSword, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.useFireball, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.saveButton, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 368)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(747, 35)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'useSword
        '
        Me.useSword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.useSword.Location = New System.Drawing.Point(3, 3)
        Me.useSword.Name = "useSword"
        Me.useSword.Size = New System.Drawing.Size(243, 29)
        Me.useSword.TabIndex = 0
        Me.useSword.Text = "Sword Attack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.useSword.UseVisualStyleBackColor = True
        '
        'useFireball
        '
        Me.useFireball.Dock = System.Windows.Forms.DockStyle.Fill
        Me.useFireball.Location = New System.Drawing.Point(252, 3)
        Me.useFireball.Name = "useFireball"
        Me.useFireball.Size = New System.Drawing.Size(243, 29)
        Me.useFireball.TabIndex = 1
        Me.useFireball.Text = "Fireball"
        Me.useFireball.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.saveButton.Location = New System.Drawing.Point(501, 3)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(243, 29)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'playerHealthLabel
        '
        Me.playerHealthLabel.AutoSize = True
        Me.playerHealthLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerHealthLabel.Location = New System.Drawing.Point(3, 0)
        Me.playerHealthLabel.Name = "playerHealthLabel"
        Me.playerHealthLabel.Size = New System.Drawing.Size(243, 36)
        Me.playerHealthLabel.TabIndex = 0
        Me.playerHealthLabel.Text = "Player Health: 100"
        Me.playerHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'playerMagicLevel
        '
        Me.playerMagicLevel.AutoSize = True
        Me.playerMagicLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerMagicLevel.Location = New System.Drawing.Point(252, 0)
        Me.playerMagicLevel.Name = "playerMagicLevel"
        Me.playerMagicLevel.Size = New System.Drawing.Size(243, 36)
        Me.playerMagicLevel.TabIndex = 1
        Me.playerMagicLevel.Text = "Player Magic: 10"
        Me.playerMagicLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragonHealthLabel
        '
        Me.dragonHealthLabel.AutoSize = True
        Me.dragonHealthLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dragonHealthLabel.Location = New System.Drawing.Point(501, 0)
        Me.dragonHealthLabel.Name = "dragonHealthLabel"
        Me.dragonHealthLabel.Size = New System.Drawing.Size(243, 36)
        Me.dragonHealthLabel.TabIndex = 2
        Me.dragonHealthLabel.Text = "Dragon Health: 50"
        Me.dragonHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 450)
        Me.Controls.Add(Me.MainPanelLayout)
        Me.Name = "Form1"
        Me.Text = "Slay The Dragon"
        Me.MainPanelLayout.ResumeLayout(False)
        Me.MainPanelLayout.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanelLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents useSword As Button
    Friend WithEvents useFireball As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents playerHealthLabel As Label
    Friend WithEvents playerMagicLevel As Label
    Friend WithEvents dragonHealthLabel As Label
End Class
