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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Chore = New System.Windows.Forms.TabPage()
        Me.Button_rienvu = New System.Windows.Forms.Button()
        Me.Button_vu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Comment = New System.Windows.Forms.TextBox()
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
        Me.Button_Texte = New System.Windows.Forms.Button()
        Me.TextBox_texte = New System.Windows.Forms.TextBox()
        Me.Button_PlBas = New System.Windows.Forms.Button()
        Me.Button_PlHaut = New System.Windows.Forms.Button()
        Me.Button_NewPL = New System.Windows.Forms.Button()
        Me.Button_EffacerList = New System.Windows.Forms.Button()
        Me.Button_SauverList = New System.Windows.Forms.Button()
        Me.Button_EnleverList = New System.Windows.Forms.Button()
        Me.Button_AjouterList = New System.Windows.Forms.Button()
        Me.ListBox_All = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_initChoregraph = New System.Windows.Forms.Button()
        Me.ListBox_Choregraphe = New System.Windows.Forms.ListBox()
        Me.Label_NbPL = New System.Windows.Forms.Label()
        Me.ComboBox_PL = New System.Windows.Forms.ComboBox()
        Me.TabPage_Parametre = New System.Windows.Forms.TabPage()
        Me.TextBoxPLPath = New System.Windows.Forms.TextBox()
        Me.TextBoxChore = New System.Windows.Forms.TextBox()
        Me.TextBoxConfig = New System.Windows.Forms.TextBox()
        Me.TextBoxMusicPath = New System.Windows.Forms.TextBox()
        Me.TextBoxPdfPath = New System.Windows.Forms.TextBox()
        Me.ButtonPLPath = New System.Windows.Forms.Button()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.ProgressBar_Dance = New System.Windows.Forms.ProgressBar()
        Me.Button_Init = New System.Windows.Forms.Button()
        Me.ButtonChore = New System.Windows.Forms.Button()
        Me.ButtonParamLoad = New System.Windows.Forms.Button()
        Me.ButtonParamSave = New System.Windows.Forms.Button()
        Me.ButtonMusicPath = New System.Windows.Forms.Button()
        Me.ButtonPdfPath = New System.Windows.Forms.Button()
        Me.TabPage_pdf = New System.Windows.Forms.TabPage()
        Me.TextBox_Youtube = New System.Windows.Forms.TextBox()
        Me.Button_Youtube = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.ButtonPdf = New System.Windows.Forms.Button()
        Me.LabelPdfFile = New System.Windows.Forms.Label()
        Me.TabPage = New System.Windows.Forms.TabControl()
        Me.CListBoxDance = New System.Windows.Forms.CheckedListBox()
        Me.CheckBox_Tri = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Chore.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Danses.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage_Parametre.SuspendLayout()
        Me.TabPage_pdf.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxDanses
        '
        Me.ListBoxDanses.BackColor = System.Drawing.Color.LemonChiffon
        Me.ListBoxDanses.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListBoxDanses.FormattingEnabled = True
        Me.ListBoxDanses.Location = New System.Drawing.Point(12, 82)
        Me.ListBoxDanses.Name = "ListBoxDanses"
        Me.ListBoxDanses.Size = New System.Drawing.Size(230, 602)
        Me.ListBoxDanses.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Chore)
        Me.TabControl1.Controls.Add(Me.TabPage_Danses)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(248, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(255, 625)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage_Chore
        '
        Me.TabPage_Chore.BackgroundImage = CType(resources.GetObject("TabPage_Chore.BackgroundImage"), System.Drawing.Image)
        Me.TabPage_Chore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Chore.Controls.Add(Me.Button_rienvu)
        Me.TabPage_Chore.Controls.Add(Me.Button_vu)
        Me.TabPage_Chore.Controls.Add(Me.Label1)
        Me.TabPage_Chore.Controls.Add(Me.TextBox_Comment)
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
        Me.TabPage_Chore.Size = New System.Drawing.Size(247, 599)
        Me.TabPage_Chore.TabIndex = 0
        Me.TabPage_Chore.Text = "Chore"
        Me.TabPage_Chore.UseVisualStyleBackColor = True
        '
        'Button_rienvu
        '
        Me.Button_rienvu.BackColor = System.Drawing.Color.Transparent
        Me.Button_rienvu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_rienvu.ForeColor = System.Drawing.Color.Maroon
        Me.Button_rienvu.Location = New System.Drawing.Point(124, 372)
        Me.Button_rienvu.Name = "Button_rienvu"
        Me.Button_rienvu.Size = New System.Drawing.Size(103, 27)
        Me.Button_rienvu.TabIndex = 35
        Me.Button_rienvu.Text = "RIENVU"
        Me.Button_rienvu.UseVisualStyleBackColor = False
        '
        'Button_vu
        '
        Me.Button_vu.BackColor = System.Drawing.Color.Transparent
        Me.Button_vu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_vu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_vu.Location = New System.Drawing.Point(18, 372)
        Me.Button_vu.Name = "Button_vu"
        Me.Button_vu.Size = New System.Drawing.Size(98, 27)
        Me.Button_vu.TabIndex = 34
        Me.Button_vu.Text = "VU"
        Me.Button_vu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(32, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Commentaires"
        '
        'TextBox_Comment
        '
        Me.TextBox_Comment.Location = New System.Drawing.Point(21, 295)
        Me.TextBox_Comment.Multiline = True
        Me.TextBox_Comment.Name = "TextBox_Comment"
        Me.TextBox_Comment.Size = New System.Drawing.Size(208, 65)
        Me.TextBox_Comment.TabIndex = 31
        '
        'LabelMusicFile
        '
        Me.LabelMusicFile.BackColor = System.Drawing.Color.White
        Me.LabelMusicFile.Location = New System.Drawing.Point(20, 468)
        Me.LabelMusicFile.Name = "LabelMusicFile"
        Me.LabelMusicFile.Size = New System.Drawing.Size(216, 19)
        Me.LabelMusicFile.TabIndex = 30
        '
        'Button_Cancel
        '
        Me.Button_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Button_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.ForeColor = System.Drawing.Color.Red
        Me.Button_Cancel.Location = New System.Drawing.Point(19, 243)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(98, 29)
        Me.Button_Cancel.TabIndex = 29
        Me.Button_Cancel.Text = "ANNULER"
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'Button_Valider
        '
        Me.Button_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Valider.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button_Valider.Location = New System.Drawing.Point(123, 210)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(103, 26)
        Me.Button_Valider.TabIndex = 28
        Me.Button_Valider.Text = "VALIDER"
        Me.Button_Valider.UseVisualStyleBackColor = True
        '
        'ButtonMusic
        '
        Me.ButtonMusic.Font = New System.Drawing.Font("Nandaka Western", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMusic.Location = New System.Drawing.Point(21, 408)
        Me.ButtonMusic.Name = "ButtonMusic"
        Me.ButtonMusic.Size = New System.Drawing.Size(215, 57)
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
        Me.Button_DanseSave.Location = New System.Drawing.Point(123, 243)
        Me.Button_DanseSave.Name = "Button_DanseSave"
        Me.Button_DanseSave.Size = New System.Drawing.Size(104, 29)
        Me.Button_DanseSave.TabIndex = 24
        Me.Button_DanseSave.Text = "SAUVER"
        Me.Button_DanseSave.UseVisualStyleBackColor = False
        '
        'ButtonNew
        '
        Me.ButtonNew.Location = New System.Drawing.Point(18, 210)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(99, 26)
        Me.ButtonNew.TabIndex = 23
        Me.ButtonNew.Text = "Nouveau"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(123, 179)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(104, 26)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Supprimer"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(18, 180)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(99, 26)
        Me.ButtonModify.TabIndex = 14
        Me.ButtonModify.Text = "Modifier"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(19, 490)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(217, 103)
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
        Me.TabPage_Danses.BackgroundImage = Global.CountryPlayerDance.My.Resources.Resources.Fond_paper
        Me.TabPage_Danses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Danses.Controls.Add(Me.Button_Texte)
        Me.TabPage_Danses.Controls.Add(Me.TextBox_texte)
        Me.TabPage_Danses.Controls.Add(Me.Button_PlBas)
        Me.TabPage_Danses.Controls.Add(Me.Button_PlHaut)
        Me.TabPage_Danses.Controls.Add(Me.Button_NewPL)
        Me.TabPage_Danses.Controls.Add(Me.Button_EffacerList)
        Me.TabPage_Danses.Controls.Add(Me.Button_SauverList)
        Me.TabPage_Danses.Controls.Add(Me.Button_EnleverList)
        Me.TabPage_Danses.Controls.Add(Me.Button_AjouterList)
        Me.TabPage_Danses.Controls.Add(Me.ListBox_All)
        Me.TabPage_Danses.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Danses.Name = "TabPage_Danses"
        Me.TabPage_Danses.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Danses.Size = New System.Drawing.Size(247, 599)
        Me.TabPage_Danses.TabIndex = 1
        Me.TabPage_Danses.Text = "Toutes"
        '
        'Button_Texte
        '
        Me.Button_Texte.Location = New System.Drawing.Point(18, 568)
        Me.Button_Texte.Name = "Button_Texte"
        Me.Button_Texte.Size = New System.Drawing.Size(52, 23)
        Me.Button_Texte.TabIndex = 9
        Me.Button_Texte.Text = "Texte"
        Me.Button_Texte.UseVisualStyleBackColor = True
        '
        'TextBox_texte
        '
        Me.TextBox_texte.Location = New System.Drawing.Point(76, 571)
        Me.TextBox_texte.Name = "TextBox_texte"
        Me.TextBox_texte.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_texte.TabIndex = 8
        '
        'Button_PlBas
        '
        Me.Button_PlBas.Location = New System.Drawing.Point(105, 540)
        Me.Button_PlBas.Name = "Button_PlBas"
        Me.Button_PlBas.Size = New System.Drawing.Size(33, 23)
        Me.Button_PlBas.TabIndex = 7
        Me.Button_PlBas.Text = "B"
        Me.Button_PlBas.UseVisualStyleBackColor = True
        '
        'Button_PlHaut
        '
        Me.Button_PlHaut.Location = New System.Drawing.Point(105, 511)
        Me.Button_PlHaut.Name = "Button_PlHaut"
        Me.Button_PlHaut.Size = New System.Drawing.Size(33, 23)
        Me.Button_PlHaut.TabIndex = 6
        Me.Button_PlHaut.Text = "H"
        Me.Button_PlHaut.UseVisualStyleBackColor = True
        '
        'Button_NewPL
        '
        Me.Button_NewPL.Location = New System.Drawing.Point(23, 484)
        Me.Button_NewPL.Name = "Button_NewPL"
        Me.Button_NewPL.Size = New System.Drawing.Size(208, 22)
        Me.Button_NewPL.TabIndex = 5
        Me.Button_NewPL.Text = "Nouvelle PL"
        Me.Button_NewPL.UseVisualStyleBackColor = True
        '
        'Button_EffacerList
        '
        Me.Button_EffacerList.Location = New System.Drawing.Point(144, 540)
        Me.Button_EffacerList.Name = "Button_EffacerList"
        Me.Button_EffacerList.Size = New System.Drawing.Size(94, 23)
        Me.Button_EffacerList.TabIndex = 4
        Me.Button_EffacerList.Text = "Effacer Liste"
        Me.Button_EffacerList.UseVisualStyleBackColor = True
        '
        'Button_SauverList
        '
        Me.Button_SauverList.Location = New System.Drawing.Point(144, 511)
        Me.Button_SauverList.Name = "Button_SauverList"
        Me.Button_SauverList.Size = New System.Drawing.Size(94, 23)
        Me.Button_SauverList.TabIndex = 3
        Me.Button_SauverList.Text = "Sauver Liste"
        Me.Button_SauverList.UseVisualStyleBackColor = True
        '
        'Button_EnleverList
        '
        Me.Button_EnleverList.Location = New System.Drawing.Point(15, 540)
        Me.Button_EnleverList.Name = "Button_EnleverList"
        Me.Button_EnleverList.Size = New System.Drawing.Size(80, 23)
        Me.Button_EnleverList.TabIndex = 2
        Me.Button_EnleverList.Text = ">> Enlever"
        Me.Button_EnleverList.UseVisualStyleBackColor = True
        '
        'Button_AjouterList
        '
        Me.Button_AjouterList.Location = New System.Drawing.Point(15, 511)
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
        Me.ListBox_All.Location = New System.Drawing.Point(9, 8)
        Me.ListBox_All.Name = "ListBox_All"
        Me.ListBox_All.Size = New System.Drawing.Size(232, 468)
        Me.ListBox_All.Sorted = True
        Me.ListBox_All.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button_initChoregraph)
        Me.TabPage1.Controls.Add(Me.ListBox_Choregraphe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(247, 599)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Choregraphes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button_initChoregraph
        '
        Me.Button_initChoregraph.Location = New System.Drawing.Point(9, 6)
        Me.Button_initChoregraph.Name = "Button_initChoregraph"
        Me.Button_initChoregraph.Size = New System.Drawing.Size(232, 23)
        Me.Button_initChoregraph.TabIndex = 2
        Me.Button_initChoregraph.Tag = ""
        Me.Button_initChoregraph.Text = "Mettre a jour Liste"
        Me.Button_initChoregraph.UseVisualStyleBackColor = True
        '
        'ListBox_Choregraphe
        '
        Me.ListBox_Choregraphe.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ListBox_Choregraphe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Choregraphe.FormattingEnabled = True
        Me.ListBox_Choregraphe.Location = New System.Drawing.Point(9, 35)
        Me.ListBox_Choregraphe.Name = "ListBox_Choregraphe"
        Me.ListBox_Choregraphe.Size = New System.Drawing.Size(232, 559)
        Me.ListBox_Choregraphe.Sorted = True
        Me.ListBox_Choregraphe.TabIndex = 1
        '
        'Label_NbPL
        '
        Me.Label_NbPL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_NbPL.BackColor = System.Drawing.Color.Transparent
        Me.Label_NbPL.Location = New System.Drawing.Point(12, 58)
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
        'TabPage_Parametre
        '
        Me.TabPage_Parametre.AutoScroll = True
        Me.TabPage_Parametre.BackgroundImage = Global.CountryPlayerDance.My.Resources.Resources.Fond_paper
        Me.TabPage_Parametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxPLPath)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxChore)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxConfig)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxMusicPath)
        Me.TabPage_Parametre.Controls.Add(Me.TextBoxPdfPath)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonPLPath)
        Me.TabPage_Parametre.Controls.Add(Me.LabelCount)
        Me.TabPage_Parametre.Controls.Add(Me.ProgressBar_Dance)
        Me.TabPage_Parametre.Controls.Add(Me.Button_Init)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonChore)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonParamLoad)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonParamSave)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonMusicPath)
        Me.TabPage_Parametre.Controls.Add(Me.ButtonPdfPath)
        Me.TabPage_Parametre.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Parametre.Name = "TabPage_Parametre"
        Me.TabPage_Parametre.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Parametre.Size = New System.Drawing.Size(741, 647)
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
        '
        'TextBoxChore
        '
        Me.TextBoxChore.Location = New System.Drawing.Point(72, 50)
        Me.TextBoxChore.Name = "TextBoxChore"
        Me.TextBoxChore.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxChore.TabIndex = 14
        '
        'TextBoxConfig
        '
        Me.TextBoxConfig.Location = New System.Drawing.Point(72, 11)
        Me.TextBoxConfig.Name = "TextBoxConfig"
        Me.TextBoxConfig.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxConfig.TabIndex = 12
        Me.TextBoxConfig.Text = ".\config.xml"
        '
        'TextBoxMusicPath
        '
        Me.TextBoxMusicPath.Location = New System.Drawing.Point(72, 129)
        Me.TextBoxMusicPath.Name = "TextBoxMusicPath"
        Me.TextBoxMusicPath.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxMusicPath.TabIndex = 9
        '
        'TextBoxPdfPath
        '
        Me.TextBoxPdfPath.Location = New System.Drawing.Point(72, 89)
        Me.TextBoxPdfPath.Name = "TextBoxPdfPath"
        Me.TextBoxPdfPath.Size = New System.Drawing.Size(293, 20)
        Me.TextBoxPdfPath.TabIndex = 7
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
        'TabPage_pdf
        '
        Me.TabPage_pdf.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.TabPage_pdf.BackgroundImage = Global.CountryPlayerDance.My.Resources.Resources.Fond_paper
        Me.TabPage_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage_pdf.Controls.Add(Me.TextBox_Youtube)
        Me.TabPage_pdf.Controls.Add(Me.Button_Youtube)
        Me.TabPage_pdf.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage_pdf.Controls.Add(Me.ButtonPdf)
        Me.TabPage_pdf.Controls.Add(Me.LabelPdfFile)
        Me.TabPage_pdf.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_pdf.Name = "TabPage_pdf"
        Me.TabPage_pdf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_pdf.Size = New System.Drawing.Size(741, 647)
        Me.TabPage_pdf.TabIndex = 1
        Me.TabPage_pdf.Text = "PDF"
        '
        'TextBox_Youtube
        '
        Me.TextBox_Youtube.Location = New System.Drawing.Point(372, 11)
        Me.TextBox_Youtube.Name = "TextBox_Youtube"
        Me.TextBox_Youtube.Size = New System.Drawing.Size(363, 20)
        Me.TextBox_Youtube.TabIndex = 21
        '
        'Button_Youtube
        '
        Me.Button_Youtube.BackColor = System.Drawing.Color.Tan
        Me.Button_Youtube.Location = New System.Drawing.Point(282, 8)
        Me.Button_Youtube.Name = "Button_Youtube"
        Me.Button_Youtube.Size = New System.Drawing.Size(84, 24)
        Me.Button_Youtube.TabIndex = 20
        Me.Button_Youtube.Text = "Youtube"
        Me.Button_Youtube.UseVisualStyleBackColor = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(6, 42)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(729, 599)
        Me.AxAcroPDF1.TabIndex = 0
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
        Me.LabelPdfFile.BackColor = System.Drawing.Color.Transparent
        Me.LabelPdfFile.Location = New System.Drawing.Point(105, 19)
        Me.LabelPdfFile.Name = "LabelPdfFile"
        Me.LabelPdfFile.Size = New System.Drawing.Size(0, 13)
        Me.LabelPdfFile.TabIndex = 1
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.TabPage_pdf)
        Me.TabPage.Controls.Add(Me.TabPage_Parametre)
        Me.TabPage.Location = New System.Drawing.Point(509, 12)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(749, 673)
        Me.TabPage.TabIndex = 1
        '
        'CListBoxDance
        '
        Me.CListBoxDance.FormattingEnabled = True
        Me.CListBoxDance.Location = New System.Drawing.Point(15, 83)
        Me.CListBoxDance.Name = "CListBoxDance"
        Me.CListBoxDance.Size = New System.Drawing.Size(227, 559)
        Me.CListBoxDance.TabIndex = 22
        '
        'CheckBox_Tri
        '
        Me.CheckBox_Tri.AutoSize = True
        Me.CheckBox_Tri.Location = New System.Drawing.Point(26, 660)
        Me.CheckBox_Tri.Name = "CheckBox_Tri"
        Me.CheckBox_Tri.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox_Tri.TabIndex = 23
        Me.CheckBox_Tri.Text = "Trier"
        Me.CheckBox_Tri.UseVisualStyleBackColor = True
        '
        'CountryPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1270, 687)
        Me.Controls.Add(Me.CheckBox_Tri)
        Me.Controls.Add(Me.CListBoxDance)
        Me.Controls.Add(Me.Label_NbPL)
        Me.Controls.Add(Me.ComboBox_PL)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListBoxDanses)
        Me.Controls.Add(Me.TabPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CountryPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Country Player Dance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Chore.ResumeLayout(False)
        Me.TabPage_Chore.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Danses.ResumeLayout(False)
        Me.TabPage_Danses.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage_Parametre.ResumeLayout(False)
        Me.TabPage_Parametre.PerformLayout()
        Me.TabPage_pdf.ResumeLayout(False)
        Me.TabPage_pdf.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxDanses As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Danses As System.Windows.Forms.TabPage
    Friend WithEvents ListBox_All As System.Windows.Forms.ListBox
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
    Friend WithEvents ComboBox_PL As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents LabelMusicFile As System.Windows.Forms.Label
    Friend WithEvents TabPage_Parametre As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxPLPath As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxChore As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConfig As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMusicPath As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPdfPath As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPLPath As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents ProgressBar_Dance As System.Windows.Forms.ProgressBar
    Friend WithEvents Button_Init As System.Windows.Forms.Button
    Friend WithEvents ButtonChore As System.Windows.Forms.Button
    Friend WithEvents ButtonParamLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonParamSave As System.Windows.Forms.Button
    Friend WithEvents ButtonMusicPath As System.Windows.Forms.Button
    Friend WithEvents ButtonPdfPath As System.Windows.Forms.Button
    Friend WithEvents TabPage_pdf As System.Windows.Forms.TabPage
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ButtonPdf As System.Windows.Forms.Button
    Friend WithEvents LabelPdfFile As System.Windows.Forms.Label
    Friend WithEvents TabPage As System.Windows.Forms.TabControl
    Friend WithEvents Button_PlBas As System.Windows.Forms.Button
    Friend WithEvents Button_PlHaut As System.Windows.Forms.Button
    Friend WithEvents Button_Youtube As System.Windows.Forms.Button
    Friend WithEvents TextBox_Youtube As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Comment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_vu As System.Windows.Forms.Button
    Friend WithEvents Button_rienvu As System.Windows.Forms.Button
    Friend WithEvents CListBoxDance As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button_Texte As System.Windows.Forms.Button
    Friend WithEvents TextBox_texte As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_Tri As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox_Choregraphe As System.Windows.Forms.ListBox
    Friend WithEvents Button_initChoregraph As System.Windows.Forms.Button

End Class
