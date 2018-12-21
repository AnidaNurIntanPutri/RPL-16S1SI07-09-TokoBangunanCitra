Public Class ClsEntMerchandise
    Private kd As String
    Private nama As String
    Private jumlah As Integer
    Private jenis As String
    Public Property kd_Hadiah() As String
        Get
            Return kd
        End Get
        Set(value As String)
            kd = value
        End Set
    End Property
    Public Property nama_Hadiah() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property jumlah_Hadiah() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
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
