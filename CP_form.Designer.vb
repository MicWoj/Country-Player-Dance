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
        Me.TabPage_pdf = New System.Windows.Forms.TabPage()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.ButtonPdf = New System.Windows.Forms.Button()
        Me.LabelPdfFile = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.TabPage_Youtube = New System.Windows.Forms.TabPage()
        Me.TextBox_YoutubeUrl = New System.Windows.Forms.TextBox()
        Me.AxShockwaveFlash2 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Button_OpenURL = New System.Windows.Forms.Button()
        Me.Label_YoutubeURL = New System.Windows.Forms.Label()
        Me.TabPage_Parametre = New System.Windows.Forms.TabPage()
        Me.TextBoxPLPath = New System.Windows.Forms.TextBox()
        Me.ButtonPLPath = New System.Windows.Forms.Button()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.ProgressBar_Dance = New System.Windows.Forms.ProgressBar()
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Chore = New System.Windows.Forms.TabPage()
        Me.LabelMusicFile = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Valider = New System.Windows.Forms.Button()
        Me.ButtonMusic = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxArtist = New System.Windows.Forms.TextBox()
        Me.TextBoxMusic = New System.Windows.Forms.TextBox()
        Me.TextBoxChoregraph = New System.Windows.Forms.TextBox()
        Me.TextBoxStart = New System.Windows.Forms.TextBox()
        Me.TextBoxCount = New System.Windows.Forms.TextBox()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Button_DanseSave = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage_Danses = New System.Windows.Forms.TabPage()
        Me.Button_NewPL = New System.Windows.Forms.Button()
        Me.Button_EffacerList = New System.Windows.Forms.Button()
        Me.Button_SauverList = New System.Windows.Forms.Button()
        Me.Button_EnleverList = New System.Windows.Forms.Button()
        Me.Button_AjouterList = New System.Windows.Forms.Button()
        Me.ListBox_All = New System.Windows.Forms.ListBox()
        Me.Label_NbPL = New System.Windows.Forms.Label()
        Me.ComboBox_PL = New System.Windows.Forms.ComboBox()
        Me.TabPage.SuspendLayout()
        Me.TabPage_pdf.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Youtube.SuspendLayout()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Parametre.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Chore.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Danses.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxDanses
        '
        Me.ListBoxDanses.BackColor = System.Drawing.Color.LemonChiffon
        Me.ListBoxDanses.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBoxDanses.FormattingEnabled = True
        Me.ListBoxDanses.Location = New System.Drawing.Point(12, 82)
        Me.ListBoxDanses.Name = "ListBoxDanses"
        Me.ListBoxDanses.Size = New System.Drawing.Size(230, 472)
        Me.ListBoxDanses.TabIndex = 0
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.TabPage_pdf)
        Me.TabPage.Controls.Add(Me.TabPage_Youtube)
        Me.TabPage.Controls.Add(Me.TabPage_Parametre)
        Me.TabPage.Location = New System.Drawing.Point(509, 12)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(503, 543)
        Me.TabPage.TabIndex = 1
        '
        'TabPage_pdf
        '
        Me.TabPage_pdf.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TabPage_pdf.BackgroundImage = Global.CP_xml.My.Resources.Resources.Fond_paper
        Me.TabPage_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_pdf.Controls.Add(Me.AxShockwaveFlash1)
        Me.TabPage_pdf.Controls.Add(Me.ButtonPdf)
        Me.TabPage_pdf.Controls.Add(Me.LabelPdfFile)
        Me.TabPage_pdf.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage_pdf.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_pdf.Name = "TabPage_pdf"
        Me.TabPage_pdf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_pdf.Size = New System.Drawing.Size(495, 517)
        Me.TabPage_pdf.TabIndex = 1
        Me.TabPage_pdf.Text = "PDF"
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
        Me.ButtonPdf.BackColor = System.Drawing.Color.Tan
        Me.ButtonPdf.Location = New System.Drawing.Point(6, 13)
        Me.ButtonPdf.Name = "ButtonPdf"
        Me.ButtonPdf.Size = New System.Drawing.Size(84, 24)
        Me.ButtonPdf.TabIndex = 18
        Me.ButtonPdf.Text = "Ouvrir PDF"
        Me.ButtonPdf.UseVisualStyleBackColor = False
        '
        'LabelPdfFile
        '
        Me.LabelPdfFile.AutoSize = True
        Me.LabelPdfFile.Location = New System.Drawing.Point(105, 19)
        Me.LabelPdfFile.Name = "LabelPdfFile"
        Me.LabelPdfFile.Size = New System.Drawing.Size(0, 13)
        Me.LabelPdfFile.TabIndex = 1
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
        'TabPage_Youtube
        '
        Me.TabPage_Youtube.BackgroundImage = Global.CP_xml.My.Resources.Resources.Fond_paper
        Me.TabPage_Youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Youtube.Controls.Add(Me.TextBox_YoutubeUrl)
        Me.TabPage_Youtube.Controls.Add(Me.AxShockwaveFlash2)
        Me.TabPage_Youtube.Controls.Add(Me.Button_OpenURL)
        Me.TabPage_Youtube.Controls.Add(Me.Label_YoutubeURL)
        Me.TabPage_Youtube.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Youtube.Name = "TabPage_Youtube"
        Me.TabPage_Youtube.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Youtube.Size = New System.Drawing.Size(495, 517)
        Me.TabPage_Youtube.TabIndex = 2
        Me.TabPage_Youtube.Text = "Youtube"
        Me.TabPage_Youtube.UseVisualStyleBackColor = True
        '
        'TextBox_YoutubeUrl
        '
        Me.TextBox_YoutubeUrl.Location = New System.Drawing.Point(96, 16)
        Me.TextBox_YoutubeUrl.Name = "TextBox_YoutubeUrl"
        Me.TextBox_YoutubeUrl.Size = New System.Drawing.Size(219, 20)
        Me.TextBox_YoutubeUrl.TabIndex = 22
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
        'Button_OpenURL
        '
        Me.Button_OpenURL.BackColor = System.Drawing.Color.Tan
        Me.Button_OpenURL.Location = New System.Drawing.Point(6, 13)
        Me.Button_OpenURL.Name = "Button_OpenURL"
        Me.Button_OpenURL.Size = New System.Drawing.Size(84, 24)
        Me.Button_OpenURL.TabIndex = 20
        Me.Button_OpenURL.Text = "Ouvrir Youtube"
        Me.Button_OpenURL.UseVisualStyleBackColor = False
        '
        'Label_YoutubeURL
        '
        Me.Label_YoutubeURL.AutoSize = True
        Me.Label_YoutubeURL.Location = New System.Drawing.Point(6, 40)
        Me.Label_YoutubeURL.Name = "Label_YoutubeURL"
        Me.Label_YoutubeURL.Size = New System.Drawing.Size(72, 13)
        Me.Label_YoutubeURL.TabIndex = 19
        Me.Label_YoutubeURL.Text = "Youtube URL"
        '
        'TabPage_Parametre
        '
        Me.TabPage_Parametre.AutoScroll = True
        Me.TabPage_Parametre.BackgroundImage = Global.CP_xml.My.Resources.Resources.Fond_paper
        Me.TabPage_Parametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxPLPath)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonPLPath)
        Me.TabPage_Parametre.Controls.Add(Me.LabelCount)
        Me.TabPage_Parametre.Controls.Add(Me.ProgressBar_Dance)
        Me.TabPage_Parametre.Controls.Add(Me.Button_Init)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxChore)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonChore)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxConfig)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonParamLoad)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonParamSave)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxMusicPath)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonMusicPath)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxPdfPath)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonPdfPath)
        Me.TabPage_Parametre.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Parametre.Name = "TabPage_Parametre"
        Me.TabPage_Parametre.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Parametre.Size = New System.Drawing.Size(495, 517)
        Me.TabPage_Parametre.TabIndex = 4
        Me.TabPage_Parametre.Text = "Parametres"
        Me.TabPage_Parametre.UseVisualStyleBackColor = True
        '
        'TextBoxPLPath
        '
        Me.TextBoxPLPath.Location = New System.Drawing.Point(72, 169)
        Me.TextBoxPLPath.Name = "TextBoxPLPath"
        Me.TextBoxPLPath.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxPLPath.TabIndex = 18
        Me.TextBoxPLPath.Text = ".\PalyList\"
        '
        'ButtonPLPath
        '
        Me.ButtonPLPath.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonPLPath.Location = New System.Drawing.Point(7, 167)
        Me.ButtonPLPath.Name = "ButtonPLPath"
        Me.ButtonPLPath.Size = New System.Drawing.Size(59, 23)
        Me.ButtonPLPath.TabIndex = 17
        Me.ButtonPLPath.Text = "PL Dir"
        Me.ButtonPLPath.UseVisualStyleBackColor = False
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(371, 53)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(0, 13)
        Me.LabelCount.TabIndex = 16
        '
        'ProgressBar_Dance
        '
        Me.ProgressBar_Dance.Location = New System.Drawing.Point(7, 206)
        Me.ProgressBar_Dance.Name = "ProgressBar_Dance"
        Me.ProgressBar_Dance.Size = New System.Drawing.Size(197, 19)
        Me.ProgressBar_Dance.TabIndex = 19
        '
        'Button_Init
        '
        Me.Button_Init.BackColor = System.Drawing.Color.Goldenrod
        Me.Button_Init.Location = New System.Drawing.Point(400, 47)
        Me.Button_Init.Name = "Button_Init"
        Me.Button_Init.Size = New System.Drawing.Size(75, 23)
        Me.Button_Init.TabIndex = 15
        Me.Button_Init.Text = "Init"
        Me.Button_Init.UseVisualStyleBackColor = False
        '
        'TextBoxChore
        '
        Me.TextBoxChore.Location = New System.Drawing.Point(72, 50)
        Me.TextBoxChore.Name = "TextBoxChore"
        Me.TextBoxChore.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxChore.TabIndex = 14
        Me.TextBoxChore.Text = ".\Chores.xml"
        '
        'ButtonChore
        '
        Me.ButtonChore.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonChore.Location = New System.Drawing.Point(7, 50)
        Me.ButtonChore.Name = "ButtonChore"
        Me.ButtonChore.Size = New System.Drawing.Size(59, 23)
        Me.ButtonChore.TabIndex = 13
        Me.ButtonChore.Text = "Chore"
        Me.ButtonChore.UseVisualStyleBackColor = False
        '
        'TextBoxConfig
        '
        Me.TextBoxConfig.Location = New System.Drawing.Point(72, 11)
        Me.TextBoxConfig.Name = "TextBoxConfig"
        Me.TextBoxConfig.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxConfig.TabIndex = 12
        Me.TextBoxConfig.Text = ".\config.xml"
        '
        'ButtonParamLoad
        '
        Me.ButtonParamLoad.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonParamLoad.Location = New System.Drawing.Point(7, 11)
        Me.ButtonParamLoad.Name = "ButtonParamLoad"
        Me.ButtonParamLoad.Size = New System.Drawing.Size(59, 23)
        Me.ButtonParamLoad.TabIndex = 11
        Me.ButtonParamLoad.Text = "Config"
        Me.ButtonParamLoad.UseVisualStyleBackColor = False
        '
        'ButtonParamSave
        '
        Me.ButtonParamSave.BackColor = System.Drawing.Color.Goldenrod
        Me.ButtonParamSave.Location = New System.Drawing.Point(400, 11)
        Me.ButtonParamSave.Name = "ButtonParamSave"
        Me.ButtonParamSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonParamSave.TabIndex = 10
        Me.ButtonParamSave.Text = "Sauver"
        Me.ButtonParamSave.UseVisualStyleBackColor = False
        '
        'TextBoxMusicPath
        '
        Me.TextBoxMusicPath.Location = New System.Drawing.Point(72, 129)
        Me.TextBoxMusicPath.Name = "TextBoxMusicPath"
        Me.TextBoxMusicPath.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxMusicPath.TabIndex = 9
        Me.TextBoxMusicPath.Text = ".\Music\"
        '
        'ButtonMusicPath
        '
        Me.ButtonMusicPath.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonMusicPath.Location = New System.Drawing.Point(7, 127)
        Me.ButtonMusicPath.Name = "ButtonMusicPath"
        Me.ButtonMusicPath.Size = New System.Drawing.Size(59, 23)
        Me.ButtonMusicPath.TabIndex = 8
        Me.ButtonMusicPath.Text = "Music Dir"
        Me.ButtonMusicPath.UseVisualStyleBackColor = False
        '
        'TextBoxPdfPath
        '
        Me.TextBoxPdfPath.Location = New System.Drawing.Point(72, 89)
        Me.TextBoxPdfPath.Name = "TextBoxPdfPath"
        Me.TextBoxPdfPath.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxPdfPath.TabIndex = 7
        Me.TextBoxPdfPath.Text = ".\Fiches\"
        '
        'ButtonPdfPath
        '
        Me.ButtonPdfPath.BackColor = System.Drawing.Color.DarkKhaki
        Me.ButtonPdfPath.Location = New System.Drawing.Point(7, 87)
        Me.ButtonPdfPath.Name = "ButtonPdfPath"
        Me.ButtonPdfPath.Size = New System.Drawing.Size(59, 23)
        Me.ButtonPdfPath.TabIndex = 6
        Me.ButtonPdfPath.Text = "PDF Dir"
        Me.ButtonPdfPath.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Chore)
        Me.TabControl1.Controls.Add(Me.TabPage_Danses)
        Me.TabControl1.Location = New System.Drawing.Point(248, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(259, 502)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage_Chore
        '
        Me.TabPage_Chore.BackgroundImage = CType(resources.GetObject("TabPage_Chore.BackgroundImage"), System.Drawing.Image)
        Me.TabPage_Chore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Chore.Controls.Add(Me.LabelMusicFile)
        Me.TabPage_Chore.Controls.Add(Me.Button_Cancel)
        Me.TabPage_Chore.Controls.Add(Me.Button_Valider)
        Me.TabPage_Chore.Controls.Add(Me.ButtonMusic)
        Me.TabPage_Chore.Controls.Add(Me.Label2)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxArtist)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxMusic)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxChoregraph)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxStart)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxCount)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxLevel)
        Me.TabPage_Chore.Controls.Add(Me.TextBoxName)
        Me.TabPage_Chore.Controls.Add(Me.Button_DanseSave)
        Me.TabPage_Chore.Controls.Add(Me.ButtonNew)
        Me.TabPage_Chore.Controls.Add(Me.ButtonDelete)
        Me.TabPage_Chore.Controls.Add(Me.ButtonModify)
        Me.TabPage_Chore.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.TabPage_Chore.Controls.Add(Me.Label8)
        Me.TabPage_Chore.Controls.Add(Me.Label4)
        Me.TabPage_Chore.Controls.Add(Me.Label3)
        Me.TabPage_Chore.Controls.Add(Me.Label5)
        Me.TabPage_Chore.Controls.Add(Me.Label6)
        Me.TabPage_Chore.Controls.Add(Me.Label7)
        Me.TabPage_Chore.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Chore.Name = "TabPage_Chore"
        Me.TabPage_Chore.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Chore.Size = New System.Drawing.Size(251, 476)
        Me.TabPage_Chore.TabIndex = 0
        Me.TabPage_Chore.Text = "Chore"
        Me.TabPage_Chore.UseVisualStyleBackColor = True
        '
        'LabelMusicFile
        '
        Me.LabelMusicFile.Location = New System.Drawing.Point(123, 309)
        Me.LabelMusicFile.Name = "LabelMusicFile"
        Me.LabelMusicFile.Size = New System.Drawing.Size(97, 34)
        Me.LabelMusicFile.TabIndex = 30
        '
        'Button_Cancel
        '
        Me.Button_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.ForeColor = System.Drawing.Color.Red
        Me.Button_Cancel.Location = New System.Drawing.Point(19, 257)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(98, 36)
        Me.Button_Cancel.TabIndex = 29
        Me.Button_Cancel.Text = "ANNULER"
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'Button_Valider
        '
        Me.Button_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Valider.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button_Valider.Location = New System.Drawing.Point(123, 218)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(103, 33)
        Me.Button_Valider.TabIndex = 28
        Me.Button_Valider.Text = "VALIDER"
        Me.Button_Valider.UseVisualStyleBackColor = True
        '
        'ButtonMusic
        '
        Me.ButtonMusic.Location = New System.Drawing.Point(21, 309)
        Me.ButtonMusic.Name = "ButtonMusic"
        Me.ButtonMusic.Size = New System.Drawing.Size(89, 34)
        Me.ButtonMusic.TabIndex = 26
        Me.ButtonMusic.Text = "Music"
        Me.ButtonMusic.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(15, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Niveau"
        '
        'TextBoxArtist
        '
        Me.TextBoxArtist.Location = New System.Drawing.Point(69, 150)
        Me.TextBoxArtist.Name = "TextBoxArtist"
        Me.TextBoxArtist.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxArtist.TabIndex = 13
        '
        'TextBoxMusic
        '
        Me.TextBoxMusic.Location = New System.Drawing.Point(69, 123)
        Me.TextBoxMusic.Name = "TextBoxMusic"
        Me.TextBoxMusic.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxMusic.TabIndex = 12
        '
        'TextBoxChoregraph
        '
        Me.TextBoxChoregraph.Location = New System.Drawing.Point(90, 97)
        Me.TextBoxChoregraph.Name = "TextBoxChoregraph"
        Me.TextBoxChoregraph.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxChoregraph.TabIndex = 11
        '
        'TextBoxStart
        '
        Me.TextBoxStart.Location = New System.Drawing.Point(153, 70)
        Me.TextBoxStart.Name = "TextBoxStart"
        Me.TextBoxStart.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxStart.TabIndex = 10
        '
        'TextBoxCount
        '
        Me.TextBoxCount.Location = New System.Drawing.Point(157, 44)
        Me.TextBoxCount.Name = "TextBoxCount"
        Me.TextBoxCount.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxCount.TabIndex = 9
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Location = New System.Drawing.Point(63, 43)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.Size = New System.Drawing.Size(39, 20)
        Me.TextBoxLevel.TabIndex = 8
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(18, 19)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxName.TabIndex = 7
        '
        'Button_DanseSave
        '
        Me.Button_DanseSave.BackColor = System.Drawing.Color.Transparent
        Me.Button_DanseSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DanseSave.ForeColor = System.Drawing.Color.Olive
        Me.Button_DanseSave.Location = New System.Drawing.Point(123, 257)
        Me.Button_DanseSave.Name = "Button_DanseSave"
        Me.Button_DanseSave.Size = New System.Drawing.Size(104, 36)
        Me.Button_DanseSave.TabIndex = 24
        Me.Button_DanseSave.Text = "SAUVER"
        Me.Button_DanseSave.UseVisualStyleBackColor = False
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(18, 218)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(99, 33)
        Me.ButtonNew.TabIndex = 23
        Me.ButtonNew.Text = "Nouveau"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(123, 179)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(104, 33)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Supprimer"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(18, 180)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(99, 33)
        Me.ButtonModify.TabIndex = 14
        Me.ButtonModify.Text = "Modifier"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(18, 357)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(217, 113)
        Me.AxWindowsMediaPlayer1.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Choregraphie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(106, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Départ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(106, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Compte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(9, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Choregraphe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(10, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Musique"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(16, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Artiste"
        '
        'TabPage_Danses
        '
        Me.TabPage_Danses.BackgroundImage = Global.CP_xml.My.Resources.Resources.Fond_paper
        Me.TabPage_Danses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Danses.Controls.Add(Me.Button_NewPL)
        Me.TabPage_Danses.Controls.Add(Me.Button_EffacerList)
        Me.TabPage_Danses.Controls.Add(Me.Button_SauverList)
        Me.TabPage_Danses.Controls.Add(Me.Button_EnleverList)
        Me.TabPage_Danses.Controls.Add(Me.Button_AjouterList)
        Me.TabPage_Danses.Controls.Add(Me.ListBox_All)
        Me.TabPage_Danses.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Danses.Name = "TabPage_Danses"
        Me.TabPage_Danses.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Danses.Size = New System.Drawing.Size(251, 476)
        Me.TabPage_Danses.TabIndex = 1
        Me.TabPage_Danses.Text = "Toutes"
        '
        'Button_NewPL
        '
        Me.Button_NewPL.Location = New System.Drawing.Point(9, 430)
        Me.Button_NewPL.Name = "Button_NewPL"
        Me.Button_NewPL.Size = New System.Drawing.Size(208, 22)
        Me.Button_NewPL.TabIndex = 5
        Me.Button_NewPL.Text = "Nouvelle PL"
        Me.Button_NewPL.UseVisualStyleBackColor = True
        '
        'Button_EffacerList
        '
        Me.Button_EffacerList.Location = New System.Drawing.Point(95, 486)
        Me.Button_EffacerList.Name = "Button_EffacerList"
        Me.Button_EffacerList.Size = New System.Drawing.Size(122, 23)
        Me.Button_EffacerList.TabIndex = 4
        Me.Button_EffacerList.Text = "Effacer Liste"
        Me.Button_EffacerList.UseVisualStyleBackColor = True
        '
        'Button_SauverList
        '
        Me.Button_SauverList.Location = New System.Drawing.Point(95, 457)
        Me.Button_SauverList.Name = "Button_SauverList"
        Me.Button_SauverList.Size = New System.Drawing.Size(122, 23)
        Me.Button_SauverList.TabIndex = 3
        Me.Button_SauverList.Text = "Sauver Liste"
        Me.Button_SauverList.UseVisualStyleBackColor = True
        '
        'Button_EnleverList
        '
        Me.Button_EnleverList.Location = New System.Drawing.Point(9, 486)
        Me.Button_EnleverList.Name = "Button_EnleverList"
        Me.Button_EnleverList.Size = New System.Drawing.Size(80, 23)
        Me.Button_EnleverList.TabIndex = 2
        Me.Button_EnleverList.Text = ">> Enlever"
        Me.Button_EnleverList.UseVisualStyleBackColor = True
        '
        'Button_AjouterList
        '
        Me.Button_AjouterList.Location = New System.Drawing.Point(9, 457)
        Me.Button_AjouterList.Name = "Button_AjouterList"
        Me.Button_AjouterList.Size = New System.Drawing.Size(80, 23)
        Me.Button_AjouterList.TabIndex = 1
        Me.Button_AjouterList.Text = "<< Ajouter"
        Me.Button_AjouterList.UseVisualStyleBackColor = True
        '
        'ListBox_All
        '
        Me.ListBox_All.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ListBox_All.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_All.FormattingEnabled = True
        Me.ListBox_All.Location = New System.Drawing.Point(9, 5)
        Me.ListBox_All.Name = "ListBox_All"
        Me.ListBox_All.Size = New System.Drawing.Size(208, 416)
        Me.ListBox_All.Sorted = True
        Me.ListBox_All.TabIndex = 0
        '
        'Label_NbPL
        '
        Me.Label_NbPL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_NbPL.BackColor = System.Drawing.Color.Transparent
        Me.Label_NbPL.Location = New System.Drawing.Point(12, 56)
        Me.Label_NbPL.Name = "Label_NbPL"
        Me.Label_NbPL.Size = New System.Drawing.Size(36, 21)
        Me.Label_NbPL.TabIndex = 20
        '
        'ComboBox_PL
        '
        Me.ComboBox_PL.FormattingEnabled = True
        Me.ComboBox_PL.Location = New System.Drawing.Point(54, 56)
        Me.ComboBox_PL.Name = "ComboBox_PL"
        Me.ComboBox_PL.Size = New System.Drawing.Size(188, 21)
        Me.ComboBox_PL.TabIndex = 21
        '
        'CountryPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 563)
        Me.Controls.Add(Me.Label_NbPL)
        Me.Controls.Add(Me.ComboBox_PL)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListBoxDanses)
        Me.Controls.Add(Me.TabPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "CountryPlayer"
        Me.Text = "Country Player"
        Me.TabPage.ResumeLayout(False)
        Me.TabPage_pdf.ResumeLayout(False)
        Me.TabPage_pdf.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Youtube.ResumeLayout(False)
        Me.TabPage_Youtube.PerformLayout()
        CType(Me.AxShockwaveFlash2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Parametre.ResumeLayout(False)
        Me.TabPage_Parametre.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Chore.ResumeLayout(False)
        Me.TabPage_Chore.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Danses.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxDanses As System.Windows.Forms.ListBox
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_pdf As System.Windows.Forms.TabPage
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage_Youtube As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TabPage_Parametre As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxPdfPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPdfPath As System.Windows.Forms.Button
    Friend WithEvents TextBoxMusicPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonMusicPath As System.Windows.Forms.Button
    Friend WithEvents ButtonParamLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonParamSave As System.Windows.Forms.Button
    Friend WithEvents TextBoxConfig As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPdf As System.Windows.Forms.Button
    Friend WithEvents LabelPdfFile As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Danses As System.Windows.Forms.TabPage
    Friend WithEvents ProgressBar_Dance As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBoxChore As System.Windows.Forms.TextBox
    Friend WithEvents ButtonChore As System.Windows.Forms.Button
    Friend WithEvents ListBox_All As System.Windows.Forms.ListBox
    Friend WithEvents Button_Init As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Button_OpenURL As System.Windows.Forms.Button
    Friend WithEvents Label_YoutubeURL As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash2 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents TextBox_YoutubeUrl As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_Chore As System.Windows.Forms.TabPage
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button_DanseSave As System.Windows.Forms.Button
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonModify As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents TextBoxStart As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxArtist As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxChoregraph As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMusic As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button_EffacerList As System.Windows.Forms.Button
    Friend WithEvents Button_SauverList As System.Windows.Forms.Button
    Friend WithEvents Button_EnleverList As System.Windows.Forms.Button
    Friend WithEvents Button_AjouterList As System.Windows.Forms.Button
    Friend WithEvents ButtonMusic As System.Windows.Forms.Button
    Friend WithEvents Button_Valider As System.Windows.Forms.Button
    Friend WithEvents Button_NewPL As System.Windows.Forms.Button
    Friend WithEvents Label_NbPL As System.Windows.Forms.Label
    Friend WithEvents TextBoxPLPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPLPath As System.Windows.Forms.Button
    Friend WithEvents ComboBox_PL As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents LabelMusicFile As System.Windows.Forms.Label

End Class
