Public Class ClsEntDataCS
    Private kd As String
    Private nama As String
    Private alamat As String
    Private telpon As String
    Private email As String
    Private username As String
    Private password As String

    Public Property kdCs() As String
        Get
            Return kd
        End Get
        Set(value As String)
            kd = value
        End Set
    End Property

    Public Property namaCs() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property alamatCs() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property telponCs() As String
        Get
            Return telpon
        End Get
        Set(value As String)
            telpon = value
        End Set
    End Property

    Public Property emailCs() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
    Public Property usernameCs() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
    Public Property passwordCs() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
