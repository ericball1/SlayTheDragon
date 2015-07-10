Public Class Form1

    Dim playerHealth As Integer = 100
    Dim dragonHealth As Integer = 50
    Dim playerMagic As Integer = 20
    Dim folder As String = Environment.GetEnvironmentVariable("SystemDrive") + "\Users\" + Environment.UserName + "\Documents\Slay The Dragon\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists(folder)) Then
            IO.Directory.CreateDirectory(folder)
        End If
        If My.Computer.FileSystem.FileExists(folder + "save.xml") Then
            mainText.Text = "The Fight Continues!"
            ReadXML()
        End If
        playerHealthLabel.Text = "Player Health: " + CStr(playerHealth)
        playerMagicLabel.Text = "Player Magic: " + CStr(playerMagic)
        dragonHealthLabel.Text = "Dragon Health" + CStr(dragonHealth)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles mainText.Click

    End Sub

    Private Sub useSword_Click(sender As Object, e As EventArgs) Handles useSword.Click
        dragonHealth -= 1
        dragonHealthLabel.Text = "Dragon Health: " + CStr(dragonHealth)
    End Sub

    Sub CheckHealth()

    End Sub

    Sub DragonDeath()

    End Sub

    Sub loadFile()

    End Sub

    Public Class Save
        Public Title As String
        Public playerHealth As String
        Public playerMagic As String
        Public dragonHealth As String
    End Class

    Public Sub WriteXML()
        Dim saveFile As New Save
        saveFile.Title = "Slay The Dragon Save File"
        saveFile.playerMagic = playerMagic
        saveFile.playerHealth = playerHealth
        saveFile.dragonHealth = dragonHealth
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(Save))
        Dim file As New IO.StreamWriter(folder + "save.xml")
        writer.Serialize(file, saveFile)
        file.Close()
    End Sub

    Public Sub ReadXML()
        Dim reader As New Xml.Serialization.XmlSerializer(GetType(Save))
        Dim file As New IO.StreamReader(folder + "save.xml")
        Dim overview As Save
        overview = CType(reader.Deserialize(file), Save)
        playerHealth = overview.playerHealth
        playerMagic = overview.playerMagic
        dragonHealth = overview.dragonHealth
    End Sub


    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        WriteXML()
    End Sub

    Private Sub useFireball_Click(sender As Object, e As EventArgs) Handles useFireball.Click

    End Sub

End Class
