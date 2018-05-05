Imports System.Net.NetworkInformation

Module CP_Fonctions
    Public Structure FOLDERFILE
        Public FolderName As String
        Public FileName As String
        Public Type As String
    End Structure

    Public FileName As FOLDERFILE

    Public Function GetFileName(ByVal Titre As String) As FOLDERFILE
        'open a input box to choose a file and return the directory and the name of the file
        ' return "Empty" if the application was cancered
        Dim FileName As String = ""
        'FileName = Application.GetOpenFilename(Title:=Titre)
        'FileName = Application.GetOpenFilename("Image Files (*.jpg), *.jpg", Title:=Titre)

        If FileName <> "False" And FileName <> "Faux" Then
            Dim i As Integer
            Dim Indice As Integer
            i = 1
            Indice = 1
            While Mid(FileName, i, 1) <> ""
                If Mid(FileName, i, 1) = "\" Then
                    Indice = i ' garde le chemin jusqu'au dernier '\' inclu
                End If
                i = i + 1 'donne le nombre total de caractère de la string
            End While
            GetFileName.FolderName = Left(FileName, Indice)
            GetFileName.FileName = Right(FileName, i - Indice - 1)
        Else
            GetFileName.FileName = "Empty"
            GetFileName.FolderName = "Empty"
        End If
    End Function



    Function getMacAddress()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function


End Module
