Public Class ClsEntMerchandise
    Private kd_merchan As String
    Private kd_memb As String
    Private jenis As Integer
    Private Ket As String
    Public Property kd_merchandise() As String
        Get
            Return kd_merchan
        End Get
        Set(value As String)
            kd_merchan = value
        End Set
    End Property
    Public Property kd_Member() As String
        Get
            Return kd_Memb
        End Get
        Set(value As String)
            kd_memb = value
        End Set
    End Property

    Public Property jenis_merchandise() As Integer
        Get
            Return jenis
        End Get
        Set(value As Integer)
            jenis = value
        End Set
    End Property

    Public Property keterangan() As String
        Get
            Return Ket
        End Get
        Set(value As String)
            Ket = value
        End Set
    End Property
End Class
