Public Class ClsEntKredit
    Private nokred As String
    Private nota As String
    Private tglkred As String
    Private tgllunas As String
    Private nama As String
    Private alamat As String
    Private ktp As String

    Public Property NO_KREDIT() As String
        Get
            Return nokred
        End Get
        Set(value As String)
            nokred = value
        End Set
    End Property

    Public Property NO_NOTA() As String
        Get
            Return nota
        End Get
        Set(value As String)
            nota = value
        End Set
    End Property

    Public Property TGL_KREDIT() As String
        Get
            Return tglkred
        End Get
        Set(value As String)
            tglkred = value
        End Set
    End Property

    Public Property TGL_LUNAS() As String
        Get
            Return tgllunas
        End Get
        Set(value As String)
            tgllunas = value
        End Set
    End Property

    Public Property NAMA_KREDIT() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property ALAMAT_KREDIT() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property NO_KTP() As String
        Get
            Return ktp
        End Get
        Set(value As String)
            ktp = value
        End Set
    End Property
End Class
