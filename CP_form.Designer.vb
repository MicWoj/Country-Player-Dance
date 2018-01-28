<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountryPlayer
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountryPlayer))
        Me.ListBoxDanses = New System.Windows.Forms.ListBox()
        Me.TabPage = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.ButtonPdf = New System.Windows.Forms.Button()
        Me.LabelPdfFile = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button_OpenURL = New System.Windows.Forms.Button()
        Me.Label_YoutubeURL = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.Button_Init = New System.Windows.Forms.Button()
        Me.TextBoxChore = New System.Windows.Forms.TextBox()
        Me.ButtonChore = New System.Windows.Forms.Button()
        Me.TextBoxConfig = New System.Windows.Forms.TextBox()
        Me.ButtonParamLoad = New System.Windows.Forms.Button()
        Me.ButtonParamSave = New System.Windows.Forms.Button()
        Me.TextBoxMusicPath = New System.Windows.Forms.TextBox()
        Me.ButtonMusicPath = New System.Windows.Forms.Button()
        Me.TextBoxPdfPath = New System.Windows.Forms.TextBox()
        Me.ButtonPdfPath = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonMusic = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.TextBoxList = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.TextBoxCount = New System.Windows.Forms.TextBox()
        Me.TextBoxStart = New System.Windows.Forms.TextBox()
        Me.TextBoxChoregraph = New System.Windows.Forms.TextBox()
        Me.TextBoxMusic = New System.Windows.Forms.TextBox()
        Me.TextBoxArtist = New System.Windows.Forms.TextBox()
        Me.LabelMusicFile = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProgressBar_Dance = New System.Windows.Forms.ProgressBar()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxShockwaveFlash2 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.TabPage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxDanses
        '
        Me.ListBoxDanses.FormattingEnabled = True
        Me.ListBoxDanses.Location = New System.Drawing.Point(12, 60)
        Me.ListBoxDanses.Name = "ListBoxDanses"
        Me.ListBoxDanses.Size = New System.Drawing.Size(230, 498)
        Me.ListBoxDanses.TabIndex = 0
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.TabPage2)
        Me.TabPage.Controls.Add(Me.TabPage3)
        Me.TabPage.Controls.Add(Me.TabPage4)
        Me.TabPage.Controls.Add(Me.TabPage5)
        Me.TabPage.Location = New System.Drawing.Point(509, 15)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(503, 543)
        Me.TabPage.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AxShockwaveFlash1)
        Me.TabPage2.Controls.Add(Me.ButtonPdf)
        Me.TabPage2.Controls.Add(Me.LabelPdfFile)
        Me.TabPage2.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(495, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PDF"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(554, 42)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(192, 192)
        Me.AxShockwaveFlash1.TabIndex = 19
        '
        'ButtonPdf
        '
        Me.ButtonPdf.Location = New System.Drawing.Point(6, 13)
        Me.ButtonPdf.Name = "ButtonPdf"
        Me.ButtonPdf.Size = New System.Drawing.Size(84, 24)
        Me.ButtonPdf.TabIndex = 18
        Me.ButtonPdf.Text = "Ouvrir PDF"
        Me.ButtonPdf.UseVisualStyleBackColor = True
        '
        'LabelPdfFile
        '
        Me.LabelPdfFile.AutoSize = True
        Me.LabelPdfFile.Location = New System.Drawing.Point(105, 19)
        Me.LabelPdfFile.Name = "LabelPdfFile"
        Me.LabelPdfFile.Size = New System.Drawing.Size(72, 13)
        Me.LabelPdfFile.TabIndex = 1
        Me.LabelPdfFile.Text = "PDF File Path"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(6, 42)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(483, 469)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AxShockwaveFlash2)
        Me.TabPage3.Controls.Add(Me.Button_OpenURL)
        Me.TabPage3.Controls.Add(Me.Label_YoutubeURL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(495, 517)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Youtube"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button_OpenURL
        '
        Me.Button_OpenURL.Location = New System.Drawing.Point(6, 13)
        Me.Button_OpenURL.Name = "Button_OpenURL"
        Me.Button_OpenURL.Size = New System.Drawing.Size(84, 24)
        Me.Button_OpenURL.TabIndex = 20
        Me.Button_OpenURL.Text = "Ouvrir Youtube"
        Me.Button_OpenURL.UseVisualStyleBackColor = True
        '
        'Label_YoutubeURL
        '
        Me.Label_YoutubeURL.AutoSize = True
        Me.Label_YoutubeURL.Location = New System.Drawing.Point(114, 16)
        Me.Label_YoutubeURL.Name = "Label_YoutubeURL"
        Me.Label_YoutubeURL.Size = New System.Drawing.Size(72, 13)
        Me.Label_YoutubeURL.TabIndex = 19
        Me.Label_YoutubeURL.Text = "Youtube URL"
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(495, 517)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Edition"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.LabelCount)
        Me.TabPage5.Controls.Add(Me.Button_Init)
        Me.TabPage5.Controls.Add(Me.TextBoxChore)
        Me.TabPage5.Controls.Add(Me.ButtonChore)
        Me.TabPage5.Controls.Add(Me.TextBoxConfig)
        Me.TabPage5.Controls.Add(Me.ButtonParamLoad)
        Me.TabPage5.Controls.Add(Me.ButtonParamSave)
        Me.TabPage5.Controls.Add(Me.TextBoxMusicPath)
        Me.TabPage5.Controls.Add(Me.ButtonMusicPath)
        Me.TabPage5.Controls.Add(Me.TextBoxPdfPath)
        Me.TabPage5.Controls.Add(Me.ButtonPdfPath)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(495, 517)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Parametres"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(481, 50)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(39, 13)
        Me.LabelCount.TabIndex = 16
        Me.LabelCount.Text = "Label1"
        '
        'Button_Init
        '
        Me.Button_Init.Location = New System.Drawing.Point(400, 47)
        Me.Button_Init.Name = "Button_Init"
        Me.Button_Init.Size = New System.Drawing.Size(75, 23)
        Me.Button_Init.TabIndex = 15
        Me.Button_Init.Text = "Init"
        Me.Button_Init.UseVisualStyleBackColor = True
        '
        'TextBoxChore
        '
        Me.TextBoxChore.Location = New System.Drawing.Point(72, 50)
        Me.TextBoxChore.Name = "TextBoxChore"
        Me.TextBoxChore.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxChore.TabIndex = 14
        Me.TextBoxChore.Text = ".\Chores.xml"
        '
        'ButtonChore
        '
        Me.ButtonChore.Location = New System.Drawing.Point(7, 50)
        Me.ButtonChore.Name = "ButtonChore"
        Me.ButtonChore.Size = New System.Drawing.Size(59, 23)
        Me.ButtonChore.TabIndex = 13
        Me.ButtonChore.Text = "Chore"
        Me.ButtonChore.UseVisualStyleBackColor = True
        '
        'TextBoxConfig
        '
        Me.TextBoxConfig.Location = New System.Drawing.Point(72, 11)
        Me.TextBoxConfig.Name = "TextBoxConfig"
        Me.TextBoxConfig.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxConfig.TabIndex = 12
        Me.TextBoxConfig.Text = ".\config.xml"
        '
        'ButtonParamLoad
        '
        Me.ButtonParamLoad.Location = New System.Drawing.Point(7, 11)
        Me.ButtonParamLoad.Name = "ButtonParamLoad"
        Me.ButtonParamLoad.Size = New System.Drawing.Size(59, 23)
        Me.ButtonParamLoad.TabIndex = 11
        Me.ButtonParamLoad.Text = "Config"
        Me.ButtonParamLoad.UseVisualStyleBackColor = True
        '
        'ButtonParamSave
        '
        Me.ButtonParamSave.Location = New System.Drawing.Point(400, 11)
        Me.ButtonParamSave.Name = "ButtonParamSave"
        Me.ButtonParamSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonParamSave.TabIndex = 10
        Me.ButtonParamSave.Text = "Sauver"
        Me.ButtonParamSave.UseVisualStyleBackColor = True
        '
        'TextBoxMusicPath
        '
        Me.TextBoxMusicPath.Location = New System.Drawing.Point(72, 129)
        Me.TextBoxMusicPath.Name = "TextBoxMusicPath"
        Me.TextBoxMusicPath.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxMusicPath.TabIndex = 9
        Me.TextBoxMusicPath.Text = ".\Music\"
        '
        'ButtonMusicPath
        '
        Me.ButtonMusicPath.Location = New System.Drawing.Point(7, 127)
        Me.ButtonMusicPath.Name = "ButtonMusicPath"
        Me.ButtonMusicPath.Size = New System.Drawing.Size(59, 23)
        Me.ButtonMusicPath.TabIndex = 8
        Me.ButtonMusicPath.Text = "Music Dir"
        Me.ButtonMusicPath.UseVisualStyleBackColor = True
        '
        'TextBoxPdfPath
        '
        Me.TextBoxPdfPath.Location = New System.Drawing.Point(72, 89)
        Me.TextBoxPdfPath.Name = "TextBoxPdfPath"
        Me.TextBoxPdfPath.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxPdfPath.TabIndex = 7
        Me.TextBoxPdfPath.Text = ".\Fiches\"
        '
        'ButtonPdfPath
        '
        Me.ButtonPdfPath.Location = New System.Drawing.Point(7, 87)
        Me.ButtonPdfPath.Name = "ButtonPdfPath"
        Me.ButtonPdfPath.Size = New System.Drawing.Size(59, 23)
        Me.ButtonPdfPath.TabIndex = 6
        Me.ButtonPdfPath.Text = "PDF Dir"
        Me.ButtonPdfPath.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(131, 306)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(84, 33)
        Me.ButtonAdd.TabIndex = 18
        Me.ButtonAdd.Text = "Ajouter"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(131, 267)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(84, 33)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Supprimer"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(6, 267)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(84, 33)
        Me.ButtonModify.TabIndex = 14
        Me.ButtonModify.Text = "Modifier"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'ButtonMusic
        '
        Me.ButtonMusic.Location = New System.Drawing.Point(262, 402)
        Me.ButtonMusic.Name = "ButtonMusic"
        Me.ButtonMusic.Size = New System.Drawing.Size(47, 24)
        Me.ButtonMusic.TabIndex = 16
        Me.ButtonMusic.Text = "LOAD"
        Me.ButtonMusic.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(14, 34)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(71, 24)
        Me.ButtonLoad.TabIndex = 2
        Me.ButtonLoad.Text = "PlayListe"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'TextBoxList
        '
        Me.TextBoxList.Location = New System.Drawing.Point(91, 37)
        Me.TextBoxList.Name = "TextBoxList"
        Me.TextBoxList.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxList.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Niveau"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Compte"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Départ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Choregraphe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Musique"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Artiste"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(49, 58)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(39, 20)
        Me.TextBoxLevel.TabIndex = 8
        '
        'TextBoxCount
        '
        Me.TextBoxCount.Location = New System.Drawing.Point(143, 59)
        Me.TextBoxCount.Name = "TextBoxCount"
        Me.TextBoxCount.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxCount.TabIndex = 9
        '
        'TextBoxStart
        '
        Me.TextBoxStart.Location = New System.Drawing.Point(140, 97)
        Me.TextBoxStart.Name = "TextBoxStart"
        Me.TextBoxStart.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxStart.TabIndex = 10
        '
        'TextBoxChoregraph
        '
        Me.TextBoxChoregraph.Location = New System.Drawing.Point(78, 135)
        Me.TextBoxChoregraph.Name = "TextBoxChoregraph"
        Me.TextBoxChoregraph.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxChoregraph.TabIndex = 11
        '
        'TextBoxMusic
        '
        Me.TextBoxMusic.Location = New System.Drawing.Point(57, 177)
        Me.TextBoxMusic.Name = "TextBoxMusic"
        Me.TextBoxMusic.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxMusic.TabIndex = 12
        '
        'TextBoxArtist
        '
        Me.TextBoxArtist.Location = New System.Drawing.Point(57, 220)
        Me.TextBoxArtist.Name = "TextBoxArtist"
        Me.TextBoxArtist.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxArtist.TabIndex = 13
        '
        'LabelMusicFile
        '
        Me.LabelMusicFile.Location = New System.Drawing.Point(315, 407)
        Me.LabelMusicFile.Name = "LabelMusicFile"
        Me.LabelMusicFile.Size = New System.Drawing.Size(178, 19)
        Me.LabelMusicFile.TabIndex = 17
        Me.LabelMusicFile.Text = "Music  File Path"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(262, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(231, 383)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ButtonNew)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.TextBox2)
        Me.TabPage6.Controls.Add(Me.ButtonModify)
        Me.TabPage6.Controls.Add(Me.ButtonDelete)
        Me.TabPage6.Controls.Add(Me.ButtonAdd)
        Me.TabPage6.Controls.Add(Me.TextBoxStart)
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Controls.Add(Me.Label3)
        Me.TabPage6.Controls.Add(Me.TextBoxCount)
        Me.TabPage6.Controls.Add(Me.TextBoxLevel)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Controls.Add(Me.Label2)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.TextBoxName)
        Me.TabPage6.Controls.Add(Me.TextBoxArtist)
        Me.TabPage6.Controls.Add(Me.TextBoxChoregraph)
        Me.TabPage6.Controls.Add(Me.TextBoxMusic)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(223, 357)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Chore"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(6, 306)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(84, 33)
        Me.ButtonNew.TabIndex = 23
        Me.ButtonNew.Text = "Nouveau"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Musique"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(53, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 22
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ListBox1)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(223, 357)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Toutes"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 511)
        Me.ListBox1.TabIndex = 0
        '
        'ProgressBar_Dance
        '
        Me.ProgressBar_Dance.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar_Dance.Name = "ProgressBar_Dance"
        Me.ProgressBar_Dance.Size = New System.Drawing.Size(230, 19)
        Me.ProgressBar_Dance.TabIndex = 19
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(262, 429)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(242, 129)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'AxShockwaveFlash2
        '
        Me.AxShockwaveFlash2.Enabled = True
        Me.AxShockwaveFlash2.Location = New System.Drawing.Point(42, 78)
        Me.AxShockwaveFlash2.Name = "AxShockwaveFlash2"
        Me.AxShockwaveFlash2.OcxState = CType(resources.GetObject("AxShockwaveFlash2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash2.Size = New System.Drawing.Size(192, 192)
        Me.AxShockwaveFlash2.TabIndex = 21
        '
        'CountryPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1029, 563)
        Me.Controls.Add(Me.ProgressBar_Dance)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LabelMusicFile)
        Me.Controls.Add(Me.ButtonMusic)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TextBoxList)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.TabPage)
        Me.Controls.Add(Me.ListBoxDanses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "CountryPlayer"
        Me.Text = "Country Player"
        Me.TabPage.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxDanses As System.Windows.Forms.ListBox
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents TextBoxList As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxPdfPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPdfPath As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TextBoxMusicPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonMusicPath As System.Windows.Forms.Button
    Friend WithEvents ButtonParamLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonParamSave As System.Windows.Forms.Button
    Friend WithEvents TextBoxConfig As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonMusic As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonModify As System.Windows.Forms.Button
    Friend WithEvents ButtonPdf As System.Windows.Forms.Button
    Friend WithEvents LabelPdfFile As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLevel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStart As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxChoregraph As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMusic As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxArtist As System.Windows.Forms.TextBox
    Friend WithEvents LabelMusicFile As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBar_Dance As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBoxChore As System.Windows.Forms.TextBox
    Friend WithEvents ButtonChore As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button_Init As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Button_OpenURL As System.Windows.Forms.Button
    Friend WithEvents Label_YoutubeURL As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash2 As AxShockwaveFlashObjects.AxShockwaveFlash

End Class
