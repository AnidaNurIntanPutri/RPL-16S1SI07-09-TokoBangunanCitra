Public Class ClsEntSupplier
    Private kd As String
    Private kdb As String
    Private nama As String
    Private alamat As String
    Private no As Integer
    Private email As String

    Public Property kd_Supplier() As String
        Get
            Return kd
        End Get
        Set(value As String)
            kd = value
        End Set
    End Property
    Public Property kdb_eli() As String
        Get
            Return kdb
        End Get
        Set(value As String)
            kdb = value
        End Set
    End Property
    Public Property nama_Supplier() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property alamat_Supplier() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property no_telp() As Integer
        Get
            Return no
        End Get
        Set(value As Integer)
            no = value
        End Set
    End Property
    Public Property email_Supplier() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
End Class
