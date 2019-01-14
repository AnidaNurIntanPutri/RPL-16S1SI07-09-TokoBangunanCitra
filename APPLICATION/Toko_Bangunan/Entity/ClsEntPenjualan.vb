Public Class ClsEntPenjualan
    Private nonota As String
    Private kasir As String
    Private kdbarang As String
    Private jumlah As String
    Private total As String
    Private bayar As String
    Private kembalian As String

    Public Property NO_NOTA() As String
        Get
            Return nonota
        End Get
        Set(value As String)
            nonota = value
        End Set
    End Property

    Public Property KASIR_() As String
        Get
            Return kasir
        End Get
        Set(value As String)
            kasir = value
        End Set
    End Property

    Public Property KD_BARANG() As String
        Get
            Return kdbarang
        End Get
        Set(value As String)
            kdbarang = value
        End Set
    End Property

    Public Property JUMLAH_() As String
        Get
            Return jumlah
        End Get
        Set(value As String)
            jumlah = value
        End Set
    End Property

    Public Property TOTAL_() As String
        Get
            Return total
        End Get
        Set(value As String)
            total = value
        End Set
    End Property

    Public Property BAYAR_() As String
        Get
            Return bayar
        End Get
        Set(value As String)
            bayar = value
        End Set
    End Property

    Public Property KEMBALIAN_() As String
        Get
            Return kembalian
        End Get
        Set(value As String)
            kembalian = value
        End Set
    End Property
End Class
