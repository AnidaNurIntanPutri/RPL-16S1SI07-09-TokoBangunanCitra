Public Class ClsEntKredit
    Private nokred As String
    Private nota As String
    Private tglkred As Date
    Private tgllunas As Date
    Private jum As Integer
    Private lamakred As String

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

    Public Property TGL_KREDIT() As Date
        Get
            Return tglkred
        End Get
        Set(value As Date)
            tglkred = value
        End Set
    End Property

    Public Property TGL_LUNAS() As Date
        Get
            Return tgllunas
        End Get
        Set(value As Date)
            tgllunas = value
        End Set
    End Property

    Public Property JUMLAH_BARANG() As Integer
        Get
            Return jum
        End Get
        Set(value As Integer)
            jum = value
        End Set
    End Property

    Public Property LAMA_KREDIT() As String
        Get
            Return lamakred
        End Get
        Set(value As String)
            lamakred = value
        End Set
    End Property
End Class
