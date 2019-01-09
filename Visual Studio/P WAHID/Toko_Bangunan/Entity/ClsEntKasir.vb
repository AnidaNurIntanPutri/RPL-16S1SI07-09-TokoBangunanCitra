Public Class ClsEntKasir
    Private kode_kasir As String
    Private nama_kasir As String
    Private telepon As String
    Private username As String
    Private password As String
    Private email_kasir As String
    Private Alamat_kasir As String



    Public Property kode() As String
        Get
            Return kode_kasir
        End Get
        Set(value As String)
            kode_kasir = value
        End Set
    End Property

    Public Property nama() As String
        Get
            Return nama_kasir
        End Get
        Set(value As String)
            nama_kasir = value
        End Set
    End Property

    Public Property telp() As String
        Get
            Return telepon
        End Get
        Set(value As String)
            telepon = value
        End Set
    End Property

    Public Property user() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property pass() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return email_kasir
        End Get
        Set(value As String)
            email_kasir = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return Alamat_kasir
        End Get
        Set(value As String)
            Alamat_kasir = value
        End Set
    End Property
End Class

