Public Class ClsEntMember
    Public Kode As String
    Public Nama As String
    Public Alamat As String
    Public Telepon As String
    Public KTP As String
    Public Email As String


    Public Property KodeMbr() As String
        Get
            Return Kode
        End Get
        Set(ByVal value As String)
            Kode = value
        End Set
    End Property


    Public Property NamaMbr() As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property

    Public Property AlamatMbr() As String
        Get
            Return Alamat
        End Get
        Set(ByVal value As String)
            Alamat = value
        End Set
    End Property


    Public Property TeleponMbr() As String
        Get
            Return Telepon
        End Get
        Set(ByVal value As String)
            Telepon = value
        End Set
    End Property


    Public Property KTPMbr() As String
        Get
            Return KTP
        End Get
        Set(ByVal value As String)
            KTP = value
        End Set
    End Property

    Public Property EmailMbr() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value
        End Set
    End Property

End Class
