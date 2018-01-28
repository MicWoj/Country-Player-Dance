<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CP_keyGen
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
        Me.Button_OkGenKey = New System.Windows.Forms.Button()
        Me.LabelGenKey = New System.Windows.Forms.Label()
        Me.TextBox_genKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_OkGenKey
        '
        Me.Button_OkGenKey.Location = New System.Drawing.Point(114, 144)
        Me.Button_OkGenKey.Name = "Button_OkGenKey"
        Me.Button_OkGenKey.Size = New System.Drawing.Size(75, 23)
        Me.Button_OkGenKey.TabIndex = 0
        Me.Button_OkGenKey.Text = "OK"
        Me.Button_OkGenKey.UseVisualStyleBackColor = True
        '
        'LabelGenKey
        '
        Me.LabelGenKey.Location = New System.Drawing.Point(12, 9)
        Me.LabelGenKey.Name = "LabelGenKey"
        Me.LabelGenKey.Size = New System.Drawing.Size(269, 34)
        Me.LabelGenKey.TabIndex = 1
        Me.LabelGenKey.Text = "Copier la clef ci dessous et l'envoyer à l'adresse suivante pour obtenir une lice" & _
    "nse."
        Me.LabelGenKey.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox_genKey
        '
        Me.TextBox_genKey.Location = New System.Drawing.Point(14, 59)
        Me.TextBox_genKey.Name = "TextBox_genKey"
        Me.TextBox_genKey.Size = New System.Drawing.Size(258, 20)
        Me.TextBox_genKey.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "micwoj72@gmail.com"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Votre demande sera étudiée, merci de preciser votre identité"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CP_keyGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 179)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_genKey)
        Me.Controls.Add(Me.LabelGenKey)
        Me.Controls.Add(Me.Button_OkGenKey)
        Me.Name = "CP_keyGen"
        Me.Text = "Clef Generation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_OkGenKey As System.Windows.Forms.Button
    Friend WithEvents LabelGenKey As System.Windows.Forms.Label
    Friend WithEvents TextBox_genKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
