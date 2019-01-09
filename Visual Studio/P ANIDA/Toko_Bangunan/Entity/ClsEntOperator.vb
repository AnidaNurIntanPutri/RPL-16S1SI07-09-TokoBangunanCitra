Public Class ClsEntOperator
    Private kodeopt As String
    Private namaopt As String
    Private username As String
    Private passwd As String
    Private levelopt As String

    Public Property kode_operator() As String
        Get
            Return kodeopt
        End Get
        Set(value As String)
            kodeopt = value
        End Set
    End Property

    Public Property nama_operator() As String
        Get
            Return namaopt
        End Get
        Set(value As String)
            namaopt = value
        End Set
    End Property

    Public Property userid() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property pass() As String
        Get
            Return passwd
        End Get
        Set(value As String)
            passwd = value
        End Set
    End Property

    Public Property level_operator() As String
        Get
            Return levelopt
        End Get
        Set(value As String)
            levelopt = value
        End Set
    End Property
End Class
