Public Class ClsEntKredit
    'pembuatan variabel untuk setiap atribut tabel kredit'
    Private nokredit As String
    Private nonota As String
    Private tgllunas As String
    Private almt As String
    Private noktp As String


    'getter setter'
    'yang di return variabel yang sudah dibuat diatas'
    Public Property no_kredit() As String ' sesuaikan dengan yg didatabase'
        Get
            Return nokredit 'sesuaikan dengan pendeklarasian variabel diatas'
        End Get
        Set(value As String)
            nokredit = value
        End Set
    End Property

    Public Property no_nota() As String
        Get
            Return nonota
        End Get
        Set(value As String)
            nonota = value
        End Set
    End Property

    Public Property tgl_lunas() As String
        Get
            Return tgllunas
        End Get
        Set(value As String)
            tgllunas = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return almt
        End Get
        Set(value As String)
            almt = value
        End Set
    End Property

    Public Property no_ktp() As String
        Get
            Return noktp
        End Get
        Set(value As String)
            noktp = value
        End Set
    End Property
End Class
