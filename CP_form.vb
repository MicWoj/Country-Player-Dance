Imports System
Imports System.Xml
Imports System.IO

Public Class CountryPlayer
    Dim lesChores As New Chores() 'création 
    Dim playList As ArrayList
    Dim choregraphList As ArrayList
    Dim artistList As ArrayList
    Dim savePlPath As String
    Dim choreChange As Integer = 0
    Dim pdfFile As String = "pdf"
    Dim change As Boolean = False

    Private Sub CountryPlayer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ' Read and set the config file directories
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
                        If (document.Name = "PlayList") Then
                            TextBoxPLPath.Text = document.ReadInnerXml.ToString()
                        End If
                    End If
                End While
                document.Close()
            End If
            chore_reset()
            Button_DanseSave.Enabled = False
            Load_Danses()
            Init_PL()
    End Sub
    '**************************************************************************************************************************
    ' *** PARAMETERS ***
    '**************************************************************************************************************************
    Private Sub ButtonPdfPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxPdfPath.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ButtonMusicPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxMusicPath.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub ButtonPLPath_Click(sender As System.Object, e As System.EventArgs)
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBoxPLPath.Text = FolderBrowserDialog1.SelectedPath & "\"
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
        'Dim _sFileName As Array
        'Dim _sShortName As String
        Dim lenDance As Integer
        Dim fileNamePath As String
        Dim fileNames As String() =
            System.IO.Directory.GetFiles(folderPath,
            "*.mp3", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            '_sFileName = Split(fileName, "-")
            '_sShortName = _sFileName(0)
            fileNamePath = fileName
            lenDance = Len(searchFile)
            fileName = Mid(eFileName(fileName), 1, lenDance)
            If InStr(UCase(fileName), UCase(searchFile), ) > 0 Then
                MusicInFolder = fileNamePath
                'Debug.Print(strFile)
                Exit For
            End If
        Next
        Return MusicInFolder
    End Function

    Private Function PdfInFolder(ByVal folderPath As String, ByVal searchFile As String) As String
        ' https://docs.microsoft.com/fr-fr/dotnet/visual-basic/developing-apps/programming/drives-directories-files/walkthrough-manipulating-files-and-directories

        PdfInFolder = "NF"
        Dim lenDance As Integer
        Dim fileNamePath As String
        Dim fileNames As String() =
            System.IO.Directory.GetFiles(folderPath,
                "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            fileNamePath = fileName
            lenDance = Len(searchFile)
            fileName = Mid(eFileName(fileName), 1, lenDance)
            If InStr(UCase(fileName), UCase(searchFile), ) > 0 Then
                PdfInFolder = fileNamePath
                'Debug.Print(strFile)

                Exit For
            End If
        Next
        Return PdfInFolder
    End Function

    Private Sub ButtonParamLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    If (document.Name = "PlayList") Then
                        TextBoxMusicPath.Text = document.ReadInnerXml.ToString()
                    End If
                End If
            End While
            document.Close()
        End If
    End Sub

    Private Sub ButtonParamSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            Beep()

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

            .WriteStartElement("PlayList")
            .WriteString(TextBoxPLPath.Text.ToString())
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndElement()

            .Close()
        End With
    End Sub

    Private Sub ButtonPdf_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPdf.Click
        If Not LabelPdfFile.Text.Equals("NF") Then
            AxAcroPDF1.Show()
            AxAcroPDF1.LoadFile(TextBoxPdfPath.Text & LabelPdfFile.Text)
        Else
            AxAcroPDF1.Hide()
        End If
    End Sub
    Private Sub Button_Youtube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Youtube.Click
        If TextBox_Youtube.Text <> "" Then
            Process.Start(TextBox_Youtube.Text)
        End If
    End Sub

    Private Sub Button_Init_Click(sender As System.Object, e As System.EventArgs)
        Load_Danses()
    End Sub

    Private Sub ButtonChore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxChore.Text = OpenFileDialog1.FileName
        End If
    End Sub

    '**************************************************************************************************************************
    ' *** PLAYLIST  ***
    '**************************************************************************************************************************

    Private Sub ComboBox_PL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_PL.SelectedIndexChanged
        'Dim line As String
        'Dim i As Integer

        If ComboBox_PL.SelectedIndex <> 0 Then
            Button_vu.Enabled = True
            CheckBox_Tri.Checked = False
            Button_SauverList.Enabled = True
            InitPlayList()
            'savePlPath = ComboBox_PL.SelectedItem
            'savePlPath = TextBoxPLPath.Text & savePlPath
            'FileOpen(1, savePlPath, OpenMode.Input) ' Ouvre en lecture.
            'CListBoxDance.Items.Clear()
            'playList = New ArrayList()
            'i = 0
            'While Not EOF(1) ' Boucler jusqu'à la fin du fichier
            '    line = Replace(LineInput(1), Chr(34), "")
            '    If i > 0 Then
            '        playList.Add(line)
            '    End If
            '    i = 1
            'End While
            'FileClose(1) ' Fermer.
            'load_PL()
        Else
            CListBoxDance.Items.Clear()
            For Each _danse As String In ListBox_All.Items
                CListBoxDance.Items.Add(_danse)
            Next
            Label_NbPL.Text = CListBoxDance.Items.Count
        End If
        LabelPdfFile.Text = ""
        LabelMusicFile.Text = ""
    End Sub

    Private Sub CListBoxDance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CListBoxDance.SelectedIndexChanged
        Dim selChore As Chore

        'RAZ buton
        ButtonMusic.Enabled = True
        ButtonPdf.Enabled = True
        'Button_OpenURL.Enabled = True
        TextBoxName.Enabled = False
        AxAcroPDF1.LoadFile("none")

        selChore = lesChores.getItem(selDance(CListBoxDance.SelectedItem))
        If selChore Is Nothing Then
            MsgBox("La choregraphie n'a pas été trouvé dans la liste des danses")
        Else
            TextBoxName.Text = UCase(selChore.Nom)
            TextBoxCount.Text = selChore.Compte
            TextBoxLevel.Text = selChore.Niveau
            TextBoxStart.Text = selChore.Depart
            TextBoxChoregraph.Text = selChore.Choregraph
            TextBoxMusic.Text = selChore.Music
            TextBoxArtist.Text = selChore.Artiste
            TextBox_Comment.Text = selChore.Comment
            'If Not change Then
            LabelPdfFile.Text = eFileName(PdfInFolder(TextBoxPdfPath.Text, TextBoxName.Text))
            pdfFile = LabelPdfFile.Text
            'End If
            LabelMusicFile.Text = eFileName(MusicInFolder(TextBoxMusicPath.Text, TextBoxName.Text))
            If selChore.Youtube <> "" Then
                TextBox_Youtube.Text = "https://www.youtube.com/watch?v=" & selChore.Youtube
                Button_Youtube.Enabled = True
            Else
                TextBox_Youtube.Text = ""
                Button_Youtube.Enabled = False
            End If
            'TextBox_YoutubeUrl.Text = selChore.Youtube

            'If TextBox_YoutubeUrl.Text <> "" Then
            '    'AxShockwaveFlash2.Show()
            'Else
            '    Button_OpenURL.Enabled = False
            '    'AxShockwaveFlash2.Hide()
            'End If

            If LabelMusicFile.Text = "NF" Then
                ButtonMusic.Enabled = False
            End If

            If LabelPdfFile.Text = "NF" Then
                ButtonPdf.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button_EffacerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_EffacerList.Click
        CListBoxDance.Items.Clear()

    End Sub

    Private Sub Button_AjouterList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AjouterList.Click
        playList.Add(ListBox_All.SelectedItem)
        load_PL()
    End Sub

    Private Sub Button_PlHaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PlHaut.Click
        Dim i As Integer = 0
        Dim _choreprv As String = ""
        Dim _chore As String = ""
        i = CListBoxDance.SelectedIndex
        If i > 0 Then
            _chore = selDance(CListBoxDance.Items(i))
            _choreprv = selDance(CListBoxDance.Items(i - 1))
            playList.Item(i) = _choreprv
            playList.Item(i - 1) = _chore
            load_PL()
            CListBoxDance.SetSelected(i - 1, True)
        End If
    End Sub

    Private Sub Button_PlBas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_PlBas.Click
        Dim i As Integer = 0
        Dim _choresvt As String = ""
        Dim _chore As String = ""
        i = CListBoxDance.SelectedIndex

        If i < playList.Count - 1 Then
            _chore = selDance(CListBoxDance.Items(i))
            _choresvt = selDance(CListBoxDance.Items(i + 1))

            playList.Item(i) = _choresvt
            playList.Item(i + 1) = _chore
            load_PL()
            CListBoxDance.SetSelected(i + 1, True)

        End If
    End Sub

    Private Sub Button_EnleverList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_EnleverList.Click
        playList.Remove(selDance(CListBoxDance.SelectedItem))
        load_PL()
    End Sub
    Private Sub Button_Texte_Click(sender As System.Object, e As System.EventArgs) Handles Button_Texte.Click
        playList.Add(TextBox_texte.Text)
        load_PL()
    End Sub


    Private Sub Button_NewPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_NewPL.Click
        playList = New ArrayList()
        CListBoxDance.Items.Clear()
        savePlPath = ""
        ComboBox_PL.ResetText()
    End Sub

    Private Sub load_PL()
        Dim _plItem As String
        Dim i As Integer
        CListBoxDance.Items.Clear()
        i = 1
        For Each _plItem In playList
            CListBoxDance.Items.Add(inDance(selDance(_plItem), i))
            If InStr(_plItem, "X") Then
                CListBoxDance.SetItemChecked(i - 1, True)
            End If
            i = i + 1
        Next
        Label_NbPL.Text = playList.Count
    End Sub

    Private Sub Button_vu_Click(sender As System.Object, e As System.EventArgs) Handles Button_vu.Click
        SauverList()
    End Sub
    Private Sub Button_rienvu_Click(sender As System.Object, e As System.EventArgs) Handles Button_rienvu.Click
        Dim i As Integer
        i = 1
        For Each _plItem In playList
            CListBoxDance.SetItemChecked(i - 1, False)
            i = i + 1
        Next
    End Sub
    Private Sub Button_SauverList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SauverList.Click
        SauverList()
    End Sub
    Private Sub SauverList()
        Dim savePL As String
        Dim outDance As String
        Dim i As Integer
        Dim newPl As Boolean = False
        If savePlPath = "" Then
            savePL = InputBox("Nom de la PlayList", "PlayList Save")
            If savePL <> "" Then
                savePlPath = TextBoxPLPath.Text & savePL & ".txt"
                newPl = True
            Else
                Exit Sub
            End If
        End If
        FileOpen(1, savePlPath, OpenMode.Output) ' Ouvre en ecriture premiere ligne.
        WriteLine(1, "Playlist : " & ComboBox_PL.SelectedItem)
        FileClose(1) ' Fermer.
        FileOpen(1, savePlPath, OpenMode.Append) ' Ouvre en ecriture.
        i = 0
        For Each _danse In CListBoxDance.Items
            If CListBoxDance.GetItemChecked(i) = True Then
                outDance = "X: " & outPlDance(_danse)
            Else
                outDance = outPlDance(_danse)
            End If
            i = i + 1
            WriteLine(1, outDance)
        Next
        FileClose(1) ' Fermer.
        If newPl Then
            ComboBox_PL.Items.Add(savePlPath)
        End If
        MsgBox("Sauvegarde terminé !")
    End Sub


    '**************************************************************************************************************************
    ' *** CHORE  ***
    '**************************************************************************************************************************

    Private Sub ButtonMusic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMusic.Click
        If Not LabelMusicFile.Text.Equals("NF") Then
            AxWindowsMediaPlayer1.URL = TextBoxMusicPath.Text & LabelMusicFile.Text
        Else
            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    'Private Sub Button_OpenURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    MsgBox("https://www.youtube.com/v/" & Label_YoutubeURL.Text)
    '    'Me.AxShockwaveFlash2.Movie = "https://www.youtube.com/v/" & Label_YoutubeURL.Text

    'End Sub

    Private Sub ButtonModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModify.Click
        TextBoxCount.Enabled = True
        TextBoxStart.Enabled = True
        TextBoxLevel.Enabled = True
        TextBoxChoregraph.Enabled = True
        TextBoxMusic.Enabled = True
        TextBoxArtist.Enabled = True
        Button_Valider.Enabled = True
        TextBox_Youtube.Enabled = True
        TextBox_Comment.Enabled = True
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
        TextBoxLevel.ResetText()
        TextBoxChoregraph.ResetText()
        TextBoxMusic.ResetText()
        TextBoxArtist.ResetText()
        TextBox_Comment.ResetText()
        LabelPdfFile.ResetText()
        LabelMusicFile.ResetText()
        TextBox_Youtube.ResetText()
        Button_Valider.Enabled = True
        ButtonModify.Enabled = False
        ButtonDelete.Enabled = False
        choreChange = 3
        chore_set()
    End Sub
    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        chore_reset()
    End Sub

    Private Sub Button_Valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Valider.Click
        Dim laChore As Chore
        Dim _youtube As String
        If choreChange = 1 Then
            laChore = lesChores.getItem(selDance(CListBoxDance.SelectedItem))
            If MsgBox("Voulez vous modifier la chore : " & laChore.Nom & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'selChore.Nom = TextBoxName.Text
                laChore.Compte = TextBoxCount.Text
                laChore.Depart = TextBoxStart.Text
                laChore.Niveau = TextBoxLevel.Text
                laChore.Choregraph = TextBoxChoregraph.Text
                laChore.Music = TextBoxMusic.Text
                laChore.Artiste = TextBoxArtist.Text
                laChore.Comment = TextBox_Comment.Text
                _youtube = Mid(TextBox_Youtube.Text, InStr(TextBox_Youtube.Text, "=") + 1)
                If _youtube <> "" Then
                    laChore.Youtube = _youtube
                Else
                    Button_Youtube.Enabled = False
                    'AxShockwaveFlash2.Hide()
                End If
            End If

            chore_reset()
            Button_DanseSave.Enabled = True
        End If
        If choreChange = 2 Then
            laChore = lesChores.getItem(CListBoxDance.SelectedItem)
            'CListBoxDance.SelectedItem
            lesChores.Remove(laChore)
            CListBoxDance.Items.Clear()
            For Each _chore As Chore In lesChores
                CListBoxDance.Items.Add(_chore.Nom)
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
                'laChore.Youtube = TextBox_YoutubeUrl.Text
                laChore.Music = TextBoxMusic.Text
                laChore.Artiste = TextBoxArtist.Text
                laChore.PdfPath = TextBoxPdfPath.Text
                laChore.Comment = TextBox_Comment.Text

            End If
            chore_reset()
            Button_DanseSave.Enabled = True
        End If

    End Sub

    Private Sub Button_DanseSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_DanseSave.Click
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
        Load_Danses()
        ComboBox_PL.SelectedIndex = 0
    End Sub



    '*************************************************************************************************************************
    ' *** FUNCTIONS  ***
    '**************************************************************************************************************************

    Private Sub Load_Danses()
        If TextBoxChore.Text <> "" Then
            Dim laChore As Chore
            Dim document1 As XmlReader = New XmlTextReader(TextBoxChore.Text.ToString())
            Dim i As Integer, j As Integer
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
            document1.Close()
            ProgressBar_Dance.Maximum = i
            ProgressBar_Dance.Minimum = 0
            LabelCount.Text = i
            Label_NbPL.Text = i
            i = 0
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
                            'Récupère le commentaire
                            document.ReadToNextSibling("Comment")
                            laChore.Comment = document.ReadInnerXml.ToString()
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
            document.Close()
            ListBox_All.Items.Clear()
            CListBoxDance.Items.Clear()
            'For Each _chore As Chore In lesChores
            '    Debug.Print(_chore.Nom)
            'Next
            For Each _chore As Chore In lesChores
                ListBox_All.Items.Add(_chore.Nom)
            Next
            j = 1
            For Each _danse As String In ListBox_All.Items
                CListBoxDance.Items.Add(j & " : " & _danse)
                j = j + 1
            Next
            Label_NbPL.Text = CListBoxDance.Items.Count

        End If

    End Sub
    Private Sub Init_PL()
        ComboBox_PL.Items.Add("All")
        ComboBox_PL.SelectedIndex = 0
        If TextBoxPLPath.Text <> "" Then
            For Each fichier As String In My.Computer.FileSystem.GetFiles(TextBoxPLPath.Text)
                ComboBox_PL.Items.Add(eFileName(fichier))
            Next
        End If
    End Sub

    Private Sub chore_reset()
        TextBoxName.Enabled = False
        TextBoxCount.Enabled = False
        TextBoxStart.Enabled = False
        TextBoxLevel.Enabled = False
        TextBoxChoregraph.Enabled = False
        TextBoxMusic.Enabled = False
        TextBoxArtist.Enabled = False
        TextBox_Youtube.Enabled = False
        TextBox_Comment.Enabled = False
        Button_Valider.Enabled = False
        Button_Youtube.Enabled = False
        ButtonModify.Enabled = True
        ButtonNew.Enabled = True
        ButtonDelete.Enabled = True
    End Sub

    Private Sub chore_set()
        TextBoxName.Enabled = True
        TextBoxCount.Enabled = True
        TextBoxStart.Enabled = True
        TextBoxLevel.Enabled = True
        TextBoxChoregraph.Enabled = True
        TextBoxMusic.Enabled = True
        TextBoxArtist.Enabled = True
        TextBox_Youtube.Enabled = True
        TextBox_Comment.Enabled = True
        Button_Valider.Enabled = True
        ButtonModify.Enabled = False
        ButtonNew.Enabled = False
        ButtonDelete.Enabled = False
    End Sub

    Private Function inDance(_chore As String, _num As Integer) As String
        Dim level As String
        level = getLevelDance(_chore)
        If level = "" Then
            inDance = _num & " : " & _chore
        Else
            inDance = _num & " (" & level & ") " & " : " & _chore
        End If
    End Function

    Private Function selDance(_dance As String) As String
        Dim pos As Integer
        pos = InStr(_dance, ":")
        If pos > 0 Then
            selDance = Mid(_dance, pos + 2)
        Else
            selDance = _dance
        End If
        pos = InStr(selDance, ":")
        If pos > 0 Then
            selDance = Mid(selDance, pos + 1)
        End If
    End Function
    Private Function outPlDance(_dance As String) As String
        outPlDance = Mid(_dance, InStr(_dance, ":") + 2)
    End Function
    Private Function eFileName(fileName As String) As String
        Dim pos As Integer
        While InStr(fileName, "\") > 0
            pos = InStr(fileName, "\")
            fileName = Mid(fileName, pos + 1)
        End While
        eFileName = fileName
    End Function
    Private Sub CheckBox_Tri_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox_Tri.CheckedChanged
        If CheckBox_Tri.Checked = True Then
            playList.Sort()
            load_PL()
            Button_vu.Enabled = False
            Button_SauverList.Enabled = False
        Else
            InitPlayList()
            Button_vu.Enabled = True
            Button_SauverList.Enabled = True
        End If

    End Sub

    Private Sub InitPlayList()
        Dim i As Integer, line As String
        savePlPath = ComboBox_PL.SelectedItem
        savePlPath = TextBoxPLPath.Text & savePlPath
        FileOpen(1, savePlPath, OpenMode.Input) ' Ouvre en lecture.
        CListBoxDance.Items.Clear()
        playList = New ArrayList()
        i = 0
        While Not EOF(1) ' Boucler jusqu'à la fin du fichier
            line = Replace(LineInput(1), Chr(34), "")
            If i > 0 Then
                playList.Add(line)
            End If
            i = 1
        End While
        FileClose(1) ' Fermer.
        load_PL()
    End Sub
    Private Sub getChoreGraph()
        Dim trouve As Boolean
        choregraphList = New ArrayList()
        For Each _chore As Chore In lesChores
            trouve = False
            For Each _choregraph As String In choregraphList
                If _choregraph.Equals(_chore.Choregraph) Then
                    trouve = True
                End If
            Next
            If Not trouve Then
                choregraphList.Add(_chore.Choregraph)
                ListBox_Choregraphe.Items.Add(_chore.Choregraph)
            End If
        Next
    End Sub
    Private Sub getArtistes()
        Dim trouve As Boolean
        artistList = New ArrayList()
        For Each _chore As Chore In lesChores
            trouve = False
            For Each _artist As String In artistList
                If _artist.Equals(_chore.Artiste) Then
                    trouve = True
                End If
            Next
            If Not trouve Then
                artistList.Add(_chore.Artiste)
                ListBox_Artiste.Items.Add(_chore.Artiste)
            End If
        Next
    End Sub

    Private Function getLevelDance(selDance As String) As String
        getLevelDance = ""
        For Each _chore As Chore In lesChores
            'If _chore.Nom.Equals(selDance) Then
            If UCase(_chore.Nom) = UCase(selDance) Then
                getLevelDance = _chore.Niveau
            End If
        Next
    End Function
    Private Sub Button_initChoregraph_Click(sender As System.Object, e As System.EventArgs) Handles Button_initChoregraph.Click
        ListBox_Choregraphe.Items.Clear()
        getChoreGraph()
    End Sub
    Private Sub ListBox_Choregraphe_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox_Choregraphe.SelectedIndexChanged
        CListBoxDance.Items.Clear()
        Dim i As Integer = 0
        For Each _chore As Chore In lesChores
            If _chore.Choregraph.Equals(ListBox_Choregraphe.SelectedItem) Then
                'If InStr(_chore.Choregraph, ListBox_Choregraphe.SelectedItem) Then
                CListBoxDance.Items.Add(_chore.Nom)
                i = i + 1
            End If
        Next
        Label_NbPL.Text = i
        ComboBox_PL.Text = "Choregraph Liste"
    End Sub

    Private Sub Button_Picture_Click(sender As System.Object, e As System.EventArgs) Handles Button_Picture.Click
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox_Picture.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub TextBox_Picture_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_Picture.TextChanged
        If InStr(TextBox_Picture.Text, "jpg") Then
            AxAcroPDF2.Visible = False
            PictureBox_Editor.Load(TextBox_Picture.Text)
        End If
        If InStr(TextBox_Picture.Text, "pdf") Then
            AxAcroPDF2.Visible = True
            AxAcroPDF2.LoadFile(TextBox_Picture.Text)
        End If
    End Sub

    'Private Sub LabelPdfFile_TextChanged(sender As System.Object, e As System.EventArgs) Handles LabelPdfFile.TextChanged
    '    If Not LabelPdfFile.Text.Equals("NF") Then
    '        AxAcroPDF1.Show()
    '        AxAcroPDF1.LoadFile(TextBoxPdfPath.Text & LabelPdfFile.Text)
    '    Else
    '        AxAcroPDF1.Hide()
    '    End If
    '    If pdfFile = LabelPdfFile.Text Then
    '        change = True
    '    Else
    '        change = False
    '    End If
    'End Sub

    Private Sub Button_initArtistes_Click(sender As System.Object, e As System.EventArgs) Handles Button_initArtistes.Click
        ListBox_Artiste.Items.Clear()
        getArtistes()
    End Sub
    Private Sub ListBox_Artiste_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ListBox_Artiste.SelectedIndexChanged
        CListBoxDance.Items.Clear()
        Dim i As Integer = 0
        For Each _chore As Chore In lesChores
            If _chore.Artiste.Equals(ListBox_Artiste.SelectedItem) Then
                'If InStr(_chore.Choregraph, ListBox_Choregraphe.SelectedItem) Then
                CListBoxDance.Items.Add(_chore.Nom)
                i = i + 1
            End If
        Next
        Label_NbPL.Text = i
        ComboBox_PL.Text = "Artistes Liste"
    End Sub

End Class

