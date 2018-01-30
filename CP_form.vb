Imports System
Imports System.Xml
Imports System.IO

Public Class CountryPlayer

    Dim lesChores As New Chores() 'création 

    'CHOREFULL LIST  

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

    Private Sub ButtonMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusic.Click
        If Not LabelMusicFile.Text.Equals("NF") Then
            AxWindowsMediaPlayer1.URL = LabelMusicFile.Text
        Else
            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    Private Sub ButtonPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPdf.Click
        If Not LabelPdfFile.Text.Equals("NF") Then
            AxAcroPDF1.Show()
            AxAcroPDF1.LoadFile(LabelPdfFile.Text)
        Else
            AxAcroPDF1.Hide()
        End If
    End Sub

    Private Sub ButtonChore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChore.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxChore.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button_OpenURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_OpenURL.Click
        MsgBox("https://www.youtube.com/v/" & Label_YoutubeURL.Text)
        AxShockwaveFlash2.Movie = "https://www.youtube.com/v/" & Label_YoutubeURL.Text
    End Sub

    'CHORE MANAGEMENT

    Private Sub ButtonModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModify.Click
        Dim selChore As Chore
        selChore = lesChores.Item(ListBoxDanses.SelectedIndex)
        'selChore.Nom = TextBoxName.Text
        selChore.Compte = TextBoxCount.Text
        selChore.Depart = TextBoxStart.Text
        selChore.Choregraph = TextBoxChoregraph.Text
        selChore.Music = TextBoxMusic.Text
        selChore.Artiste = TextBoxArtist.Text

        If Label_YoutubeURL.Text <> "" Then
            selChore.Youtube = TextBox_YoutubeUrl.Text
        Else
            Button_OpenURL.Enabled = False
            AxShockwaveFlash2.Hide()
        End If

    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim selChore As Chore
        selChore = lesChores.Item(ListBoxDanses.SelectedIndex)
        'ListBoxDanses.SelectedItem
        lesChores.Remove(selChore)
        'ListBoxDanses.Items.RemoveAt(ListBoxDanses.SelectedIndex)
        ListBoxDanses.Items.Clear()
        For Each _chore As Chore In lesChores
            ListBoxDanses.Items.Add(_chore.Nom)
        Next
    End Sub

    Private Sub ButtonNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        TextBoxName.Enabled = True
        TextBoxName.ResetText()
        TextBoxCount.ResetText()
        TextBoxStart.ResetText()
        TextBoxChoregraph.ResetText()
        TextBoxMusic.ResetText()
        TextBoxArtist.ResetText()
        LabelPdfFile.ResetText()
        LabelMusicFile.ResetText()
        TextBox_YoutubeUrl.ResetText()
        ButtonAdd.Enabled = True

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim laChore As Chore
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
        Else
            MsgBox("Le Nom de la danse est obligatoire !")
        End If

    End Sub

    'PARAMETERS 
    Private Sub Button_Init_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Init.Click
        Dim laChore As Chore
        Dim document1 As XmlReader = New XmlTextReader(TextBoxChore.Text.ToString())
        Dim i As Integer
        ProgressBar_Dance.Minimum = 0
        lesChores.init()
        ButtonAdd.Enabled = False
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

        ListBoxDanses.Items.Clear()
        For Each _chore As Chore In lesChores
            ListBoxDanses.Items.Add(_chore.Nom)
        Next
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
            document.Close()
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

    'PLAYLISTE

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        'Load a playlist and display in listBox_PL
        If (TextBoxList.Text = "") Then
            If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                TextBoxList.Text = OpenFileDialog1.FileName
            End If
        End If
        'Open the file for reading
        FileOpen(1, TextBoxList.Text, OpenMode.Input) ' Ouvre en lecture.
        While Not EOF(1) ' Boucler jusqu'à la fin du fichier
            ListBox_PL.Items.Add(LineInput(1))
        End While
        'trie le tableau
        If (System.IO.File.Exists(TextBoxList.Text.ToString())) Then
            ListBox_PL.Sorted = True
        Else
            MessageBox.Show("The filename you selected was not found.")
        End If
        FileClose(1) ' Fermer.
    End Sub

    Private Sub ListBox_PL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_PL.SelectedIndexChanged
        'RAZ buton
        ButtonMusic.Enabled = True
        ButtonPdf.Enabled = True
        Button_OpenURL.Enabled = True
        TextBoxName.Enabled = False
        AxAcroPDF1.LoadFile("none")

        Dim selChore As Chore
        selChore = lesChores.GetChore(ListBox_PL.SelectedItem)
        If Not (IsNothing(selChore)) Then
            TextBoxName.Text = UCase(selChore.Nom)
            TextBoxCount.Text = selChore.Compte
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
        End If

    End Sub

    Private Sub Button_AddPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddPL.Click
        ListBox_PL.Items.Add(ListBoxDanses.SelectedItem)
    End Sub
End Class
