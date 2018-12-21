Public Class ClsEntPajak
    Private nomor As String
    Private jumlah As Integer
    Private tanggal As Date


    Public Property noP() As String
        Get
            Return nomor
        End Get
        Set(value As String)
            nomor = value
        End Set
    End Property

    Public Property jml() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property tgl() As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property


End Class
