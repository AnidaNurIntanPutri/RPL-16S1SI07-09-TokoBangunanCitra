Public Class ClsEntBarang

    Public Kode As String
    Public Nama As String
    Public Jumlah As Integer
    Public Harga As Integer

    Public Property KodeBrg() As String
        Get
            Return Kode
        End Get
        Set(value As String)
            Kode = value
        End Set
    End Property

    Public Property NamaBrg() As String
        Get
            Return Nama
        End Get
        Set(value As String)
            Nama = value
        End Set
    End Property

    Public Property JumlahBrg() As Integer

        Get
            Return Jumlah
        End Get
        Set(value As Integer)
            Jumlah = value
        End Set
    End Property


    Public Property HargaBrg() As Integer

        Get
            Return Harga
        End Get
        Set(value As Integer)
            Harga = value
        End Set
    End Property

End Class

