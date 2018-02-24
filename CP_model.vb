Imports System.Collections
Module CP_Model
    Public Class Chore
        Private _sNom As String
        Private _sNiveau As String
        Private _sCompte As String
        Private _sDepart As String
        Private _sChoregraph As String
        Private _sMusic As String
        Private _sArtiste As String
        Private _sPdfPath As String
        Private _sMusicPath As String
        Private _sYoutubeUrl As String

        Public Property Nom() As String
            Get
                Nom = _sNom
            End Get
            Set(ByVal value As String)
                _sNom = value
            End Set
        End Property

        Public Property Niveau() As String
            Get
                Niveau = _sNiveau
            End Get
            Set(ByVal value As String)
                _sNiveau = value
            End Set
        End Property

        Public Property Compte() As String
            Get
                Compte = _sCompte
            End Get
            Set(ByVal value As String)
                _sCompte = value
            End Set
        End Property

        Public Property Depart() As String
            Get
                Depart = _sDepart
            End Get
            Set(ByVal value As String)
                _sDepart = value
            End Set
        End Property

        Public Property Choregraph() As String
            Get
                Choregraph = _sChoregraph
            End Get
            Set(ByVal value As String)
                _sChoregraph = value
            End Set
        End Property

        Public Property Music() As String
            Get
                Music = _sMusic
            End Get
            Set(ByVal value As String)
                _sMusic = value
            End Set
        End Property

        Public Property Artiste() As String
            Get
                Artiste = _sArtiste
            End Get
            Set(ByVal value As String)
                _sArtiste = value
            End Set
        End Property

        Public Property MusicPath() As String
            Get
                MusicPath = _sMusicPath
            End Get
            Set(ByVal value As String)
                _sMusicPath = value
            End Set
        End Property

        Public Property PdfPath() As String
            Get
                PdfPath = _sPdfPath
            End Get
            Set(ByVal value As String)
                _sPdfPath = value
            End Set
        End Property
        Public Property Youtube() As String
            Get
                Youtube = _sYoutubeUrl
            End Get
            Set(ByVal value As String)
                _sYoutubeUrl = value
            End Set
        End Property

        Public Sub New(ByVal sNom As String)
            Nom = sNom
        End Sub

    End Class

    Public Class Chores
        Private maCol As ArrayList

        Public Sub New()
            maCol = New ArrayList()    'cela crée une ArrayList
        End Sub

        Public Sub init() 'reinitialise la classe Chores, vide la collection
            maCol = Nothing
            maCol = New ArrayList()
        End Sub

        Public Function GetEnumerator() As IEnumerator    'permet d'utiliser For Each
            GetEnumerator = maCol.GetEnumerator
        End Function

        Public Function Add(ByVal LeNom As String) As Chore
            Dim UneChore As New Chore(LeNom)
            maCol.Add(UneChore)
            Add = UneChore
        End Function

        Public ReadOnly Property Item(ByVal lIndex As Integer) As Chore
            Get
                Item = (CType(maCol.Item(lIndex), Chore))
            End Get
        End Property
        Public ReadOnly Property Count() As Integer
            Get
                Count = maCol.Count
                'Debug.Print(Count)
            End Get
        End Property

        Public Sub Remove(ByVal ChoreId As Chore)
            maCol.Remove(ChoreId)
        End Sub

        Public Function getItem(ByVal LeNom As String) As Chore
            getItem = Nothing
            For Each _chore As Chore In maCol
                If _chore.Nom = LeNom Then
                    getItem = _chore
                    Exit For
                End If
            Next
            Return getItem
        End Function
    End Class
End Module

