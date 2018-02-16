Imports System
Imports System.Xml
Imports System.IO

Public Class CountryPlayer

    Dim lesChores As New Chores() 'création 
    Dim choreChange As Integer = 0

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        If (TextBoxList.Text = "") Then
            If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                TextBoxList.Text = OpenFileDialog1.FileName
            End If
        End If
        Dim document As XmlReader = New XmlTextReader(TextBoxList.Text.ToString())
        While (document.Read())
            Dim type = document.NodeType
            If (type = XmlNodeType.Element) Then
                If (document.Name = "Name") Then
                    Dim danse = document.ReadInnerXml.ToString()
                    If danse <> "" Then
                        ListBoxDanses.Items.Add(danse)
                    End If
                End If
            End If
        End While
        If (System.IO.File.Exists(TextBoxList.Text.ToString())) Then
            ListBoxDanses.Sorted = True
        Else
            MessageBox.Show("The filename you selected was not found.")
        End If

    End Sub

    Private Sub ListBoxDanses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxDanses.SelectedIndexChanged
        'RAZ buton
        ButtonMusic.Enabled = True
        ButtonPdf.Enabled = True
        Button_OpenURL.Enabled = True
        TextBoxName.Enabled = False
        AxAcroPDF1.LoadFile("none")

        Dim selChore As Chore
        selChore = lesChores.Item(ListBoxDanses.SelectedIndex)
        TextBoxName.Text = UCase(selChore.Nom)
        TextBoxCount.Text = selChore.Compte
        TextBoxLevel.Text = selChore.Niveau
        TextBoxStart.Text = selChore.Depart
        TextBoxChoregraph.Text = selChore.Choregraph
        TextBoxMusic.Text = selChore.Music
        TextBoxArtist.Text = selChore.Artiste
        LabelPdfFile.Text = PdfInFolder(TextBoxPdfPath.Text, TextBoxName.Text)
        LabelMusicFile.Text = MusicInFolder(TextBoxMusicPath.Text, TextBoxName.Text)
        TextBox_YoutubeUrl.Text = selChore.Youtube

        If TextBox_YoutubeUrl.Text <> "" Then
            AxShockwaveFlash2.Show()
        Else
            Button_OpenURL.Enabled = False
            AxShockwaveFlash2.Hide()
        End If

        If LabelMusicFile.Text = "NF" Then
            ButtonMusic.Enabled = False
        End If

        If LabelPdfFile.Text = "NF" Then
            ButtonPdf.Enabled = False
        End If

    End Sub

    Private Sub ButtonPdfPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPdfPath.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxPdfPath.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ButtonMusicPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusicPath.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxMusicPath.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Function FileInFolder(ByVal folderPath As String, ByVal fileName As String) As String
        Dim i As Integer
        Dim strFile As String
        FileInFolder = "NF"
        For i = 0 To My.Computer.FileSystem.GetFiles(folderPath).Count - 1
            strFile = My.Computer.FileSystem.GetFiles(folderPath).Item(i)
            If InStr(UCase(strFile), UCase(fileName), ) > 0 Then
                FileInFolder = strFile
                'Debug.Print(strFile)
                Exit For
            End If
        Next i
        Return FileInFolder

    End Function

    Private Function MusicInFolder(ByVal folderPath As String, ByVal searchFile As String) As String
        ' https://docs.microsoft.com/fr-fr/dotnet/visual-basic/developing-apps/programming/drives-directories-files/walkthrough-manipulating-files-and-directories

        MusicInFolder = "NF"
        Dim fileNames As String() =
            System.IO.Directory.GetFiles(folderPath,
                "*.mp3", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            If InStr(UCase(fileName), UCase(searchFile), ) > 0 Then
                MusicInFolder = fileName
                'Debug.Print(strFile)

                Exit For
            End If
        Next
        Return MusicInFolder
    End Function

    Private Function PdfInFolder(ByVal folderPath As String, ByVal searchFile As String) As String
        ' https://docs.microsoft.com/fr-fr/dotnet/visual-basic/developing-apps/programming/drives-directories-files/walkthrough-manipulating-files-and-directories

        PdfInFolder = "NF"
        Dim fileNames As String() =
            System.IO.Directory.GetFiles(folderPath,
                "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            If InStr(UCase(fileName), UCase(searchFile), ) > 0 Then
                PdfInFolder = fileName
                'Debug.Print(strFile)

                Exit For
            End If
        Next
        Return PdfInFolder
    End Function


    Private Sub ButtonParamLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonParamLoad.Click
        If (System.IO.File.Exists(TextBoxConfig.Text.ToString())) Then
            Dim document As XmlReader = New XmlTextReader(TextBoxConfig.Text.ToString())
            While (document.Read())
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                    If (document.Name = "Chore") Then
                        TextBoxChore.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "PDF") Then
                        TextBoxPdfPath.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Music") Then
                        TextBoxMusicPath.Text = document.ReadInnerXml.ToString()
                    End If
                End If
            End While
        End If
    End Sub

    Private Sub ButtonParamSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonParamSave.Click
        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create(TextBoxConfig.Text.ToString(), settings)

        With XmlWrt

            ' Write the Xml declaration.
            .WriteStartDocument() 
            ' Write a comment.
            .WriteComment("XML Database.")

            ' Write the root element.
            .WriteStartElement("Configs")

            ' Start directories.
            .WriteStartElement("directories")

            .WriteStartElement("Chore")
            .WriteString(TextBoxChore.Text.ToString())
            .WriteEndElement()

            .WriteStartElement("PDF")
            .WriteString(TextBoxPdfPath.Text.ToString())
            .WriteEndElement()

            .WriteStartElement("Music")
            .WriteString(TextBoxMusicPath.Text.ToString())
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndElement()

            .Close()
        End With
    End Sub



    Private Sub ButtonPdf_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPdf.Click
        If Not LabelPdfFile.Text.Equals("NF") Then
            AxAcroPDF1.Show()
            AxAcroPDF1.LoadFile(LabelPdfFile.Text)
        Else
            AxAcroPDF1.Hide()
        End If
    End Sub

    Private Sub Button_Init_Click(sender As System.Object, e As System.EventArgs) Handles Button_Init.Click
        Load_Danses()
    End Sub

    Private Sub ButtonChore_Click(sender As System.Object, e As System.EventArgs) Handles ButtonChore.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxChore.Text = OpenFileDialog1.FileName
        End If
    End Sub


    Private Sub Button_OpenURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OpenURL.Click
        MsgBox("https://www.youtube.com/v/" & Label_YoutubeURL.Text)
        AxShockwaveFlash2.Movie = "https://www.youtube.com/v/" & Label_YoutubeURL.Text
    End Sub

    Private Sub ButtonModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModify.Click
        TextBoxCount.Enabled = True
        TextBoxStart.Enabled = True
        TextBoxLevel.Enabled = True
        TextBoxChoregraph.Enabled = True
        TextBoxMusic.Enabled = True
        TextBoxArtist.Enabled = True
        Button_Valider.Enabled = True
        choreChange = 1
        ButtonNew.Enabled = False
        ButtonDelete.Enabled = False
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If MsgBox("Confirmer la suppression ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Button_Valider.Enabled = True
            ButtonModify.Enabled = False
            ButtonNew.Enabled = False
            choreChange = 2
        End If
    End Sub

    Private Sub ButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        TextBoxName.ResetText()
        TextBoxCount.ResetText()
        TextBoxStart.ResetText()
        TextBoxChoregraph.ResetText()
        TextBoxMusic.ResetText()
        TextBoxArtist.ResetText()
        LabelPdfFile.ResetText()
        LabelMusicFile.ResetText()
        TextBox_YoutubeUrl.ResetText()
        Button_Valider.Enabled = True
        ButtonModify.Enabled = False
        ButtonDelete.Enabled = False
        choreChange = 3
    End Sub

    Private Sub Button_Valider_Click(sender As System.Object, e As System.EventArgs) Handles Button_Valider.Click
        Dim laChore As Chore
        If choreChange = 1 Then
            laChore = lesChores.Item(ListBoxDanses.SelectedIndex)
            'selChore.Nom = TextBoxName.Text
            laChore.Compte = TextBoxCount.Text
            laChore.Depart = TextBoxStart.Text
            laChore.Niveau = TextBoxLevel.Text
            laChore.Choregraph = TextBoxChoregraph.Text
            laChore.Music = TextBoxMusic.Text
            laChore.Artiste = TextBoxArtist.Text

            If Label_YoutubeURL.Text <> "" Then
                laChore.Youtube = TextBox_YoutubeUrl.Text
            Else
                Button_OpenURL.Enabled = False
                AxShockwaveFlash2.Hide()
            End If
            chore_reset()
            Button_DanseSave.Enabled = True
        End If
        If choreChange = 2 Then
            laChore = lesChores.Item(ListBoxDanses.SelectedIndex)
            'ListBoxDanses.SelectedItem
            lesChores.Remove(laChore)
            ListBoxDanses.Items.Clear()
            For Each _chore As Chore In lesChores
                ListBoxDanses.Items.Add(_chore.Nom)
                ListBox_All.Items.Add(_chore.Nom)
            Next
            chore_reset()
            Button_DanseSave.Enabled = True
        End If
        If choreChange = 3 Then
            If TextBoxName.Text <> "" Then
                laChore = lesChores.Add(TextBoxName.Text)    'Ajout d'une chore avec le nom
                laChore.Niveau = TextBoxLevel.Text
                laChore.Compte = TextBoxCount.Text
                laChore.Depart = TextBoxStart.Text
                laChore.Choregraph = TextBoxChoregraph.Text
                laChore.Youtube = TextBox_YoutubeUrl.Text
                laChore.Music = TextBoxMusic.Text
                laChore.Artiste = TextBoxArtist.Text
                laChore.PdfPath = TextBoxPdfPath.Text
            End If
            chore_reset()
            Button_DanseSave.Enabled = True
        End If

    End Sub



    Private Sub Button_DanseSave_Click(sender As System.Object, e As System.EventArgs) Handles Button_DanseSave.Click
        Dim settings As New XmlWriterSettings()
        Dim i As Integer
        settings.Indent = True
        ProgressBar_Dance.Minimum = 0
        ProgressBar_Dance.Maximum = lesChores.Count
        ' Initialize the XmlWriter.
        'Dim SaveDanse As String = "c:\Git\Country-Player-Dance\res\CountryDanses_save.xml"
        'Dim XmlWrt As XmlWriter = XmlWriter.Create(SaveDanse, settings)
        Dim XmlWrt As XmlWriter = XmlWriter.Create(TextBoxChore.Text.ToString(), settings)
        With XmlWrt

            ' Write the Xml declaration.
            .WriteStartDocument()
            ' Write a comment.
            .WriteComment("XML Database.")

            ' Write the root element.
            .WriteStartElement("Danses")
            i = 1
            For Each _chore As Chore In lesChores

                ' Write the dance element.
                .WriteStartElement("Danse")

                .WriteStartElement("Name")
                .WriteString(_chore.Nom)
                .WriteEndElement()

                .WriteStartElement("Niveau")
                .WriteString(_chore.Niveau)
                .WriteEndElement()

                .WriteStartElement("Compte")
                .WriteString(_chore.Compte)
                .WriteEndElement()

                .WriteStartElement("Depart")
                .WriteString(_chore.Depart)
                .WriteEndElement()

                .WriteStartElement("Choregraphe")
                .WriteString(_chore.Choregraph)
                .WriteEndElement()

                .WriteStartElement("Youtube")
                .WriteString(_chore.Youtube)
                .WriteEndElement()

                .WriteStartElement("Musique")
                .WriteString(_chore.Music)
                .WriteEndElement()

                .WriteStartElement("Artiste")
                .WriteString(_chore.Artiste)
                .WriteEndElement()

                .WriteEndElement()
                ProgressBar_Dance.Value() = i
                i = i + 1
            Next
            .WriteEndElement()
            .Close()
        End With
        Button_DanseSave.Enabled = False
    End Sub


    Private Sub CountryPlayer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (System.IO.File.Exists(TextBoxConfig.Text.ToString())) Then
            Dim document As XmlReader = New XmlTextReader(TextBoxConfig.Text.ToString())
            While (document.Read())
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                    If (document.Name = "Chore") Then
                        TextBoxChore.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "PDF") Then
                        TextBoxPdfPath.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Music") Then
                        TextBoxMusicPath.Text = document.ReadInnerXml.ToString()
                    End If
                End If
            End While
        End If

        chore_reset()
        Button_DanseSave.Enabled = False
        Load_Danses()
    End Sub

    Private Sub Load_Danses()
        Dim laChore As Chore
        Dim document1 As XmlReader = New XmlTextReader(TextBoxChore.Text.ToString())
        Dim i As Integer
        ProgressBar_Dance.Minimum = 0
        lesChores.init()
        i = 0
        While (document1.Read())
            Dim type = document1.NodeType
            If (type = XmlNodeType.Element) Then
                If (document1.Name = "Name") Then
                    Dim danse = document1.ReadInnerXml.ToString()
                    If danse <> "" Then
                        i = i + 1
                    End If
                End If
            End If
        End While
        ProgressBar_Dance.Maximum = i
        LabelCount.Text = i
        i = 1
        Dim document As XmlReader = New XmlTextReader(TextBoxChore.Text.ToString())
        While (document.Read())
            Dim type = document.NodeType
            If (type = XmlNodeType.Element) Then
                If (document.Name = "Name") Then
                    Dim danse = document.ReadInnerXml.ToString()
                    If danse <> "" Then
                        laChore = lesChores.Add(danse)    'Ajout d'une chore avec le nom
                        'Récupère le niveau
                        document.ReadToNextSibling("Niveau")
                        laChore.Niveau = document.ReadInnerXml.ToString()
                        'Récupère le compte
                        document.ReadToNextSibling("Compte")
                        laChore.Compte = document.ReadInnerXml.ToString()
                        'Récupère le depart
                        document.ReadToNextSibling("Depart")
                        laChore.Depart = document.ReadInnerXml.ToString()
                        'Récupère le choregraph
                        document.ReadToNextSibling("Choregraphe")
                        laChore.Choregraph = document.ReadInnerXml.ToString()
                        'Récupère l url Youtube
                        document.ReadToNextSibling("Youtube")
                        laChore.Youtube = document.ReadInnerXml.ToString()
                        'Récupère la musique
                        document.ReadToNextSibling("Musique")
                        laChore.Music = document.ReadInnerXml.ToString()
                        'Récupère l'artiste
                        document.ReadToNextSibling("Artiste")
                        laChore.Artiste = document.ReadInnerXml.ToString()
                        'Récupère le chemin du pdf
                        'laChore.PdfPath = PdfInFolder(TextBoxPdfPath.Text, danse)
                        ''Récupère le chemin du music
                        'laChore.MusicPath = MusicInFolder(TextBoxMusicPath.Text, danse)
                        ProgressBar_Dance.Value() = i
                        i = i + 1
                    End If
                End If
            End If

        End While
        'LabelCount.Text = lesChores.Count 'connaître le nombre de chores

        ListBox_All.Items.Clear()
        ListBoxDanses.Items.Clear()

        For Each _chore As Chore In lesChores
            ListBox_All.Items.Add(_chore.Nom)
            ListBoxDanses.Items.Add(_chore.Nom)
        Next
    End Sub

    Private Sub chore_reset()
        TextBoxCount.Enabled = False
        TextBoxStart.Enabled = False
        TextBoxLevel.Enabled = False
        TextBoxChoregraph.Enabled = False
        TextBoxMusic.Enabled = False
        TextBoxArtist.Enabled = False
        Button_Valider.Enabled = False
        ButtonModify.Enabled = True
        ButtonNew.Enabled = True
        ButtonDelete.Enabled = True
    End Sub

    Private Sub ButtonMusic_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMusic.Click
        If Not LabelMusicFile.Text.Equals("NF") Then
            AxWindowsMediaPlayer1.URL = LabelMusicFile.Text
        Else
            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

End Class

