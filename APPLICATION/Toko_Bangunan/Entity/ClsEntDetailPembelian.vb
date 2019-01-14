Public Class ClsEntDetailPembelian
    Private kodebrg As String
    Private kodebeli As String
    Private hrgbeli As Integer
    Private jumlah As Integer
    Private subtot As Integer

    Public Property kode_barang() As String
        Get
            Return kodebrg
        End Get
        Set(value As String)
            kodebrg = value
        End Set
    End Property

    Public Property kode_beli() As String
        Get
            Return kodebeli
        End Get
        Set(value As String)
            kodebeli = value
        End Set
    End Property


    Public Property harga_beli() As Integer
        Get
            Return hrgbeli
        End Get
        Set(value As Integer)
            hrgbeli = value
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property sub_total() As Integer
        Get
            Return subtot
        End Get
        Set(value As Integer)
            subtot = value
        End Set
    End Property
End Class
