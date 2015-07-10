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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.useSword = New System.Windows.Forms.Button()
        Me.useFireball = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.mainText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.playerHealthLabel = New System.Windows.Forms.Label()
        Me.playerMagicLabel = New System.Windows.Forms.Label()
        Me.dragonHealthLabel = New System.Windows.Forms.Label()
        Me.MainPanelLayout.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanelLayout
        '
        Me.MainPanelLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.MainPanelLayout.ColumnCount = 1
        Me.MainPanelLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainPanelLayout.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.MainPanelLayout.Controls.Add(Me.mainText, 0, 0)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(747, 35)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'useSword
        '
        Me.useSword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.useSword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useSword.Location = New System.Drawing.Point(4, 4)
        Me.useSword.Name = "useSword"
        Me.useSword.Size = New System.Drawing.Size(241, 27)
        Me.useSword.TabIndex = 0
        Me.useSword.Text = "Sword Attack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.useSword.UseVisualStyleBackColor = True
        '
        'useFireball
        '
        Me.useFireball.Dock = System.Windows.Forms.DockStyle.Fill
        Me.useFireball.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useFireball.Location = New System.Drawing.Point(252, 4)
        Me.useFireball.Name = "useFireball"
        Me.useFireball.Size = New System.Drawing.Size(241, 27)
        Me.useFireball.TabIndex = 1
        Me.useFireball.Text = "Fireball"
        Me.useFireball.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(500, 4)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(243, 27)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'mainText
        '
        Me.mainText.AutoSize = True
        Me.mainText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainText.Location = New System.Drawing.Point(4, 1)
        Me.mainText.Name = "mainText"
        Me.mainText.Size = New System.Drawing.Size(747, 363)
        Me.mainText.TabIndex = 1
        Me.mainText.Text = "The Fight Begins!"
        Me.mainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.playerHealthLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.playerMagicLabel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dragonHealthLabel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 410)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(747, 36)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'playerHealthLabel
        '
        Me.playerHealthLabel.AutoSize = True
        Me.playerHealthLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerHealthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerHealthLabel.Location = New System.Drawing.Point(4, 1)
        Me.playerHealthLabel.Name = "playerHealthLabel"
        Me.playerHealthLabel.Size = New System.Drawing.Size(241, 34)
        Me.playerHealthLabel.TabIndex = 0
        Me.playerHealthLabel.Text = "Player Health: 100"
        Me.playerHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'playerMagicLabel
        '
        Me.playerMagicLabel.AutoSize = True
        Me.playerMagicLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerMagicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerMagicLabel.Location = New System.Drawing.Point(252, 1)
        Me.playerMagicLabel.Name = "playerMagicLabel"
        Me.playerMagicLabel.Size = New System.Drawing.Size(241, 34)
        Me.playerMagicLabel.TabIndex = 1
        Me.playerMagicLabel.Text = "Player Magic: 20"
        Me.playerMagicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragonHealthLabel
        '
        Me.dragonHealthLabel.AutoSize = True
        Me.dragonHealthLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dragonHealthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dragonHealthLabel.Location = New System.Drawing.Point(500, 1)
        Me.dragonHealthLabel.Name = "dragonHealthLabel"
        Me.dragonHealthLabel.Size = New System.Drawing.Size(243, 34)
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
        Me.MinimumSize = New System.Drawing.Size(771, 489)
        Me.Name = "Form1"
        Me.Text = "Slay The Dragon"
        Me.MainPanelLayout.ResumeLayout(False)
        Me.MainPanelLayout.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanelLayout As TableLayoutPanel
    Friend WithEvents mainText As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents useSword As Button
    Friend WithEvents useFireball As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents playerHealthLabel As Label
    Friend WithEvents playerMagicLabel As Label
    Friend WithEvents dragonHealthLabel As Label
End Class
