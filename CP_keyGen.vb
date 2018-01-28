Public Class CP_keyGen


    Private Sub Button_OkGenKey_Click(sender As System.Object, e As System.EventArgs) Handles Button_OkGenKey.Click
        Me.Close()
    End Sub

    Private Sub CP_keyGen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim strMac As Long = CLng("&H" & getMacAddress())
        TextBox_genKey.Text = strMac
    End Sub

    Private Sub TextBox_genKey_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_genKey.TextChanged

    End Sub
End Class