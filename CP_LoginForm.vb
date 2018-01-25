Imports System.IO
Public Class CP_LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim strMac As String
        Dim lngMac As Double
        Dim keyPrivate As Long
        Dim keyPublic As Double
        keyPrivate = 1965
        strMac = "&H" & getMacAddress()
        ' string hexadécimal -> décimal
        lngMac = CLng(strMac)
        lngMac = lngMac * 2
        keyPublic = CLng("&H" & PasswordTextBox.Text)
        If (PasswordTextBox.Text = "") Then
            MsgBox("Veuillez saisir un numéro de clef !")
        Else
            'keyPublic = CLng("&H" & PasswordTextBox.Text)
            If (keyPrivate = keyPublic - lngMac) Then
                CountryPlayer.Show()
                Me.Close()
            Else
                MsgBox("Clef invalide, veuillez recommencer")
            End If
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CP_LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strLicence As String
        Dim licenceFile As String = "./license.txt"
        If (System.IO.File.Exists(licenceFile)) Then
            strLicence = File.ReadAllText(licenceFile)
            PasswordTextBox.Text = strLicence
        End If
    End Sub
End Class
