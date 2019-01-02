Public Class ClsEntMerchandise
    Private kd As String
    Private kategori As String
    Private kode As String
    Private jenis As String
    Public Property kd_Hadiah() As String
        Get
            Return kd
        End Get
        Set(value As String)
            kd = value
        End Set
    End Property
    Public Property kategori_Hadiah() As String
        Get
            Return kategori
        End Get
        Set(value As String)
            kategori = value
        End Set
    End Property

    Public Property kode_member() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property jenis_hadiah() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property
End Class
